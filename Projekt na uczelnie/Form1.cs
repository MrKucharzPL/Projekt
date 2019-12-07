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

            SqlDataReader reader;
            SqlConnection connection = new SqlConnection(connString);
            if (connection.State != ConnectionState.Open) connection.Open();

            SqlCommand loginCommand = new SqlCommand(sqlText, connection);
            if (loginCommand.ExecuteScalar() == null) loginInfo.Text = "błąd logowania";
            else
            {
                loginPanel.Visible = false;
                SqlCommand userData = new SqlCommand(sqlText, connection);
                reader = userData.ExecuteReader();

                while (reader.Read())
                {
                    firstNameLabel.Text = reader.GetString(4);
                    surNameLabel.Text = reader.GetString(5);
                    moneyCountLabel.Text = reader.GetValue(3).ToString();
                }

                loggedPanel.Visible = true;
            }

         
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = true;
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
