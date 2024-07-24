using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace EmergencyFillingSystemClient
{
    public partial class EntryForm : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.EmergencyConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        double paidamount,Resultb;
        EmergencyDataSetTableAdapters.Tbl_FuelPriceTableAdapter tblfuelprice = new EmergencyDataSetTableAdapters.Tbl_FuelPriceTableAdapter();
        EmergencyDataSetTableAdapters.Hose_DeliveryDetailTableAdapter tblDeliveryDetail = new EmergencyDataSetTableAdapters.Hose_DeliveryDetailTableAdapter();
        EmergencyDataSetTableAdapters.Tbl_SessionTableAdapter tblsession = new EmergencyDataSetTableAdapters.Tbl_SessionTableAdapter();
        EmergencyDataSetTableAdapters.Tbl_CompanyTableAdapter tblcompany = new EmergencyDataSetTableAdapters.Tbl_CompanyTableAdapter(); 
        string fueltype;
        int sid,hdid;
        string companyname, caddress;
        string[] ph={"","","","",""};
        string[] data = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
        string sqlFormattedDate;
        public EntryForm()
        {
            InitializeComponent();
        }
        /*
        public EntryForm(int txt)
        {
            InitializeComponent();
           sid = txt;
        }*/
        private void companyprofile()
        {
            if (tblcompany.SelectCompanyName() != null)
            {
                companyname = tblcompany.SelectCompanyName().ToString();
            }
            if (tblcompany.SelectCompanyAddress() != null)
            {
                caddress = tblcompany.SelectCompanyAddress().ToString();
            }
            phone();
            /*
            if (tblcompany.SelectPhone1() != null)
            {
                phone1 = tblcompany.SelectPhone1().ToString();
            }
            if (tblcompany.SelectPhone2() != null)
            {
                phone2 = tblcompany.SelectPhone2().ToString();
            }*/
           
        }
        private void EntryForm_Load(object sender, EventArgs e)
        {
            sid = Convert.ToInt32(tblsession.SID());
            companyprofile();
            hdid = Convert.ToInt32(tblDeliveryDetail.SID());

            //displayidr(sid.ToString());
           
            // TODO: This line of code loads data into the 'emergencyDataSet.Tbl_FuelPrice' table. You can move, or remove it, as needed.
            //this.tbl_FuelPriceTableAdapter.Fill(this.emergencyDataSet.Tbl_FuelPrice);
            string query = "select * from Tbl_FuelPrice";
            displayDTG(query);
            // TODO: This line of code loads data into the 'emergencyDataSet.Tbl_FuelPrice' table. You can move, or remove it, as needed.
           // this.tbl_FuelPriceTableAdapter.Fill(this.emergencyDataSet.Tbl_FuelPrice);
         comboBox1.DataSource = dt;
          fuelprice.Text = tblfuelprice.FuelPrice(comboBox1.Text).ToString();
          saletype.SelectedIndex = 0;
          
        }
        public void setText(string txt) { UserName.Text = txt; }
        private void phone()
        {
            for (int i = 1; i <= 4; i++)
            {
                string query = "select Phone"+i + " from Tbl_Company";

                try
                {
                    //opening connection
                    conn.Open();


                    //initialize a new instance of sqlcommand
                    cmd = new SqlCommand();
                    //set a connection used by this instance of sqlcommand
                    cmd.Connection = conn;
                    //set the sql statement to execute at the data source
                    cmd.CommandText = query;
                    //initialize a new instance of sqlDataAdapter
                    da = new SqlDataAdapter();
                    //set the sql statement or stored procedure to execute at the data source
                    da.SelectCommand = cmd;
                    //initialize a new instance of DataTable
                    dt = new DataTable();
                    //add or resfresh rows in the certain range in the datatable to match those in the data source.
                    ph[i] = (string)cmd.ExecuteScalar();

                    //add the data source to display the data in the ListView



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                da.Dispose();
                conn.Close();
            }
        }
        private void displayDTG(string query)
        {
            try
            {
                //opening connection
                conn.Open();


                //initialize a new instance of sqlcommand
                cmd = new SqlCommand();
                //set a connection used by this instance of sqlcommand
                cmd.Connection = conn;
                //set the sql statement to execute at the data source
                cmd.CommandText = query;
                //initialize a new instance of sqlDataAdapter
                da = new SqlDataAdapter();
                //set the sql statement or stored procedure to execute at the data source
                da.SelectCommand = cmd;
                //initialize a new instance of DataTable
                dt = new DataTable();
                //add or resfresh rows in the certain range in the datatable to match those in the data source.
                da.Fill(dt);

                //add the data source to display the data in the ListView



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            da.Dispose();
            conn.Close();
        }
        private void displayid(string query, string sth)
        {
            try
            {
                //opening connection
                conn.Open();


                //initialize a new instance of sqlcommand
                cmd = new SqlCommand();
                //set a connection used by this instance of sqlcommand
                cmd.Connection = conn;
                //set the sql statement to execute at the data source
                cmd.CommandText = query;
                //initialize a new instance of sqlDataAdapter
                cmd.Parameters.AddWithValue("@sth", sth);
                da = new SqlDataAdapter();
                //set the sql statement or stored procedure to execute at the data source
                da.SelectCommand = cmd;
                //initialize a new instance of DataTable
                dt = new DataTable();
                //add or resfresh rows in the certain range in the datatable to match those in the data source.
                da.Fill(dt);

                //add the data source to display the data in the ListView



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            da.Dispose();
            conn.Close();
        }
       
        private void insertDelivery(string saletype)
        {
            DateTime myDateTime = DateTime.Now;
            sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            //string query = "INSERT INTO [dbo].[Hose_DeliveryDetail] ([CarNo], [FuelType], [FillType], [SaleType], [CustomerID], [SessionID], [Date_Time], [DeliveryVolume], [PaidAmount], [DiscountAmount], [NetAmount], [CompanyID]) VALUES ("+vehicletxt.Text+","+comboBox1.Text+","+"0, 0,NULL, 1,"+myDateTime+","+totallitre.Text+","+Resulta.ToString()+","+Discount.Text+","+TxtResult.Text+", 1)";
            string query = "INSERT INTO [dbo].[Hose_DeliveryDetail] ([CarNo], [FuelType],[FuelPrice], [FillType], [SaleType], [CustomerID], [SessionID], [Date_Time], [DeliveryVolume], [PaidAmount], [DiscountAmount], [NetAmount], [CompanyID]) VALUES (@CarNo, @FuelType,@FuelPrice, @FillType, @SaleType, @CustomerID, @SessionID, @Date_Time, @DeliveryVolume, @PaidAmount, @DiscountAmount, @NetAmount, @CompanyID)";
            //tblDeliveryDetail.Insert(vehicletxt.Text, fueltype, 0, 0, null, 1, myDateTime, Convert.ToDouble(totallitre.Text), Resulta, Convert.ToDouble(Discount.Text), Convert.ToDouble(Result.Text), 1);
            try
            {
                //opening connection
                conn.Open();


                //initialize a new instance of sqlcommand
                cmd = new SqlCommand();
                //set a connection used by this instance of sqlcommand
                cmd.Connection = conn;
                //set the sql statement to execute at the data source
                cmd.CommandText = query;
                //initialize a new instance of sqlDataAdapter
                da = new SqlDataAdapter();
                //set the sql statement or stored procedure to execute at the data source
                da.SelectCommand = cmd;
                //initialize a new instance of DataTable
                cmd.Parameters.AddWithValue("@CarNo", vehicletxt.Text);
                cmd.Parameters.AddWithValue("@FuelType", comboBox1.Text);
                cmd.Parameters.AddWithValue("@FuelPrice", fuelprice.Text);
                cmd.Parameters.AddWithValue("@FillType", "0");
                cmd.Parameters.AddWithValue("@SaleType", saletype);
                cmd.Parameters.AddWithValue("@SessionID", sid.ToString());
                cmd.Parameters.AddWithValue("@CustomerID", "0");
                cmd.Parameters.AddWithValue("@Date_Time", sqlFormattedDate);
                cmd.Parameters.AddWithValue("@DeliveryVolume", totallitre.Text);
                cmd.Parameters.AddWithValue("@PaidAmount", paidamount);
                cmd.Parameters.AddWithValue("@DiscountAmount", Discount.Text);
                cmd.Parameters.AddWithValue("@NetAmount", Resultb);
                cmd.Parameters.AddWithValue("@CompanyID", "1");
                dt = new DataTable();
                //add or resfresh rows in the certain range in the datatable to match those in the data source.
                da.Fill(dt);
               // cmd.ExecuteNonQuery();
                MessageBox.Show("Data is saved");
                //add the data source to display the data in the ListView



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            da.Dispose();
            conn.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Receipts", 400, 900);
            Margins margins = new Margins(100, 100, 100, 100);
            printDocument1.DefaultPageSettings.Margins = margins;
            DateTime myDateTime = DateTime.Now;
            getFuelPrice();
            calculate();
            if (saletype.SelectedIndex == 0)
            {
                insertDelivery(saletype.SelectedIndex.ToString());
                printDocument1.Print();
            }
            else if (saletype.SelectedIndex == 1) {
                paidamount = 0;
                Discount.Text = "0";
                insertDelivery(saletype.SelectedIndex.ToString());
                printDocument1.Print();
            }
           //tblDeliveryDetail.InsertQuery(vehicletxt.Text, fueltype, 0, 0, null, 1, myDateTime, Convert.ToDouble(totallitre.Text), Resulta, Convert.ToDouble(Discount.Text), Convert.ToDouble(Result.Text), 1);
           
        }
        private void getFuelPrice()
        {
            
             fuelprice.Text = tblfuelprice.FuelPrice(comboBox1.Text).ToString();

             fueltype = comboBox1.Text;
        }
        private void calculate() {

            paidamount = (Convert.ToDouble(fuelprice.Text) *Convert.ToDouble(totallitre.Text));
            //Resulta = Resulta - float.Parse(Discount.Text);
            Resultb = paidamount - Convert.ToDouble(Discount.Text);
            TxtResult.Text = Resultb.ToString();
        
        }

        private void totallitre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter  )
            {
                
                calculate();
            }
           

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            getFuelPrice();
          
        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tblsession.UpdateLogout(DateTime.Now, sid);
                    
                    //MessageBox.Show("Logout");
                    //logout();
                    Environment.Exit(0);
                    
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
            //if (string.Equals((sender as Button).Name, @"CloseButton")) { tblsession.Logout(DateTime.Now, ssid);  }
        }
        private void logout() {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            //string query = "INSERT INTO [dbo].[Hose_DeliveryDetail] ([CarNo], [FuelType], [FillType], [SaleType], [CustomerID], [SessionID], [Date_Time], [DeliveryVolume], [PaidAmount], [DiscountAmount], [NetAmount], [CompanyID]) VALUES ("+vehicletxt.Text+","+comboBox1.Text+","+"0, 0,NULL, 1,"+myDateTime+","+totallitre.Text+","+Resulta.ToString()+","+Discount.Text+","+TxtResult.Text+", 1)";
            string query = "UPDATE [Tbl_Session] SET [logoutdatetime] = @logoutdatetime WHERE [SessionID] = @SessionID ";
            //tblDeliveryDetail.Insert(vehicletxt.Text, fueltype, 0, 0, null, 1, myDateTime, Convert.ToDouble(totallitre.Text), Resulta, Convert.ToDouble(Discount.Text), Convert.ToDouble(Result.Text), 1);
            try
            {
                //opening connection
                conn.Open();


                //initialize a new instance of sqlcommand
                cmd = new SqlCommand();
                //set a connection used by this instance of sqlcommand
                cmd.Connection = conn;
                //set the sql statement to execute at the data source
                cmd.CommandText = query;
                //initialize a new instance of sqlDataAdapter
                da = new SqlDataAdapter();
                //set the sql statement or stored procedure to execute at the data source
                
                //initialize a new instance of DataTable
                cmd.Parameters.AddWithValue("@logoutdatetime", sqlFormattedDate);
                cmd.Parameters.AddWithValue("@SessionID", sid.ToString());
                da.SelectCommand = cmd;
                dt = new DataTable();
                //add or resfresh rows in the certain range in the datatable to match those in the data source.
                //da.Fill(dt);
                 cmd.ExecuteNonQuery();
                MessageBox.Show("Data is saved");
                //add the data source to display the data in the ListView



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            da.Dispose();
            conn.Close();
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {  
            Graphics graphics = e.Graphics;
            e.PageSettings.Margins.Left = 10;
            e.PageSettings.Margins.Right = 25;
            e.PageSettings.Landscape = false;
            Font Hfont = new Font("Arial", 14);
            Font font = new Font("Arial", 10);
            var brush = new SolidBrush(Color.Black);
            float fontHeight = font.GetHeight();
            int startX = 5;
            int startY = 35;
            int Offset = 40;
            int xoffset = startX;
            string voc = "S" + sid.ToString() + "-"+DateTime.Now.ToShortDateString()+ "-"+hdid;
            graphics.DrawString("             "+companyname+"              ", Hfont, brush, startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("             "+caddress+"         ", font, brush, startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("             Phone:" +"       ", font, brush, startX, startY + Offset);
            for (int i = 1; i <= 4; i++)
            {
                
                graphics.DrawString("                          " + ph[i] + ",       ", font, brush, startX+xoffset, startY + Offset);
                xoffset = xoffset + 90;
                if (startX + xoffset > e.PageBounds.Y) { Offset = Offset + 20; xoffset = startX; }
            }
            Offset = Offset + 20;
            /*
            graphics.DrawString("                  \t" + phone1 + "," + phone2 + "         ", font, brush, startX, startY + Offset);
            Offset = Offset + 20;
             */
            string linea3 = string.Format(" Date: {0}", DateTime.Now.ToString());
            graphics.DrawString(linea3, font, brush, startX, startY + Offset);
            Offset = Offset + 20;
            string linea2 = string.Format(" Car No: {0}",vehicletxt.Text);
            graphics.DrawString(linea2, font, brush, startX, startY + Offset);
            Offset = Offset + 20;
            string linea4 = string.Format("VouncherNo: {0}", voc);
            graphics.DrawString(linea4, font, brush, startX, startY + Offset);
            Offset = Offset + 20;
            string linea5 = string.Format("Cashier: {0}", UserName.Text);
            graphics.DrawString(linea5, font, brush, startX, startY + Offset);
            Offset = Offset + 20;
            string linea6 = string.Format(saletype.Text);
            graphics.DrawString(linea6, font, brush, startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("FuelType" + "\t" + "Price" + "\t" + "Liter" + "\t" + "Amount", font, brush, startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(comboBox1.Text + "\t" + fuelprice.Text + "\t" + totallitre.Text + "\t" + paidamount, font, brush, startX, startY + Offset);
            Offset = Offset + 20;
            if (Convert.ToInt16(Discount.Text) > 0)
            {
                graphics.DrawString("Discount" + "\t" + Discount.Text + "\t" + "NetAmt" + "\t" + Resultb, font, brush, startX, startY + Offset);
                Offset = Offset + 20;
            }
        }
      
      
       

        
    }
}
