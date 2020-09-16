namespace medusa
{
    partial class MedusaMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedusaMain));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.medusaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartTrainingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StopTrainingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitAppMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainingSettingMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 24);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(715, 493);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medusaToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(715, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // medusaToolStripMenuItem
            // 
            this.medusaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartTrainingMenu,
            this.StopTrainingMenu,
            this.ExitAppMenu});
            this.medusaToolStripMenuItem.Name = "medusaToolStripMenuItem";
            this.medusaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.medusaToolStripMenuItem.Text = "Medusa";
            // 
            // StartTrainingMenu
            // 
            this.StartTrainingMenu.Name = "StartTrainingMenu";
            this.StartTrainingMenu.Size = new System.Drawing.Size(180, 22);
            this.StartTrainingMenu.Text = "トレーニング開始";
            this.StartTrainingMenu.Click += new System.EventHandler(this.StartTrainingMenu_Click);
            // 
            // StopTrainingMenu
            // 
            this.StopTrainingMenu.Name = "StopTrainingMenu";
            this.StopTrainingMenu.Size = new System.Drawing.Size(180, 22);
            this.StopTrainingMenu.Text = "トレーニング終了";
            this.StopTrainingMenu.Click += new System.EventHandler(this.StopTrainingMenu_Click);
            // 
            // ExitAppMenu
            // 
            this.ExitAppMenu.Name = "ExitAppMenu";
            this.ExitAppMenu.Size = new System.Drawing.Size(180, 22);
            this.ExitAppMenu.Text = "アプリを閉じる";
            this.ExitAppMenu.Click += new System.EventHandler(this.ExitAppMenu_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrainingSettingMenu});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // TrainingSettingMenu
            // 
            this.TrainingSettingMenu.Name = "TrainingSettingMenu";
            this.TrainingSettingMenu.Size = new System.Drawing.Size(180, 22);
            this.TrainingSettingMenu.Text = "トレーニング設定";
            this.TrainingSettingMenu.Click += new System.EventHandler(this.TrainingSettingMenu_Click);
            // 
            // MedusaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 517);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MedusaMain";
            this.Text = "動体視力トレーニング Medusa";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResizeEnd += new System.EventHandler(this.FormResizeEnd);
            this.Resize += new System.EventHandler(this.FormResized);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem medusaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartTrainingMenu;
        private System.Windows.Forms.ToolStripMenuItem StopTrainingMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitAppMenu;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrainingSettingMenu;
    }
}

