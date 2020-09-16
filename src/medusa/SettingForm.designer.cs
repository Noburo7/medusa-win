namespace medusa
{
    partial class SettingForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BackgroundColorBTrackBar = new System.Windows.Forms.TrackBar();
            this.BackgroundColorGTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackgroundColorPictureBox = new System.Windows.Forms.PictureBox();
            this.BackgroundColorRTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MarkerColorBTrackBar = new System.Windows.Forms.TrackBar();
            this.MarkerColorGTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MarkerColorPictureBox = new System.Windows.Forms.PictureBox();
            this.MarkerColorRTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MarkerSizeLargeRadioButton = new System.Windows.Forms.RadioButton();
            this.MarkerSizeMiddleRadioButton = new System.Windows.Forms.RadioButton();
            this.MarkerSizeSmallRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MarkerSpeedHighRadioButton = new System.Windows.Forms.RadioButton();
            this.MarkerSpeedMiddleRadioButton = new System.Windows.Forms.RadioButton();
            this.MarkerSpeedLowRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColorBTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColorGTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColorRTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarkerColorBTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkerColorGTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkerColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkerColorRTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BackgroundColorBTrackBar);
            this.groupBox1.Controls.Add(this.BackgroundColorGTrackBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BackgroundColorPictureBox);
            this.groupBox1.Controls.Add(this.BackgroundColorRTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "背景色";
            // 
            // BackgroundColorBTrackBar
            // 
            this.BackgroundColorBTrackBar.Location = new System.Drawing.Point(29, 127);
            this.BackgroundColorBTrackBar.Maximum = 255;
            this.BackgroundColorBTrackBar.Name = "BackgroundColorBTrackBar";
            this.BackgroundColorBTrackBar.Size = new System.Drawing.Size(230, 45);
            this.BackgroundColorBTrackBar.TabIndex = 8;
            this.BackgroundColorBTrackBar.TabStop = false;
            this.BackgroundColorBTrackBar.TickFrequency = 32;
            this.BackgroundColorBTrackBar.Scroll += new System.EventHandler(this.BackgroundColorScrolled);
            // 
            // BackgroundColorGTrackBar
            // 
            this.BackgroundColorGTrackBar.Location = new System.Drawing.Point(28, 76);
            this.BackgroundColorGTrackBar.Maximum = 255;
            this.BackgroundColorGTrackBar.Name = "BackgroundColorGTrackBar";
            this.BackgroundColorGTrackBar.Size = new System.Drawing.Size(230, 45);
            this.BackgroundColorGTrackBar.TabIndex = 7;
            this.BackgroundColorGTrackBar.TabStop = false;
            this.BackgroundColorGTrackBar.TickFrequency = 32;
            this.BackgroundColorGTrackBar.Scroll += new System.EventHandler(this.BackgroundColorScrolled);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // BackgroundColorPictureBox
            // 
            this.BackgroundColorPictureBox.Location = new System.Drawing.Point(274, 25);
            this.BackgroundColorPictureBox.Name = "BackgroundColorPictureBox";
            this.BackgroundColorPictureBox.Size = new System.Drawing.Size(120, 120);
            this.BackgroundColorPictureBox.TabIndex = 3;
            this.BackgroundColorPictureBox.TabStop = false;
            // 
            // BackgroundColorRTrackBar
            // 
            this.BackgroundColorRTrackBar.Location = new System.Drawing.Point(28, 25);
            this.BackgroundColorRTrackBar.Maximum = 255;
            this.BackgroundColorRTrackBar.Name = "BackgroundColorRTrackBar";
            this.BackgroundColorRTrackBar.Size = new System.Drawing.Size(230, 45);
            this.BackgroundColorRTrackBar.TabIndex = 0;
            this.BackgroundColorRTrackBar.TabStop = false;
            this.BackgroundColorRTrackBar.TickFrequency = 32;
            this.BackgroundColorRTrackBar.Scroll += new System.EventHandler(this.BackgroundColorScrolled);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MarkerColorBTrackBar);
            this.groupBox2.Controls.Add(this.MarkerColorGTrackBar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.MarkerColorPictureBox);
            this.groupBox2.Controls.Add(this.MarkerColorRTrackBar);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 179);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "マーカー色";
            // 
            // MarkerColorBTrackBar
            // 
            this.MarkerColorBTrackBar.Location = new System.Drawing.Point(29, 127);
            this.MarkerColorBTrackBar.Maximum = 255;
            this.MarkerColorBTrackBar.Name = "MarkerColorBTrackBar";
            this.MarkerColorBTrackBar.Size = new System.Drawing.Size(230, 45);
            this.MarkerColorBTrackBar.TabIndex = 8;
            this.MarkerColorBTrackBar.TabStop = false;
            this.MarkerColorBTrackBar.TickFrequency = 32;
            this.MarkerColorBTrackBar.Scroll += new System.EventHandler(this.MarkerColorScrolled);
            // 
            // MarkerColorGTrackBar
            // 
            this.MarkerColorGTrackBar.Location = new System.Drawing.Point(28, 76);
            this.MarkerColorGTrackBar.Maximum = 255;
            this.MarkerColorGTrackBar.Name = "MarkerColorGTrackBar";
            this.MarkerColorGTrackBar.Size = new System.Drawing.Size(230, 45);
            this.MarkerColorGTrackBar.TabIndex = 7;
            this.MarkerColorGTrackBar.TabStop = false;
            this.MarkerColorGTrackBar.TickFrequency = 32;
            this.MarkerColorGTrackBar.Scroll += new System.EventHandler(this.MarkerColorScrolled);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "R";
            // 
            // MarkerColorPictureBox
            // 
            this.MarkerColorPictureBox.Location = new System.Drawing.Point(274, 25);
            this.MarkerColorPictureBox.Name = "MarkerColorPictureBox";
            this.MarkerColorPictureBox.Size = new System.Drawing.Size(120, 120);
            this.MarkerColorPictureBox.TabIndex = 3;
            this.MarkerColorPictureBox.TabStop = false;
            // 
            // MarkerColorRTrackBar
            // 
            this.MarkerColorRTrackBar.Location = new System.Drawing.Point(28, 25);
            this.MarkerColorRTrackBar.Maximum = 255;
            this.MarkerColorRTrackBar.Name = "MarkerColorRTrackBar";
            this.MarkerColorRTrackBar.Size = new System.Drawing.Size(230, 45);
            this.MarkerColorRTrackBar.TabIndex = 0;
            this.MarkerColorRTrackBar.TabStop = false;
            this.MarkerColorRTrackBar.TickFrequency = 32;
            this.MarkerColorRTrackBar.Scroll += new System.EventHandler(this.MarkerColorScrolled);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MarkerSizeLargeRadioButton);
            this.groupBox3.Controls.Add(this.MarkerSizeMiddleRadioButton);
            this.groupBox3.Controls.Add(this.MarkerSizeSmallRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 59);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "マーカーのサイズ";
            // 
            // MarkerSizeLargeRadioButton
            // 
            this.MarkerSizeLargeRadioButton.AutoSize = true;
            this.MarkerSizeLargeRadioButton.Location = new System.Drawing.Point(194, 24);
            this.MarkerSizeLargeRadioButton.Name = "MarkerSizeLargeRadioButton";
            this.MarkerSizeLargeRadioButton.Size = new System.Drawing.Size(74, 22);
            this.MarkerSizeLargeRadioButton.TabIndex = 2;
            this.MarkerSizeLargeRadioButton.TabStop = true;
            this.MarkerSizeLargeRadioButton.Text = "おおきい";
            this.MarkerSizeLargeRadioButton.UseVisualStyleBackColor = true;
            this.MarkerSizeLargeRadioButton.CheckedChanged += new System.EventHandler(this.MarkerSizeCheckedChanged);
            // 
            // MarkerSizeMiddleRadioButton
            // 
            this.MarkerSizeMiddleRadioButton.AutoSize = true;
            this.MarkerSizeMiddleRadioButton.Location = new System.Drawing.Point(107, 24);
            this.MarkerSizeMiddleRadioButton.Name = "MarkerSizeMiddleRadioButton";
            this.MarkerSizeMiddleRadioButton.Size = new System.Drawing.Size(62, 22);
            this.MarkerSizeMiddleRadioButton.TabIndex = 1;
            this.MarkerSizeMiddleRadioButton.TabStop = true;
            this.MarkerSizeMiddleRadioButton.Text = "ふつう";
            this.MarkerSizeMiddleRadioButton.UseVisualStyleBackColor = true;
            this.MarkerSizeMiddleRadioButton.CheckedChanged += new System.EventHandler(this.MarkerSizeCheckedChanged);
            // 
            // MarkerSizeSmallRadioButton
            // 
            this.MarkerSizeSmallRadioButton.AutoSize = true;
            this.MarkerSizeSmallRadioButton.Location = new System.Drawing.Point(9, 24);
            this.MarkerSizeSmallRadioButton.Name = "MarkerSizeSmallRadioButton";
            this.MarkerSizeSmallRadioButton.Size = new System.Drawing.Size(74, 22);
            this.MarkerSizeSmallRadioButton.TabIndex = 0;
            this.MarkerSizeSmallRadioButton.TabStop = true;
            this.MarkerSizeSmallRadioButton.Text = "ちいさい";
            this.MarkerSizeSmallRadioButton.UseVisualStyleBackColor = true;
            this.MarkerSizeSmallRadioButton.CheckedChanged += new System.EventHandler(this.MarkerSizeCheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MarkerSpeedHighRadioButton);
            this.groupBox4.Controls.Add(this.MarkerSpeedMiddleRadioButton);
            this.groupBox4.Controls.Add(this.MarkerSpeedLowRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(12, 447);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 59);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "マーカーのスピード";
            // 
            // MarkerSpeedHighRadioButton
            // 
            this.MarkerSpeedHighRadioButton.AutoSize = true;
            this.MarkerSpeedHighRadioButton.Location = new System.Drawing.Point(194, 24);
            this.MarkerSpeedHighRadioButton.Name = "MarkerSpeedHighRadioButton";
            this.MarkerSpeedHighRadioButton.Size = new System.Drawing.Size(62, 22);
            this.MarkerSpeedHighRadioButton.TabIndex = 2;
            this.MarkerSpeedHighRadioButton.TabStop = true;
            this.MarkerSpeedHighRadioButton.Text = "はやい";
            this.MarkerSpeedHighRadioButton.UseVisualStyleBackColor = true;
            this.MarkerSpeedHighRadioButton.CheckedChanged += new System.EventHandler(this.MarkerSpeedCheckChanged);
            // 
            // MarkerSpeedMiddleRadioButton
            // 
            this.MarkerSpeedMiddleRadioButton.AutoSize = true;
            this.MarkerSpeedMiddleRadioButton.Location = new System.Drawing.Point(107, 24);
            this.MarkerSpeedMiddleRadioButton.Name = "MarkerSpeedMiddleRadioButton";
            this.MarkerSpeedMiddleRadioButton.Size = new System.Drawing.Size(62, 22);
            this.MarkerSpeedMiddleRadioButton.TabIndex = 1;
            this.MarkerSpeedMiddleRadioButton.TabStop = true;
            this.MarkerSpeedMiddleRadioButton.Text = "ふつう";
            this.MarkerSpeedMiddleRadioButton.UseVisualStyleBackColor = true;
            this.MarkerSpeedMiddleRadioButton.CheckedChanged += new System.EventHandler(this.MarkerSpeedCheckChanged);
            // 
            // MarkerSpeedLowRadioButton
            // 
            this.MarkerSpeedLowRadioButton.AutoSize = true;
            this.MarkerSpeedLowRadioButton.Location = new System.Drawing.Point(9, 24);
            this.MarkerSpeedLowRadioButton.Name = "MarkerSpeedLowRadioButton";
            this.MarkerSpeedLowRadioButton.Size = new System.Drawing.Size(62, 22);
            this.MarkerSpeedLowRadioButton.TabIndex = 0;
            this.MarkerSpeedLowRadioButton.TabStop = true;
            this.MarkerSpeedLowRadioButton.Text = "おそい";
            this.MarkerSpeedLowRadioButton.UseVisualStyleBackColor = true;
            this.MarkerSpeedLowRadioButton.CheckedChanged += new System.EventHandler(this.MarkerSpeedCheckChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 514);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.Text = "設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingFormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColorBTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColorGTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColorRTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarkerColorBTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkerColorGTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkerColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkerColorRTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar BackgroundColorRTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackgroundColorPictureBox;
        private System.Windows.Forms.TrackBar BackgroundColorBTrackBar;
        private System.Windows.Forms.TrackBar BackgroundColorGTrackBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar MarkerColorBTrackBar;
        private System.Windows.Forms.TrackBar MarkerColorGTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox MarkerColorPictureBox;
        private System.Windows.Forms.TrackBar MarkerColorRTrackBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton MarkerSizeLargeRadioButton;
        private System.Windows.Forms.RadioButton MarkerSizeMiddleRadioButton;
        private System.Windows.Forms.RadioButton MarkerSizeSmallRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton MarkerSpeedHighRadioButton;
        private System.Windows.Forms.RadioButton MarkerSpeedMiddleRadioButton;
        private System.Windows.Forms.RadioButton MarkerSpeedLowRadioButton;
    }
}

