using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Diagnostics;
namespace VideoLabeling
{
    public partial class Form1 : Form
    {
        //eğer true ise frame extraction işlemini durdur
        private bool stopExtract = false;
        private VideoCapture capture;
        //videonun oynatilip oynatilmadiğini anlamamiza yarayan
        //boolean değişken
        private bool isPaused = false;
        //saniyede gösterilen frame sayisi
        private int fps;
        //yüklenen videodaki toplam frame sayisini tutar
        private int totalFrameCount;
        //o anda ekranda görünen frame' i tutar.
        private int currFrameNo = 0;
        //arayüzdeki etiket resimlerini tutar
        private List<PictureBox> pictureboxes;
        //arayüzdeki etiketlerin listesini tutar.
        private List<Label> labels;
        //etiket sınıflarının olduğu text dosyasında
        //okunan satir numarasini tutar
        private int lineNum = 0;
        //arayüzdeki labellardan son işaretlenin
        //bilgisini tutar
        private int lastSelectedLabelIndex = -1;
        //framelerin etiketlerini tutar
        //etiketler arayüzden seçilir.
        private string[] labelOfFrames;
        //dosya arama, seçme işlemleri için
        private OpenFileDialog ofd;
        private string lastLabelClass;
        //ekranin full screen başlamasi için 
        private void GoFullScreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }
        //arayüzde etiketlerin resimlerini olusturur
        //ve ekranda nerede görüneceğini belirler
        private void CreatePictureBoxes(string labelImagesPath)
        {
            pictureboxes.Add(new PictureBox());
            pictureboxes[lineNum].Size = new Size(200, 140);
            pictureboxes[lineNum].SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxes[lineNum].Cursor = Cursors.Hand;
            if (lineNum < 10)
                pictureboxes[lineNum].Name = "labelImage0" + (lineNum + 1);
            else
                pictureboxes[lineNum].Name = "labelImage" + (lineNum + 1);
            pictureboxes[lineNum].ImageLocation = labelImagesPath + "\\" + "Label" + (lineNum + 1) + ".png";
            pictureboxes[lineNum].Click += new System.EventHandler(labelImage_Click);
            SetPictureBoxLocations();
            //olusturulan pictureboxlarin görünmesi icin ekliyoruz
            this.Controls.Add(pictureboxes[lineNum]);
            //resimlerin önde görünmesi icin
            pictureboxes[lineNum].BringToFront();
        }
        //resimlerin üzerinde görünen label
        //objelerini olusturur
        private void CreateLabels(string ln)
        {
            labels.Add(new Label());
            labels[lineNum].AutoSize = true;
            labels[lineNum].Text = ln;
            labels[lineNum].Name = "labelClass" + (lineNum + 1);
        }
        //label objelerini resimlerin üzerine belirli offset ile yerlestirir
        private void SetLabelLocations()
        {
            //label location
            labels[lineNum].Location =
            new Point(pictureboxes[lineNum].Location.X - 3, pictureboxes[lineNum].Location.Y - 16);
            this.Controls.Add(labels[lineNum]);
            labels[lineNum].BringToFront();
        }

