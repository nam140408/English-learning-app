namespace Learning_Vocabulary
{
    partial class Learning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Learning_word = new System.Windows.Forms.Panel();
            this.From_box = new System.Windows.Forms.TextBox();
            this.Show_from = new System.Windows.Forms.Label();
            this.Show_meaning_box = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Meaning_box = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Word = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Voca = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EXAM = new System.Windows.Forms.Button();
            this.LEARN = new System.Windows.Forms.Button();
            this.VOC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Learning_word.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Learning_word
            // 
            this.Learning_word.AutoScroll = true;
            this.Learning_word.Controls.Add(this.From_box);
            this.Learning_word.Controls.Add(this.Show_from);
            this.Learning_word.Controls.Add(this.Show_meaning_box);
            this.Learning_word.Controls.Add(this.button1);
            this.Learning_word.Controls.Add(this.groupBox3);
            this.Learning_word.Controls.Add(this.groupBox2);
            this.Learning_word.Controls.Add(this.groupBox1);
            this.Learning_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Learning_word.Location = new System.Drawing.Point(236, 46);
            this.Learning_word.Name = "Learning_word";
            this.Learning_word.Size = new System.Drawing.Size(1122, 698);
            this.Learning_word.TabIndex = 7;
            // 
            // From_box
            // 
            this.From_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.From_box.Location = new System.Drawing.Point(902, 25);
            this.From_box.Name = "From_box";
            this.From_box.Size = new System.Drawing.Size(205, 22);
            this.From_box.TabIndex = 6;
            // 
            // Show_from
            // 
            this.Show_from.AutoSize = true;
            this.Show_from.Location = new System.Drawing.Point(831, 23);
            this.Show_from.Name = "Show_from";
            this.Show_from.Size = new System.Drawing.Size(65, 24);
            this.Show_from.TabIndex = 5;
            this.Show_from.Text = "From :";
            // 
            // Show_meaning_box
            // 
            this.Show_meaning_box.Location = new System.Drawing.Point(835, 152);
            this.Show_meaning_box.Name = "Show_meaning_box";
            this.Show_meaning_box.Size = new System.Drawing.Size(272, 56);
            this.Show_meaning_box.TabIndex = 4;
            this.Show_meaning_box.Text = "Show the meaning";
            this.Show_meaning_box.UseVisualStyleBackColor = true;
            this.Show_meaning_box.Click += new System.EventHandler(this.Show_meaning_box_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(835, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show your word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Show_your_word_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Meaning_box);
            this.groupBox3.Location = new System.Drawing.Point(379, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 323);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meaning";
            // 
            // Meaning_box
            // 
            this.Meaning_box.Location = new System.Drawing.Point(6, 28);
            this.Meaning_box.Multiline = true;
            this.Meaning_box.Name = "Meaning_box";
            this.Meaning_box.ReadOnly = true;
            this.Meaning_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Meaning_box.Size = new System.Drawing.Size(431, 284);
            this.Meaning_box.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Word);
            this.groupBox2.Location = new System.Drawing.Point(379, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your word";
            // 
            // Word
            // 
            this.Word.FlatAppearance.BorderSize = 0;
            this.Word.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Word.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(7, 25);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(430, 288);
            this.Word.TabIndex = 0;
            this.Word.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Voca);
            this.groupBox1.Location = new System.Drawing.Point(5, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 652);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vocabulary";
            // 
            // Voca
            // 
            this.Voca.AutoScroll = true;
            this.Voca.Location = new System.Drawing.Point(6, 25);
            this.Voca.Name = "Voca";
            this.Voca.Size = new System.Drawing.Size(356, 616);
            this.Voca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Learning";
            // 
            // EXAM
            // 
            this.EXAM.BackColor = System.Drawing.Color.Gainsboro;
            this.EXAM.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.EXAM.FlatAppearance.BorderSize = 0;
            this.EXAM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.EXAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.EXAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXAM.Location = new System.Drawing.Point(3, 325);
            this.EXAM.Name = "EXAM";
            this.EXAM.Size = new System.Drawing.Size(228, 50);
            this.EXAM.TabIndex = 4;
            this.EXAM.Text = "Exam";
            this.EXAM.UseVisualStyleBackColor = false;
            this.EXAM.Click += new System.EventHandler(this.EXAM_Click);
            // 
            // LEARN
            // 
            this.LEARN.BackColor = System.Drawing.Color.White;
            this.LEARN.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.LEARN.FlatAppearance.BorderSize = 0;
            this.LEARN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.LEARN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.LEARN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LEARN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEARN.Location = new System.Drawing.Point(3, 270);
            this.LEARN.Name = "LEARN";
            this.LEARN.Size = new System.Drawing.Size(228, 50);
            this.LEARN.TabIndex = 3;
            this.LEARN.Text = "Learning";
            this.LEARN.UseVisualStyleBackColor = false;
            // 
            // VOC
            // 
            this.VOC.BackColor = System.Drawing.Color.Gainsboro;
            this.VOC.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.VOC.FlatAppearance.BorderSize = 0;
            this.VOC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.VOC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.VOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VOC.Location = new System.Drawing.Point(3, 215);
            this.VOC.Name = "VOC";
            this.VOC.Size = new System.Drawing.Size(228, 50);
            this.VOC.TabIndex = 2;
            this.VOC.Text = "Vocabulary";
            this.VOC.UseVisualStyleBackColor = false;
            this.VOC.Click += new System.EventHandler(this.VOC_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.EXAM);
            this.panel1.Controls.Add(this.LEARN);
            this.panel1.Controls.Add(this.VOC);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 749);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Learning_Vocabulary.Properties.Resources._09fdc04f_afd2_410e_8a8e_c93c767664c7_removebg_preview__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(48, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(235, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 45);
            this.panel2.TabIndex = 6;
            // 
            // Learning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Learning_word);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Learning";
            this.ShowIcon = false;
            this.Text = "Learning";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Learning_word.ResumeLayout(false);
            this.Learning_word.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Learning_word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EXAM;
        private System.Windows.Forms.Button LEARN;
        private System.Windows.Forms.Button VOC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Show_meaning_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Word;
        private System.Windows.Forms.TextBox Meaning_box;
        private System.Windows.Forms.Panel Voca;
        private System.Windows.Forms.TextBox From_box;
        private System.Windows.Forms.Label Show_from;
    }
}