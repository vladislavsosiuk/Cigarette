using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            try
            {
                age = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("ВВеди цифры!!!!!!");
                return;
            }
            
            if (age >= 18)
            {

                var mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Еще юн щегол!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Login form has been shown");
        }
    }
}