        //resimlerin gösterilecegi alanlari
        //düzenli bir bicimde arayüze yerlestirir
        private void SetPictureBoxLocations()
        {
            Point firstPictureBoxLocation = new Point(660, 50);
            if (lineNum == 0)
            {
                pictureboxes[lineNum].Location = firstPictureBoxLocation;
            }
            else
            {
                if (lineNum % 3 == 0)
                {
                    pictureboxes[lineNum].Location =
                    new Point(firstPictureBoxLocation.X, pictureboxes[lineNum - 1].Location.Y + 165);
                }
                else
                {
                    pictureboxes[lineNum].Location =
                    new Point(pictureboxes[lineNum - 1].Location.X + 233, pictureboxes[lineNum - 1].Location.Y);
                }
            }
        }
        public Form1()
        {
            GoFullScreen();
            //initializing lists
            labels = new List<Label>();
            pictureboxes = new List<PictureBox>();
            //Windows Forms methodu
            InitializeComponent();
            //aktif framin etiketini gösteren degiskenin textini siliyoruz
            currentFrameLabel.Text = "";
            //başlangicta görünmesini istemedigimiz objeleri gizlemek
            SetVisibility(false);
            setVisiblityExtraction(false);
            //calistirilan exe dosyasinin adresi
            string exePath = Path.GetDirectoryName(Application.ExecutablePath);
            //exe dosyasi ile ayni dizinde bulunan labels klasörünün adresi
            string labelImagesPath = exePath + "\\labels";
            //labels klaösür icerisinde bulunan 
            //classes isimli text dosyasinin adresi
            string classesPath = labelImagesPath + "\\classes.txt";
            //clases.txt dosyasini okuma
            using (StreamReader file = new StreamReader(classesPath))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    CreatePictureBoxes(labelImagesPath);
                    CreateLabels(ln);
                    //set picture box location
                    SetLabelLocations();
                    lineNum++;
                }
                file.Close();
                lastLabelClass = ln;
            }
        }

        //bir etiket resmine tiklanirsa cagrilir
        private void labelImage_Click(object sender, EventArgs e)
        {

            PictureBox selectedPicture = sender as PictureBox;
            if (lastSelectedLabelIndex != -1)
                labels[lastSelectedLabelIndex].BackColor = SystemColors.Control;
            int index = int.Parse(selectedPicture.Name.Substring(selectedPicture.Name.Length - 2, 2)) - 1;
            labels[index].BackColor = Color.PaleGreen;
            lastSelectedLabelIndex = index;
        }

        //videonun altinda bulunan 2 panelin gizlenmesini
        //veya gözükmesini saglar
        private void SetVisibility(bool isVisible)
        {
            videoPlayerComponents.Visible = isVisible;
            jumpPanel.Visible = isVisible;
            Application.DoEvents();
        }

        //videonun gözükeceği alana bir frame resmi yansitir.
        //bu frame currFrameNo numarali framedir
        private void DisplayCurrentImage()
        {
            Mat m = new Mat();
            capture.Read(m);
            videoDisplayer.Image = m.ToImage<Bgr, byte>().ToBitmap();
            currFrameDisplayer.Text = "Frame: " + currFrameNo + "/" + (totalFrameCount - 1);
            timer.Text = "Time(s): " + currFrameNo / fps + "/" + totalFrameCount / fps;
            currentFrameLabel.Text = labelOfFrames[currFrameNo];
        }

        //import video
        private void importVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Video Files(*.mp4;*mkv;*.wmv;*.flv;*.avi;*.mov)|*.mp4;*.mkv;*.wmv;*.flv;*.avi;*.mov|" +
                "All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    capture = new VideoCapture(ofd.FileName);
                    totalFrameCount = (int)capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                    labelOfFrames = new string[totalFrameCount];
                    if (totalFrameCount > 0)
                    {
                        isPaused = true;
                        SetVisibility(true);
                        trackerVideo.Value = 0;
                        frameFreqDown.Maximum = totalFrameCount - 1;
                        trackerVideo.Maximum = totalFrameCount - 1;
                        jumpAmount.Maximum = totalFrameCount - 1;
                        videoTitle.Text = ofd.SafeFileName;
                        fps = (int)capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                        //ilk frame i göster
                        DisplayCurrentImage();
                        //etiket listesini 
                        //en son okunan satir ile ilklendiriyoruz
                        for (int i = 0; i < totalFrameCount; ++i)
                        {
                            labelOfFrames[i] = labels.Last().Text;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //play butonu
        private async void play_Click(object sender, EventArgs e)
        {
            if (capture == null)
                return;
            if (isPaused)
            {
                isPaused = false;
                jumpPanel.Visible = false;
                try
                {
                    while (!isPaused && currFrameNo < totalFrameCount)
                    {
                        trackerVideo.Value = currFrameNo;
                        currFrameNo += (int)frameFreqDown.Value;
                        await Task.Delay(1000 / fps);
                    }
                    if (currFrameNo >= totalFrameCount)
                    {
                        currFrameNo = totalFrameCount - 1;
                        trackerVideo.Value = currFrameNo;
                        isPaused = true;
                        jumpPanel.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //pause butonu
        private void pause_Click(object sender, EventArgs e)
        {
            isPaused = true;
            currFrameNo = (int)capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames) - 1;
            jumpPanel.Visible = true;
        }

        //stop butonu, videoyu başa sarar ve durdurur
        private void stop_Click(object sender, EventArgs e)
        {
            capture.Pause();
            currFrameNo = 0;
            trackerVideo.Value = currFrameNo;
            isPaused = true;
            jumpPanel.Visible = true;
        }

        //videoyu n frame kadar ileri sarar
        private void Forward_Click(object sender, EventArgs e)
        {
            try
            {
                currFrameNo += (int)jumpAmount.Value;
                if (currFrameNo >= totalFrameCount)
                {
                    currFrameNo = totalFrameCount - 1;
                }
                //capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, currFrameNo);
                trackerVideo.Value = currFrameNo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //videoyu n frame kadar geri sarar
        private void Backward_Click(object sender, EventArgs e)
        {
            try
            {
                currFrameNo -= (int)jumpAmount.Value;
                if (currFrameNo < 0)
                {
                    currFrameNo = 0;
                }
                //capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, currFrameNo);
                trackerVideo.Value = currFrameNo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void setVisiblityExtraction(bool visible)
        {
            stopExtractButton.Visible = visible;
            ExtractingFramesLabel.Visible = visible;
            progressBar1.Visible = visible;
            ExtractingFramesLabel.BackColor = System.Drawing.Color.Transparent;
            Application.DoEvents();
        }
        private void LaunchCommandLineApp(String targetFolder)
        {
            Console.WriteLine("Hellowoasdkaskdaskd");
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "ffmpeg.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "-i " + ofd.FileName + " " + targetFolder + "\\%5d.jpg";
            Console.WriteLine(startInfo.Arguments);
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                Console.WriteLine("strartt");
                using (Process exeProcess = Process.Start(startInfo))
                {
                    
                }
            }
            catch
            {
                Console.WriteLine("erırr");
                // Log error.
            }
        }
        //frameleri disa aktarma
        private void extractFramesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("wqeqweqw");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                setVisiblityExtraction(true);
                LaunchCommandLineApp(fbd.SelectedPath);
            }
        }

        //video barinin degeri degistinde cagrilir
        private void trackerVideo_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                currFrameNo = trackerVideo.Value;
                capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, currFrameNo);
                DisplayCurrentImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //current frame i etiketleme aragiliginin baslangici olarak ayarlar
        //etiketleme aragiligina dahildir
        private void starting_Click(object sender, EventArgs e)
        {
            startingBox.Text = currFrameNo.ToString();
        }

        ////current frame i etiketleme aragiliginin sonu olarak ayarlar
        /// etiketleme aragiligina dahildir
        private void ending_Click(object sender, EventArgs e)
        {
            endingBox.Text = currFrameNo.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        //secilen araligi, secilen etiketle etiketler
        private void assignLabel_Click(object sender, EventArgs e)
        {
            if (totalFrameCount == 0)
            {
                MessageBox.Show("Please Load A Video Before Assign A Label");
                return;
            }
            if (lastSelectedLabelIndex == -1)
            {
                MessageBox.Show("Please Choose A Label");
                return;
            }

            try
            {
                for (int i = int.Parse(startingBox.Text); i <= int.Parse(endingBox.Text); ++i)
                {
                    double frame = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames);
                    labelOfFrames[i] = labels[lastSelectedLabelIndex].Text;
                }
                currentFrameLabel.Text = labels[lastSelectedLabelIndex].Text;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //etiketleme islemini tamamlama butonu, 
        //bu butona basildiktan sonra secilen video ile
        //ayni dizinde ve ayni isimde bir .csv dosyasi olusturulur.
        private void doneLabeling_Click(object sender, EventArgs e)
        {
            string labelFile = System.IO.Path.GetDirectoryName(ofd.FileName) + "//" + Path.GetFileNameWithoutExtension(ofd.FileName) + ".csv";
            //MessageBox.Show(labelFile);
            System.IO.File.WriteAllLines(labelFile, labelOfFrames);
            MessageBox.Show(labelFile.ToString() + " was created");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void stopExtractButton_Click(object sender, EventArgs e)
        {
            stopExtract = true;
        }
    }
}
