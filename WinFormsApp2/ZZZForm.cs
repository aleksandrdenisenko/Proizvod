using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ZZZForm : Form
    {
        public ZZZForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Violet;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NachaloForm NachaloForm = new NachaloForm();
            NachaloForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BebraForm BebraForm = new BebraForm();
            BebraForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HISTORIForm HISTORIForm = new HISTORIForm();
            HISTORIForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BelkaForm BelkaForm = new BelkaForm();
            BelkaForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThisForm ThisForm = new ThisForm();
            ThisForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            SSSForm SSSForm = new SSSForm();
            SSSForm.Show();
        }
    }
}
