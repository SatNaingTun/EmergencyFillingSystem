using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace EmergencyFillingSystemClient
{
    
    public partial class LoginForm : Form
    {
        EmergencyDataSetTableAdapters.Tbl_LoginTableAdapter tblLogin = new EmergencyDataSetTableAdapters.Tbl_LoginTableAdapter();
        EmergencyDataSetTableAdapters.Tbl_SessionTableAdapter tblsession = new EmergencyDataSetTableAdapters.Tbl_SessionTableAdapter();
        
        public LoginForm()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.EmergencyConnectionString);
            try
            {

                
                InitializeComponent();
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }
      

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" & txtPassword.Text != "")
            {
                int chkLogin = int.Parse(tblLogin.CheckLogin(txtUserName.Text, txtPassword.Text).ToString());
                if (chkLogin == 1)
                {
                    this.Hide();
                    
                   // EntryForm entryform = new EntryForm();
                    //entryform.setText(txtUserName.Text);
                   
                    //entryform.Show();
                   tblsession.InsertLogin(txtUserName.Text, DateTime.Now);
                   // ssid=tblsession.Insert(txtUserName.Text, DateTime.Now, DateTime.Now);
                    
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Incorrect User Name and Password, please Try again!!", "Login");
                }
            }
            else
            {
                MessageBox.Show("Enter User Name and Password in TextBox", "Login");
            }
        }
    }
}
