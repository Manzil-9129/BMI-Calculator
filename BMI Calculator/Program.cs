using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    static class Program
    {   //Instantiate an BMIcalculator object
        public static BMI BMIcalculator;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BMIcalculator = new BMI();
            Application.Run(new Splashform()); //Splash form runs        
        }
    }
}
