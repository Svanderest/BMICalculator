using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class BmiCalculator
    {
        public int Height;
        public int Weight;
        public bool IsImperial;

        public BmiCalculator(int height, int weight, bool isImperial = false)
        {
            Height = height;
            Weight = weight;
            IsImperial = isImperial;
        }

        public string Result
        {
            get
            {
                double index = Weight / Math.Pow(Height, 2) * (IsImperial ? 703 : 1);
                if (index < 15)
                    return "Very severly underweight";
                else if (index < 16)
                    return "Severly underweight";
                else if (index < 18.5)
                    return "Underweight";
                else if (index < 25)
                    return "Normal";
                else if (index < 30)
                    return "Overweight";
                else if (index < 35)
                    return "Moderately obese";
                else if (index < 40)
                    return "Severly obese";
                else
                    return "Very severly obese";
            }
        }
    }
}
