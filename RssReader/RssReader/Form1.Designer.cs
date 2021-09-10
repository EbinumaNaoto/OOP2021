
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.lbRss = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.lbdescription = new System.Windows.Forms.Label();
            this.btWebDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRss
            // 
            this.lbRss.AutoSize = true;
            this.lbRss.Font = new System.Drawing.Font("MS UI Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRss.Location = new System.Drawing.Point(13, 13);
            this.lbRss.Name = "lbRss";
            this.lbRss.Size = new System.Drawing.Size(205, 40);
            this.lbRss.TabIndex = 0;
            this.lbRss.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(251, 18);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(514, 37);
            this.tbUrl.TabIndex = 1;
            // 
            // lbTitles
            // 
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 15;
            this.lbTitles.Location = new System.Drawing.Point(20, 61);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(299, 199);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.SelectedIndexChanged += new System.EventHandler(this.lbTitles_SelectedIndexChanged);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(771, 18);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(105, 37);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読込";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbdescription
            // 
            this.lbdescription.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbdescription.Location = new System.Drawing.Point(325, 61);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(657, 199);
            this.lbdescription.TabIndex = 6;
            // 
            // btWebDisplay
            // 
            this.btWebDisplay.Location = new System.Drawing.Point(882, 18);
            this.btWebDisplay.Name = "btWebDisplay";
            this.btWebDisplay.Size = new System.Drawing.Size(105, 37);
            this.btWebDisplay.TabIndex = 4;
            this.btWebDisplay.Text = "ブラウザ表示";
            this.btWebDisplay.UseVisualStyleBackColor = true;
            this.btWebDisplay.Click += new System.EventHandler(this.btWebDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 278);
            this.Controls.Add(this.lbdescription);
            this.Controls.Add(this.btWebDisplay);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lbRss);
            this.Name = "Form1";
            this.Text = "32063";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRss;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.Button btWebDisplay;
    }
}

