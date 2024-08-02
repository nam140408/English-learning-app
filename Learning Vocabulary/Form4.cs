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
    public partial class Exam : Form
    {
        int pos = Properties.Settings.Default.Learned;
        List<string> vocabulary = new List<string>();
        Dictionary<string, int> pos_voc = new Dictionary<string, int>();
        public Exam()
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
                        pos_voc[t] = vocabulary.Count - 1;
                        t = "";
                    }
                }
                if (t != "")
                {
                    vocabulary.Add(t);
                    pos_voc[t] = vocabulary.Count - 1;
                }
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
                if (y == 0)
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
        private void Form4_Load(object sender, EventArgs e)
        {
            load_voc();
            show_voc();
        }

        private void LEARN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Learning form3 = new Learning();
            form3.ShowDialog();
            this.Close();
        }

        private void VOC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vocabulary form2 = new Vocabulary();
            form2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = Word.Text;
            string filePath = Properties.Settings.Default.My_Path + @"Meaning\" + s + ".txt";
            if (File.Exists(filePath))
            {
                string mean = File.ReadAllText(filePath);
                Meaning_box.Text = mean;
            }
        }
        List<string> showed = new List<string>();
        private void Random_voc(int st, int en)
        {
            Random random = new Random();
            int ta = random.Next(st, en + 1);
            while (showed.Contains(vocabulary[ta]))
            {
                ta = random.Next(st, en + 1);
            }
            showed.Add(vocabulary[ta]);
            Word.Text = vocabulary[ta];
        }
        private void sequence(int st, int en)
        {
            bool finish = true;
            for (int i = st; i <= en; i++)
            {
                if (!showed.Contains(vocabulary[i]))
                {
                    finish = false;
                    Random_voc(st, en);
                    break;
                }
            }
            if (finish)
            {
                All_word.Checked = false;
                From_box.ReadOnly = to_box.ReadOnly = false;
                showed.Clear();
                MessageBox.Show("This test ended.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!All_word.Checked)
            {
                if (From_box.Text == "" || to_box.Text == "")
                {
                    MessageBox.Show("Please, fill out completely or choose All word", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!vocabulary.Contains(From_box.Text) || !vocabulary.Contains(to_box.Text))
                {
                    MessageBox.Show("Please, those words do not exist", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else sequence(pos_voc[From_box.Text], pos_voc[to_box.Text]);
            }
            else sequence(0, vocabulary.Count - 1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(!From_box.ReadOnly) From_box.ReadOnly = to_box.ReadOnly = true;
            else
            {
                From_box.ReadOnly = to_box.ReadOnly = false;
                All_word.Checked = false;
            }
        }
    }
}
