
namespace SendMail {
    partial class ConfigForm {
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
            this.gbServerInfo = new System.Windows.Forms.GroupBox();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbHost = new System.Windows.Forms.Label();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.lbSender = new System.Windows.Forms.Label();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.btApply = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btDefault = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.gbServerInfo.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServerInfo
            // 
            this.gbServerInfo.Controls.Add(this.cbSSL);
            this.gbServerInfo.Controls.Add(this.tbUserName);
            this.gbServerInfo.Controls.Add(this.tbPass);
            this.gbServerInfo.Controls.Add(this.tbPort);
            this.gbServerInfo.Controls.Add(this.tbHost);
            this.gbServerInfo.Controls.Add(this.lbUserName);
            this.gbServerInfo.Controls.Add(this.lbPass);
            this.gbServerInfo.Controls.Add(this.lbPort);
            this.gbServerInfo.Controls.Add(this.lbHost);
            this.gbServerInfo.Location = new System.Drawing.Point(12, 12);
            this.gbServerInfo.Name = "gbServerInfo";
            this.gbServerInfo.Size = new System.Drawing.Size(568, 115);
            this.gbServerInfo.TabIndex = 0;
            this.gbServerInfo.TabStop = false;
            this.gbServerInfo.Text = "サーバー情報";
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Location = new System.Drawing.Point(406, 81);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(68, 16);
            this.cbSSL.TabIndex = 2;
            this.cbSSL.Text = "SSL有効";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(76, 44);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(206, 19);
            this.tbUserName.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(352, 44);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(206, 19);
            this.tbPass.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(352, 16);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(206, 19);
            this.tbPort.TabIndex = 1;
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(76, 16);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(206, 19);
            this.tbHost.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(1, 47);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(57, 12);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "ユーザー名";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(297, 47);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(52, 12);
            this.lbPass.TabIndex = 0;
            this.lbPass.Text = "パスワード";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(297, 19);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(33, 12);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "ポート";
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Location = new System.Drawing.Point(1, 19);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(69, 12);
            this.lbHost.TabIndex = 0;
            this.lbHost.Text = "送信サーバー";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.lbSender);
            this.gbUserInfo.Controls.Add(this.tbSender);
            this.gbUserInfo.Location = new System.Drawing.Point(12, 152);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(296, 46);
            this.gbUserInfo.TabIndex = 1;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "ユーザー情報";
            // 
            // lbSender
            // 
            this.lbSender.AutoSize = true;
            this.lbSender.Location = new System.Drawing.Point(6, 15);
            this.lbSender.Name = "lbSender";
            this.lbSender.Size = new System.Drawing.Size(41, 12);
            this.lbSender.TabIndex = 0;
            this.lbSender.Text = "送信元";
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(81, 12);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(206, 19);
            this.tbSender.TabIndex = 1;
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(505, 220);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 2;
            this.btApply.Text = "適用";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(424, 220);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btDefault
            // 
            this.btDefault.Location = new System.Drawing.Point(12, 220);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(75, 23);
            this.btDefault.TabIndex = 2;
            this.btDefault.Text = "デフォルト";
            this.btDefault.UseVisualStyleBackColor = true;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(343, 220);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 253);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btDefault);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbServerInfo);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.gbServerInfo.ResumeLayout(false);
            this.gbServerInfo.PerformLayout();
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServerInfo;
        private System.Windows.Forms.CheckBox cbSSL;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label lbSender;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.Button btOK;
    }
}