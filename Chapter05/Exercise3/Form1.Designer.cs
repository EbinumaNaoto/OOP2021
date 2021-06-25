
namespace Exercise3 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputStringText = new System.Windows.Forms.TextBox();
            this.spaceCountButton = new System.Windows.Forms.Button();
            this.spaceCountText = new System.Windows.Forms.TextBox();
            this.replaceBigWithSmallText = new System.Windows.Forms.TextBox();
            this.replaceBigWithSmallButton = new System.Windows.Forms.Button();
            this.wordCountText = new System.Windows.Forms.TextBox();
            this.wordCountButton = new System.Windows.Forms.Button();
            this.fourLetterWordListText = new System.Windows.Forms.TextBox();
            this.fourLetterWordListButton = new System.Windows.Forms.Button();
            this.reproductionWordText = new System.Windows.Forms.TextBox();
            this.reproductionWordButton = new System.Windows.Forms.Button();
            this.beforeReplaceLabel = new System.Windows.Forms.Label();
            this.afterReplaceLabel = new System.Windows.Forms.Label();
            this.beforeReplaceText = new System.Windows.Forms.TextBox();
            this.afterReplaceText = new System.Windows.Forms.TextBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.breakButton = new System.Windows.Forms.Button();
            this.inputStringData = new System.Windows.Forms.TextBox();
            this.outputStringData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // inputStringText
            // 
            this.inputStringText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStringText.Location = new System.Drawing.Point(33, 81);
            this.inputStringText.Name = "inputStringText";
            this.inputStringText.Size = new System.Drawing.Size(776, 39);
            this.inputStringText.TabIndex = 1;
            // 
            // spaceCountButton
            // 
            this.spaceCountButton.AutoSize = true;
            this.spaceCountButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.spaceCountButton.Location = new System.Drawing.Point(33, 140);
            this.spaceCountButton.Name = "spaceCountButton";
            this.spaceCountButton.Size = new System.Drawing.Size(156, 34);
            this.spaceCountButton.TabIndex = 2;
            this.spaceCountButton.Text = "空白をカウント";
            this.spaceCountButton.UseVisualStyleBackColor = true;
            this.spaceCountButton.Click += new System.EventHandler(this.spaceCountButton_Click);
            // 
            // spaceCountText
            // 
            this.spaceCountText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.spaceCountText.Location = new System.Drawing.Point(220, 140);
            this.spaceCountText.Name = "spaceCountText";
            this.spaceCountText.Size = new System.Drawing.Size(589, 39);
            this.spaceCountText.TabIndex = 1;
            // 
            // replaceBigWithSmallText
            // 
            this.replaceBigWithSmallText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.replaceBigWithSmallText.Location = new System.Drawing.Point(220, 196);
            this.replaceBigWithSmallText.Name = "replaceBigWithSmallText";
            this.replaceBigWithSmallText.Size = new System.Drawing.Size(589, 39);
            this.replaceBigWithSmallText.TabIndex = 1;
            // 
            // replaceBigWithSmallButton
            // 
            this.replaceBigWithSmallButton.AutoSize = true;
            this.replaceBigWithSmallButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.replaceBigWithSmallButton.Location = new System.Drawing.Point(33, 196);
            this.replaceBigWithSmallButton.Name = "replaceBigWithSmallButton";
            this.replaceBigWithSmallButton.Size = new System.Drawing.Size(156, 34);
            this.replaceBigWithSmallButton.TabIndex = 2;
            this.replaceBigWithSmallButton.Text = "big→small";
            this.replaceBigWithSmallButton.UseVisualStyleBackColor = true;
            this.replaceBigWithSmallButton.Click += new System.EventHandler(this.replaceBigWithSmallButton_Click);
            // 
            // wordCountText
            // 
            this.wordCountText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.wordCountText.Location = new System.Drawing.Point(220, 254);
            this.wordCountText.Name = "wordCountText";
            this.wordCountText.Size = new System.Drawing.Size(589, 39);
            this.wordCountText.TabIndex = 1;
            // 
            // wordCountButton
            // 
            this.wordCountButton.AutoSize = true;
            this.wordCountButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.wordCountButton.Location = new System.Drawing.Point(33, 254);
            this.wordCountButton.Name = "wordCountButton";
            this.wordCountButton.Size = new System.Drawing.Size(156, 34);
            this.wordCountButton.TabIndex = 2;
            this.wordCountButton.Text = "単語をカウント";
            this.wordCountButton.UseVisualStyleBackColor = true;
            this.wordCountButton.Click += new System.EventHandler(this.wordCountButton_Click);
            // 
            // fourLetterWordListText
            // 
            this.fourLetterWordListText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fourLetterWordListText.Location = new System.Drawing.Point(220, 307);
            this.fourLetterWordListText.Name = "fourLetterWordListText";
            this.fourLetterWordListText.Size = new System.Drawing.Size(589, 39);
            this.fourLetterWordListText.TabIndex = 1;
            // 
            // fourLetterWordListButton
            // 
            this.fourLetterWordListButton.AutoSize = true;
            this.fourLetterWordListButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fourLetterWordListButton.Location = new System.Drawing.Point(18, 312);
            this.fourLetterWordListButton.Name = "fourLetterWordListButton";
            this.fourLetterWordListButton.Size = new System.Drawing.Size(196, 34);
            this.fourLetterWordListButton.TabIndex = 2;
            this.fourLetterWordListButton.Text = "4文字以下の単語";
            this.fourLetterWordListButton.UseVisualStyleBackColor = true;
            this.fourLetterWordListButton.Click += new System.EventHandler(this.fourLetterWordListButton_Click);
            // 
            // reproductionWordText
            // 
            this.reproductionWordText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reproductionWordText.Location = new System.Drawing.Point(220, 356);
            this.reproductionWordText.Name = "reproductionWordText";
            this.reproductionWordText.Size = new System.Drawing.Size(589, 39);
            this.reproductionWordText.TabIndex = 1;
            // 
            // reproductionWordButton
            // 
            this.reproductionWordButton.AutoSize = true;
            this.reproductionWordButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reproductionWordButton.Location = new System.Drawing.Point(33, 361);
            this.reproductionWordButton.Name = "reproductionWordButton";
            this.reproductionWordButton.Size = new System.Drawing.Size(152, 34);
            this.reproductionWordButton.TabIndex = 2;
            this.reproductionWordButton.Text = "分解して蘇生";
            this.reproductionWordButton.UseVisualStyleBackColor = true;
            this.reproductionWordButton.Click += new System.EventHandler(this.reproductionWordButton_Click);
            // 
            // beforeReplaceLabel
            // 
            this.beforeReplaceLabel.AutoSize = true;
            this.beforeReplaceLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beforeReplaceLabel.Location = new System.Drawing.Point(26, 434);
            this.beforeReplaceLabel.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.beforeReplaceLabel.Name = "beforeReplaceLabel";
            this.beforeReplaceLabel.Size = new System.Drawing.Size(82, 24);
            this.beforeReplaceLabel.TabIndex = 0;
            this.beforeReplaceLabel.Text = "置換前";
            // 
            // afterReplaceLabel
            // 
            this.afterReplaceLabel.AutoSize = true;
            this.afterReplaceLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.afterReplaceLabel.Location = new System.Drawing.Point(26, 488);
            this.afterReplaceLabel.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.afterReplaceLabel.Name = "afterReplaceLabel";
            this.afterReplaceLabel.Size = new System.Drawing.Size(82, 24);
            this.afterReplaceLabel.TabIndex = 0;
            this.afterReplaceLabel.Text = "置換後";
            // 
            // beforeReplaceText
            // 
            this.beforeReplaceText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beforeReplaceText.Location = new System.Drawing.Point(117, 424);
            this.beforeReplaceText.Name = "beforeReplaceText";
            this.beforeReplaceText.Size = new System.Drawing.Size(177, 39);
            this.beforeReplaceText.TabIndex = 1;
            // 
            // afterReplaceText
            // 
            this.afterReplaceText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.afterReplaceText.Location = new System.Drawing.Point(117, 478);
            this.afterReplaceText.Name = "afterReplaceText";
            this.afterReplaceText.Size = new System.Drawing.Size(177, 39);
            this.afterReplaceText.TabIndex = 1;
            // 
            // replaceButton
            // 
            this.replaceButton.AutoSize = true;
            this.replaceButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.replaceButton.Location = new System.Drawing.Point(353, 454);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(68, 34);
            this.replaceButton.TabIndex = 2;
            this.replaceButton.Text = "置換";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // replaceText
            // 
            this.replaceText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.replaceText.Location = new System.Drawing.Point(18, 545);
            this.replaceText.Name = "replaceText";
            this.replaceText.Size = new System.Drawing.Size(791, 39);
            this.replaceText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(26, 606);
            this.label2.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "問題5.4";
            // 
            // breakButton
            // 
            this.breakButton.AutoSize = true;
            this.breakButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.breakButton.Location = new System.Drawing.Point(33, 728);
            this.breakButton.Name = "breakButton";
            this.breakButton.Size = new System.Drawing.Size(152, 34);
            this.breakButton.TabIndex = 2;
            this.breakButton.Text = "分解";
            this.breakButton.UseVisualStyleBackColor = true;
            this.breakButton.Click += new System.EventHandler(this.breakButton_Click);
            // 
            // inputStringData
            // 
            this.inputStringData.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStringData.Location = new System.Drawing.Point(18, 660);
            this.inputStringData.Name = "inputStringData";
            this.inputStringData.Size = new System.Drawing.Size(791, 39);
            this.inputStringData.TabIndex = 1;
            // 
            // outputStringData
            // 
            this.outputStringData.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputStringData.Location = new System.Drawing.Point(220, 723);
            this.outputStringData.Multiline = true;
            this.outputStringData.Name = "outputStringData";
            this.outputStringData.Size = new System.Drawing.Size(589, 128);
            this.outputStringData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(34F, 64F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 863);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.breakButton);
            this.Controls.Add(this.reproductionWordButton);
            this.Controls.Add(this.inputStringData);
            this.Controls.Add(this.afterReplaceText);
            this.Controls.Add(this.outputStringData);
            this.Controls.Add(this.beforeReplaceText);
            this.Controls.Add(this.reproductionWordText);
            this.Controls.Add(this.fourLetterWordListButton);
            this.Controls.Add(this.fourLetterWordListText);
            this.Controls.Add(this.wordCountButton);
            this.Controls.Add(this.wordCountText);
            this.Controls.Add(this.replaceBigWithSmallButton);
            this.Controls.Add(this.replaceText);
            this.Controls.Add(this.replaceBigWithSmallText);
            this.Controls.Add(this.spaceCountButton);
            this.Controls.Add(this.spaceCountText);
            this.Controls.Add(this.inputStringText);
            this.Controls.Add(this.afterReplaceLabel);
            this.Controls.Add(this.beforeReplaceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStringText;
        private System.Windows.Forms.Button spaceCountButton;
        private System.Windows.Forms.TextBox spaceCountText;
        private System.Windows.Forms.TextBox replaceBigWithSmallText;
        private System.Windows.Forms.Button replaceBigWithSmallButton;
        private System.Windows.Forms.TextBox wordCountText;
        private System.Windows.Forms.Button wordCountButton;
        private System.Windows.Forms.TextBox fourLetterWordListText;
        private System.Windows.Forms.Button fourLetterWordListButton;
        private System.Windows.Forms.TextBox reproductionWordText;
        private System.Windows.Forms.Button reproductionWordButton;
        private System.Windows.Forms.Label beforeReplaceLabel;
        private System.Windows.Forms.Label afterReplaceLabel;
        private System.Windows.Forms.TextBox beforeReplaceText;
        private System.Windows.Forms.TextBox afterReplaceText;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.TextBox replaceText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button breakButton;
        private System.Windows.Forms.TextBox inputStringData;
        private System.Windows.Forms.TextBox outputStringData;
    }
}

