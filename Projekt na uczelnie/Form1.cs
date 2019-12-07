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

namespace Projekt_na_uczelnie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginText.Text;
            string password = passwordText.Text;
            string sqlText = "SELECT * FROM Users WHERE(Login = '" + login + "' AND Password = '" + password + "')";
            string connString = Properties.Settings.Default.conn;

            SqlConnection connection = new SqlConnection(connString);
            if (connection.State != ConnectionState.Open) connection.Open();

            SqlCommand loginCommand = new SqlCommand(sqlText, connection);
            if (loginCommand.ExecuteScalar() == null) loginInfo.Text = "błąd logowania";
            else loginInfo.Text = "zalogowano";

         
        }

        private void loginText_TextChanged(object sender, EventArgs e)
        {

        }






        //bool fullScreenState = false;

        //private void FullScreen_Button(object sender, EventArgs e)
        //{

        //    if(fullScreenState == false)
        //    {
        //        FormBorderStyle = FormBorderStyle.None;
        //        WindowState = FormWindowState.Maximized;
        //        TopMost = true;
        //        fullScreenState = true;
        //    }
        //    else
        //    {
        //        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        //        WindowState = FormWindowState.Normal;
        //        TopMost = false;
        //        fullScreenState = false;
        //    }

        //}
    }
}
