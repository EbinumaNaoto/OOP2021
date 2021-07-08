
namespace StopWatch {
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
            this.components = new System.ComponentModel.Container();
            this.TimerDispLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.risetButton = new System.Windows.Forms.Button();
            this.rapButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.rapDispListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TimerDispLabel
            // 
            this.TimerDispLabel.AllowDrop = true;
            this.TimerDispLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TimerDispLabel.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerDispLabel.Location = new System.Drawing.Point(12, 9);
            this.TimerDispLabel.Name = "TimerDispLabel";
            this.TimerDispLabel.Size = new System.Drawing.Size(425, 79);
            this.TimerDispLabel.TabIndex = 0;
            this.TimerDispLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.StopWatchDisplay);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(12, 91);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(204, 121);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // risetButton
            // 
            this.risetButton.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.risetButton.Location = new System.Drawing.Point(12, 218);
            this.risetButton.Name = "risetButton";
            this.risetButton.Size = new System.Drawing.Size(204, 121);
            this.risetButton.TabIndex = 1;
            this.risetButton.Text = "リセット";
            this.risetButton.UseVisualStyleBackColor = true;
            this.risetButton.Click += new System.EventHandler(this.risetButton_Click);
            // 
            // rapButton
            // 
            this.rapButton.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rapButton.Location = new System.Drawing.Point(233, 218);
            this.rapButton.Name = "rapButton";
            this.rapButton.Size = new System.Drawing.Size(204, 121);
            this.rapButton.TabIndex = 1;
            this.rapButton.Text = "ラップ";
            this.rapButton.UseVisualStyleBackColor = true;
            this.rapButton.Click += new System.EventHandler(this.rapButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stopButton.Location = new System.Drawing.Point(233, 91);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(204, 121);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "ストップ";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // rapDispListBox
            // 
            this.rapDispListBox.FormattingEnabled = true;
            this.rapDispListBox.ItemHeight = 12;
            this.rapDispListBox.Location = new System.Drawing.Point(443, 9);
            this.rapDispListBox.Name = "rapDispListBox";
            this.rapDispListBox.Size = new System.Drawing.Size(251, 328);
            this.rapDispListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(706, 341);
            this.Controls.Add(this.rapDispListBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.rapButton);
            this.Controls.Add(this.risetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.TimerDispLabel);
            this.Name = "Form1";
            this.Text = "ストップウォッチ";
            this.Load += new System.EventHandler(this.StopWatchDisplay);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimerDispLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button risetButton;
        private System.Windows.Forms.Button rapButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ListBox rapDispListBox;
    }
}

