using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace EnglishTest
{
    public static class Utils
    {
        public static Form PreviousPage; //handle the menu screen.
        public static string lists_directory = "lists";
        public static string current_list_name = "";

    public static List<string> Get_all_lists()
        {
            List<string> words_lists = new List<string>();
            Directory.CreateDirectory(lists_directory);
            string[] fileEntries = Directory.GetFiles(lists_directory);
            foreach (string fileName in fileEntries)
                if (fileName.EndsWith(".txt"))
                    words_lists.Add(fileName);
            return words_lists;
        }

    public static bool create_new_list(string name)
    {
        if (File.Exists(lists_directory+"\\"+name+".txt"))
            return false;
        File.Create(lists_directory+"\\"+name+".txt").Close();
        return true;
    }

    public static bool delete_list(string name)
    {
        char[] delimiterChars = { '\\' };
        string[] words = name.Split(delimiterChars);
        name = words[words.Length - 1];
        name = name.Replace(".txt", "");
        if (File.Exists(lists_directory+"\\"+name+".txt"))
        {
            File.Delete(lists_directory + "\\" + name + ".txt");
            return true;
        }
        return false;

    }
        public static void write_words(List<Word> words_list)
        {
            /*This function write the words list to the disk.
             * הפונקציה דורסת את הערכים הקודמים שהיו בקובץ!
             */


            using (System.IO.StreamWriter file =
        new System.IO.StreamWriter(current_list_name))
            {
                foreach (Word w in words_list)
                {
                    file.WriteLine(w.ToString());
                }
            }
        }

        public static List<Word> load_words()
        {
            /*This function load the words from the disk and return a words list*/
            List<Word> words_list = new List<Word>();


            //if (!File.Exists("WordsDB.txt"))
            //{
            //    File.Create("WordsDB.txt").Close();
            //    return words_list;
            //  //  MessageBox.Show("שגיאה! קובץ המילים לא נמצא ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    //Application.Exit();
            //}
           // else
            //{
                string[] lines = System.IO.File.ReadAllLines(current_list_name);
                char[] delimiterChars = { ':' };

                foreach (string line in lines)
                {
                    string[] words = line.Split(delimiterChars);
                    if (words.Length > 1 && words.Length != 5)
                    {
                        words_list.Add(new Word(words[0], words[1], 0, 0, 0));
                    }

                    else
                    {
                        words_list.Add(new Word(words[0], words[1], Int32.Parse(words[2]), Int32.Parse(words[3]), Int32.Parse(words[4])));

                    }
                    //     words_list.Add(new Word(words[0], words[1], 0, 0,0));

                    //   Console.WriteLine(words_list[0].get_translate());
                }
                return words_list;
          //  }

       

        }
    }
}
