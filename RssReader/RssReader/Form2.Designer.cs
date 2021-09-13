
namespace RssReader {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btback = new System.Windows.Forms.Button();
            this.btAdvance = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(0, 50);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1229, 803);
            this.wbBrowser.TabIndex = 0;
            this.wbBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbBrowser_DocumentCompleted);
            // 
            // btback
            // 
            this.btback.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btback.Location = new System.Drawing.Point(13, 3);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(50, 41);
            this.btback.TabIndex = 1;
            this.btback.Text = "⇦";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btAdvance
            // 
            this.btAdvance.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAdvance.Location = new System.Drawing.Point(69, 3);
            this.btAdvance.Name = "btAdvance";
            this.btAdvance.Size = new System.Drawing.Size(49, 41);
            this.btAdvance.TabIndex = 1;
            this.btAdvance.Text = "⇨";
            this.btAdvance.UseVisualStyleBackColor = true;
            this.btAdvance.Click += new System.EventHandler(this.btAdvance_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btUpdate.Location = new System.Drawing.Point(125, 3);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(52, 41);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "↻";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHome
            // 
            this.btHome.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btHome.Location = new System.Drawing.Point(184, 3);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(53, 41);
            this.btHome.TabIndex = 3;
            this.btHome.Text = "🏠";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 853);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdvance);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.wbBrowser);
            this.Name = "Form2";
            this.Text = "32063のwebです。";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btAdvance;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHome;
    }
}