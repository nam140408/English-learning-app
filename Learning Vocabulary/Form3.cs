using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Vocabulary
{
    public partial class Learning : Form
    {
        string from_word = "";
        int pos = Properties.Settings.Default.Learned;
        List<string> vocabulary = new List<string>();
        public Learning()
        {
            InitializeComponent();
        }

        private void load_voc()
        {
            string filePath = Properties.Settings.Default.My_Path + "All_words.txt";
            if (File.Exists(filePath))
            {
                string s = File.ReadAllText(filePath);
                string t = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != '_') t += s[i];
                    else
                    {
                        vocabulary.Add(t);
                        t = "";
                    }
                }
                if (t != "") vocabulary.Add(t);
            }
        }
        private void show_voc()
        {
            int y = 0;
            for (int i = 0; i < vocabulary.Count; i++) 
            { 
                TextBox new_word = new TextBox();
                new_word.Text = vocabulary[i];
                new_word.Size = new Size(333, 24);
                if(y == 0)
                {
                    y = 3;
                    new_word.Location = new Point(12, 3);
                }
                else
                {
                    y = y + 30;
                    new_word.Location = new Point(12, y);
                }
                new_word.ReadOnly = true;
                new_word.BackColor = SystemColors.Control;
                new_word.BorderStyle = BorderStyle.None;
                new_word.Font = new Font(new_word.Font.FontFamily, (float)15.75, new_word.Font.Style);
                Voca.Controls.Add(new_word);
                
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            load_voc();
            show_voc();
        }

        private void VOC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vocabulary form2 = new Vocabulary();
            form2.ShowDialog();
            this.Close();
        }

        private void Show_your_word_Click(object sender, EventArgs e)
        {
            string s = From_box.Text;
            if (s != from_word)
            {
                if (vocabulary.Contains(s))
                {
                    for (int i = 0; i < vocabulary.Count; i++) {
                        if (vocabulary[i] == s) 
                        { 
                            pos = i - 1;
                            break;
                        }
                    }
                    from_word = s;
                }
                else MessageBox.Show("This word does not exist", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pos++;
            if (pos < vocabulary.Count) Word.Text = vocabulary[pos];
            else MessageBox.Show("The end of your vocabulary", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Show_meaning_box_Click(object sender, EventArgs e)
        {
            string s = Word.Text;
            string filePath = Properties.Settings.Default.My_Path + @"Meaning\" + s + ".txt";
            if (File.Exists(filePath))
            {
                string mean = File.ReadAllText(filePath);
                Meaning_box.Text = mean;
            }
        }

        private void EXAM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam form4 = new Exam();
            form4.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
