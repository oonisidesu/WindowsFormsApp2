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
    }
}
