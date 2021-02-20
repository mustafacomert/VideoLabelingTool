namespace VideoLabeling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.videoDisplayer = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.Button();
            this.videoTitle = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            this.frameFreqDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.videoPlayerComponents = new System.Windows.Forms.Panel();
            this.currFrameDisplayer = new System.Windows.Forms.Label();
            this.trackerVideo = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Label();
            this.jumpPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.jumpAmount = new System.Windows.Forms.NumericUpDown();
            this.Forward = new System.Windows.Forms.Button();
            this.Backward = new System.Windows.Forms.Button();
            this.endingBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.starting = new System.Windows.Forms.Button();
            this.ending = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.assignLabel = new System.Windows.Forms.Button();
            this.startingBox = new System.Windows.Forms.TextBox();
            this.currentFrameLabel = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractFramesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneLabelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.doneLabeling = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoDisplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameFreqDown)).BeginInit();
            this.videoPlayerComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackerVideo)).BeginInit();
            this.jumpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumpAmount)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // videoDisplayer
            // 
            this.videoDisplayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.videoDisplayer.Location = new System.Drawing.Point(12, 178);
            this.videoDisplayer.Name = "videoDisplayer";
            this.videoDisplayer.Size = new System.Drawing.Size(613, 304);
            this.videoDisplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoDisplayer.TabIndex = 2;
            this.videoDisplayer.TabStop = false;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.LightSalmon;
            this.play.Location = new System.Drawing.Point(16, 77);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(126, 23);
            this.play.TabIndex = 3;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // videoTitle
            // 
            this.videoTitle.AutoSize = true;
            this.videoTitle.Location = new System.Drawing.Point(9, 162);
            this.videoTitle.Name = "videoTitle";
            this.videoTitle.Size = new System.Drawing.Size(57, 13);
            this.videoTitle.TabIndex = 4;
            this.videoTitle.Text = "Video Title";
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.LightSalmon;
            this.pause.Location = new System.Drawing.Point(148, 77);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(126, 23);
            this.pause.TabIndex = 6;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // frameFreqDown
            // 
            this.frameFreqDown.BackColor = System.Drawing.SystemColors.Control;
            this.frameFreqDown.Location = new System.Drawing.Point(481, 77);
            this.frameFreqDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameFreqDown.Name = "frameFreqDown";
            this.frameFreqDown.Size = new System.Drawing.Size(111, 20);
            this.frameFreqDown.TabIndex = 7;
            this.frameFreqDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frame Freq.";
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.LightSalmon;
            this.stop.Location = new System.Drawing.Point(280, 77);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(126, 23);
            this.stop.TabIndex = 9;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // videoPlayerComponents
            // 
            this.videoPlayerComponents.Controls.Add(this.currFrameDisplayer);
            this.videoPlayerComponents.Controls.Add(this.trackerVideo);
            this.videoPlayerComponents.Controls.Add(this.timer);
            this.videoPlayerComponents.Controls.Add(this.label1);
            this.videoPlayerComponents.Controls.Add(this.pause);
            this.videoPlayerComponents.Controls.Add(this.play);
            this.videoPlayerComponents.Controls.Add(this.stop);
            this.videoPlayerComponents.Controls.Add(this.frameFreqDown);
            this.videoPlayerComponents.Location = new System.Drawing.Point(12, 488);
            this.videoPlayerComponents.Name = "videoPlayerComponents";
            this.videoPlayerComponents.Size = new System.Drawing.Size(612, 108);
            this.videoPlayerComponents.TabIndex = 10;
            // 
            // currFrameDisplayer
            // 
            this.currFrameDisplayer.AutoSize = true;
            this.currFrameDisplayer.Location = new System.Drawing.Point(478, 10);
            this.currFrameDisplayer.Name = "currFrameDisplayer";
            this.currFrameDisplayer.Size = new System.Drawing.Size(79, 13);
            this.currFrameDisplayer.TabIndex = 10;
            this.currFrameDisplayer.Text = "FrameDisplayer";
            // 
            // trackerVideo
            // 
            this.trackerVideo.Location = new System.Drawing.Point(0, 26);
            this.trackerVideo.Maximum = 100;
            this.trackerVideo.Name = "trackerVideo";
            this.trackerVideo.Size = new System.Drawing.Size(606, 45);
            this.trackerVideo.TabIndex = 5;
            this.trackerVideo.ValueChanged += new System.EventHandler(this.trackerVideo_ValueChanged_1);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(3, 10);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(33, 13);
            this.timer.TabIndex = 12;
            this.timer.Text = "Timer";
            // 
            // jumpPanel
            // 
            this.jumpPanel.Controls.Add(this.label2);
            this.jumpPanel.Controls.Add(this.jumpAmount);
            this.jumpPanel.Controls.Add(this.Forward);
            this.jumpPanel.Controls.Add(this.Backward);
            this.jumpPanel.Location = new System.Drawing.Point(12, 594);
            this.jumpPanel.Name = "jumpPanel";
            this.jumpPanel.Size = new System.Drawing.Size(612, 51);
            this.jumpPanel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jump N Frames";
            // 
            // jumpAmount
            // 
            this.jumpAmount.BackColor = System.Drawing.SystemColors.Control;
            this.jumpAmount.Location = new System.Drawing.Point(254, 19);
            this.jumpAmount.Name = "jumpAmount";
            this.jumpAmount.Size = new System.Drawing.Size(95, 20);
            this.jumpAmount.TabIndex = 2;
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.Color.LightSalmon;
            this.Forward.Location = new System.Drawing.Point(355, 19);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(205, 23);
            this.Forward.TabIndex = 1;
            this.Forward.Text = "Forward";
            this.Forward.UseVisualStyleBackColor = false;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Backward
            // 
            this.Backward.BackColor = System.Drawing.Color.LightSalmon;
            this.Backward.Location = new System.Drawing.Point(43, 16);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(205, 23);
            this.Backward.TabIndex = 0;
            this.Backward.Text = "Backward";
            this.Backward.UseVisualStyleBackColor = false;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // endingBox
            // 
            this.endingBox.BackColor = System.Drawing.SystemColors.Control;
            this.endingBox.Location = new System.Drawing.Point(339, 62);
            this.endingBox.Name = "endingBox";
            this.endingBox.Size = new System.Drawing.Size(230, 20);
            this.endingBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(254, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Set Current Frame As";
            // 
            // starting
            // 
            this.starting.BackColor = System.Drawing.Color.LightSalmon;
            this.starting.Location = new System.Drawing.Point(52, 16);
            this.starting.Name = "starting";
            this.starting.Size = new System.Drawing.Size(232, 23);
            this.starting.TabIndex = 15;
            this.starting.Text = "StartingFrame";
            this.starting.UseVisualStyleBackColor = false;
            this.starting.Click += new System.EventHandler(this.starting_Click);
            // 
            // ending
            // 
            this.ending.BackColor = System.Drawing.Color.LightSalmon;
            this.ending.Location = new System.Drawing.Point(339, 16);
            this.ending.Name = "ending";
            this.ending.Size = new System.Drawing.Size(230, 23);
            this.ending.TabIndex = 16;
            this.ending.Text = "Ending Frame";
            this.ending.UseVisualStyleBackColor = false;
            this.ending.Click += new System.EventHandler(this.ending_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "StartingFrame";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "EndingFrame";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.assignLabel);
            this.panel1.Controls.Add(this.startingBox);
            this.panel1.Controls.Add(this.ending);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.endingBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.starting);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 111);
            this.panel1.TabIndex = 19;
            // 
            // assignLabel
            // 
            this.assignLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.assignLabel.Location = new System.Drawing.Point(226, 88);
            this.assignLabel.Name = "assignLabel";
            this.assignLabel.Size = new System.Drawing.Size(173, 23);
            this.assignLabel.TabIndex = 21;
            this.assignLabel.Text = "Assign Label To This Interval";
            this.assignLabel.UseVisualStyleBackColor = false;
            this.assignLabel.Click += new System.EventHandler(this.assignLabel_Click);
            // 
            // startingBox
            // 
            this.startingBox.Location = new System.Drawing.Point(52, 62);
            this.startingBox.Name = "startingBox";
            this.startingBox.Size = new System.Drawing.Size(232, 20);
            this.startingBox.TabIndex = 19;
            // 
            // currentFrameLabel
            // 
            this.currentFrameLabel.AutoSize = true;
            this.currentFrameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.currentFrameLabel.ForeColor = System.Drawing.Color.Red;
            this.currentFrameLabel.Location = new System.Drawing.Point(415, 157);
            this.currentFrameLabel.Name = "currentFrameLabel";
            this.currentFrameLabel.Size = new System.Drawing.Size(210, 20);
            this.currentFrameLabel.TabIndex = 20;
            this.currentFrameLabel.Text = "RubWithInterlockedFingers";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importVideoToolStripMenuItem,
            this.extractFramesToolStripMenuItem,
            this.doneLabelingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importVideoToolStripMenuItem
            // 
            this.importVideoToolStripMenuItem.Name = "importVideoToolStripMenuItem";
            this.importVideoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.importVideoToolStripMenuItem.Text = "Import Video File";
            this.importVideoToolStripMenuItem.Click += new System.EventHandler(this.importVideoToolStripMenuItem_Click);
            // 
            // extractFramesToolStripMenuItem
            // 
            this.extractFramesToolStripMenuItem.Name = "extractFramesToolStripMenuItem";
            this.extractFramesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.extractFramesToolStripMenuItem.Text = "Extract Frames";
            this.extractFramesToolStripMenuItem.Click += new System.EventHandler(this.extractFramesToolStripMenuItem_Click);
            // 
            // doneLabelingToolStripMenuItem
            // 
            this.doneLabelingToolStripMenuItem.Name = "doneLabelingToolStripMenuItem";
            this.doneLabelingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.doneLabelingToolStripMenuItem.Text = "Done Labeling";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1333, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 749);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // doneLabeling
            // 
            this.doneLabeling.BackColor = System.Drawing.Color.PaleGreen;
            this.doneLabeling.Location = new System.Drawing.Point(238, 651);
            this.doneLabeling.Name = "doneLabeling";
            this.doneLabeling.Size = new System.Drawing.Size(150, 33);
            this.doneLabeling.TabIndex = 23;
            this.doneLabeling.Text = "Done Labeling";
            this.doneLabeling.UseVisualStyleBackColor = false;
            this.doneLabeling.Click += new System.EventHandler(this.doneLabeling_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.doneLabeling);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentFrameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jumpPanel);
            this.Controls.Add(this.videoPlayerComponents);
            this.Controls.Add(this.videoTitle);
            this.Controls.Add(this.videoDisplayer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Video Labeling Program";
            ((System.ComponentModel.ISupportInitialize)(this.videoDisplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameFreqDown)).EndInit();
            this.videoPlayerComponents.ResumeLayout(false);
            this.videoPlayerComponents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackerVideo)).EndInit();
            this.jumpPanel.ResumeLayout(false);
            this.jumpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumpAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox videoDisplayer;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label videoTitle;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.NumericUpDown frameFreqDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Panel videoPlayerComponents;
        private System.Windows.Forms.Panel jumpPanel;
        private System.Windows.Forms.NumericUpDown jumpAmount;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.TrackBar trackerVideo;
        private System.Windows.Forms.Label currFrameDisplayer;
        private System.Windows.Forms.TextBox endingBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button starting;
        private System.Windows.Forms.Button ending;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currentFrameLabel;
        private System.Windows.Forms.TextBox startingBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractFramesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem doneLabelingToolStripMenuItem;
        private System.Windows.Forms.Button assignLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button doneLabeling;
    }
}

