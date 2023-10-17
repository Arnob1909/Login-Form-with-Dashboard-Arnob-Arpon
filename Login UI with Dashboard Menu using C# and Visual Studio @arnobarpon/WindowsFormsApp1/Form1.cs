using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        String id = "arnobarpon001@gmail.com";
        String pass = "A1b2c3d4!";
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frmreg = new Form3();
            frmreg.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            if(textBox1.Text == id)
            {
                if(textBox2.Text == pass)
                {
                    Form2 frmdb = new Form2();
                    
                    frmdb.ShowDialog();

                    label5.Visible = false;
                    label6.Visible = false;

                    this.Close();


                }
                else
                {

                    label6.Visible = true;
                    label5.Visible = false;
                }
            }
            else
            {
                label5.Visible = true;
                label6.Visible = false;
            }
        }
    }
}
