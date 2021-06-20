using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCanHo_demo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gửi username + password lên database để kiểm tra
            //SqlConnection con =

            //chuyển hướng đến form main

            if (usernamebox.Text == "abcd" && textBox1.Text == "1234")
            {
                this.Hide();
                mainForm MF = new mainForm();
                MF.Show();
            }
            else
            {
                MessageBox.Show("Sai username hoặc password");
            }
        
        }
    }
}
