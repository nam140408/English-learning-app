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
    public partial class Vocabulary : Form
    {
        int last_y = 0;
        List<string> vocabulary = new List<string>();
        public Vocabulary()
        {
            InitializeComponent();
        }
        private void show_path()
        {
            if (Properties.Settings.Default.Having_path == true)
            {

                filepath.ReadOnly = true;
                Add_file_path.Text = "Edit";
                string path = Properties.Settings.Default.My_Path;
                filepath.Text = path;
            }
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
        private string Give_mean(string word)
        {
            string filePath = Properties.Settings.Default.My_Path + @"\Meaning\" + word + ".txt";
            string s = "";
            if (File.Exists(filePath))
            {
                s = File.ReadAllText(filePath);
            }
            return s;
        }
        private void load_your_words()
        {
            for (int i = 0; i < vocabulary.Count; i++)
            {
                string word = vocabulary[i];
                string meaning = Give_mean(word);

                GroupBox new_word = new GroupBox();
                new_word.Text = word;
                new_word.Size = new Size(1096, 120);
                new_word.Font = new Font(new_word.Font.FontFamily, (float)18, FontStyle.Bold);
                if (last_y == 0)
                {
                    new_word.Location = new Point(3, -2);
                    last_y = -2;
                }
                else
                {
                    int y = last_y + 132;
                    new_word.Location = new Point(3, y);
                    last_y = y;
                }
                All_words.Controls.Add(new_word);

                TextBox show_all = new TextBox();
                show_all.Text = meaning;
                show_all.ReadOnly = true;
                show_all.ScrollBars = ScrollBars.Vertical;
                show_all.Location = new Point(7, 30);
                show_all.Size = new Size(1065, 84);
                show_all.Multiline = true;
                show_all.Font = new Font(show_all.Font.FontFamily, (float)14.25, show_all.Font.Style);

                new_word.Controls.Add(show_all);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            show_path();
            load_voc();
            load_your_words();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(!Adding_box.Visible) Adding_box.Visible = true;
            else Adding_box.Visible = false;
        }
        private void add_word()
        {
            Adding_box.Visible = false;
            string word = Word_box.Text;
            string meaning = Meaning_box.Text;

            GroupBox new_word = new GroupBox();
            new_word.Text = word;
            new_word.Size = new Size(1096, 120);
            new_word.Font = new Font(new_word.Font.FontFamily, (float)18, FontStyle.Bold);
            if (last_y == 0)
            {
                new_word.Location = new Point(3, -2);
                last_y = -2;
            }
            else
            {
                int y = last_y + 132;
                new_word.Location = new Point(3, y);
                last_y = y;
            }
            All_words.Controls.Add(new_word);
            vocabulary.Add(word);

            TextBox show_all = new TextBox();
            show_all.Text = meaning;
            show_all.ReadOnly = true;
            show_all.ScrollBars = ScrollBars.Vertical;
            show_all.Location = new Point(7, 30);
            show_all.Size = new Size(1065, 84);
            show_all.Multiline = true;
            show_all.Font = new Font(show_all.Font.FontFamily, (float)14.25, show_all.Font.Style);

            new_word.Controls.Add(show_all);
        }
        private void write_word()
        {
            string word = Word_box.Text;
            string path = Properties.Settings.Default.My_Path + "All_words.txt";
            string words = "";
            if (File.Exists(path)) words = File.ReadAllText(path);
            if (words != "") words = words + "_" + word;
            else words = word;

            string folderPath = filepath.Text;
            string filename = "All_words.txt";
            string File_Path = Path.Combine(folderPath, filename); ;
            File.WriteAllText(File_Path, words);
        }
        private void save_word()
        {
            string folderPath = filepath.Text + @"Meaning\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string word = Word_box.Text;
            string mean = Meaning_box.Text;
            string filename = word + ".txt";
            string File_Path = Path.Combine(folderPath, filename);
            File.WriteAllText(File_Path, mean);
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            string word = Word_box.Text;
            string mean = Meaning_box.Text;
            if (word == "" && mean == "")
            {
                MessageBox.Show("Please, enter.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (word == "")
            {
                MessageBox.Show("Please, enter your word.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (mean == "")
            {
                MessageBox.Show("Please, enter the meaning of your word.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (word != "" && mean != "" && vocabulary.Contains(word))
                {
                    MessageBox.Show("This word is already there.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    add_word();
                    write_word();
                    save_word();
                }
            }
            Word_box.Text = "";
            Meaning_box.Text = "";
        }

        private void VOC_Click(object sender, EventArgs e)
        {
            if(LEARN.BackColor != Color.Gainsboro)
            {
               LEARN.BackColor = Color.Gainsboro;
                LEARN.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            if (EXAM.BackColor != Color.Gainsboro)
            {
                EXAM.BackColor = Color.Gainsboro;
                EXAM.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            VOC.BackColor = Color.White;
            VOC.FlatAppearance.MouseOverBackColor = Color.LightGray;
        }

        private void LEARN_Click(object sender, EventArgs e)
        {
            if (VOC.BackColor != Color.Gainsboro)
            {
                VOC.BackColor = Color.Gainsboro;
                VOC.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            if (EXAM.BackColor != Color.Gainsboro)
            {
                EXAM.BackColor = Color.Gainsboro;
                EXAM.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            LEARN.BackColor = Color.White;
            LEARN.FlatAppearance.MouseOverBackColor = Color.LightGray;
            this.Hide();
            Learning form3 = new Learning();
            form3.ShowDialog();
            this.Close();
        }

        private void EXAM_Click(object sender, EventArgs e)
        {
            if (VOC.BackColor != Color.Gainsboro)
            {
                VOC.BackColor = Color.Gainsboro;
                VOC.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            if (LEARN.BackColor != Color.Gainsboro)
            {
                LEARN.BackColor = Color.Gainsboro;
                LEARN.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            EXAM.BackColor = Color.White;
            EXAM.FlatAppearance.MouseOverBackColor = Color.LightGray; 
            this.Hide();
            Exam form4 = new Exam();
            form4.ShowDialog();
            this.Close();
        }

        private void VOC_MouseDown(object sender, MouseEventArgs e)
        {
            VOC.Font = new Font(VOC.Font.FontFamily, (float)13.50, VOC.Font.Style);
        }

        private void VOC_MouseUp(object sender, MouseEventArgs e)
        {

            VOC.Font = new Font(VOC.Font.FontFamily, (float)14.25, VOC.Font.Style);
        }


        private void LEARN_MouseDown(object sender, MouseEventArgs e)
        {
            LEARN.Font = new Font(LEARN.Font.FontFamily, (float)13.50, LEARN.Font.Style);
        }
        private void LEARN_MouseUp(object sender, MouseEventArgs e)
        {
            LEARN.Font = new Font(LEARN.Font.FontFamily, (float)14.25, LEARN.Font.Style);
        }

        private void EXAM_MouseDown(object sender, MouseEventArgs e)
        {
            EXAM.Font = new Font(EXAM.Font.FontFamily, (float)13.50, EXAM.Font.Style);
        }
        private void EXAM_MouseUp(object sender, MouseEventArgs e)
        {
            EXAM.Font = new Font(EXAM.Font.FontFamily, (float)14.25, EXAM.Font.Style);
        }

        private void Add_file_path_Click(object sender, EventArgs e)
        {
            if(!filepath.ReadOnly){   
                filepath.ReadOnly = true;
                Add_file_path.Text = "Edit";
                string path = filepath.Text;

                Properties.Settings.Default.Having_path = true;
                Properties.Settings.Default.My_Path = path;
                Properties.Settings.Default.Save();
            }
            else
            {
                filepath.ReadOnly = false;
                Add_file_path.Text = "Add file path";

            }
           /* string folderPath = path;
            string filename = "Path.txt";
            string File_Path = Path.Combine(folderPath, filename); ;
            File.WriteAllText(File_Path, path);*/
        }

    }
}
