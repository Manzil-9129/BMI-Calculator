using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Splashform : Form
    {   
        //Properties
        public BMI BMIcalculator1
        {
            get
            {
                return Program.BMIcalculator; //Calling Program class to acces the instance variables
            }
            set
            {
                Program.BMIcalculator = value;
            }
        }
        public Splashform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Splashform_Load(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Dispay Splash form for 3sec and then hides the form and dislplay the BMI calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BMIcalculator1.Show();
            this.Hide();
            timer1.Enabled = false;
        }
    }
}
