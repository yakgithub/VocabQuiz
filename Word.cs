using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishTest
{
    public class Word
    {
        private String english_word;
        private String hebrew_word;
        private int right_ans;
        private int wrong_ans;
        private int sequence_of_correct_ans;

        public Word(String english_word, String hebrew_word, int right_ans, int wrong_ans,int sequence_of_correct_ans)
        {
            this.english_word = english_word;
            this.hebrew_word = hebrew_word;
            this.right_ans = right_ans;
            this.wrong_ans = wrong_ans;
            this.sequence_of_correct_ans = sequence_of_correct_ans;
        }
        public String get_english_word()
        {
            return this.english_word;
        }

        public String get_hebrew_word()
        {
            return this.hebrew_word;
        }

        public void set_english_word(String english_word)
        {
            this.english_word = english_word;
        }

        public void set_hebrew_word(String hebrew_word)
        {
            this.hebrew_word = hebrew_word;
        }
    

        public int get_right_ans()
        {
            return this.right_ans;
        }

        public int get_wrong_ans()
        {
            return this.wrong_ans;
        }

        public int get_sequence()
        {
            return this.sequence_of_correct_ans;
        }

        public void inc_right_ans()
        {
            this.right_ans += 1;
        }

        public void inc_wrong_ans()
        {
            this.wrong_ans += 1;
        }

        public void inc_sequence()
        {
            this.sequence_of_correct_ans += 1;
        }

        public void reset_sequence()
        {
            this.sequence_of_correct_ans=0;
        }
        public String ToString()
        {
            return this.english_word + ":" + this.hebrew_word + ":" + this.right_ans.ToString() + ":" + this.wrong_ans.ToString() + ":" + this.sequence_of_correct_ans.ToString();
        }

    }
}
