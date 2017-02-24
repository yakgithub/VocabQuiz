using System;
using System.Collections.Generic;
using System.Collections;
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

    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //Test testform = new Test(false,30,true);
            //testform.Show();
            //this.Hide();
            TestSettings t = new TestSettings();
            t.ShowInTaskbar = false;
            t.Show();
            Utils.PreviousPage=this;
           

          //  this.Close();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            ShowStats stats_form = new ShowStats();
            this.Hide();
            Utils.PreviousPage = this;
            stats_form.ShowDialog();

            
        }

        private void btn_edit_words_Click(object sender, EventArgs e)
        {
            WordsEditor w = new WordsEditor();
            this.Hide();
            Utils.PreviousPage = this;
            w.Show();

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            Utils.PreviousPage = this;
            about.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



    }

