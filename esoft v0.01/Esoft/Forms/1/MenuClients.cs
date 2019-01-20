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
    public partial class MenuClients : Form
    {
        

        SqlConnection con = ResourcesConnectSql.GetSringsSql();

        public MenuClients()
        {
            InitializeComponent();
            panelSlide.Visible = false;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 160;

            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void MenuClients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.homeConnect.clients);

            
 
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = ResourcesConnectSql.GetSringsSql();
            await con.OpenAsync();


            SqlCommand command = new SqlCommand("SELECT * FROM [clients] WHERE [FirstName] in"+ textBox7.Text + 
                "and [LastName] in "+ textBox7.Text + "and [MiddleName] in " + textBox7.Text, con);
            con.Close();

        }//Find of clients

        private void btn_insert_Click(object sender, EventArgs e)//INSERT
        {
            con.Open();
            if (!string.IsNullOrEmpty(tb_phone.Text) || !string.IsNullOrEmpty(tb_email.Text))
            {
                SqlCommand command = new SqlCommand(CommandsSql.insert_cl(), con);
                command.Parameters.AddWithValue("Id", tb_id.Text);
                command.Parameters.AddWithValue("FirstName", tb_FN.Text);
                command.Parameters.AddWithValue("LastName", tb_LN.Text);
                command.Parameters.AddWithValue("MiddleName", tb_MN.Text);
                command.Parameters.AddWithValue("Phone", tb_phone.Text);
                command.Parameters.AddWithValue("Email", tb_email.Text);
                try
                {
                    command.ExecuteNonQuery();
                    lblInfo.Visible = true;
                    lblInfo.Text = "Запись " + tb_id.Text + " добавлена";
                }
                catch
                {
                    MessageBox.Show("Ошибка добавления. Проверьте правильность заполнения полей.", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка добавления. Одно из полей Телефон или Email должно быть заполнено.", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter checkid = new SqlDataAdapter("SELECT Id FROM clients WHERE Id='"+tb_id.Text+"'", con);
            DataTable id_c = new DataTable();
            checkid.Fill(id_c);

            if (id_c.Rows.Count !=0)
            {

                SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.check_id_dem_sup(tb_id.Text), con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM [clients] WHERE [Id]=@Id", con);
                        command.Parameters.AddWithValue("Id", tb_id.Text);
                        command.ExecuteNonQuery();

                        lblInfo.Visible = true;
                        lblInfo.Text = "Запись " + tb_id.Text + " удалена";
                    }
                    catch
                    {
                        MessageBox.Show("Нельзя удалить клиента, который участвует в сделке, либо связан с потребностью или предложением.", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
            else
            {
                if (string.IsNullOrEmpty(tb_id.Text))
                {
                    MessageBox.Show("Укажите Id клиента для удаления записи", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Пользователь с идентификатором " + tb_id.Text + " не найден.", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            con.Close();
        }//DELETE

        private void btn_upd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand(CommandsSql.upd_cl(), con);

            command.Parameters.AddWithValue("Id", tb_id.Text);
            command.Parameters.AddWithValue("FirstName", tb_FN.Text);
            command.Parameters.AddWithValue("LastName", tb_LN.Text);
            command.Parameters.AddWithValue("MiddleName", tb_MN.Text);
            command.Parameters.AddWithValue("Phone", tb_phone.Text);
            command.Parameters.AddWithValue("Email", tb_email.Text);

            command.ExecuteNonQuery();
            lblInfo.Visible = true;
            lblInfo.Text = "Запись " + tb_id.Text + " изменена";
            con.Close();
        }//UPDATE

        private void btn_show_slide_Click(object sender, EventArgs e)
        {
            pc_logo.Visible = false;
            if (panelSlide.Visible)
            {
                panelSlide.Visible = false;
            }
            else
            {
                panelSlide.Visible = true;
            }
        }

        private void refresh_grid_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.homeConnect.clients);
            pc_logo.Visible = true;
            lblInfo.Visible = false;
        }

        private void tb_LN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_FN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_MN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Capture = false;
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            var m2 = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m2);
        }

        private void btn_show_slide_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btn_show_slide, "Клиент: добавить, изменить, удалить");
        }

        private void refresh_grid_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(refresh_grid, "Обновить");
        }
    }
}
