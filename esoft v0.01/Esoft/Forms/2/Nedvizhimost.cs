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
using System.Collections;

namespace Esoft
{
    public partial class Nedvizhimost : Form
    {
        SqlConnection con = ResourcesConnectSql.GetSringsSql();

        public Nedvizhimost()
        {
            InitializeComponent();
        }


        private void Nedvizhimost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.lands". При необходимости она может быть перемещена или удалена.
            this.landsTableAdapter.Fill(this.homeConnect.lands);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.houses". При необходимости она может быть перемещена или удалена.
            this.housesTableAdapter.Fill(this.homeConnect.houses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.apartments". При необходимости она может быть перемещена или удалена.
            this.apartmentsTableAdapter.Fill(this.homeConnect.apartments);

            panel_find.Visible = false;
            panelSlide.Visible = false;
            panel_dop.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
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

        private void bnt_type_object_Click(object sender, EventArgs e)
        {
            if (cb_type_object.Text.Equals("Квартира"))//Choose apartments
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;

                panelSlide.Visible = true;
                lbl_floor.Visible = true;
                lbl_floor.Text = "Этаж";
                tb_floor.Visible = true;
                lbl_rooms.Visible = true;
                tb_rooms.Visible = true;

                pb_load.Visible = false;
                pb_home.Visible = false;
                lbl_load.Visible = false;

                // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.apartments". При необходимости она может быть перемещена или удалена.
                this.apartmentsTableAdapter.Fill(this.homeConnect.apartments);

            }
            else if (cb_type_object.Text.Equals("Дом"))//Choose houses
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;

                panelSlide.Visible = true;
                lbl_floor.Visible = true;
                lbl_floor.Text = "Этажей";
                tb_floor.Visible = true;
                lbl_rooms.Visible = true;
                tb_rooms.Visible = true;

                pb_load.Visible = false;
                pb_home.Visible = false;
                lbl_load.Visible = false;


                // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.houses". При необходимости она может быть перемещена или удалена.
                this.housesTableAdapter.Fill(this.homeConnect.houses);

            }

            else if (cb_type_object.Text.Equals("Земля"))//Choose lands
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
                dataGridView4.Visible = false;

                panelSlide.Visible = true;
                lbl_floor.Visible = false;
                lbl_floor.Text = "Этажей";
                tb_floor.Visible = false;
                lbl_rooms.Visible = false;
                tb_rooms.Visible = false;

                pb_load.Visible = false;
                pb_home.Visible = false;
                lbl_load.Visible = false;

                // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.lands". При необходимости она может быть перемещена или удалена.
                this.landsTableAdapter.Fill(this.homeConnect.lands);
            }
            else
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;

                pb_load.Visible = true;
                pb_home.Visible = true;
                lbl_load.Visible = true;

