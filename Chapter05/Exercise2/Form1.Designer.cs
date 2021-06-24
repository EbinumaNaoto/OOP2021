
namespace Exercise2 {
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
            this.inputStringNumber = new System.Windows.Forms.TextBox();
            this.Button5_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputStringNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputStringNumber
            // 
            this.inputStringNumber.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStringNumber.Location = new System.Drawing.Point(96, 12);
            this.inputStringNumber.Name = "inputStringNumber";
            this.inputStringNumber.Size = new System.Drawing.Size(539, 55);
            this.inputStringNumber.TabIndex = 0;
            // 
            // Button5_2
            // 
            this.Button5_2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_2.Location = new System.Drawing.Point(668, 18);
            this.Button5_2.Name = "Button5_2";
            this.Button5_2.Size = new System.Drawing.Size(97, 40);
            this.Button5_2.TabIndex = 1;
            this.Button5_2.Text = "問題5.2";
            this.Button5_2.UseVisualStyleBackColor = true;
            this.Button5_2.Click += new System.EventHandler(this.Button5_2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "変換後";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "変換前";
            // 
            // outputStringNumber
            // 
            this.outputStringNumber.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputStringNumber.Location = new System.Drawing.Point(96, 88);
            this.outputStringNumber.Name = "outputStringNumber";
            this.outputStringNumber.Size = new System.Drawing.Size(539, 55);
            this.outputStringNumber.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button5_2);
            this.Controls.Add(this.outputStringNumber);
            this.Controls.Add(this.inputStringNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputStringNumber;
        private System.Windows.Forms.Button Button5_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputStringNumber;
    }
}

