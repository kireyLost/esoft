using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            MenuClients mc = new MenuClients();
            mc.Show();
            this.Hide();
            
        }

        private void buttonRieltors_Click(object sender, EventArgs e)
        {
            MenuRieltors mr = new MenuRieltors();
            mr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nedvizhimost ned = new Nedvizhimost();
            ned.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplies supl = new Supplies();
            supl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Demands dm = new Demands();
            dm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deals dl = new Deals();
            dl.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Capture = false;
            var m2 = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m2);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            var m2 = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m2);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void btn_logout_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btn_logout, "Выйти из учетной записи");
        }
    }
}
