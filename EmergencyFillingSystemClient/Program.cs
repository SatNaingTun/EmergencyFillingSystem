using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmergencyFillingSystemClient
{   
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm fLogin = new LoginForm();
           

            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                fLogin.Close();
                EntryForm entryform = new EntryForm();
                entryform.setText(fLogin.txtUserName.Text);
                Application.Run(entryform);
            }
            else
            {
                Application.Exit();
            }
            
            //Application.Run(new EntryForm());
        }
    }
}
