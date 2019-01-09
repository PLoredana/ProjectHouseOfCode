using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHouseOfCode
{
    public partial class FormaLogin : Form
    {
        public FormaLogin()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //textBox1.Text = "";            

            //picuser.BackgroundImage = Properties.Resources.icons8;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            //picpass.BackgroundImage = Properties.Resources.icons8pass;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            //picmail.BackgroundImage = Properties.Resources.icons8mail;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            //if (textBox1.Text == "") textBox2.Text = "Username";
            //textBox2.PasswordChar.ToString();
            textBox2.PasswordChar = '\0';
            if (textBox2.Text == "") textBox2.Text = "Password"; else textBox2.PasswordChar = '●';
            if (textBox3.Text == "") textBox3.Text = "Email";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //            textBox2.Clear();
            textBox2.PasswordChar = '●';
            textBox2.Clear();

            //picuser.BackgroundImage = Properties.Resources.icons8;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            //picpass.BackgroundImage = Properties.Resources.icons8pass;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            //picmail.BackgroundImage = Properties.Resources.icons8mail;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            if (textBox1.Text == "") textBox1.Text = "Username";

            //if (textBox2.Text == "") textBox2.Text = "Password";
            if (textBox3.Text == "") textBox3.Text = "Email";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            //picuser.BackgroundImage = Properties.Resources.icons8;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            //picpass.BackgroundImage = Properties.Resources.icons8pass;
            panel2.BackColor = Color.WhiteSmoke; ;
            textBox2.ForeColor = Color.WhiteSmoke;

            //picmail.BackgroundImage = Properties.Resources.icons8mail;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(78, 184, 206);

            if (textBox1.Text == "") textBox1.Text = "Username";
            textBox2.PasswordChar = '\0';
            if (textBox2.Text == "") textBox2.Text = "Password"; else textBox2.PasswordChar = '●';
            //textBox2.PasswordChar.ToString();
            //if (textBox3.Text == "") textBox3.Text = "Email";
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
