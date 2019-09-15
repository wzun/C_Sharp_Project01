﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mybikes.client
{
    public partial class Login : Form
    {
        //initialization
        static string txtFilePath = @"../../data/textLogin.txt";
        const int MAX = 2;
        Login[] loginArray = new Login[MAX];
        private string UserName;
        private string UserPassword;

        public Login()
        {
            InitializeComponent();
        }
        //button login
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string userPassword = textBoxUserPassword.Text;

            bool error = false;

            //reading login text file 
            if (File.Exists(txtFilePath))
            {
                StreamReader reader = new StreamReader(txtFilePath);

                String line = null;
                for (int i = 0; i < loginArray.Length && ((line = reader.ReadLine()) != null); i++)
                {
                    Login element = new Login();
                    String[] tokens = line.Split('|');
                    element.UserName = tokens[0];
                    element.UserPassword = tokens[1];
                    loginArray[i] = element;
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Login File NOT FOUND");
            }

            for (int index = 0; index < loginArray.Length; index++)
            {
                if (loginArray[index].UserName == userName && loginArray[index].UserPassword == userPassword)
                {
                    MessageBox.Show("You are logged in successfully");

                    Form1 BikesForm = new Form1();
                    this.Hide();
                    BikesForm.ShowDialog();
                    this.Close();
                    break;
                }
                else
                {
                    error = true;
                }
            }
            if (error)
            {
                MessageBox.Show("Login Error... Try again ");
                this.textBoxUserName.Clear();
                this.textBoxUserPassword.Clear();
                this.textBoxUserName.Focus();
            }
        }
    }
}
