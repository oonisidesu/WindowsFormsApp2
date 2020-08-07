namespace WindowsFormsApp2
{
    partial class UserSaveForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.MailCheckBox = new System.Windows.Forms.CheckBox();
            this.MailAddressTextBox = new System.Windows.Forms.TextBox();
            this.MailAddressLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FreeRadioButton = new System.Windows.Forms.RadioButton();
            this.BusinessRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(49, 25);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(32, 24);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(156, 25);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(180, 31);
            this.IdTextBox.TabIndex = 1;
            // 
            // MailCheckBox
            // 
            this.MailCheckBox.AutoSize = true;
            this.MailCheckBox.Location = new System.Drawing.Point(53, 84);
            this.MailCheckBox.Name = "MailCheckBox";
            this.MailCheckBox.Size = new System.Drawing.Size(203, 28);
            this.MailCheckBox.TabIndex = 2;
            this.MailCheckBox.Text = "メールを送信する";
            this.MailCheckBox.UseVisualStyleBackColor = true;
            this.MailCheckBox.CheckedChanged += new System.EventHandler(this.MailCheckBox_CheckedChanged);
            // 
            // MailAddressTextBox
            // 
            this.MailAddressTextBox.Location = new System.Drawing.Point(217, 158);
            this.MailAddressTextBox.Name = "MailAddressTextBox";
            this.MailAddressTextBox.Size = new System.Drawing.Size(180, 31);
            this.MailAddressTextBox.TabIndex = 4;
            // 
            // MailAddressLabel
            // 
            this.MailAddressLabel.AutoSize = true;
            this.MailAddressLabel.Location = new System.Drawing.Point(49, 158);
            this.MailAddressLabel.Name = "MailAddressLabel";
            this.MailAddressLabel.Size = new System.Drawing.Size(138, 24);
            this.MailAddressLabel.TabIndex = 3;
            this.MailAddressLabel.Text = "メールアドレス";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BusinessRadioButton);
            this.groupBox1.Controls.Add(this.FreeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(53, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "プラン";
            // 
            // FreeRadioButton
            // 
            this.FreeRadioButton.AutoSize = true;
            this.FreeRadioButton.Location = new System.Drawing.Point(24, 46);
            this.FreeRadioButton.Name = "FreeRadioButton";
            this.FreeRadioButton.Size = new System.Drawing.Size(89, 28);
            this.FreeRadioButton.TabIndex = 0;
            this.FreeRadioButton.TabStop = true;
            this.FreeRadioButton.Text = "無料";
            this.FreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // BusinessRadioButton
            // 
            this.BusinessRadioButton.AutoSize = true;
            this.BusinessRadioButton.Location = new System.Drawing.Point(217, 46);
            this.BusinessRadioButton.Name = "BusinessRadioButton";
            this.BusinessRadioButton.Size = new System.Drawing.Size(116, 28);
            this.BusinessRadioButton.TabIndex = 1;
            this.BusinessRadioButton.TabStop = true;
            this.BusinessRadioButton.Text = "ビジネス";
            this.BusinessRadioButton.UseVisualStyleBackColor = true;
            // 
            // UserSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MailAddressTextBox);
            this.Controls.Add(this.MailAddressLabel);
            this.Controls.Add(this.MailCheckBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Name = "UserSaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ユーザー登録";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.CheckBox MailCheckBox;
        private System.Windows.Forms.TextBox MailAddressTextBox;
        private System.Windows.Forms.Label MailAddressLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BusinessRadioButton;
        private System.Windows.Forms.RadioButton FreeRadioButton;
    }
}

