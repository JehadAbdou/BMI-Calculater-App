using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;

namespace assignment3
{
    public partial class MainForm : Form
    {

        private Calculater Calc = new Calculater();

        public MainForm()
        {
            InitializeComponent();
            InitializationGUI();
        }

        private void InitializationGUI()
        {
            this.Text += " Jehad Abdou";

            rbtnMeteric.Checked = true;
            lblExtra.Text = "Normal BMI is between 18.50 and 24.9 ";

            rbtnMale.Checked = true;
            rbtnSedentary.Checked = true;





        }
        #region BMI Calc

        private void UpdateHeightTxt()
        {
            if (rbtnImperial.Checked)
            {
                lblHeight.Text = "Height (ft, in)";
                txtinch.Visible = true;

            }

            else
            {
                lblHeight.Text = "Height (cm)";
                txtinch.Visible = false;
            }
            lblResult.Text = string.Empty;
            lblOutput.Text = string.Empty;
            lblNormalWeight.Text = string.Empty;

        }



        private void UpdateWeightTxt()
        {
            if (rbtnImperial.Checked)
                lblWeight.Text = "Weight (lb)";

            else
                lblWeight.Text = "Weight (kg)";
        }

        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightTxt();
            UpdateWeightTxt();

        }

        private void rbtnMeteric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightTxt();
            UpdateWeightTxt();

        }

        private void Readname()
        {
            string name = string.Empty;
            name = txtName.Text;
            name = name.Trim();

            if (!string.IsNullOrEmpty(name))
                Calc.setName(name);

            else
                Calc.setName("unknown");

        }
        private void ReadUnit()
        {
            if (rbtnMeteric.Checked)
                Calc.SetUnitType(UnitType.Meteric);

            else
                Calc.SetUnitType(UnitType.Imperial);

        }

        private bool ReadHeight()
        {
            double Height = 0.0;


            bool ok = double.TryParse(txtFtCm.Text, out Height);
            if (!ok)
                MessageBox.Show("The height value is invalid", "Error");

            double inch = 0.0;
            if (rbtnImperial.Checked)
            {
                ok = ok && double.TryParse(txtinch.Text, out inch);

                if (!ok)
                    MessageBox.Show("The inch value is invalid", "Error");


            }


            if (Calc.GetUnitType() == UnitType.Meteric)
                Height = Height / 100.0;

            else
                Height = Height * 12.0 + inch;


            Calc.SetHeight(Height);

            return ok;

        }



        private bool ReadWeight()
        {
            double Weight = 0.0;
            bool ok = double.TryParse(txtkglb.Text, out Weight);

            if (!ok)
                MessageBox.Show("The weight value is invalid", "Error");

            Calc.SetWeight(Weight);


            return ok;
        }



        private bool ReadInput()
        {
            Readname();
            ReadUnit();
            bool HeightOK = ReadHeight();
            bool WeightOK = ReadWeight();
            lblNormalWeight.Text = Calc.NormalWeightLimits();




            return HeightOK && WeightOK;
        }
        private void CalculateAndDisplay()
        {
            double bmi = Calc.CalculateBMI();

            lblResult.Text = bmi.ToString("f2");
            lblOutput.Text = Calc.CatagoryBMI();
            lblNormalWeight.Text = Calc.NormalWeightLimits();
        }






        private void btnCalculat_Click(object sender, EventArgs e)
        {
            bool ok = ReadInput();

            if (ok)
            {
                CalculateAndDisplay();
            }
            grpResult.Text = "Results for " + Calc.GetName();



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        #endregion





        #region Saving


        private void ReadandCalcSavings()
        {

            double initialDeposit = double.Parse(txtInitial.Text); // Read input from user
            double monthlySaving = double.Parse(txtMonthly.Text);
            int years = int.Parse(txtYears.Text);
            double annualInterestRate = double.Parse(txtIntrest.Text);
            double annulyFeesRate = double.Parse(txtFees.Text);

            int months = years * 12;
            double monthlyInterestRate = annualInterestRate / 100.0 / 12.0;
            double monthlyFees = annulyFeesRate / 100.0 / 12.0;

            double balance = initialDeposit;
            double totalInterest = 0;
            double totalFees = 0;

            for (int month = 1; month <= months; month++)   // calculations
            {
                double interest = monthlyInterestRate * balance;
                double fees = monthlyFees * balance;
                balance += interest - fees + monthlySaving;
                totalInterest += interest;
                totalFees += fees;
            }
            double TotalAmountPaid = initialDeposit + (months * monthlySaving);
            double AmountEearned = balance - TotalAmountPaid;



            lblAmountPaid.Text = TotalAmountPaid.ToString("f2");
            lblFinalBalance.Text = balance.ToString("f2");
            lblTotalFeesRes.Text = totalFees.ToString("f2");
            lblAmountEarned.Text = AmountEearned.ToString("f2");


        }




        private void button1_Click(object sender, EventArgs e)
        {
            ReadandCalcSavings();


        }

        #endregion


        #region BMR
        private void btnCalcBMR_Click(object sender, EventArgs e)
        {

            ReadGender();
            ReadBMR();
            ActivityLevelCalc();
            grbReults.Text = "Results for " + Calc.GetName();





        }

        private void ConvertValues() //convert from lb --> kg and inch --> cm
        {
            double Hight = Calc.GetHeight();
            double Weight = Calc.GetWeight();
            if (rbtnImperial.Checked)
            {
                Hight = Hight * 2.54;
                Weight = Weight / 2.20462262;





            }

            else
            { if (Hight < 1000)
                    Hight *= 100;

                else
                    Hight = Hight;
               
            }
            Calc.SetHeight(Hight);
            Calc.SetWeight(Weight);

            if (Hight > 1000) 
            {
                Hight = Hight / 100;
                Calc.SetHeight(Hight);
                
                }
        }

        public void ReadBMR()
        {
            double bmr = 0;
            int age = 0;
            bool ok = int.TryParse(txtAge.Text, out age);

            if (!ok)
                MessageBox.Show("Invalid age");

            Calc.SetAge(age);
            ConvertValues();

            bmr = Calc.CalculateBMR();
            lblBMR.Text = string.Empty;
            lblBMR.Text = bmr.ToString("0.0");

            bmr = 0;





        }

        private void ReadGender()
        {
            if (rbtnMale.Checked)
                Calc.SetGender(Gender.Male);

            else
                Calc.SetGender(Gender.Female);

        }


        private void ActivityLevelCalc()  // chose activity level and calculate colories to gain or lose
        {
            double MaintainBMR = 0.0;


            if (rbtnSedentary.Checked)
            {
                Calc.SetActivityLevel(Activity_Level.Sedentary);


            }

            else if (rbtnLightlyactive.Checked)
                Calc.SetActivityLevel(Activity_Level.Lightlyactive);

            else if (rbtnModerately.Checked)
                Calc.SetActivityLevel(Activity_Level.Moderatelyactive);

            else if (rbtnVeryActive.Checked)
                Calc.SetActivityLevel(Activity_Level.Veryactive);

            else
                Calc.SetActivityLevel(Activity_Level.Extraactive);

            MaintainBMR = Calc.MaintainBMR();

            lblMaintain.Text = MaintainBMR.ToString("f1");

            lblLose500.Text = (MaintainBMR - 500).ToString("f1");
            lblLose1000.Text = (MaintainBMR - 1000).ToString("f1");
            lblGain500.Text = (MaintainBMR + 500).ToString("f1");
            lblGain1000.Text = (MaintainBMR + 1000).ToString("f1");





        }


        #endregion





       
    }
}

