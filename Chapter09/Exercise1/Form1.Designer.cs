
namespace Exercise1 {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKeyWord = new System.Windows.Forms.TextBox();
            this.buttonReadAllLines = new System.Windows.Forms.Button();
            this.buttonReadLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxOutput.Location = new System.Drawing.Point(12, 58);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(776, 446);
            this.textBoxOutput.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(13, 13);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(91, 39);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "開く...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "キーワード";
            // 
            // textBoxKeyWord
            // 
            this.textBoxKeyWord.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxKeyWord.Location = new System.Drawing.Point(221, 15);
            this.textBoxKeyWord.Name = "textBoxKeyWord";
            this.textBoxKeyWord.Size = new System.Drawing.Size(567, 36);
            this.textBoxKeyWord.TabIndex = 3;
            // 
            // buttonReadAllLines
            // 
            this.buttonReadAllLines.Location = new System.Drawing.Point(793, 12);
            this.buttonReadAllLines.Name = "buttonReadAllLines";
            this.buttonReadAllLines.Size = new System.Drawing.Size(91, 39);
            this.buttonReadAllLines.TabIndex = 1;
            this.buttonReadAllLines.Text = "ALLで開く";
            this.buttonReadAllLines.UseVisualStyleBackColor = true;
            this.buttonReadAllLines.Click += new System.EventHandler(this.buttonReadAllLines_Click);
            // 
            // buttonReadLines
            // 
            this.buttonReadLines.Location = new System.Drawing.Point(793, 58);
            this.buttonReadLines.Name = "buttonReadLines";
            this.buttonReadLines.Size = new System.Drawing.Size(91, 39);
            this.buttonReadLines.TabIndex = 1;
            this.buttonReadLines.Text = "普通に開く";
            this.buttonReadLines.UseVisualStyleBackColor = true;
            this.buttonReadLines.Click += new System.EventHandler(this.buttonReadLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 515);
            this.Controls.Add(this.textBoxKeyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReadLines);
            this.Controls.Add(this.buttonReadAllLines);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKeyWord;
        private System.Windows.Forms.Button buttonReadAllLines;
        private System.Windows.Forms.Button buttonReadLines;
    }
}

