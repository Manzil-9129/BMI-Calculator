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
    public partial class BMI : Form
    {
        private double _results;
        private double _results2;
        

        //Properties
        public double Results
        {
            get
            {
                return this._results;
            }
            set
            {
                this._results = value;
            }
        }

        public double Results2
        {
            get
            {
                return this._results2;
            }
            set
            {
                this._results2 = value;
            }
        }
        public BMI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        // Block of code to run the BMI calculator
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double height = Convert.ToDouble(textBox1.Text);
                double weight = Convert.ToDouble(textBox2.Text);
                if (Metricbutton.Checked == true)
                {
                    
                    
                    double Height = height * height;
                    this.Results = (weight / Height);
                    textBox3.Text = Convert.ToString(this.Results);
                    double Text = Convert.ToDouble(textBox3.Text);
                    if(Text <18.5)
                    {
                        textBox4.Text = "Underweight";
                    }
                    else if((Text>=18.5)&&(Text<=24.9))
                    {
                        textBox4.Text = "Normal";
                    }
                    else if((Text>=25)&&(Text<=29.9))
                    {
                        textBox4.Text = "Overweigth";
                    }
                    else if (Text >=30)
                    {
                        textBox4.Text = "Obese";
                    }
                }
                
                
                //Code for the Imperial Radio button
                else if (Imperialbutton.Checked == true)
                {
                    double Height2 = height * height;
                    this.Results2 = (weight * 703 / Height2);
                    textBox3.Text = Convert.ToString(this.Results2);

                    double Text = Convert.ToDouble(textBox3.Text);
                    if (Text < 18.5)
                    {
                        textBox4.Text = "Underweight";
                    }
                    else if ((Text >= 18.5) && (Text <= 24.9))
                    {
                        textBox4.Text = "Normal";
                    }
                    else if ((Text >= 25) && (Text <= 29.9))
                    {
                        textBox4.Text = "Overweigth";
                    }
                    else if (Text >= 30)
                    {
                        textBox4.Text = "Obese";
                    }



                }
            }

            catch (Exception error)
            {

                MessageBox.Show("Numeric only ");
                Console.WriteLine("Enter the correct value type ");
                Console.WriteLine(error.Message);
            }
            }

       
      
      
        private void BMI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BMI_Load(object sender, EventArgs e)
        {
            if((Metricbutton.Checked==true)|| (Imperialbutton.Checked==true))
            {
                this.Show(Calculatebutton);
               
            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        /*private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled=!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Numeric only ");
            }
            else
            {
                errorProvider1.SetError(Errorlabel, "");
                Errorlabel.Text = "";
            }
        }*/

       /* private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled=!char.IsDigit(e.KeyChar)) 
            {
                errorProvider2.SetError(Errorlabel2, "Only Numeric ");
                Errorlabel2.Text = "Only Numeric ";
            }
           
            else
            {
                errorProvider2.SetError(Errorlabel2, "");
                Errorlabel2.Text = "";
            }
        }*/
    }
}
