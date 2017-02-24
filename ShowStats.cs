using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnglishTest
{
    public partial class ShowStats : Form
    {
        public ShowStats()
        {
            InitializeComponent();
            List<string> words_lists = Utils.Get_all_lists();
            foreach (string fileName in words_lists)
                this.rep_box.Items.Add(fileName);

            if (Utils.current_list_name != "")
            {
                grid_update();
                this.rep_box.Text = Utils.current_list_name;
            }

        }

        private void do_search()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("הכנס מילה/ תחילת מילה לחיפוש", "חיפוש", "Default", -1, -1).ToLower();
            foreach (DataGridViewRow row in stats_table.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().StartsWith(input) || row.Cells[1].Value.ToString().ToLower().StartsWith(input))
                {
                    stats_table.Rows[row.Index].Selected = true;
                    stats_table.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void ShowStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.PreviousPage.Show();

        }

        private void rep_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.current_list_name = this.rep_box.Text;
            this.grid_update();
        }

        private void grid_update()
        {
            List<Word> words_list = Utils.load_words();

            this.stats_table.Rows.Clear();
            foreach (Word w in words_list)
            {
                DataGridViewRow new_row = new DataGridViewRow();
                new_row.CreateCells(stats_table);
                new_row.Cells[0].Value = w.get_english_word();
                new_row.Cells[1].Value = w.get_hebrew_word();
                new_row.Cells[2].Value = w.get_right_ans().ToString();
                new_row.Cells[3].Value = w.get_wrong_ans().ToString();


                if (w.get_right_ans() == 0 && w.get_wrong_ans() == 0)
                    new_row.Cells[4].Value = "אין מידע";

                else
                    new_row.Cells[4].Value = Convert.ToInt32((w.get_right_ans() * 100.0 / (w.get_right_ans() + w.get_wrong_ans()))).ToString() + "%";
                new_row.Cells[5].Value = w.get_sequence();
                stats_table.Rows.Add(new_row);


            }
            stats_table.Sort(stats_table.Columns[0], ListSortDirection.Ascending);
        }



        private void stats_table_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Control)
                do_search();
        }
    }
}