                panelSlide.Visible = false;
            }
        }

        private void btn_dop_Click(object sender, EventArgs e)
        {
            if (panel_dop.Visible)
            {
                panel_dop.Visible = false;
            }
            else
            {
                panel_dop.Visible = true;
            }
        }
        private void refresh_grid_Click(object sender, EventArgs e)
        {
            if (cb_type_object.Text.Equals("Квартира"))
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.apartments". При необходимости она может быть перемещена или удалена.
                this.apartmentsTableAdapter.Fill(this.homeConnect.apartments);
            }
            else if (cb_type_object.Text.Equals("Дом"))
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.houses". При необходимости она может быть перемещена или удалена.
                this.housesTableAdapter.Fill(this.homeConnect.houses);
            }
            else if (cb_type_object.Text.Equals("Земля"))
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.lands". При необходимости она может быть перемещена или удалена.
                this.landsTableAdapter.Fill(this.homeConnect.lands);
            }
            else
            {
                MessageBox.Show("Для обновления сначала выберите тип недвижимости", "Info refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)//INSERT
        {
            con.Open();

            try
            {
                if (cb_type_object.Text.Equals("Квартира"))
                {

                    SqlCommand command = new SqlCommand(CommandsSql.InsertApartment(), con);

                    command.Parameters.AddWithValue("Id", tb_id.Text);
                    command.Parameters.AddWithValue("Address_City", tb_city.Text);
                    command.Parameters.AddWithValue("Address_Street", tb_street.Text);
                    command.Parameters.AddWithValue("Address_House", tb_adr_hosuse.Text);
                    command.Parameters.AddWithValue("Address_Number", tb_adr_floor.Text);
                    command.Parameters.AddWithValue("Coordinate_latitude", tb_width.Text);
                    command.Parameters.AddWithValue("Coordinate_longitude", tb_length.Text);
                    command.Parameters.AddWithValue("TotalArea", tb_area.Text);
                    command.Parameters.AddWithValue("Rooms", tb_rooms.Text);
                    command.Parameters.AddWithValue("Floor", tb_floor.Text);

                    if (!string.IsNullOrEmpty(tb_width.Text) || !string.IsNullOrEmpty(tb_width.Text))
                    {
                        if (Convert.ToInt32(tb_width.Text) < -90 || Convert.ToInt32(tb_width.Text) > 90)
                        {
                            MessageBox.Show("Широта может принимать значения от -90 до +90", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Convert.ToInt32(tb_length.Text) < -180 || Convert.ToInt32(tb_length.Text) > 180)
                        {
                            MessageBox.Show("Долгота может принимать значения от -180 до +180", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                    }

                }
                else if (cb_type_object.Text.Equals("Дом"))
                {

                    SqlCommand command = new SqlCommand(CommandsSql.InsertHouses(), con);

                    command.Parameters.AddWithValue("Id", tb_id.Text);
                    command.Parameters.AddWithValue("Address_City", tb_city.Text);
                    command.Parameters.AddWithValue("Address_Street", tb_street.Text);
                    command.Parameters.AddWithValue("Address_House", tb_adr_hosuse.Text);
                    command.Parameters.AddWithValue("Address_Number", tb_adr_floor.Text);
                    command.Parameters.AddWithValue("Coordinate_latitude", tb_width.Text);
                    command.Parameters.AddWithValue("Coordinate_longitude", tb_length.Text);
                    command.Parameters.AddWithValue("TotalArea", tb_area.Text);
                    command.Parameters.AddWithValue("TotalFloors", tb_floor.Text);

                    if (!string.IsNullOrEmpty(tb_width.Text) || !string.IsNullOrEmpty(tb_width.Text))
                    {
                        if (Convert.ToInt32(tb_width.Text) < -90 || Convert.ToInt32(tb_width.Text) > 90)
                        {
                            MessageBox.Show("Широта может принимать значения от -90 до +90", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Convert.ToInt32(tb_length.Text) < -180 || Convert.ToInt32(tb_length.Text) > 180)
                        {
                            MessageBox.Show("Долгота может принимать значения от -180 до +180", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                    }

                }
                else if (cb_type_object.Text.Equals("Земля"))
                {

                    SqlCommand command = new SqlCommand(CommandsSql.InsertLands(), con);

                    command.Parameters.AddWithValue("Id", tb_id.Text);
                    command.Parameters.AddWithValue("Address_City", tb_city.Text);
                    command.Parameters.AddWithValue("Address_Street", tb_street.Text);
                    command.Parameters.AddWithValue("Address_House", tb_adr_hosuse.Text);
                    command.Parameters.AddWithValue("Address_Number", tb_adr_floor.Text);
                    command.Parameters.AddWithValue("Coordinate_latitude", tb_width.Text);
                    command.Parameters.AddWithValue("Coordinate_longitude", tb_length.Text);
                    command.Parameters.AddWithValue("TotalArea", tb_area.Text);

                    if (!string.IsNullOrEmpty(tb_width.Text) || !string.IsNullOrEmpty(tb_width.Text))
                    {
                        if (Convert.ToInt32(tb_width.Text) < -90 || Convert.ToInt32(tb_width.Text) > 90)
                        {
                            MessageBox.Show("Широта может принимать значения от -90 до +90", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Convert.ToInt32(tb_length.Text) < -180 || Convert.ToInt32(tb_length.Text) > 180)
                        {
                            MessageBox.Show("Долгота может принимать значения от -180 до +180", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            
            catch
            {
                MessageBox.Show("Ошибка добавления объекта недвижимости", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)//DELETE
        {
            con.Open();

            if (!string.IsNullOrEmpty(tb_id.Text))
            {
                //to check id in supplies
                SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.check_id_sup(tb_id.Text), con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                        try
                        {
                            if (cb_type_object.Text.Equals("Квартира"))
                            {
                                //to check id in apartment
                                SqlDataAdapter apid = new SqlDataAdapter(CommandsSql.check_id_ap(tb_id.Text), con);
                                DataTable dtap = new DataTable();
                                apid.Fill(dtap);

                                if (dtap.Rows.Count != 0)
                                {
                                    SqlCommand com1 = new SqlCommand("DELETE FROM [apartments] WHERE Id=@Id", con);
                                    com1.Parameters.AddWithValue("Id", tb_id.Text);
                                    com1.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Квартиры с идентификатором " + tb_id.Text + " не существует", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (cb_type_object.Text.Equals("Дом"))
                            {
                                //to check id in houses
                                SqlDataAdapter hoid = new SqlDataAdapter(CommandsSql.check_id_houses(tb_id.Text), con);
                                DataTable dtho = new DataTable();
                                hoid.Fill(dtho);

                                if (dtho.Rows.Count != 0)
                                {

                                    SqlCommand com2 = new SqlCommand("DELETE FROM [houses] WHERE Id=@Id", con);
                                    com2.Parameters.AddWithValue("Id", tb_id.Text);
                                    com2.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Дома с идентификатором " + tb_id.Text + " не существует", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (cb_type_object.Text.Equals("Земля"))
                            {
                                //to check id in lands
                                SqlDataAdapter laid = new SqlDataAdapter(CommandsSql.check_id_lands(tb_id.Text), con);
                                DataTable dtla = new DataTable();
                                laid.Fill(dtla);

                                if (dtla.Rows.Count != 0)
                                {

                                    SqlCommand com3 = new SqlCommand("DELETE FROM [lands] WHERE Id=@Id", con);
                                    com3.Parameters.AddWithValue("Id", tb_id.Text);
                                    com3.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Земельного участка с идентификатором " + tb_id.Text + " не существует", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        catch
                        {
                            MessageBox.Show("Ошибка удаления недвижимости", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    

                }
                else
                {
                    MessageBox.Show("Недвижимость с идентификатором " + tb_id.Text + " связана с предложением!", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Для удаления введите Id недвижимости", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btn_upd_Click(object sender, EventArgs e)//UPDATE
        {
            con.Open();

            if (string.IsNullOrEmpty(tb_id.Text))
            {
                MessageBox.Show("Укажите Id записи, которую хотите изменить", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (cb_type_object.Text.Equals("Квартира"))
                    {
                        //to check id in apartment
                        SqlDataAdapter apid = new SqlDataAdapter(CommandsSql.check_id_ap(tb_id.Text), con);
                        DataTable dtap = new DataTable();
                        apid.Fill(dtap);

                        if (dtap.Rows.Count != 0)
                        {
                            SqlCommand com1 = new SqlCommand(CommandsSql.UpdateApartment(), con);
                            com1.Parameters.AddWithValue("Id", tb_id.Text);
                            com1.Parameters.AddWithValue("Address_City", tb_city.Text);
                            com1.Parameters.AddWithValue("Address_Street", tb_street.Text);
                            com1.Parameters.AddWithValue("Address_House", tb_adr_hosuse.Text);
                            com1.Parameters.AddWithValue("Address_Number", tb_adr_floor.Text);
                            com1.Parameters.AddWithValue("Coordinate_latitude", tb_width.Text);
                            com1.Parameters.AddWithValue("Coordinate_longitude", tb_length.Text);
                            com1.Parameters.AddWithValue("TotalArea", tb_area.Text);
                            com1.Parameters.AddWithValue("Rooms", tb_rooms.Text);
                            com1.Parameters.AddWithValue("Floor", tb_floor.Text);
                            com1.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Квартиры с идентификатором " + tb_id.Text + " не существует", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (cb_type_object.Text.Equals("Дом"))
                    {
                        //to check id in houses
                        SqlDataAdapter hoid = new SqlDataAdapter(CommandsSql.check_id_houses(tb_id.Text), con);
                        DataTable dtho = new DataTable();
                        hoid.Fill(dtho);

                        if (dtho.Rows.Count != 0)
                        {
                            SqlCommand com2 = new SqlCommand(CommandsSql.UpdateHouses(), con);
                            com2.Parameters.AddWithValue("Id", tb_id.Text);
                            com2.Parameters.AddWithValue("Address_City", tb_city.Text);
                            com2.Parameters.AddWithValue("Address_Street", tb_street.Text);
                            com2.Parameters.AddWithValue("Address_House", tb_adr_hosuse.Text);
                            com2.Parameters.AddWithValue("Address_Number", tb_adr_floor.Text);
                            com2.Parameters.AddWithValue("Coordinate_latitude", tb_width.Text);
                            com2.Parameters.AddWithValue("Coordinate_longitude", tb_length.Text);
                            com2.Parameters.AddWithValue("TotalArea", tb_area.Text);
                            com2.Parameters.AddWithValue("TotalFloors", tb_floor.Text);
                            com2.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Дома с идентификатором " + tb_id.Text + " не существует", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (cb_type_object.Text.Equals("Земля"))
                    {
                        //to check id in lands
                        SqlDataAdapter laid = new SqlDataAdapter(CommandsSql.check_id_lands(tb_id.Text), con);
                        DataTable dtla = new DataTable();
                        laid.Fill(dtla);

                        if (dtla.Rows.Count != 0)
                        {
                            SqlCommand com3 = new SqlCommand(CommandsSql.UpdateLands(), con);
                            com3.Parameters.AddWithValue("Id", tb_id.Text);
                            com3.Parameters.AddWithValue("Address_City", tb_city.Text);
                            com3.Parameters.AddWithValue("Address_Street", tb_street.Text);
                            com3.Parameters.AddWithValue("Address_House", tb_adr_hosuse.Text);
                            com3.Parameters.AddWithValue("Address_Number", tb_adr_floor.Text);
                            com3.Parameters.AddWithValue("Coordinate_latitude", tb_width.Text);
                            com3.Parameters.AddWithValue("Coordinate_longitude", tb_length.Text);
                            com3.Parameters.AddWithValue("TotalArea", tb_area.Text);
                            com3.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Земельного участка с идентификатором " + tb_id.Text + " не существует", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Ошибка изменения недвижимости", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            con.Close();
        }

        private void btn_find_object_Click(object sender, EventArgs e)//FIND
        {
            if(string.IsNullOrEmpty(tb_width_find.Text) || string.IsNullOrEmpty(tb_length_find.Text))
            {
                MessageBox.Show("Укажите координаты широты и долготы для поиска недвижимости в области", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Convert.ToInt32(tb_width_find.Text) < -90 || Convert.ToInt32(tb_width_find.Text) > 90)
                {
                    MessageBox.Show("Широта может принимать значения от -90 до +90", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(tb_length_find.Text) < -180 || Convert.ToInt32(tb_length_find.Text) > 180)
                {
                    MessageBox.Show("Долгота может принимать значения от -180 до +180", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.find_obj(tb_width_find.Text, tb_length_find.Text), con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count != 0)
                        {
                            dataGridView4.DataSource = dt;

                            pb_load.Visible = false;
                            pb_home.Visible = false;
                            lbl_load.Visible = false;

                            dataGridView4.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("В заданном диапазоне координат объектов не найдено", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка поиска", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    con.Close();
                }
            }
        }

        private void btn_show_slide_Click(object sender, EventArgs e)
        {
            panelSlide.Visible = false;
            if (panel_find.Visible)
            {
                panel_find.Visible = false;
            }
            else
            {
                panel_find.Visible = true;
            }
            
        }

        private void btn_filter_Click(object sender, EventArgs e)//FILTER
        {
            //clear datagrid
            ArrayList empty = new ArrayList();
            dataGridView4.DataSource = empty;

            pb_load.Visible = false;
            pb_home.Visible = false;
            lbl_load.Visible = false;


            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.filter_objects(),con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView4.DataSource = dt;
            dataGridView4.Visible = true;

            con.Close();
        }

        //digits and letters
        private void tb_area_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }
        private void tb_floor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }
        private void tb_rooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }
        private void tb_adr_hosuse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }
        private void tb_adr_floor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }
        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }
        private void tb_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != 8;
        }
        private void tb_street_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != 8;
        }

        //mouse hover
        private void btn_show_slide_find_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btn_show_slide_find, "Поиск объекта недвижимости по координатам");
        }
        private void btn_filter_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btn_filter, "Фильтрация объектов недвижимости по типу, адресу");
        }
        private void refresh_grid_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(refresh_grid, "Обновить таблицу");
        }
        private void btn_dop_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btn_dop, "Дополнительно");
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Capture = false;
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            panel4.Capture = false;
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
