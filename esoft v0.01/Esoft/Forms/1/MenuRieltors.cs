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
    public partial class MenuRieltors : Form
    {
        SqlConnection con = ResourcesConnectSql.GetSringsSql();

        public MenuRieltors()
        {
            InitializeComponent();
            panelSlide.Visible = false;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 150;
        }

        private void MenuRieltors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.agents". При необходимости она может быть перемещена или удалена.
            this.agentsTableAdapter.Fill(this.homeConnect.agents);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.agents". При необходимости она может быть перемещена или удалена.
            this.agentsTableAdapter.Fill(this.homeConnect.agents);
            pc_logo.Visible = true;
            lblInfo.Visible = false;
        }

        private void btn_del_Click(object sender, EventArgs e)//DELETE
        {
            con.Open();
            SqlDataAdapter checkid_ag = new SqlDataAdapter("SELECT * FROM [agents] WHERE Id='" + tb_id.Text + "'", con);
            DataTable dt1 = new DataTable();
            checkid_ag.Fill(dt1);

            if (dt1.Rows.Count != 0)
            {
                SqlDataAdapter checkid_s_d = new SqlDataAdapter(CommandsSql.check_id_dem_sup_ag(tb_id.Text), con);
                DataTable dt2 = new DataTable();
                checkid_s_d.Fill(dt2);

                if (dt2.Rows.Count == 0)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM [agents] WHERE [Id]=@Id", con);
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
                    MessageBox.Show("Укажите Id пользователя для удаления записи", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrEmpty(tb_id.Text))
                    {
                        MessageBox.Show("Укажите Id агента для удаления записи", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с идентификатором " + tb_id.Text + " не найден.", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            con.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand com = new SqlCommand(CommandsSql.insert_ag(), con);
            com.Parameters.AddWithValue("Id", tb_id.Text);
            com.Parameters.AddWithValue("FirstName", tb_FN.Text);
            com.Parameters.AddWithValue("MiddleName", tb_MN.Text);
            com.Parameters.AddWithValue("LastName", tb_LN.Text);
            com.Parameters.AddWithValue("DealShare", tb_ds.Text);

            try
            {
                if (tb_ds.Text != "")
                {
                    if (Convert.ToInt32(tb_ds.Text) >= 0 && Convert.ToInt32(tb_ds.Text) <= 100)
                    {
                        com.ExecuteNonQuery();
                        lblInfo.Visible = true;
                        lblInfo.Text = "Запись " + tb_id.Text + " добавлена";
                    }
                    else
                    {
                        MessageBox.Show("Значение комиссии может быть в диапазоне от 0 до 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (tb_ds.Text == "")
                {
                    com.ExecuteNonQuery();
                    lblInfo.Visible = true;
                    lblInfo.Text = "Запись " + tb_id.Text + " добавлена";
                }
            }
            catch
            {
                if (string.IsNullOrEmpty(tb_FN.Text) || string.IsNullOrEmpty(tb_MN.Text) || string.IsNullOrEmpty(tb_LN.Text))
                {
                    MessageBox.Show("Ошибка добавления. Указание ФИО агента обязательно для добавления записи", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ошибка добавления. Проверьте правильность заполнения полей.", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }//INSERT

        private void btn_upd_Click(object sender, EventArgs e)//UPDATE
        {
            con.Open();
            SqlCommand com = new SqlCommand(CommandsSql.upd_ag(), con);
            com.Parameters.AddWithValue("Id", tb_id.Text);
            com.Parameters.AddWithValue("FirstName", tb_FN.Text);
            com.Parameters.AddWithValue("MiddleName", tb_MN.Text);
            com.Parameters.AddWithValue("LastName", tb_LN.Text);
            com.Parameters.AddWithValue("DealShare", tb_ds.Text);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM agents WHERE Id='" + tb_id.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                try
                {
                    if (tb_ds.Text != "")
                    {
                        if (Convert.ToInt32(tb_ds.Text) >= 0 && Convert.ToInt32(tb_ds.Text) <= 100)
                        {
                            com.ExecuteNonQuery();
                            lblInfo.Visible = true;
                            lblInfo.Text = "Запись " + tb_id.Text + " добавлена";
                        }
                        else
                        {
                            MessageBox.Show("Значение комиссии может быть в диапазоне от 0 до 100", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tb_ds.Text == "")
                    {
                        MessageBox.Show("Укажите индентификатор агента для внесения изменений", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    if (string.IsNullOrEmpty(tb_FN.Text) || string.IsNullOrEmpty(tb_MN.Text) || string.IsNullOrEmpty(tb_LN.Text))
                    {
                        MessageBox.Show("Ошибка изменения. Указание ФИО агента обязательно для добавления записи", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка изменения. Проверьте правильность заполнения полей.", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Агент с идентификатором " + tb_id.Text + " не найден.", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        //digit and letters
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
        private void tb_ds_KeyPress(object sender, KeyPressEventArgs e)
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
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void btn_show_slide_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btn_show_slide, "Риелтор: добавить, изменить, удалить");
        }

        private void refresh_grid_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(refresh_grid, "Клиент: добавить, изменить, удалить");
        }
    }
}
