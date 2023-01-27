using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMICalculator.MVVM.Models;

namespace BMICalculator.MVVM.ViewModels
{
    public class BMIViewModel
    {

        public BMI BMI { get; set; }   // The Property BMI is BMI type.


        public BMIViewModel()
        {
            BMI =new BMI();           // Create an instance of the class.

            BMI.Height = 180;         // Initial Height.
            BMI.Weight = 73;
        }

    }
}

