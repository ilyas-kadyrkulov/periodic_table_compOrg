using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periodic_Table
{
    public partial class Form2 : Form
    {
        public Form2(string name, string atomicMass, string number, string oxidationState, string sign, string electronConf, string yearDiscovered,string location )
        {
            InitializeComponent();
            label1.Text = name;
            label12.Text = number;
            label11.Text = atomicMass;
            label10.Text = electronConf;
            label9.Text = oxidationState;
            label8.Text = yearDiscovered;
            label7.Text = sign;
            pictureBox1.ImageLocation= location;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
