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
    public partial class Deals : Form
    {
        SqlConnection con = ResourcesConnectSql.GetSringsSql();

        public Deals()
        {
            InitializeComponent();

            dataGridView1.Columns[1].Width = 120;
        }

        private void Deals_Load(object sender, EventArgs e)
        {
            con.Open();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.agents". При необходимости она может быть перемещена или удалена.
            this.agentsTableAdapter.Fill(this.homeConnect.agents);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.deals". При необходимости она может быть перемещена или удалена.
            this.dealsTableAdapter.Fill(this.homeConnect.deals);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeConnect.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.homeConnect.supplies);
            cb_supplies.SelectedIndex = -1;
            cb_type_client.SelectedIndex = -1;

            SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.select_id_demands(), con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cb_demands.DataSource = dt;
            cb_demands.DisplayMember = "Id";
            cb_demands.ValueMember = "Id";
            cb_demands.SelectedIndex = -1;


            con.Close();

        }

        private void refresh_grid_Click(object sender, EventArgs e)
        {
            this.dealsTableAdapter.Fill(this.homeConnect.deals);
        }

        private void btn_show_deal_Click(object sender, EventArgs e)
        {
            panel_deal_totalSum.Visible = false;
            panelDeduction.Visible = false;
            

            if (panelDeal.Visible)
            {
                panelDeal.Visible = false;
            }
            else { panelDeal.Visible = true; }
            if (pc_logo.Visible) { pc_logo.Visible = false; } else { pc_logo.Visible = true; }
        }

        private void btn_deduction_Click(object sender, EventArgs e)
        {
            if (pc_logo.Visible) { pc_logo.Visible = false; } else { pc_logo.Visible = true; }

            panel_deal_totalSum.Visible = false;
            panelDeal.Visible = false;

            if (panelDeduction.Visible)
            {
                panelDeduction.Visible = false;
            }
            else { panelDeduction.Visible = true; }


            label9.Visible = false;
            lblSum.Visible = false;
            label8.Visible = false;
            cb_type_object_com.Visible = false;
            button1.Visible = false;
            cb_type_client.SelectedIndex = -1;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            var m2 = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m2);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            panel4.Capture = false;
            var m2 = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m2);
        }

        private void btn_insert_Click(object sender, EventArgs e)//INSERT
        {
            con.Open();

            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Supply_Id FROM deals Where Id = '"+cb_supplies.Text+"'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Demand_Id FROM deals Where Id = '" + cb_demands.Text + "'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            try
            {
                if (dt1.Rows.Count == 0 && dt2.Rows.Count == 0)
                {
                    SqlCommand com = new SqlCommand("INSERT INTO [deals] (Id, Demand_Id, Supply_Id) VALUES(@Id,@Demand_Id, @Supply_Id)", con);
                    com.Parameters.AddWithValue("Id", tb_id.Text);
                    com.Parameters.AddWithValue("Demand_Id", cb_demands.Text);
                    com.Parameters.AddWithValue("Supply_Id", cb_supplies.Text);

                    com.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Предложение или потребность, которые уже учавствуют в сделке, не могут быть выбраны повторно",
                        "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {
                MessageBox.Show("Ошибка добавления", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_upd_Click(object sender, EventArgs e)//UPDATE
        {
            con.Open();
            if(!string.IsNullOrEmpty(tb_id.Text))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM deals WHERE Id= '" + tb_id.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    SqlCommand com = new SqlCommand("UPDATE deals SET Id=@id, Demand_Id=@Demand_Id, Supply_Id=@Supply_Id WHERE Id=@Id", con);
                    com.Parameters.AddWithValue("Id", tb_id.Text);
                    com.Parameters.AddWithValue("Demand_Id", cb_demands.Text);
                    com.Parameters.AddWithValue("Supply_Id", cb_supplies.Text);

                    com.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Сделка с идентификатором " + tb_id.Text + " не найдена ", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Введите Id сделки, которую хотите изменить", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)//DELETE
        {
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM deals WHERE Id= '" + tb_id.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count != 0)
            {
                SqlCommand com = new SqlCommand("DELETE FROM deals WHERE Id= '" + tb_id.Text + "'", con);
                com.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Сделка с идентификатором "+tb_id.Text+" не найдена ","Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)//Summa
        {
            con.Open();

            if(!string.IsNullOrEmpty(tb_id_com.Text))
            {
                if (!string.IsNullOrEmpty(cb_type_client.Text))
                {
                    if (cb_type_client.Text.Equals("продавец"))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(CommandsSql.check_id_demands(tb_id_com.Text), con);//check id demands(3)
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if(dt.Rows.Count !=0)
                        {
                            if (cb_type_object_com.Text.Equals("Квартира"))
                            {
                                try
                                {
                                    SqlCommand command = new SqlCommand("SELECT Price * 0.01 + 36000 as Comissya, ClientId FROM supplies WHERE ClientId=@ClientId", con);
                                    command.Parameters.AddWithValue("ClientId", tb_id_com.Text);
                                    SqlDataReader s = command.ExecuteReader();
                                    s.Read();
                                    lblSum.Text = s[0].ToString();
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка поиска", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (cb_type_object_com.Text.Equals("Дом"))
                            {
                                try
                                {
                                    SqlCommand command = new SqlCommand("SELECT Price * 0.02 + 30000 as Comissya, ClientId FROM supplies WHERE ClientId=@ClientId", con);
                                    command.Parameters.AddWithValue("ClientId", tb_id_com.Text);
                                    SqlDataReader s = command.ExecuteReader();
                                    s.Read();
                                    lblSum.Text = s[0].ToString();
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка поиска", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (cb_type_object_com.Text.Equals("Земля"))
                            {
                                try
                                {
                                    SqlCommand command = new SqlCommand("SELECT Price * 0.01 + 30000 as Comissya, ClientId FROM supplies WHERE ClientId=@ClientId", con);
                                    command.Parameters.AddWithValue("ClientId", tb_id_com.Text);
                                    SqlDataReader s = command.ExecuteReader();
                                    s.Read();
                                    lblSum.Text = s[0].ToString();
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка поиска", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ошибка поиска", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Продавца с идентификатором " + tb_id_com.Text + " не найдено", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (cb_type_client.Text.Equals("покупатель"))
                    {
                        //check id client in supplies
                        SqlDataAdapter sda = new SqlDataAdapter("Select ClientId FROM supplies Where ClientId='" + tb_id_com.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count != 0)
                        {
                            try
                            {
                                SqlCommand command = new SqlCommand("SELECT Price * 0.03 as Comissya, ClientId FROM supplies WHERE ClientId=@ClientId", con);
                                command.Parameters.AddWithValue("ClientId", tb_id_com.Text);
                                SqlDataReader s = command.ExecuteReader();
                                s.Read();
                                lblSum.Text = s[0].ToString();
                            }
                            catch
                            {
                                MessageBox.Show("Ошибка поиска", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Клиент с идентификатором " + tb_id_com.Text + " не является покупателем", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Укажите кем является клиент", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Укажите Id", "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void bnt_type_object_Click(object sender, EventArgs e)
        {
            if (cb_type_client.Text.Equals("продавец"))
            {
                label9.Visible = true;
                lblSum.Visible = true;
                label8.Visible = true;
                cb_type_object_com.Visible = true;
                button1.Visible = true;
            }
            else if(cb_type_client.Text.Equals("покупатель"))
            {
                label9.Visible = false;
                lblSum.Visible = true;
                label8.Visible = true;
                cb_type_object_com.Visible = false;
                button1.Visible = true;
            }
            else
            {
                label9.Visible = false;
                lblSum.Visible = false;
                label8.Visible = false;
                cb_type_object_com.Visible = false;
                button1.Visible = false;
            }
        }

        private void btn_deal_totalSum_Click(object sender, EventArgs e)
        {
            if (pc_logo.Visible) { pc_logo.Visible = false; } else { pc_logo.Visible = true; }

            panelDeduction.Visible = false;
            panelDeal.Visible = false;

            if(panel_deal_totalSum.Visible)
            {
                panel_deal_totalSum.Visible = false;
            }
            else
            {
                panel_deal_totalSum.Visible = true;
            }
        }

        private void btn_sumTotal_Click(object sender, EventArgs e)
        {
            con.Open();

            if(!string.IsNullOrEmpty(tb_idDeal_total.Text))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM deals WHERE Id='"+tb_idDeal_total.Text+"'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count != 0)
                {
                    //***main***

                    //for raltor of customer
                    SqlCommand com1 = new SqlCommand("SELECT Price * 0.03, ClientId FROM supplies WHERE Id='" + tb_idDeal_total.Text + "'", con);
                    SqlDataReader r = com1.ExecuteReader();
                    r.Read();
                    lbl_clUp_sum.Text = r[0].ToString();
                    r.Close();

                    SqlDataAdapter sda1 = new SqlDataAdapter("select DealShare from agents", con);//if realtor have %
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    if (dt1.Rows.Count != 0)
                    {
                        //for raltor of customer
                        SqlCommand comR = new SqlCommand(CommandsSql.cRb(tb_idDeal_total.Text) , con);
                        SqlDataReader rR = comR.ExecuteReader();
                        rR.Read();
                        lbl_r_ClUp.Text = rR[0].ToString();
                        rR.Close();

                        //for raltor of saller
                        SqlCommand comRd = new SqlCommand("SELECT Price * 0.03, ClientId FROM supplies WHERE Id='" + tb_idDeal_total.Text + "'", con);
                        SqlDataReader rRd = comRd.ExecuteReader();
                        rRd.Read();
                        rRd.Close();

                        //for company
                        SqlCommand company = new SqlCommand(CommandsSql.company(tb_idDeal_total.Text), con);
                        SqlDataReader rCompany = company.ExecuteReader();
                        rCompany.Read();
                        lbl_company_sum.Text = rCompany[1].ToString();
                        rCompany.Close();

                    }
                    else//commission of realtor have 45%
                    {
                        //check id object
                        SqlDataAdapter checksda = new SqlDataAdapter(CommandsSql.check_id(tb_idDeal_total.Text), con);
                        DataTable dtacheck = new DataTable();
                        checksda.Fill(dtacheck);

                        if(dtacheck.Rows.Count > 0 )
                        {
                            //know type object
                            SqlDataAdapter checkAp = new SqlDataAdapter("SELECT Id FROM appartment_demands WHERE Id = '" + tb_idDeal_total.Text + "'", con);
                            SqlDataAdapter checkHo = new SqlDataAdapter("SELECT Id FROM house_demands WHERE Id = '" + tb_idDeal_total.Text + "'", con);
                            SqlDataAdapter checkLa = new SqlDataAdapter("SELECT Id FROM land_demands WHERE Id = '" + tb_idDeal_total.Text + "'", con);
                            DataTable dtAp = new DataTable();
                            DataTable dtHo = new DataTable();
                            DataTable dtLa = new DataTable();
                            checkAp.Fill(dtAp);
                            checkAp.Fill(dtHo);
                            checkAp.Fill(dtLa);

                            //appartment %
                            if (dtAp.Rows.Count >0)
                            {
                                //для клиента
                                SqlCommand comAp = new SqlCommand(CommandsSql.cmsNullbuyer_ap(tb_idDeal_total.Text), con);
                                SqlDataReader rAp = comAp.ExecuteReader();
                                rAp.Read();
                                lbl_clDown_sum.Text = rAp[0].ToString();
                                lbl_r_ClDown.Text = rAp[1].ToString();

                                //для риелтора клиента-продавца
                                SqlCommand comR = new SqlCommand(CommandsSql.cmsNull1(tb_idDeal_total.Text), con);
                                SqlDataReader rR = comR.ExecuteReader();
                                rR.Read();
                                lbl_r_ClUp.Text = rR[0].ToString();
                                rR.Close();

                            }
                            //house %
                            else if (dtHo.Rows.Count > 0)
                            {
                                //for client
                                SqlCommand comHo = new SqlCommand(CommandsSql.cmsNullbuyer_ho(tb_idDeal_total.Text), con);
                                SqlDataReader rHo = comHo.ExecuteReader();
                                rHo.Read();
                                lbl_clDown_sum.Text = rHo[0].ToString();
                                lbl_r_ClDown.Text = rHo[1].ToString();

                                //for raltor of saller
                                SqlCommand comR = new SqlCommand(CommandsSql.cmsNull2(tb_idDeal_total.Text), con);
                                SqlDataReader rR = comR.ExecuteReader();
                                rR.Read();
                                lbl_r_ClUp.Text = rR[0].ToString();
                                
                                rHo.Close();
                            }
                            //land %
                            else if (dtHo.Rows.Count > 0) 
                            {
                                //for client
                                SqlCommand comLa = new SqlCommand(CommandsSql.cmsNullbuyer_la(tb_idDeal_total.Text), con);
                                SqlDataReader rLa = comLa.ExecuteReader();
                                rLa.Read();
                                lbl_clDown_sum.Text = rLa[0].ToString();
                                lbl_r_ClDown.Text = rLa[1].ToString();

                                //for raltor of saller
                                SqlCommand comR = new SqlCommand(CommandsSql.cmsNull3(tb_idDeal_total.Text), con);
                                SqlDataReader rR = comR.ExecuteReader();
                                rR.Read();
                                lbl_r_ClUp.Text = rR[0].ToString();

                                rLa.Close();
                            }
                            else
                            {
                                lbl_clDown_sum.Text = "Недвижимости не существует.";
                                lbl_r_ClDown.Text = "Недвижимости не существует.";
                            }
                        }
                        else
                        {
                            lbl_clDown_sum.Text = "Недвижимость не учавствует в сделке.";
                            lbl_r_ClDown.Text = "Недвижимость не учавствует в сделке.";
                        }

                        //for company
                        SqlCommand company = new SqlCommand(CommandsSql.company_null_rieltor(tb_idDeal_total.Text), con);
                        SqlDataReader rCompany = company.ExecuteReader();
                        rCompany.Read();
                        lbl_company_sum.Text = rCompany[1].ToString();
                        rCompany.Close();

                    }

                }
                else
                {
                    MessageBox.Show("Сделки с идентификатором "+tb_idDeal_total.Text+" не существует", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите Id сделки", "Error find", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
}
