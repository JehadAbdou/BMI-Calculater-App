using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Calculater
    {
        private double Height;  //   BMI/BMR instance variables
        private double Weight;
        private string Name;
        private UnitType unit;
        private int Age;
        private Gender gender;
        private Activity_Level level;


       
        







        #region BMI Calc       
        public void SetHeight(double Height)
        {   if (Height > 0)
            this.Height = Height;
        }
        public double GetHeight()
        {
            return Height;
        }
        public void SetWeight(double Weight)
        {  if (Weight > 0)
            this.Weight = Weight;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public void setName(string Name)
        {
            this.Name = Name;

        }

        public string GetName()
        {
            return Name;
        }

        public void SetUnitType(UnitType unit)
        {
            this.unit = unit;
        }

        public UnitType GetUnitType() 
        {
            return unit;
        }

        public double CalculateBMI()
        {
            double BMI = 0.0;
            double factor = 1.0;


            if (unit == UnitType.Imperial) { 
                factor = 703.0;

            }
            BMI = factor * Weight / (Height * Height);
            return BMI;


        }
       

        public string NormalWeightLimits()
        {
            string NormalWeight = "";
            double lowWeight = 0;
            double highWeight = 0;
            double factor = 1.0;



            if (unit == UnitType.Imperial)
            {
                factor = 703.0;
                NormalWeight = "lbs";
            }
            else
                NormalWeight = "kg";

            lowWeight = Height * Height / factor * 18.50;
            highWeight = Height * Height / factor * 24.9;

            lowWeight = Math.Round(lowWeight);
            highWeight = Math.Round(highWeight);

            string LowWeightStr =lowWeight.ToString("f2");
            string HighWeightStr = highWeight.ToString("f2");

            NormalWeight = "Normal weight should be between "+LowWeightStr+" and "+HighWeightStr +" "+NormalWeight;

            return NormalWeight;

        }
        

        public string CatagoryBMI()
        {
            double bmi = CalculateBMI();
            string stringOut = string.Empty;

            if (bmi <= 18.5)
                stringOut = "underweight";

            else if (bmi <= 24.9)
                stringOut = "normal weight";

            else if (bmi <= 29.9)
                stringOut = "overweight (Pre-obesity)";

            else if (bmi <= 34.9)
                stringOut = "overweight (obesity class I)";

            else if (bmi <= 39.9)
                stringOut = "overweight (obesity class II)";

            else if (bmi >= 40)
                stringOut = "overweight (obesity class III)";
            return stringOut;
        }
        #endregion






        #region BMR Calc
        public double CalculateBMR()
        {
            double BMR = 0.0;
            

            BMR = 10 * Weight + 6.25 * Height - 5 * Age;

            if (gender == Gender.Male)
                BMR = BMR + 5;

            else
                BMR = BMR - 161;



            return BMR;

            

        }
        public void SetGender(Gender gender)
        {

            this.gender = gender;
        }

        public Gender GetGender()
        {
            return gender;
        }

        public void SetAge(int Age)
        {
            this.Age = Age;

        }

        public int GetAge()
        {

            return Age;

        }

        public void SetActivityLevel(Activity_Level level)
        {
            this.level = level;



        }

        public Activity_Level GetActivityLevel()
        {

            return level;

        }



        public double MaintainBMR()
        {   double factor = 1.0;
            

            if (level == Activity_Level.Sedentary)
                factor = 1.2;

            else if (level == Activity_Level.Lightlyactive)
                factor = 1.375;

            else if (level == Activity_Level.Moderatelyactive)
                factor = 1.550;

            else if (level == Activity_Level.Veryactive)
                factor = 1.725;

            else
                factor = 1.9;


            double MaintainBMR = CalculateBMR() * factor;

            return MaintainBMR;
        }

        #endregion
    }
}
