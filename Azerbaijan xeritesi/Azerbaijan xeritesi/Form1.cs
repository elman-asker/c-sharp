using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azerbaijan_xeritesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


      
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("BAKI");
            comboBox1.Items.Add("NAXCIVAN");
            comboBox1.Items.Add("XACMAZ");


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(comboBox1.Text == "BAKI")
            {
                label2.Visible=true;
                label3.Visible = false;
                label4.Visible = false;


            }
            else if (comboBox1.Text == "NAXCIVAN" )
            {
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
                
            }
            else if (comboBox1.Text == "XACMAZ")
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;

            }



        }
   
        
    }
}
