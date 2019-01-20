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
    public partial class Demands : Form
    {
        SqlConnection con = ResourcesConnectSql.GetSringsSql();

        public Demands()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void bntDopInfo_Click(object sender, EventArgs e)
        {
            if (panel_dopInfo.Visible==false)
            {
                panel_dopInfo.Visible = true;
            }
            else
            {
                panel_dopInfo.Visible = false;
            }
        }

        private void bnt_type_object_Click(object sender, EventArgs e)
        {
            pb_load.Visible = false;
            pb_home.Visible = false;
            lbl_load.Visible = false;
            

            if (cb_type_object.Text.Equals("Квартира"))
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.apartment_demands". При необходимости она может быть перемещена или удалена.
                this.apartment_demandsTableAdapter.Fill(this.homeConnect.apartment_demands);
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;

                //**Floors
                label14.Visible = true;
                label15.Visible = true;
                label14.Text = "Этаж(мин)";
                label15.Text = "Этаж(макс)";
                tbFloor_min.Visible = true;
                tbFloor_max.Visible = true;
                //**

                //**Roomns
                label12.Visible = true;
                label16.Visible = true;
                tbCount_rooms_min.Visible = true;
                tbCount_rooms_max.Visible = true;
                //**
            }
            else if (cb_type_object.Text.Equals("Дом"))
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.house_demands". При необходимости она может быть перемещена или удалена.
                this.house_demandsTableAdapter.Fill(this.homeConnect.house_demands);

                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView3.Visible = false;

                //**Floors
                label14.Visible = true;
                label15.Visible = true;
                label14.Text = "Этажей(мин)";
                label15.Text = "Этажей(макс)";
                tbFloor_min.Visible = true;
                tbFloor_max.Visible = true;
                //**

                //**Roomns
                label12.Visible = true;
                label16.Visible = true;
                tbCount_rooms_min.Visible = true;
                tbCount_rooms_max.Visible = true;
                //**
            }
            else if (cb_type_object.Text.Equals("Земля"))//hide floors and rooms
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.land_demands". При необходимости она может быть перемещена или удалена.
                this.land_demandsTableAdapter.Fill(this.homeConnect.land_demands);

                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;

                label14.Visible = false;
                label15.Visible = false;
                tbFloor_min.Visible = false;
                tbFloor_max.Visible = false;

                label12.Visible = false;
                label16.Visible = false;
                tbCount_rooms_min.Visible = false;
                tbCount_rooms_max.Visible = false;
            }
        }

        private void Demands_Load(object sender, EventArgs e)//Load form
        {
            con.Open();

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[1].Width = 115;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[4].Width = 145;

            panel_dopInfo.Visible = false;


            //Selecting city in cb
            SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.selcity(), con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Город";
            comboBox1.ValueMember = "Address_City";
            comboBox1.SelectedIndex = -1;

            //Selecting client in cb
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Id FROM[clients]", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            cb_Client.DataSource = dt2;
            cb_Client.DisplayMember = "Id";
            cb_Client.ValueMember = "Id";
            cb_Client.SelectedIndex = -1;

            //Selecting agent in cb
            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT Id FROM[agents]", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);

            cb_Agent.DataSource = dt3;
            cb_Agent.DisplayMember = "Id";
            cb_Agent.ValueMember = "Id";
            cb_Agent.SelectedIndex = -1;

            con.Close();

        }
        private void btn_del_Click(object sender, EventArgs e) //DELETE
        {
            con.Open();

            //check id in table
            SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.check_id(tb_id.Text), con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count != 0)
            {

                SqlDataAdapter sdaDel = new SqlDataAdapter("Select Demand_Id from deals where Demand_Id = '" + tb_id.Text + "'", con);
                DataTable dtDel = new DataTable();
                sdaDel.Fill(dtDel);

                if (dt.Rows.Count != 0)
                {
                    if (cb_type_object.Text.Equals("Квартира"))
                    {
                        SqlCommand com1 = new SqlCommand("DELETE FROM [apartment_demands] WHERE Id='" + tb_id.Text + "'", con);
                        com1.ExecuteNonQuery();

                        lblInfo.Visible = true;
                        lblInfo.Text = "Запись " + tb_id.Text + " удалена";
                    }
                    else if (cb_type_object.Text.Equals("Дом"))
                    {
                        SqlCommand com2 = new SqlCommand("DELETE FROM [house_demands] WHERE Id='" + tb_id.Text + "'", con);
                        com2.ExecuteNonQuery();

                        lblInfo.Visible = true;
                        lblInfo.Text = "Запись " + tb_id.Text + " удалена";
                    }
                    else if (cb_type_object.Text.Equals("Земля"))
                    {
                        SqlCommand com3 = new SqlCommand("DELETE FROM [land_demands] WHERE Id='" + tb_id.Text + "'", con);
                        com3.ExecuteNonQuery();

                        lblInfo.Visible = true;
                        lblInfo.Text = "Запись " + tb_id.Text + " удалена";
                    }
                    else
                    {
                        MessageBox.Show("Выберите тип потребности.", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Нельзя удалить потребность, которая участвует в сделке.", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Потребности с таким идентификатором не существует.", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        private void btn_insert_Click(object sender, EventArgs e)//INSERT
        {
            if (cb_Client.SelectedIndex > -1 && cb_Agent.SelectedIndex > -1 && !string.IsNullOrEmpty(comboBox1.Text) && cb_type_object.SelectedIndex > -1)
            {
                con.Open();

                if (cb_type_object.Text.Equals("Квартира")) //insert demand of apartment
                {
                    try
                    {
                        SqlCommand com1 = new SqlCommand(CommandsSql.insert_d_apart(), con);
                        com1.Parameters.AddWithValue("Id", tb_id.Text);
                        com1.Parameters.AddWithValue("Address_City", comboBox1.Text);
                        com1.Parameters.AddWithValue("Address_Street", tbStreet.Text);
                        com1.Parameters.AddWithValue("Address_House", tbHouseN.Text);
                        com1.Parameters.AddWithValue("Address_Number", tb_kv.Text);
                        com1.Parameters.AddWithValue("MinPrice", minPrice.Text);
                        com1.Parameters.AddWithValue("MaxPrice", maxPrice.Text);
                        com1.Parameters.AddWithValue("AgentId", cb_Agent.Text);
                        com1.Parameters.AddWithValue("ClientId", cb_Client.Text);
                        com1.Parameters.AddWithValue("MinArea", tbArea_min.Text);
                        com1.Parameters.AddWithValue("MaxArea", tbArea_max.Text);
                        com1.Parameters.AddWithValue("MinRooms", tbCount_rooms_min.Text);
                        com1.Parameters.AddWithValue("MaxRooms", tbCount_rooms_max.Text);
                        com1.Parameters.AddWithValue("MinFloor", tbFloor_min.Text);
                        com1.Parameters.AddWithValue("MaxFloor", tbFloor_max.Text);

                        com1.ExecuteNonQuery();

                        lblInfo.Visible = true;
                        lblInfo.Text = "Запись " + tb_id.Text + " добавлена";
                    }

                    catch
                    {
                        MessageBox.Show("Невозможно добавить потребность в квартире. Проверьте правильность заполнения полей", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cb_type_object.Text.Equals("Дом"))//insert demand of house
                {
                    try
                    {
                        SqlCommand com2 = new SqlCommand(CommandsSql.insert_d_house(), con);
                        com2.Parameters.AddWithValue("Id", tb_id.Text);
                        com2.Parameters.AddWithValue("Address_City", comboBox1.Text);
                        com2.Parameters.AddWithValue("Address_Street", tbStreet.Text);
                        com2.Parameters.AddWithValue("Address_House", tbHouseN.Text);
                        com2.Parameters.AddWithValue("Address_Number", tb_kv.Text);
                        com2.Parameters.AddWithValue("MinPrice", minPrice.Text);
                        com2.Parameters.AddWithValue("MaxPrice", maxPrice.Text);
                        com2.Parameters.AddWithValue("AgentId", cb_Agent.Text);
                        com2.Parameters.AddWithValue("ClientId", cb_Client.Text);
                        com2.Parameters.AddWithValue("MinFloors", tbFloor_min.Text);
                        com2.Parameters.AddWithValue("MaxFloors", tbFloor_max.Text);
                        com2.Parameters.AddWithValue("MinArea", tbArea_min.Text);
                        com2.Parameters.AddWithValue("MaxArea", tbArea_max.Text);
                        com2.Parameters.AddWithValue("MinRooms", tbCount_rooms_min.Text);
                        com2.Parameters.AddWithValue("MaxRooms", tbCount_rooms_max.Text);

                        com2.ExecuteNonQuery();

                        lblInfo.Visible = true;
                        lblInfo.Text = "Запись " + tb_id.Text + " добавлена";
                    }

                    catch
                    {
                        MessageBox.Show("Невозможно добавить потребность в доме. Проверьте правильность заполнения полей", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cb_type_object.Text.Equals("Земля"))//insert demand of land
                {

                    try
                    {
                        SqlCommand com = new SqlCommand(CommandsSql.insert_d_land(), con);
                        com.Parameters.AddWithValue("Id", tb_id.Text);
                        com.Parameters.AddWithValue("Address_City", comboBox1.Text);
                        com.Parameters.AddWithValue("Address_Street", tbStreet.Text);
                        com.Parameters.AddWithValue("Address_House", tbHouseN.Text);
                        com.Parameters.AddWithValue("Address_Number", tb_kv.Text);
                        com.Parameters.AddWithValue("MinPrice", minPrice.Text);
                        com.Parameters.AddWithValue("MaxPrice", maxPrice.Text);
                        com.Parameters.AddWithValue("AgentId", cb_Agent.Text);
                        com.Parameters.AddWithValue("ClientId", cb_Client.Text);
                        com.Parameters.AddWithValue("MinArea", tbArea_min.Text);
                        com.Parameters.AddWithValue("MaxArea", tbArea_max.Text);

                        com.ExecuteNonQuery();

                        lblInfo.Visible = true;
                        lblInfo.Text = "Запись " + tb_id.Text + " добавлена";
                    }

                    catch
                    {
                        MessageBox.Show("Невозможно добавить потребность в земле. Проверьте правильность заполнения полей", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Выберите тип потребности.", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            con.Close();

        }
        private void btn_upd_Click(object sender, EventArgs e)//UPDATE
        {
            if (cb_Client.SelectedIndex > -1 && cb_Agent.SelectedIndex > -1 && !string.IsNullOrEmpty(comboBox1.Text) && cb_type_object.SelectedIndex > -1)
            {
                con.Open();

                //check id in table
                SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.check_id(tb_id.Text), con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    if (cb_type_object.Text.Equals("Квартира")) //update demands of apartments
                    {
                        try
                        {
                            SqlCommand comm1 = new SqlCommand(CommandsSql.upd_d_apart(), con);
                            comm1.Parameters.AddWithValue("Id", tb_id.Text);
                            comm1.Parameters.AddWithValue("Address_City", comboBox1.Text);
                            comm1.Parameters.AddWithValue("Address_Street", tbStreet.Text);
                            comm1.Parameters.AddWithValue("Address_House", tbHouseN.Text);
                            comm1.Parameters.AddWithValue("Address_Number", tb_kv.Text);
                            comm1.Parameters.AddWithValue("MinPrice", minPrice.Text);
                            comm1.Parameters.AddWithValue("MaxPrice", maxPrice.Text);
                            comm1.Parameters.AddWithValue("AgentId", cb_Agent.Text);
                            comm1.Parameters.AddWithValue("ClientId", cb_Client.Text);
                            comm1.Parameters.AddWithValue("MinArea", tbArea_min.Text);
                            comm1.Parameters.AddWithValue("MaxArea", tbArea_max.Text);
                            comm1.Parameters.AddWithValue("MinRooms", tbCount_rooms_min.Text);
                            comm1.Parameters.AddWithValue("MaxRooms", tbCount_rooms_max.Text);
                            comm1.Parameters.AddWithValue("MinFloor", tbFloor_min.Text);
                            comm1.Parameters.AddWithValue("MaxFloor", tbFloor_max.Text);

                            comm1.ExecuteNonQuery();

                            lblInfo.Visible = true;
                            lblInfo.Text = "Запись " + tb_id.Text + " изменена";
                        }

                        catch
                        {
                            MessageBox.Show("Невозможно изменить потребность в квартире. Проверьте правильность заполнения полей", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (cb_type_object.Text.Equals("Дом"))//update demands of houses
                    {
                        try
                        {
                            SqlCommand comm2 = new SqlCommand(CommandsSql.upd_d_house(), con);
                            comm2.Parameters.AddWithValue("Id", tb_id.Text);
                            comm2.Parameters.AddWithValue("Address_City", comboBox1.Text);
                            comm2.Parameters.AddWithValue("Address_Street", tbStreet.Text);
                            comm2.Parameters.AddWithValue("Address_House", tbHouseN.Text);
                            comm2.Parameters.AddWithValue("Address_Number", tb_kv.Text);
                            comm2.Parameters.AddWithValue("MinPrice", minPrice.Text);
                            comm2.Parameters.AddWithValue("MaxPrice", maxPrice.Text);
                            comm2.Parameters.AddWithValue("AgentId", cb_Agent.Text);
                            comm2.Parameters.AddWithValue("ClientId", cb_Client.Text);
                            comm2.Parameters.AddWithValue("MinFloors", tbFloor_min.Text);
                            comm2.Parameters.AddWithValue("MaxFloors", tbFloor_max.Text);
                            comm2.Parameters.AddWithValue("MinArea", tbArea_min.Text);
                            comm2.Parameters.AddWithValue("MaxArea", tbArea_max.Text);
                            comm2.Parameters.AddWithValue("MinRooms", tbCount_rooms_min.Text);
                            comm2.Parameters.AddWithValue("MaxRooms", tbCount_rooms_max.Text);

                            comm2.ExecuteNonQuery();

                            lblInfo.Visible = true;
                            lblInfo.Text = "Запись " + tb_id.Text + " изменена";
                        }

                        catch
                        {
                            MessageBox.Show("Невозможно изменить потребность в доме. Проверьте правильность заполнения полей", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (cb_type_object.Text.Equals("Земля"))//update demands of lands
                    {

                        try
                        {
                            SqlCommand comm3 = new SqlCommand(CommandsSql.upd_d_land(), con);
                            comm3.Parameters.AddWithValue("Id", tb_id.Text);
                            comm3.Parameters.AddWithValue("Address_City", comboBox1.Text);
                            comm3.Parameters.AddWithValue("Address_Street", tbStreet.Text);
                            comm3.Parameters.AddWithValue("Address_House", tbHouseN.Text);
                            comm3.Parameters.AddWithValue("Address_Number", tb_kv.Text);
                            comm3.Parameters.AddWithValue("MinPrice", minPrice.Text);
                            comm3.Parameters.AddWithValue("MaxPrice", maxPrice.Text);
                            comm3.Parameters.AddWithValue("AgentId", cb_Agent.Text);
                            comm3.Parameters.AddWithValue("ClientId", cb_Client.Text);
                            comm3.Parameters.AddWithValue("MinArea", tbArea_min.Text);
                            comm3.Parameters.AddWithValue("MaxArea", tbArea_max.Text);

                            comm3.ExecuteNonQuery();

                            lblInfo.Visible = true;
                            lblInfo.Text = "Запись " + tb_id.Text + " изменена";
                        }

                        catch
                        {
                            MessageBox.Show("Невозможно изменить потребность в земле. Проверьте правильность заполнения полей", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Выберите тип потребности.", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Потребности с таким идентификатором не существует.", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Поля Тип потребности, Клиент, Агент обязательны для заполнения.", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }



        //KeyPress
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != 8;
        }

        private void minPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void maxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbHouseN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbArea_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbArea_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbFloor_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbFloor_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbCount_rooms_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbCount_rooms_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void movie_form(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
