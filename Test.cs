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
using System.Speech.Synthesis;


namespace EnglishTest
{
    public partial class Test : Form
    {
        public static List<Word> words_list = new List<Word>();
        int q_counter = 0;  //number of question
        int right_ans_btn;      // button number of the right answer.
        int words_num;      //number of words in repository.
        int q_test_num; //the number of questions in the test.
        Button[] answers_btns_array = new Button[4];
        public static int[] correct_user_ans;  //array of user answers. 1 ->right 2>wrong.
        public static int[] random_questions_index_list;

        public Test(Boolean replay, int q_test_num,Boolean worst_priority=false)
        {
            /*
             * This function create new test. The function accept 2 parameters:
             * replay- Repeat the wrong questions from the last test.
             * q_test_num= number of questions in the test.
             * */
        
            InitializeComponent();
            if (!replay)   
                words_list = Utils.load_words();
            this.q_test_num = q_test_num;
            this.words_num = words_list.Count();
            if (this.words_num < 4)
            {
                MessageBox.Show("שגיאה, המספר מינימאלי של מילים לשימוש הוא 4", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
            // Create an array for the questions and array for the user answers.
            correct_user_ans = new int[this.q_test_num];
            if (worst_priority)
            {
                this.sort_by_priority();
                random_questions_index_list = generate_random_questions_list(this.q_test_num, this.q_test_num);
            }
            else
            {
                random_questions_index_list = generate_random_questions_list(this.q_test_num, this.words_num);
            }

            //Intialize the answers_btns_array with the buttons of the answers.
            answers_btns_array[0] = ans_1;
            answers_btns_array[1] = ans_2;
            answers_btns_array[2] = ans_3;
            answers_btns_array[3] = ans_4;
            choose_word();

        }


        private void sort_by_priority()
        {
            int percentage_1, points_1, percentage_2, points_2;
            for (int i=0;i<this.words_num;i++)
                for(int j=0;j<this.words_num-i-1;j++)
                {
                    if (words_list[j].get_wrong_ans()==0 && words_list[j].get_right_ans()==0)
                        percentage_1=0;
                    else
                        percentage_1 = Convert.ToInt32((words_list[j].get_wrong_ans()*100.0)/(words_list[j].get_wrong_ans()+words_list[j].get_right_ans()));
                    
                    points_1 = (words_list[j].get_sequence() * 50)+percentage_1;

                    if (words_list[j+1].get_wrong_ans()==0 && words_list[j+1].get_right_ans()==0)
                        percentage_2=0;
                    else
                        percentage_2 = Convert.ToInt32((words_list[j+1].get_wrong_ans() * 100.0) / (words_list[j+1].get_wrong_ans() + words_list[j+1].get_right_ans()));
                    points_2 = (words_list[j+1].get_sequence() * 50) + percentage_1;

                    if (points_1 >points_2)
                    {
                        Word w = words_list[j];
                        words_list[j] = words_list[j + 1];
                        words_list[j + 1] = w;

                    }
               
                }
        }


        private void choose_word()
        {
            /*
             * This function display a new word on the screen.
             * The function also arrange the answers randomely on the screen.
             */

            foreach (Button b in answers_btns_array) //reset colors of all buttons.
            {
                b.BackColor = SystemColors.Control;
            }

            this.q_counter += 1; //increase the question counter by 1.
            q_num_label.Text = this.q_counter.ToString() + "/" + this.q_test_num.ToString(); //display the question counter
            Random rnd = new Random();
            // int number_of_word = rnd.Next(this.words_num); //generate a new word to ask;
            int number_of_word = random_questions_index_list[this.q_counter - 1];


            q_text.Text = words_list[number_of_word].get_english_word(); //dispaly the word


            this.right_ans_btn = rnd.Next(1, 5);  // generate the right btn number
            List<Word> ans_list = words_list.ToList<Word>(); //list of wrong ans/
            ans_list.RemoveAt(number_of_word);

            //arrange the answers on the screen.
            for (int i = 0; i < 4; i++)
            {
                if (i + 1 == this.right_ans_btn)
                {
                    answers_btns_array[i].Text = words_list[number_of_word].get_hebrew_word();
                }

                else
                {
                    int num_of_words = ans_list.Count();
                    int rand_ans = rnd.Next(num_of_words);

                    answers_btns_array[i].Text = ans_list[rand_ans].get_hebrew_word();
                    ans_list.RemoveAt(rand_ans);
                }
            }

        }
        private void check_ans(int ans)
        {
            /*This function accept number of answer and check if the answer is correct.*/

            if (this.right_ans_btn == ans)
            {
                // this.answres[ans - 1].BackColor = Color.Lime;
                if (correct_user_ans[this.q_counter - 1] != 2) //if the user succeded in the first time.
                {
                    correct_user_ans[this.q_counter - 1] = 1;
                }

                if (this.q_counter == this.q_test_num)
                {
                    end_test();
                }
                else
                {

                    System.Threading.Thread.Sleep(500);
                    choose_word();
                }
            }

            else //Wrong answer
            {
                this.answers_btns_array[ans - 1].BackColor = Color.Red;
                correct_user_ans[this.q_counter - 1] = 2;
            }
        }


        private void end_test()
        {

            //   MessageBox.Show("המבחן נגמר" + "\n" + "מספר תשובות נכונות: " + num_of_correct_ans.ToString(), "TestEnd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }




        private int[] generate_random_questions_list(int number_of_questions_in_exam, int quesions_count)
        {
            int[] q_list;
            int index, temp;
            Random rnd = new Random();

            if (number_of_questions_in_exam > quesions_count)
            {
                q_list = new int[number_of_questions_in_exam];
                for (int i = 0; i < q_list.Length; i++)
                {
                    q_list[i] = i % quesions_count;
                }

            }

            else
            {
                q_list = new int[quesions_count];

                for (int i = 0; i < q_list.Length; i++)
                {
                    q_list[i] = i;
                }
            }


            for (int j = q_list.Length; j > 0; j--)
            {
                index = rnd.Next(j);
                temp = q_list[index];
                q_list[index] = q_list[j - 1];
                q_list[j - 1] = temp;

            }


            return q_list;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            end_test();
        }

        private void ans_1_Click(object sender, EventArgs e)
        {
            check_ans(1);
        }

        private void ans_2_Click(object sender, EventArgs e)
        {
            check_ans(2);
        }

        private void ans_3_Click(object sender, EventArgs e)
        {
            check_ans(3);
        }

        private void ans_4_Click(object sender, EventArgs e)
        {
            check_ans(4);
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Utils.PreviousPage.Show();
            ShowSolutions solutions = new ShowSolutions();
            solutions.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (SpeechSynthesizer synth =
   new SpeechSynthesizer())
            {
                synth.Speak(q_text.Text);

            }

        }

    }

}
