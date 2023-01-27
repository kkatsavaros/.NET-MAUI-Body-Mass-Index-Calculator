using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;             // <-----

namespace BMICalculator.MVVM.Models
{


    [AddINotifyPropertyChangedInterface]

    public class BMI
    {
        private float result;
        public float Height { get; set; }
        public float Weight { get; set; }
        public float Result
        {
            get
            {
                return ((Weight / Height) / Height) * 10000;
            }
        }


    public string ResultText
        {
            get
            {
                string template = "BMI: #";

                if (Result <= 16)
                {
                    return template.Replace("#", "Severe Thinness - Σοβαρή λεπτότητα");
                }
                else if (Result > 16 && Result <= 17)
                {
                    return template.Replace("#", "Moderate Thinness - Μέτρια λεπτότητα");
                }
                else if (Result > 17 && Result <= 18.5)
                {
                    return template.Replace("#", "Mild Thinness - Ήπια Λεπτότητα");
                }
                else if (Result > 18.5 && Result <= 25)
                {
                    return template.Replace("#", "Normal - Κανονικός");
                }
                else if (Result > 25 && Result <= 30)
                {
                    return template.Replace("#", "Overweight - Υπέρβαρος");
                }
                else if (Result > 30 && Result <= 35)
                {
                    return template.Replace("#", "Obese Class I - Παχύσαρκοι Κατηγορία Ι");
                }
                else if (Result > 35 && Result <= 40)
                {
                    return template.Replace("#", "Obese Class II - Παχύσαρκοι Κατηγορία ΙI");
                }
                else
                {
                    return template.Replace("#", "Obese Class III - Παχύσαρκοι Κατηγορία ΙII");
                }

            }
        }
    }

}

