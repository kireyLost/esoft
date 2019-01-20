using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Esoft
{
    public partial class Supplies : Form
    {
        SqlConnection con = ResourcesConnectSql.GetSringsSql();

        public Supplies()
        {
            InitializeComponent();
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 140;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void movie_form(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Supplies_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.homeConnect.supplies);

            
            con.Open();


            //заполнение id клиентов
            SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.fill_ID_CB_clients(),con);
            DataTable dtc = new DataTable();
            sda.Fill(dtc);

            cbClient.DataSource=dtc;
            cbClient.DisplayMember = "Id";
            cbClient.ValueMember = "id";
            cbClient.SelectedIndex = -1;

            //заполнение id агентов
            SqlDataAdapter sda2 = new SqlDataAdapter(CommandsSql.fill_ID_CB_agents(),con);
            DataTable dtb2 = new DataTable();
            sda2.Fill(dtb2);

            cbRieltor.DataSource = dtb2;
            cbRieltor.DisplayMember = "Id";
            cbRieltor.ValueMember ="Id";
            cbRieltor.SelectedIndex = -1;            


            //заполнение id объектов/
            SqlDataAdapter da = new SqlDataAdapter(CommandsSql.fill_ID_CB_type_objects(), con);
            DataTable tb = new DataTable();
            da.Fill(tb);

            cbObject.DataSource = tb;
            cbObject.DisplayMember ="Id";
            cbObject.ValueMember = "Id";
            cbObject.SelectedIndex = -1;

            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.suppliesTableAdapter.Fill(this.homeConnect.supplies);

            lblInfo.Visible = true;
            lblInfo.Text = "Обновлено";
        }//Refresh

        private void btnInsert_Click(object sender, EventArgs e)//INSETR INTO
        {
            con.Open();
            try
            {
                SqlCommand com = new SqlCommand(CommandsSql.insert_supply(), con);
                com.Parameters.AddWithValue("Id", tbId.Text);
                com.Parameters.AddWithValue("Price", tbPrice.Text);
                com.Parameters.AddWithValue("AgentId", cbRieltor.Text);
                com.Parameters.AddWithValue("ClientId", cbClient.Text);
                com.Parameters.AddWithValue("RealEstateId", cbObject.Text);
                com.ExecuteNonQuery();

                lblInfo.Visible = true;
                lblInfo.Text = "Добавлена новая запись";
            }
            catch
            {
                MessageBox.Show("Error insert");
            }
            con.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)//DELETE
        {
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select Supply_Id from deals where Supply_Id = '" + tbId.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Вы не можете удалить предложение, которое уже участвует в сделке.", "Активная сделка", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                con.Close();
            }
            else
            {
                SqlCommand cDel = new SqlCommand("Delete from supplies where Id = '" + tbId.Text + "'", con);
                cDel.ExecuteNonQuery();
                
                lblInfo.Visible = true;
                lblInfo.Text = "Запись удалена";
            }

            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)//UPDATE
        {
            con.Open();
            try
            {
                SqlCommand com = new SqlCommand(CommandsSql.update_supply(), con);
                com.Parameters.AddWithValue("Id", tbId.Text);
                com.Parameters.AddWithValue("Price", tbPrice.Text);
                com.Parameters.AddWithValue("AgentId", cbRieltor.Text);
                com.Parameters.AddWithValue("ClientId", cbClient.Text);
                com.Parameters.AddWithValue("RealEstateId", cbObject.Text);
                com.ExecuteNonQuery();
                lblInfo.Visible = true;
                lblInfo.Text = "Запись изменена";
            }
            catch
            {
                MessageBox.Show("Error update");
            }
            con.Close();

        }


        //digits for textbox
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Обновить");
        }
    }
}
