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
    public partial class ShowSolutions : Form
    {
        List<Word> wrong_words_list = new List<Word>();
        static Boolean replay = false;

        public ShowSolutions()
        {
            InitializeComponent();
            float num_of_correct_ans = 0;
            int index = 0;


            foreach (int i in Test.correct_user_ans)
            {
                DataGridViewRow new_row = new DataGridViewRow();
                new_row.CreateCells(solutions_t);
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                new_row.Cells[0].Value = Test.words_list[Test.random_questions_index_list[index]].get_english_word();
                new_row.Cells[1].Value = Test.words_list[Test.random_questions_index_list[index]].get_hebrew_word();

                if (i == 1)
                {
                    num_of_correct_ans += 1;
                    Test.words_list[Test.random_questions_index_list[index]].inc_right_ans();
                    Test.words_list[Test.random_questions_index_list[index]].inc_sequence();
                    cellStyle.BackColor = Color.LimeGreen;
                    new_row.DefaultCellStyle = cellStyle;


                }

                else if (i == 2)
                {
                    Test.words_list[Test.random_questions_index_list[index]].inc_wrong_ans();
                    Test.words_list[Test.random_questions_index_list[index]].reset_sequence();
                    cellStyle.BackColor = Color.Red;
                    new_row.DefaultCellStyle = cellStyle;
                    wrong_words_list.Add(Test.words_list[Test.random_questions_index_list[index]]);
                }

                index += 1;
                solutions_t.Rows.Add(new_row);


            }
            this.score_text.Text = Convert.ToInt32(((num_of_correct_ans / Test.correct_user_ans.Length) * 100)).ToString();
            if (!replay)
                Utils.write_words(Test.words_list);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stats_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowSolutions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.PreviousPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.PreviousPage.Show();
            replay = false;
            this.Close();

        }

        private void btn_replay_Click(object sender, EventArgs e)
        {
            if (this.wrong_words_list.Count() > 3)
            {
                Test.words_list = this.wrong_words_list;
                Test testform = new Test(true, this.wrong_words_list.Count());
                replay = true;
                testform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("שגיאה, המספר מינימאלי של מילים לשימוש הוא 4", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }


        }
    }
}
