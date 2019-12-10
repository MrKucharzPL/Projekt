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
            connection.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = true;
            Label[] errors = { eMessage0, eMessage1, eMessage2, eMessage3, eMessage4, eMessage5 };

            foreach (Label error in errors)
            {
                error.Visible = false;
            }
        }

        private void rRegisterBtn_Click(object sender, EventArgs e)
        {
            bool isGood = true;
            string login = rLoginTxt.Text;
            string password = rPasswordTxt.Text;
            string rePassword = rRePasswordTxt.Text;
            string email = rEmailTxt.Text;
            string firstName = rFirstNameTxt.Text;
            string surName = rSurNameTxt.Text;
            string sqlText = "INSERT INTO Users(Login,Password,FirstName,SurName,Email)" +
                " VALUES('"+ login + "','" + password + "','"+ firstName + "', '"+ surName +"','"+ email +"')";
            string connString = Properties.Settings.Default.conn;
            Label[] errors = { eMessage0, eMessage1, eMessage2, eMessage3, eMessage4, eMessage5 };
            
            foreach(Label error in errors)
            {
                error.Visible = false;
            }

            if (String.IsNullOrEmpty(login) && login.Length < 4) errors[0].Visible = true; isGood = false;
            if (String.IsNullOrEmpty(password) || password.Length < 8) errors[1].Visible = true; isGood = false;
            if (String.IsNullOrEmpty(rePassword) || rePassword.Length < 8 || rePassword !=password) errors[2].Visible = true; isGood = false;
            if (String.IsNullOrEmpty(email)) errors[3].Visible = true; isGood = false;
            if (String.IsNullOrEmpty(firstName)) errors[4].Visible = true; isGood = false;
            if (String.IsNullOrEmpty(surName)) errors[5].Visible = true; isGood = false;

            if(isGood == true)
            {
                SqlConnection connection = new SqlConnection(connString);

                //SqlCommand registerData = new SqlCommand(sqlText, connection);
                SqlCommand registerData = new SqlCommand("sp_insert", connection);
                registerData.CommandType = CommandType.StoredProcedure;
                registerData.Parameters.AddWithValue("@Login", login);
                registerData.Parameters.AddWithValue("@Password", password);
                registerData.Parameters.AddWithValue("@Email", email);
                registerData.Parameters.AddWithValue("@FirstName", firstName);
                registerData.Parameters.AddWithValue("@SurName", surName);
                if (connection.State != ConnectionState.Open) connection.Open();
                int i = registerData.ExecuteNonQuery();
                connection.Close();
                if(i != 0)
                {
                    //no to elo
                }
            }
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
