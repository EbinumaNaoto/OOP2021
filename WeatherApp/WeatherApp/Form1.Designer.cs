
namespace WeatherApp {
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
            this.areaInputLabel = new System.Windows.Forms.Label();
            this.weatherDisplayButton = new System.Windows.Forms.Button();
            this.weatherOutputTextbox = new System.Windows.Forms.TextBox();
            this.areaInputComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // areaInputLabel
            // 
            this.areaInputLabel.AutoSize = true;
            this.areaInputLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.areaInputLabel.Location = new System.Drawing.Point(13, 13);
            this.areaInputLabel.Name = "areaInputLabel";
            this.areaInputLabel.Size = new System.Drawing.Size(89, 17);
            this.areaInputLabel.TabIndex = 0;
            this.areaInputLabel.Text = "地域を入力";
            // 
            // weatherDisplayButton
            // 
            this.weatherDisplayButton.Location = new System.Drawing.Point(302, 13);
            this.weatherDisplayButton.Name = "weatherDisplayButton";
            this.weatherDisplayButton.Size = new System.Drawing.Size(89, 31);
            this.weatherDisplayButton.TabIndex = 1;
            this.weatherDisplayButton.Text = "天気表示\r\n";
            this.weatherDisplayButton.UseVisualStyleBackColor = true;
            this.weatherDisplayButton.Click += new System.EventHandler(this.weatherDisplayButton_Click);
            // 
            // weatherOutputTextbox
            // 
            this.weatherOutputTextbox.Location = new System.Drawing.Point(16, 50);
            this.weatherOutputTextbox.Multiline = true;
            this.weatherOutputTextbox.Name = "weatherOutputTextbox";
            this.weatherOutputTextbox.Size = new System.Drawing.Size(772, 388);
            this.weatherOutputTextbox.TabIndex = 2;
            // 
            // areaInputComboBox
            // 
            this.areaInputComboBox.FormattingEnabled = true;
            this.areaInputComboBox.Location = new System.Drawing.Point(108, 13);
            this.areaInputComboBox.Name = "areaInputComboBox";
            this.areaInputComboBox.Size = new System.Drawing.Size(168, 23);
            this.areaInputComboBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.areaInputComboBox);
            this.Controls.Add(this.weatherOutputTextbox);
            this.Controls.Add(this.weatherDisplayButton);
            this.Controls.Add(this.areaInputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label areaInputLabel;
        private System.Windows.Forms.Button weatherDisplayButton;
        private System.Windows.Forms.TextBox weatherOutputTextbox;
        private System.Windows.Forms.ComboBox areaInputComboBox;
    }
}

