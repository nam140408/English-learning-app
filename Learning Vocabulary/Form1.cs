using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Vocabulary
{
    public partial class Welcome : Form
    {
        private Timer timer;
        public Welcome()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            // Tạo Timer và thiết lập thời gian là 2000 ms (2 giây)
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            // Bắt đầu đếm thời gian khi Form1 tải
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Khi Timer kết thúc (Tick), thực hiện các hành động
            timer.Stop();

            this.Hide();
            Vocabulary form2 = new Vocabulary();
            form2.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
