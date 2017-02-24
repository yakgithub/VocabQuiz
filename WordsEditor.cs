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
    public partial class WordsEditor : Form
    {
        private List<Word> words_list;
        int current_num_of_words;

        public WordsEditor()
        {
            InitializeComponent();

            update_words_lists();
            if (Utils.current_list_name!="")
            {
                grid_update();
                this.rep_box.Text = Utils.current_list_name;
            }
      
        }

        private void update_num_of_words()
        {
            this.current_num_of_words = this.words_list.Count();

            this.words_num.Text = "מילים במאגר: " + this.current_num_of_words.ToString();
        }

        private void update_words_lists()
        {
            this.rep_box.Items.Clear();
            List<string> words_lists = Utils.Get_all_lists();
            foreach (string fileName in words_lists)
                this.rep_box.Items.Add(fileName);
        }


  
        private void save_btn_Click_1(object sender, EventArgs e)
        {
         DialogResult d = MessageBox.Show("האם אתה בטוח שברצונך לשמור את השינויים", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (d == DialogResult.Yes)
         {
             int num_of_rows = this.words_table.RowCount;
             for (int i = 0; i < num_of_rows; i++)
             {
                 try
                 {
                 String val1 = words_table.Rows[i].Cells[0].Value.ToString();
                 String val2 = words_table.Rows[i].Cells[1].Value.ToString();
                 if (!String.IsNullOrEmpty(val1) && !String.IsNullOrEmpty(val1))
                 {
                     this.words_list[i].set_english_word(val1);
                     this.words_list[i].set_hebrew_word(val2);

                 }
                 }
                 
                 catch (System.NullReferenceException)
                 {
                     continue;
                 }
                 
             }


             Utils.write_words(this.words_list);

             MessageBox.Show("השינויים נשמרו בהצלחה", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
             this.Close();
         }
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow new_row = new DataGridViewRow();
            new_row.CreateCells(words_table);
            new_row.Cells[0].Value = "";
            new_row.Cells[1].Value = "";
            words_table.Rows.Add(new_row);  //Add empty line to the datagridview.
            this.words_list.Add(new Word("", "", 0, 0, 0)); //Add new empty word to the list.
            words_table.FirstDisplayedScrollingRowIndex = words_table.RowCount - 1;
            DataGridViewCell cell = words_table.Rows[words_table.RowCount - 1].Cells[0];
            words_table.CurrentCell = cell;
            words_table.BeginEdit(true);  //move the cursor to the new word.
            update_num_of_words(); //update num of words on the screen.

        }

        private void cancel_btn_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("האם אתה בטוח שברצונך לבטל את השינויים", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d==DialogResult.Yes)
                this.Close();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (words_table.SelectedRows.Count==0)
                MessageBox.Show("יש לסמן שורה למחיקה", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (DataGridViewRow i in words_table.SelectedRows) //iterate over the selected raws.
            {
                words_table.Rows.RemoveAt(i.Index); //delete the raw from the datagridview and the words list.
                this.words_list.RemoveAt(i.Index+1);
            }
            update_num_of_words();


        }

        private void WordsEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.PreviousPage.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            do_search();
        }

        private void do_search()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("הכנס מילה/ תחילת מילה לחיפוש", "חיפוש", "Default", -1, -1).ToLower();
            foreach (DataGridViewRow row in words_table.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().StartsWith(input) || row.Cells[1].Value.ToString().ToLower().StartsWith(input))
                {
                    words_table.Rows[row.Index].Selected = true;
                    words_table.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void new_rep_btn_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("הקלד שם למאגר החדש", "מאגר חדש", "Default", -1, -1).ToLower();
            if (input!="")
            {
                bool ret = Utils.create_new_list(input);
                if (!ret)
                    MessageBox.Show("שגיאה, המאגר כבר קיים", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    update_words_lists();
                    MessageBox.Show("המאגר נוצר בהצלחה", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                   
            }
            else
                MessageBox.Show("יש להקליד שם מאגר", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void rep_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.current_list_name = this.rep_box.Text;
            grid_update();
        }

        private void grid_update()
        {
            this.words_list = Utils.load_words();
            update_num_of_words();
            //Display the words in the repository
            words_table.Rows.Clear();
            foreach (Word w in words_list)
            {
                DataGridViewRow new_row = new DataGridViewRow();
                new_row.CreateCells(words_table);
                new_row.Cells[0].Value = w.get_english_word();
                new_row.Cells[1].Value = w.get_hebrew_word();
                words_table.Rows.Add(new_row);

            }

            this.search_btn.Enabled = true;
            this.add_btn.Enabled = true;
            this.delete_btn.Enabled = true;
            this.save_btn.Enabled = true;
            this.cancel_btn.Enabled = true;
            this.delete_rep_btn.Enabled = true;
        }

        private void delete_rep_btn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("האם אתה בטוח שברצונך למחוק מאגר זה", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                bool ret = Utils.delete_list(rep_box.Text);
                if (!ret)
                {
                    MessageBox.Show("שגיאה, המאגר אינו קיים", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    update_words_lists();
                    MessageBox.Show("המאגר נמחק בהצלחה", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.rep_box.Text = "";
                    Utils.current_list_name = "";
                    words_table.Rows.Clear();
                    this.words_num.Text = "מילים במאגר: ";
                    this.disable_btns();
                }
                
            }
            
        }
        private void disable_btns()
        {
            this.search_btn.Enabled = false;
            this.add_btn.Enabled = false;
            this.delete_btn.Enabled = false;
            this.save_btn.Enabled = false;
            this.cancel_btn.Enabled = false;
            this.delete_rep_btn.Enabled = false;
        }


        private void words_table_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Control)
                do_search();
        }
    }
}
