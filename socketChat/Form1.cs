using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socketChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void makeChat_Click(object sender, EventArgs e)
        {
            serverForm serverF = new serverForm();
            serverF.ShowDialog();
        }

        private void joinChat_Click(object sender, EventArgs e)
        {
            clientForm clientForm = new clientForm();
            clientForm.ShowDialog();
        }
    }
}
