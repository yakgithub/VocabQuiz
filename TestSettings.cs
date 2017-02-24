using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTest
{
    public partial class TestSettings : Form
    {
        public TestSettings()
        {
            InitializeComponent();
            List<string> words_lists = Utils.Get_all_lists();
            if (words_lists.Count==0)
            {
                MessageBox.Show("לא נמצאו מאגרי מילים", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            foreach (string fileName in words_lists)
                this.Rpository_box.Items.Add(fileName);

            if (Utils.current_list_name != "")
                this.Rpository_box.Text = Utils.current_list_name;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void start_test_Click(object sender, EventArgs e)
        {
            if (Rpository_box.SelectedIndex == -1)//Nothing selected
                {
                    MessageBox.Show("יש לבחור מאגר מילים", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

            Boolean worst_priority = this.hard_words_priority.Checked;
            Utils.current_list_name = this.Rpository_box.Text;
            Test testform = new Test(false, Convert.ToInt32(this.number_of_q.Value), worst_priority);
            Utils.PreviousPage.Hide();
            testform.Show();
            this.Close();
        }
    }
}
