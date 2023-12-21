using BMI.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.ViewModels
{
    
    public class BMIViewModel
    {   
        public BMIModel BMIModel { get; set; }
        public BMIViewModel() 
        {
            BMIModel = new BMIModel();
            BMIModel.Height = 200;
            BMIModel.Weight = 100;
        }
    }
}
