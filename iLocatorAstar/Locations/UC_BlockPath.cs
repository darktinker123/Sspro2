using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLocatorAstar
{
    public partial class UC_BlockPath : UserControl
    {
        public UC_BlockPath()
        {
            InitializeComponent();
        }

        private void UC_BlockPath_Load(object sender, EventArgs e)
        {
            TextBox_OtherReason.Text = "Please Specify Reason";
            btn_BlockPath.Enabled = false;
        }

        private void dropDown_BlockReason_onItemSelected(object sender, EventArgs e)
        {
            if (dropDown_BlockReason.selectedValue == "Other")
            {
                TextBox_OtherReason.Visible = true;
            }
            else
            {
                TextBox_OtherReason.Visible = false;
            }
        }

        private void TextBox_OtherReason_MouseEnter(object sender, EventArgs e)
        {

        }

        private void TextBox_OtherReason_Leave(object sender, EventArgs e)
        {
            if (TextBox_OtherReason.Text == "")
            {
                TextBox_OtherReason.Text = "Please Specify Reason";
            }
        }

        private void TextBox_OtherReason_Enter(object sender, EventArgs e)
        {
            if (TextBox_OtherReason.Text == "Please Specify Reason")
            {
                TextBox_OtherReason.Text = "";
            }
        }
    }
}
