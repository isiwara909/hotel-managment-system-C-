using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_managment_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username == "admin"&& password == "admin123")
            {   

                
                MessageBox.Show("Login succecced!!!!");
                this.Hide();
                Main_menu mn = new Main_menu();
                mn.Show();
             
            }
            else
            {
                MessageBox.Show("Please enter correct username or password!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
