namespace _1131435_張新誠_WAV音效播放器
{
    partial class frmWAVPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grPath = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.ofdWAVFile = new System.Windows.Forms.OpenFileDialog();
            this.listeningGIF = new System.Windows.Forms.PictureBox();
            this.grPath.SuspendLayout();
            this.grpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeningGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // grPath
            // 
            this.grPath.Controls.Add(this.btnBrowse);
            this.grPath.Controls.Add(this.txtPath);
            this.grPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grPath.Location = new System.Drawing.Point(10, 10);
            this.grPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grPath.Name = "grPath";
            this.grPath.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grPath.Size = new System.Drawing.Size(361, 62);
            this.grPath.TabIndex = 0;
            this.grPath.TabStop = false;
            this.grPath.Text = "音效位置";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(278, 22);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(66, 26);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 27);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(259, 22);
            this.txtPath.TabIndex = 0;
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnEnd);
            this.grpButton.Controls.Add(this.btnStop);
            this.grpButton.Controls.Add(this.btnLoop);
            this.grpButton.Controls.Add(this.btnPlay);
            this.grpButton.Location = new System.Drawing.Point(9, 95);
            this.grpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpButton.Name = "grpButton";
            this.grpButton.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpButton.Size = new System.Drawing.Size(362, 62);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "播放按鍵";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(279, 20);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(62, 26);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "結束程式";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(194, 20);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(62, 26);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止播放";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(106, 20);
            this.btnLoop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(62, 26);
            this.btnLoop.TabIndex = 3;
            this.btnLoop.Text = "重複播放";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(23, 20);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(62, 26);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "播放一次";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // ofdWAVFile
            // 
            this.ofdWAVFile.DefaultExt = "wav";
            // 
            // listeningGIF
            // 
            this.listeningGIF.BackColor = System.Drawing.SystemColors.Control;
            this.listeningGIF.BackgroundImage = global::_1131435_張新誠_WAV音效播放器.Properties.Resources.listening;
            this.listeningGIF.Image = global::_1131435_張新誠_WAV音效播放器.Properties.Resources.listening;
            this.listeningGIF.ImageLocation = "";
            this.listeningGIF.Location = new System.Drawing.Point(10, 172);
            this.listeningGIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeningGIF.Name = "listeningGIF";
            this.listeningGIF.Size = new System.Drawing.Size(500, 281);
            this.listeningGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.listeningGIF.TabIndex = 2;
            this.listeningGIF.TabStop = false;
            this.listeningGIF.Visible = false;
            // 
            // frmWAVPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 167);
            this.Controls.Add(this.listeningGIF);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grPath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmWAVPlayer";
            this.Text = "WAV音效播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWAVPlayer_FormClosing);
            this.Load += new System.EventHandler(this.frmWAVPlayer_Load);
            this.grPath.ResumeLayout(false);
            this.grPath.PerformLayout();
            this.grpButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeningGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.OpenFileDialog ofdWAVFile;
        private System.Windows.Forms.PictureBox listeningGIF;
    }
}

