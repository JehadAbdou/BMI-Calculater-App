namespace assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculat = new Button();
            txtFtCm = new TextBox();
            txtkglb = new TextBox();
            txtinch = new TextBox();
            txtName = new TextBox();
            lblName = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            Unit = new GroupBox();
            rbtnImperial = new RadioButton();
            rbtnMeteric = new RadioButton();
            grpResult = new GroupBox();
            lblNormalWeight = new Label();
            lblExtra = new Label();
            lblOutput = new Label();
            lblCatagory = new Label();
            lblResult = new Label();
            lblBMI = new Label();
            grbSaving = new GroupBox();
            txtFees = new TextBox();
            txtIntrest = new TextBox();
            txtYears = new TextBox();
            txtMonthly = new TextBox();
            txtInitial = new TextBox();
            lblFees = new Label();
            lblIntrest = new Label();
            lblPeriod = new Label();
            lblMonthly = new Label();
            lblInitial = new Label();
            grbCalc = new GroupBox();
            btnCalcSaving = new Button();
            grbFutureValue = new GroupBox();
            lblTotalFeesRes = new Label();
            lblTotalFees = new Label();
            lblFinalBalance = new Label();
            lblBalance = new Label();
            lblAmountEarned = new Label();
            lblEarned = new Label();
            lblAmountPaid = new Label();
            lblAmount = new Label();
            BMRcalc = new GroupBox();
            btnCalcBMR = new Button();
            grbActivityLevel = new GroupBox();
            rbtnExtraActive = new RadioButton();
            rbtnVeryActive = new RadioButton();
            rbtnModerately = new RadioButton();
            rbtnLightlyactive = new RadioButton();
            rbtnSedentary = new RadioButton();
            lblAge = new Label();
            txtAge = new TextBox();
            grpGender = new GroupBox();
            rbtnFemale = new RadioButton();
            rbtnMale = new RadioButton();
            lblNote = new Label();
            lbl1000plus = new Label();
            lbl500Plus = new Label();
            lbl1000Minus = new Label();
            lbl500Minus = new Label();
            lblMatintainWeight = new Label();
            lblBMRvalue = new Label();
            lblGain1000 = new Label();
            lblGain500 = new Label();
            lblLose1000 = new Label();
            lblLose500 = new Label();
            lblMaintain = new Label();
            lblBMR = new Label();
            grbReults = new GroupBox();
            Unit.SuspendLayout();
            grpResult.SuspendLayout();
            grbSaving.SuspendLayout();
            grbCalc.SuspendLayout();
            grbFutureValue.SuspendLayout();
            BMRcalc.SuspendLayout();
            grbActivityLevel.SuspendLayout();
            grpGender.SuspendLayout();
            grbReults.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculat
            // 
            btnCalculat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculat.Location = new Point(134, 127);
            btnCalculat.Name = "btnCalculat";
            btnCalculat.Size = new Size(198, 35);
            btnCalculat.TabIndex = 0;
            btnCalculat.Text = "Calculate";
            btnCalculat.UseVisualStyleBackColor = true;
            btnCalculat.Click += btnCalculat_Click;
            // 
            // txtFtCm
            // 
            txtFtCm.Location = new Point(134, 56);
            txtFtCm.Name = "txtFtCm";
            txtFtCm.Size = new Size(77, 23);
            txtFtCm.TabIndex = 1;
            // 
            // txtkglb
            // 
            txtkglb.Location = new Point(134, 85);
            txtkglb.Name = "txtkglb";
            txtkglb.Size = new Size(77, 23);
            txtkglb.TabIndex = 2;
            // 
            // txtinch
            // 
            txtinch.Location = new Point(240, 56);
            txtinch.Name = "txtinch";
            txtinch.Size = new Size(77, 23);
            txtinch.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(24, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 21);
            lblName.TabIndex = 5;
            lblName.Text = "Your Name";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeight.Location = new Point(24, 58);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(56, 21);
            lblHeight.TabIndex = 6;
            lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeight.Location = new Point(24, 87);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(59, 21);
            lblWeight.TabIndex = 7;
            lblWeight.Text = "Weight";
            // 
            // Unit
            // 
            Unit.Controls.Add(rbtnImperial);
            Unit.Controls.Add(rbtnMeteric);
            Unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Unit.Location = new Point(483, 12);
            Unit.Name = "Unit";
            Unit.Size = new Size(200, 138);
            Unit.TabIndex = 8;
            Unit.TabStop = false;
            Unit.Text = "Unit";
            // 
            // rbtnImperial
            // 
            rbtnImperial.AutoSize = true;
            rbtnImperial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnImperial.Location = new Point(33, 55);
            rbtnImperial.Name = "rbtnImperial";
            rbtnImperial.Size = new Size(129, 25);
            rbtnImperial.TabIndex = 1;
            rbtnImperial.TabStop = true;
            rbtnImperial.Text = "Imperial (ft, lb)";
            rbtnImperial.UseVisualStyleBackColor = true;
            rbtnImperial.CheckedChanged += rbtnImperial_CheckedChanged;
            // 
            // rbtnMeteric
            // 
            rbtnMeteric.AutoSize = true;
            rbtnMeteric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnMeteric.Location = new Point(33, 28);
            rbtnMeteric.Name = "rbtnMeteric";
            rbtnMeteric.Size = new Size(139, 25);
            rbtnMeteric.TabIndex = 0;
            rbtnMeteric.TabStop = true;
            rbtnMeteric.Text = "Meteric (kg ,cm)";
            rbtnMeteric.UseVisualStyleBackColor = true;
            rbtnMeteric.CheckedChanged += rbtnMeteric_CheckedChanged;
            // 
            // grpResult
            // 
            grpResult.Controls.Add(lblNormalWeight);
            grpResult.Controls.Add(lblExtra);
            grpResult.Controls.Add(lblOutput);
            grpResult.Controls.Add(lblCatagory);
            grpResult.Controls.Add(lblResult);
            grpResult.Controls.Add(lblBMI);
            grpResult.Location = new Point(27, 215);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(656, 193);
            grpResult.TabIndex = 9;
            grpResult.TabStop = false;
            grpResult.Text = "Results for ";
            // 
            // lblNormalWeight
            // 
            lblNormalWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNormalWeight.Location = new Point(134, 144);
            lblNormalWeight.Name = "lblNormalWeight";
            lblNormalWeight.Size = new Size(454, 41);
            lblNormalWeight.TabIndex = 5;
            lblNormalWeight.Text = "label1";
            lblNormalWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExtra
            // 
            lblExtra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExtra.ForeColor = SystemColors.Highlight;
            lblExtra.Location = new Point(172, 108);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(306, 36);
            lblExtra.TabIndex = 4;
            lblExtra.Text = "label5";
            lblExtra.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.Fixed3D;
            lblOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(240, 59);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(336, 25);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "label4";
            // 
            // lblCatagory
            // 
            lblCatagory.AutoSize = true;
            lblCatagory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatagory.Location = new Point(24, 59);
            lblCatagory.Name = "lblCatagory";
            lblCatagory.Size = new Size(126, 21);
            lblCatagory.TabIndex = 2;
            lblCatagory.Text = "Weight Catagory";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(240, 28);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(134, 23);
            lblResult.TabIndex = 1;
            lblResult.Text = "label2";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBMI.Location = new Point(24, 30);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(73, 21);
            lblBMI.TabIndex = 0;
            lblBMI.Text = "Your BMI";
            // 
            // grbSaving
            // 
            grbSaving.Controls.Add(txtFees);
            grbSaving.Controls.Add(txtIntrest);
            grbSaving.Controls.Add(txtYears);
            grbSaving.Controls.Add(txtMonthly);
            grbSaving.Controls.Add(txtInitial);
            grbSaving.Controls.Add(lblFees);
            grbSaving.Controls.Add(lblIntrest);
            grbSaving.Controls.Add(lblPeriod);
            grbSaving.Controls.Add(lblMonthly);
            grbSaving.Controls.Add(lblInitial);
            grbSaving.Location = new Point(736, 12);
            grbSaving.Name = "grbSaving";
            grbSaving.Size = new Size(363, 187);
            grbSaving.TabIndex = 10;
            grbSaving.TabStop = false;
            grbSaving.Text = "Saving plan";
            // 
            // txtFees
            // 
            txtFees.Location = new Point(196, 153);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(161, 23);
            txtFees.TabIndex = 10;
            // 
            // txtIntrest
            // 
            txtIntrest.AcceptsReturn = true;
            txtIntrest.Location = new Point(196, 120);
            txtIntrest.Name = "txtIntrest";
            txtIntrest.Size = new Size(161, 23);
            txtIntrest.TabIndex = 9;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(196, 87);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(161, 23);
            txtYears.TabIndex = 8;
            // 
            // txtMonthly
            // 
            txtMonthly.Location = new Point(196, 55);
            txtMonthly.Name = "txtMonthly";
            txtMonthly.Size = new Size(161, 23);
            txtMonthly.TabIndex = 7;
            // 
            // txtInitial
            // 
            txtInitial.Location = new Point(196, 20);
            txtInitial.Name = "txtInitial";
            txtInitial.Size = new Size(161, 23);
            txtInitial.TabIndex = 6;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(34, 161);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(56, 15);
            lblFees.TabIndex = 4;
            lblFees.Text = "Fees in %";
            // 
            // lblIntrest
            // 
            lblIntrest.AutoSize = true;
            lblIntrest.Location = new Point(34, 123);
            lblIntrest.Name = "lblIntrest";
            lblIntrest.Size = new Size(130, 15);
            lblIntrest.TabIndex = 3;
            lblIntrest.Text = "Growth (or intrest) in %";
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Location = new Point(34, 90);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(79, 15);
            lblPeriod.TabIndex = 2;
            lblPeriod.Text = "Period (years)";
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Location = new Point(34, 55);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.Size = new Size(94, 15);
            lblMonthly.TabIndex = 1;
            lblMonthly.Text = "Monthly deposit";
            // 
            // lblInitial
            // 
            lblInitial.AutoSize = true;
            lblInitial.Location = new Point(34, 23);
            lblInitial.Name = "lblInitial";
            lblInitial.Size = new Size(78, 15);
            lblInitial.TabIndex = 0;
            lblInitial.Text = "Initial deposit";
            // 
            // grbCalc
            // 
            grbCalc.Controls.Add(txtName);
            grbCalc.Controls.Add(txtFtCm);
            grbCalc.Controls.Add(txtkglb);
            grbCalc.Controls.Add(txtinch);
            grbCalc.Controls.Add(btnCalculat);
            grbCalc.Controls.Add(lblWeight);
            grbCalc.Controls.Add(lblName);
            grbCalc.Controls.Add(lblHeight);
            grbCalc.Location = new Point(27, 12);
            grbCalc.Name = "grbCalc";
            grbCalc.Size = new Size(384, 187);
            grbCalc.TabIndex = 11;
            grbCalc.TabStop = false;
            grbCalc.Text = "BMI Calculator";
            // 
            // btnCalcSaving
            // 
            btnCalcSaving.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcSaving.Location = new Point(814, 205);
            btnCalcSaving.Name = "btnCalcSaving";
            btnCalcSaving.Size = new Size(212, 35);
            btnCalcSaving.TabIndex = 5;
            btnCalcSaving.Text = "Calculate saving";
            btnCalcSaving.UseVisualStyleBackColor = true;
            btnCalcSaving.Click += button1_Click;
            // 
            // grbFutureValue
            // 
            grbFutureValue.Controls.Add(lblTotalFeesRes);
            grbFutureValue.Controls.Add(lblTotalFees);
            grbFutureValue.Controls.Add(lblFinalBalance);
            grbFutureValue.Controls.Add(lblBalance);
            grbFutureValue.Controls.Add(lblAmountEarned);
            grbFutureValue.Controls.Add(lblEarned);
            grbFutureValue.Controls.Add(lblAmountPaid);
            grbFutureValue.Controls.Add(lblAmount);
            grbFutureValue.Location = new Point(738, 243);
            grbFutureValue.Name = "grbFutureValue";
            grbFutureValue.Size = new Size(361, 165);
            grbFutureValue.TabIndex = 12;
            grbFutureValue.TabStop = false;
            grbFutureValue.Text = "Future Value";
            // 
            // lblTotalFeesRes
            // 
            lblTotalFeesRes.BorderStyle = BorderStyle.Fixed3D;
            lblTotalFeesRes.Location = new Point(215, 128);
            lblTotalFeesRes.Name = "lblTotalFeesRes";
            lblTotalFeesRes.Size = new Size(146, 22);
            lblTotalFeesRes.TabIndex = 7;
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Location = new Point(39, 128);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(56, 15);
            lblTotalFees.TabIndex = 6;
            lblTotalFees.Text = "Total fees";
            // 
            // lblFinalBalance
            // 
            lblFinalBalance.BorderStyle = BorderStyle.Fixed3D;
            lblFinalBalance.Location = new Point(215, 93);
            lblFinalBalance.Name = "lblFinalBalance";
            lblFinalBalance.Size = new Size(146, 26);
            lblFinalBalance.TabIndex = 5;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(39, 93);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(76, 15);
            lblBalance.TabIndex = 4;
            lblBalance.Text = "Final balance";
            // 
            // lblAmountEarned
            // 
            lblAmountEarned.BorderStyle = BorderStyle.Fixed3D;
            lblAmountEarned.Location = new Point(215, 58);
            lblAmountEarned.Name = "lblAmountEarned";
            lblAmountEarned.Size = new Size(145, 27);
            lblAmountEarned.TabIndex = 3;
            // 
            // lblEarned
            // 
            lblEarned.AutoSize = true;
            lblEarned.Location = new Point(39, 59);
            lblEarned.Name = "lblEarned";
            lblEarned.Size = new Size(90, 15);
            lblEarned.TabIndex = 2;
            lblEarned.Text = "Amount earned";
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.BorderStyle = BorderStyle.Fixed3D;
            lblAmountPaid.Location = new Point(215, 19);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(146, 29);
            lblAmountPaid.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(39, 31);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(77, 15);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount Paid";
            // 
            // BMRcalc
            // 
            BMRcalc.Controls.Add(btnCalcBMR);
            BMRcalc.Controls.Add(grbActivityLevel);
            BMRcalc.Controls.Add(lblAge);
            BMRcalc.Controls.Add(txtAge);
            BMRcalc.Controls.Add(grpGender);
            BMRcalc.Location = new Point(27, 424);
            BMRcalc.Name = "BMRcalc";
            BMRcalc.Size = new Size(531, 232);
            BMRcalc.TabIndex = 13;
            BMRcalc.TabStop = false;
            BMRcalc.Text = "BMR Calculator";
            // 
            // btnCalcBMR
            // 
            btnCalcBMR.Location = new Point(75, 188);
            btnCalcBMR.Name = "btnCalcBMR";
            btnCalcBMR.Size = new Size(311, 36);
            btnCalcBMR.TabIndex = 4;
            btnCalcBMR.Text = "Calculate BMR";
            btnCalcBMR.UseVisualStyleBackColor = true;
            btnCalcBMR.Click += btnCalcBMR_Click;
            // 
            // grbActivityLevel
            // 
            grbActivityLevel.Controls.Add(rbtnExtraActive);
            grbActivityLevel.Controls.Add(rbtnVeryActive);
            grbActivityLevel.Controls.Add(rbtnModerately);
            grbActivityLevel.Controls.Add(rbtnLightlyactive);
            grbActivityLevel.Controls.Add(rbtnSedentary);
            grbActivityLevel.Location = new Point(172, 31);
            grbActivityLevel.Name = "grbActivityLevel";
            grbActivityLevel.Size = new Size(311, 151);
            grbActivityLevel.TabIndex = 3;
            grbActivityLevel.TabStop = false;
            grbActivityLevel.Text = "Weekly Activity Level";
            // 
            // rbtnExtraActive
            // 
            rbtnExtraActive.AutoSize = true;
            rbtnExtraActive.Location = new Point(30, 122);
            rbtnExtraActive.Name = "rbtnExtraActive";
            rbtnExtraActive.Size = new Size(247, 19);
            rbtnExtraActive.TabIndex = 4;
            rbtnExtraActive.TabStop = true;
            rbtnExtraActive.Text = "Extra active (Hard exercise or physical job)";
            rbtnExtraActive.UseVisualStyleBackColor = true;
            // 
            // rbtnVeryActive
            // 
            rbtnVeryActive.AutoSize = true;
            rbtnVeryActive.Location = new Point(30, 96);
            rbtnVeryActive.Name = "rbtnVeryActive";
            rbtnVeryActive.Size = new Size(242, 19);
            rbtnVeryActive.TabIndex = 3;
            rbtnVeryActive.TabStop = true;
            rbtnVeryActive.Text = "Very active (Exercises 6 to 7 times a week)";
            rbtnVeryActive.UseVisualStyleBackColor = true;
            // 
            // rbtnModerately
            // 
            rbtnModerately.AutoSize = true;
            rbtnModerately.Location = new Point(30, 71);
            rbtnModerately.Name = "rbtnModerately";
            rbtnModerately.Size = new Size(280, 19);
            rbtnModerately.TabIndex = 2;
            rbtnModerately.TabStop = true;
            rbtnModerately.Text = "Moderately active (Exercises 4 to 5 times a week)";
            rbtnModerately.UseVisualStyleBackColor = true;
            // 
            // rbtnLightlyactive
            // 
            rbtnLightlyactive.AutoSize = true;
            rbtnLightlyactive.Location = new Point(30, 46);
            rbtnLightlyactive.Name = "rbtnLightlyactive";
            rbtnLightlyactive.Size = new Size(251, 19);
            rbtnLightlyactive.TabIndex = 1;
            rbtnLightlyactive.TabStop = true;
            rbtnLightlyactive.Text = "Lightly active (Exercise 1 to 3 times a week)";
            rbtnLightlyactive.UseVisualStyleBackColor = true;
            
            // 
            // rbtnSedentary
            // 
            rbtnSedentary.AutoSize = true;
            rbtnSedentary.Location = new Point(30, 21);
            rbtnSedentary.Name = "rbtnSedentary";
            rbtnSedentary.Size = new Size(190, 19);
            rbtnSedentary.TabIndex = 0;
            rbtnSedentary.TabStop = true;
            rbtnSedentary.Text = "Sedentary (Little or no exercise)";
            rbtnSedentary.UseVisualStyleBackColor = true;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(32, 153);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(75, 149);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(60, 23);
            txtAge.TabIndex = 1;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbtnFemale);
            grpGender.Controls.Add(rbtnMale);
            grpGender.Location = new Point(24, 31);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(111, 101);
            grpGender.TabIndex = 0;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(28, 52);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(63, 19);
            rbtnFemale.TabIndex = 1;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(28, 25);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(51, 19);
            rbtnMale.TabIndex = 0;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // lblNote
            // 
            lblNote.BackColor = SystemColors.ActiveCaption;
            lblNote.ForeColor = SystemColors.HotTrack;
            lblNote.Location = new Point(86, 170);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(327, 36);
            lblNote.TabIndex = 17;
            lblNote.Text = "Losing more than 1000 colories per day is to be avoided";
            lblNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1000plus
            // 
            lbl1000plus.AutoSize = true;
            lbl1000plus.Location = new Point(24, 147);
            lbl1000plus.Name = "lbl1000plus";
            lbl1000plus.Size = new Size(165, 15);
            lbl1000plus.TabIndex = 16;
            lbl1000plus.Text = "Colories to gain 1 kg per week\r\n";
            // 
            // lbl500Plus
            // 
            lbl500Plus.AutoSize = true;
            lbl500Plus.Location = new Point(24, 125);
            lbl500Plus.Name = "lbl500Plus";
            lbl500Plus.Size = new Size(174, 15);
            lbl500Plus.TabIndex = 15;
            lbl500Plus.Text = "Colories to gain 0.5 kg per week\r\n";
            // 
            // lbl1000Minus
            // 
            lbl1000Minus.AutoSize = true;
            lbl1000Minus.Location = new Point(24, 104);
            lbl1000Minus.Name = "lbl1000Minus";
            lbl1000Minus.Size = new Size(163, 15);
            lbl1000Minus.TabIndex = 14;
            lbl1000Minus.Text = "Colories to lose 1 kg per week\r\n";
            // 
            // lbl500Minus
            // 
            lbl500Minus.AutoSize = true;
            lbl500Minus.Location = new Point(24, 81);
            lbl500Minus.Name = "lbl500Minus";
            lbl500Minus.Size = new Size(172, 15);
            lbl500Minus.TabIndex = 13;
            lbl500Minus.Text = "Colories to lose 0.5 kg per week";
            // 
            // lblMatintainWeight
            // 
            lblMatintainWeight.AutoSize = true;
            lblMatintainWeight.Location = new Point(24, 59);
            lblMatintainWeight.Name = "lblMatintainWeight";
            lblMatintainWeight.Size = new Size(180, 15);
            lblMatintainWeight.TabIndex = 12;
            lblMatintainWeight.Text = "Colories to maintain your weight";
            // 
            // lblBMRvalue
            // 
            lblBMRvalue.AutoSize = true;
            lblBMRvalue.Location = new Point(24, 36);
            lblBMRvalue.Name = "lblBMRvalue";
            lblBMRvalue.Size = new Size(141, 15);
            lblBMRvalue.TabIndex = 11;
            lblBMRvalue.Text = "Your BMR (colories / day)";
            // 
            // lblGain1000
            // 
            lblGain1000.BorderStyle = BorderStyle.Fixed3D;
            lblGain1000.Location = new Point(419, 147);
            lblGain1000.Name = "lblGain1000";
            lblGain1000.Size = new Size(100, 23);
            lblGain1000.TabIndex = 10;
            // 
            // lblGain500
            // 
            lblGain500.BorderStyle = BorderStyle.Fixed3D;
            lblGain500.Location = new Point(419, 125);
            lblGain500.Name = "lblGain500";
            lblGain500.Size = new Size(100, 23);
            lblGain500.TabIndex = 9;
            // 
            // lblLose1000
            // 
            lblLose1000.BorderStyle = BorderStyle.Fixed3D;
            lblLose1000.Location = new Point(419, 104);
            lblLose1000.Name = "lblLose1000";
            lblLose1000.Size = new Size(100, 23);
            lblLose1000.TabIndex = 8;
            // 
            // lblLose500
            // 
            lblLose500.BorderStyle = BorderStyle.Fixed3D;
            lblLose500.Location = new Point(419, 81);
            lblLose500.Name = "lblLose500";
            lblLose500.Size = new Size(100, 23);
            lblLose500.TabIndex = 7;
            // 
            // lblMaintain
            // 
            lblMaintain.BorderStyle = BorderStyle.Fixed3D;
            lblMaintain.Location = new Point(419, 60);
            lblMaintain.Name = "lblMaintain";
            lblMaintain.Size = new Size(100, 18);
            lblMaintain.TabIndex = 6;
            // 
            // lblBMR
            // 
            lblBMR.BorderStyle = BorderStyle.Fixed3D;
            lblBMR.Location = new Point(419, 36);
            lblBMR.Name = "lblBMR";
            lblBMR.Size = new Size(100, 24);
            lblBMR.TabIndex = 5;
            // 
            // grbReults
            // 
            grbReults.Controls.Add(lblNote);
            grbReults.Controls.Add(lblBMRvalue);
            grbReults.Controls.Add(lbl1000plus);
            grbReults.Controls.Add(lblBMR);
            grbReults.Controls.Add(lbl500Plus);
            grbReults.Controls.Add(lblMaintain);
            grbReults.Controls.Add(lbl1000Minus);
            grbReults.Controls.Add(lblLose500);
            grbReults.Controls.Add(lbl500Minus);
            grbReults.Controls.Add(lblLose1000);
            grbReults.Controls.Add(lblMatintainWeight);
            grbReults.Controls.Add(lblGain500);
            grbReults.Controls.Add(lblGain1000);
            grbReults.Location = new Point(584, 428);
            grbReults.Name = "grbReults";
            grbReults.Size = new Size(535, 228);
            grbReults.TabIndex = 18;
            grbReults.TabStop = false;
            grbReults.Text = "BMR results for ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 661);
            Controls.Add(grbReults);
            Controls.Add(BMRcalc);
            Controls.Add(grbFutureValue);
            Controls.Add(grbCalc);
            Controls.Add(grbSaving);
            Controls.Add(grpResult);
            Controls.Add(Unit);
            Controls.Add(btnCalcSaving);
            Name = "MainForm";
            Text = "BMI Calculater";
            Load += MainForm_Load;
            Unit.ResumeLayout(false);
            Unit.PerformLayout();
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            grbSaving.ResumeLayout(false);
            grbSaving.PerformLayout();
            grbCalc.ResumeLayout(false);
            grbCalc.PerformLayout();
            grbFutureValue.ResumeLayout(false);
            grbFutureValue.PerformLayout();
            BMRcalc.ResumeLayout(false);
            BMRcalc.PerformLayout();
            grbActivityLevel.ResumeLayout(false);
            grbActivityLevel.PerformLayout();
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            grbReults.ResumeLayout(false);
            grbReults.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculat;
        private TextBox txtFtCm;
        private TextBox txtkglb;
        private TextBox txtinch;
        private TextBox txtName;
        private Label lblName;
        private Label lblHeight;
        private Label lblWeight;
        private GroupBox Unit;
        private GroupBox grpResult;
        private Label lblExtra;
        private Label lblOutput;
        private Label lblCatagory;
        private Label lblResult;
        private Label lblBMI;
        private RadioButton rbtnImperial;
        private RadioButton rbtnMeteric;
        private GroupBox grbSaving;
        private Label lblInitial;
        private GroupBox grbCalc;
        private TextBox txtFees;
        private TextBox txtIntrest;
        private TextBox txtYears;
        private TextBox txtMonthly;
        private TextBox txtInitial;
        private Label lblFees;
        private Label lblIntrest;
        private Label lblPeriod;
        private Label lblMonthly;
        private Button btnCalcSaving;
        private GroupBox grbFutureValue;
        private Label lblTotalFeesRes;
        private Label lblTotalFees;
        private Label lblFinalBalance;
        private Label lblBalance;
        private Label lblAmountEarned;
        private Label lblEarned;
        private Label lblAmountPaid;
        private Label lblAmount;
        private Label lblNormalWeight;
        private GroupBox BMRcalc;
        private Label lblAge;
        private TextBox txtAge;
        private GroupBox grpGender;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private Button btnCalcBMR;
        private GroupBox grbActivityLevel;
        private RadioButton rbtnExtraActive;
        private RadioButton rbtnVeryActive;
        private RadioButton rbtnModerately;
        private RadioButton rbtnLightlyactive;
        private RadioButton rbtnSedentary;
        private Label lblBMR;
        private Label lblMaintain;
        private Label lblGain1000;
        private Label lblGain500;
        private Label lblLose1000;
        private Label lblLose500;
        private Label lbl1000plus;
        private Label lbl500Plus;
        private Label lbl1000Minus;
        private Label lbl500Minus;
        private Label lblMatintainWeight;
        private Label lblBMRvalue;
        private Label lblNote;
        private GroupBox grbReults;
    }
}
