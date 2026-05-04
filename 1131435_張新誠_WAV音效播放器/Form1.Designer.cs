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
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // grPath
            // 
            this.grPath.Controls.Add(this.txtPath);
            this.grPath.Location = new System.Drawing.Point(13, 13);
            this.grPath.Name = "grPath";
            this.grPath.Size = new System.Drawing.Size(633, 78);
            this.grPath.TabIndex = 0;
            this.grPath.TabStop = false;
            this.grPath.Text = "音效位置";
            // 
            // grpButton
            // 
            this.grpButton.Location = new System.Drawing.Point(12, 119);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(634, 77);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "播放按鍵";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(16, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(497, 25);
            this.txtPath.TabIndex = 0;
            // 
            // frmWAVPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 216);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grPath);
            this.Name = "frmWAVPlayer";
            this.Text = "WAV音效播放器";
            this.grPath.ResumeLayout(false);
            this.grPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox grpButton;
    }
}

