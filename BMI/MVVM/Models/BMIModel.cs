using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]   // Nuget Package Installed "PropertyChanged.Fody" 
    public class BMIModel
    {
        private float result;

        public float Height { get; set; }
        public float Weight { get; set; }
        public float Result 
        { 
            get 
            {  
                return ((Weight/Height)/Height*10000); 
            } 
        }

        public string ResultText {  
            get 
            {
                string Template = "BMI : #";
                if (Result <= 16)
                {
                    return Template.Replace("#", "Severe Thinness");
                }
                else if (Result > 16 && Result <= 17)
                {
                    return Template.Replace("#", "Moderate Thinness");
                }
                else if(Result > 17 && Result <= 18.5)
                {
                    return Template.Replace("#", "Mild Thinness");
                }
                else if (Result > 18.5 && Result <= 25)
                {
                    return Template.Replace("#", "Normal");
                }
                else if (Result > 25 && Result <= 30)
                {
                    return Template.Replace("#", "OverWeight");
                }
                else if (Result > 30 && Result <= 35)
                {
                    return Template.Replace("#", "Obese Class I");
                }
                else if (Result > 35 && Result <= 40)
                {
                    return Template.Replace("#", "Obese Class II");
                }
                else
                {
                    return Template.Replace("#", "Obese Class III");
                }
            } 
        }

    }
}
