using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserSaveForm : Form
    {
        public UserSaveForm()
        {
            InitializeComponent();

            StatusLabel.Text = "必要事項を入力して保存してください";

            EnableComboBox.Items.Add("有効");
            EnableComboBox.Items.Add("無効");
            EnableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox.SelectedIndex = 0;

            MailCheckBox.Enabled = true;
            FreeRadioButton.Checked = true;
            SetMailAddressTextBox();
            PlanChenge();
        }

        private void MailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetMailAddressTextBox();
        }

        private void SetMailAddressTextBox()
        {
            MailAddressTextBox.Enabled = MailCheckBox.Checked;
            MailAddressLabel.Enabled = MailCheckBox.Checked;
        }

        private void BusinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlanChenge();
        }

        private void PlanChenge()
        {
            NoteLabel.Visible = BusinessRadioButton.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "保存しますか？", 
                "確認", 
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if(dialogResult == DialogResult.OK)
            {
                using (var sw =
                    new System.IO.StreamWriter
                    (@"D:\work\save.csv", true, Encoding.GetEncoding("shift-jis")))
                {
                    sw.Write(IdTextBox.Text);
                    sw.Write(",");
                    sw.Write(MailCheckBox.Checked);
                    sw.Write(",");
                    sw.Write(MailAddressTextBox.Text);
                    sw.Write(",");
                    if (BusinessRadioButton.Checked)
                    {
                        sw.Write("1");
                    }
                    else 
                    {
                        sw.Write("0");
                    }
                    sw.Write(",");
                    sw.Write(EnableComboBox.Text);
                    sw.WriteLine("");
                }

                StatusLabel.Text = "保存しました";
            }
            else
            {
                StatusLabel.Text = "キャンセルしました";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
