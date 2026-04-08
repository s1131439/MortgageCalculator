namespace 個人房貸試算器
{
    partial class frmMortgageCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.rbPercent = new System.Windows.Forms.RadioButton();
            this.txtDownPercent = new System.Windows.Forms.TextBox();
            this.rdAmount = new System.Windows.Forms.RadioButton();
            this.txtDownAmount = new System.Windows.Forms.TextBox();
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtGrace = new System.Windows.Forms.TextBox();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblLoanAmount1 = new System.Windows.Forms.Label();
            this.lblMonthlyPayment1 = new System.Windows.Forms.Label();
            this.lblFirstInterest1 = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblFirstPrincipal1 = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblTotalInterest1 = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblTotalPayment1 = new System.Windows.Forms.Label();
            this.chkGrace = new System.Windows.Forms.CheckBox();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblName.Location = new System.Drawing.Point(279, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(204, 35);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "個人房貸試算器";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(105)))), ((int)(((byte)(158)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnClear.Location = new System.Drawing.Point(602, 197);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 50);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.chkGrace);
            this.grpInput.Controls.Add(this.btnClear);
            this.grpInput.Controls.Add(this.btnCalculate);
            this.grpInput.Controls.Add(this.txtHousePrice);
            this.grpInput.Controls.Add(this.rbPercent);
            this.grpInput.Controls.Add(this.txtDownPercent);
            this.grpInput.Controls.Add(this.rdAmount);
            this.grpInput.Controls.Add(this.txtDownAmount);
            this.grpInput.Controls.Add(this.lblHousePrice);
            this.grpInput.Controls.Add(this.lblRate);
            this.grpInput.Controls.Add(this.txtRate);
            this.grpInput.Controls.Add(this.lblYears);
            this.grpInput.Controls.Add(this.txtYears);
            this.grpInput.Controls.Add(this.txtGrace);
            this.grpInput.Font = new System.Drawing.Font("Microsoft JhengHei", 16F, System.Drawing.FontStyle.Bold);
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.grpInput.Location = new System.Drawing.Point(19, 85);
            this.grpInput.Margin = new System.Windows.Forms.Padding(2);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(2);
            this.grpInput.Size = new System.Drawing.Size(720, 276);
            this.grpInput.TabIndex = 31;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(125)))), ((int)(((byte)(178)))));
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnCalculate.Location = new System.Drawing.Point(496, 197);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(83, 50);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.txtHousePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHousePrice.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.txtHousePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtHousePrice.Location = new System.Drawing.Point(172, 59);
            this.txtHousePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(165, 22);
            this.txtHousePrice.TabIndex = 0;
            this.txtHousePrice.Text = "10000000";
            // 
            // rbPercent
            // 
            this.rbPercent.AutoSize = true;
            this.rbPercent.Checked = true;
            this.rbPercent.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.rbPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.rbPercent.Location = new System.Drawing.Point(53, 103);
            this.rbPercent.Margin = new System.Windows.Forms.Padding(2);
            this.rbPercent.Name = "rbPercent";
            this.rbPercent.Size = new System.Drawing.Size(102, 25);
            this.rbPercent.TabIndex = 1;
            this.rbPercent.TabStop = true;
            this.rbPercent.Text = "自備款(%)";
            this.rbPercent.UseVisualStyleBackColor = true;
            this.rbPercent.CheckedChanged += new System.EventHandler(this.rbPercent_CheckedChanged);
            // 
            // txtDownPercent
            // 
            this.txtDownPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.txtDownPercent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDownPercent.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.txtDownPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtDownPercent.Location = new System.Drawing.Point(172, 101);
            this.txtDownPercent.Margin = new System.Windows.Forms.Padding(2);
            this.txtDownPercent.Name = "txtDownPercent";
            this.txtDownPercent.Size = new System.Drawing.Size(165, 22);
            this.txtDownPercent.TabIndex = 2;
            this.txtDownPercent.Text = "20";
            // 
            // rdAmount
            // 
            this.rdAmount.AutoSize = true;
            this.rdAmount.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.rdAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.rdAmount.Location = new System.Drawing.Point(382, 103);
            this.rdAmount.Margin = new System.Windows.Forms.Padding(2);
            this.rdAmount.Name = "rdAmount";
            this.rdAmount.Size = new System.Drawing.Size(120, 25);
            this.rdAmount.TabIndex = 3;
            this.rdAmount.Text = "自備款(金額)";
            this.rdAmount.UseVisualStyleBackColor = true;
            this.rdAmount.CheckedChanged += new System.EventHandler(this.rdAmount_CheckedChanged);
            // 
            // txtDownAmount
            // 
            this.txtDownAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.txtDownAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDownAmount.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.txtDownAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtDownAmount.Location = new System.Drawing.Point(520, 101);
            this.txtDownAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDownAmount.Name = "txtDownAmount";
            this.txtDownAmount.Size = new System.Drawing.Size(165, 22);
            this.txtDownAmount.TabIndex = 4;
            // 
            // lblHousePrice
            // 
            this.lblHousePrice.AutoSize = true;
            this.lblHousePrice.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblHousePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblHousePrice.Location = new System.Drawing.Point(49, 63);
            this.lblHousePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHousePrice.Name = "lblHousePrice";
            this.lblHousePrice.Size = new System.Drawing.Size(74, 21);
            this.lblHousePrice.TabIndex = 5;
            this.lblHousePrice.Text = "房屋總價";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblRate.Location = new System.Drawing.Point(49, 146);
            this.lblRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(100, 21);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "貨款利率(%)";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.txtRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtRate.Location = new System.Drawing.Point(172, 142);
            this.txtRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(165, 22);
            this.txtRate.TabIndex = 7;
            this.txtRate.Text = "2.15";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblYears.Location = new System.Drawing.Point(50, 186);
            this.lblYears.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(102, 21);
            this.lblYears.TabIndex = 8;
            this.lblYears.Text = "貸款年限(年)";
            // 
            // txtYears
            // 
            this.txtYears.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.txtYears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYears.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.txtYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtYears.Location = new System.Drawing.Point(172, 182);
            this.txtYears.Margin = new System.Windows.Forms.Padding(2);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(165, 22);
            this.txtYears.TabIndex = 9;
            this.txtYears.Text = "30";
            // 
            // txtGrace
            // 
            this.txtGrace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.txtGrace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrace.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.txtGrace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.txtGrace.Location = new System.Drawing.Point(172, 223);
            this.txtGrace.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrace.Name = "txtGrace";
            this.txtGrace.Size = new System.Drawing.Size(165, 22);
            this.txtGrace.TabIndex = 11;
            this.txtGrace.Text = "0";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoanAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblLoanAmount.Location = new System.Drawing.Point(51, 38);
            this.lblLoanAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(74, 21);
            this.lblLoanAmount.TabIndex = 20;
            this.lblLoanAmount.Text = "貸款總額";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblTotalPayment.Location = new System.Drawing.Point(51, 218);
            this.lblTotalPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(90, 21);
            this.lblTotalPayment.TabIndex = 25;
            this.lblTotalPayment.Text = "總還款金額";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalInterest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblTotalInterest.Location = new System.Drawing.Point(52, 182);
            this.lblTotalInterest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(90, 21);
            this.lblTotalInterest.TabIndex = 24;
            this.lblTotalInterest.Text = "總利息支出";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblLoanAmount);
            this.grpOutput.Controls.Add(this.lblLoanAmount1);
            this.grpOutput.Controls.Add(this.lblTotalPayment);
            this.grpOutput.Controls.Add(this.lblMonthlyPayment1);
            this.grpOutput.Controls.Add(this.lblTotalInterest);
            this.grpOutput.Controls.Add(this.lblFirstInterest1);
            this.grpOutput.Controls.Add(this.lblFirstPrincipal);
            this.grpOutput.Controls.Add(this.lblFirstPrincipal1);
            this.grpOutput.Controls.Add(this.lblFirstInterest);
            this.grpOutput.Controls.Add(this.lblTotalInterest1);
            this.grpOutput.Controls.Add(this.lblMonthlyPayment);
            this.grpOutput.Controls.Add(this.lblTotalPayment1);
            this.grpOutput.Font = new System.Drawing.Font("Microsoft JhengHei", 16F, System.Drawing.FontStyle.Bold);
            this.grpOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.grpOutput.Location = new System.Drawing.Point(19, 373);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(2);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(2);
            this.grpOutput.Size = new System.Drawing.Size(720, 258);
            this.grpOutput.TabIndex = 32;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "輸出";
            // 
            // lblLoanAmount1
            // 
            this.lblLoanAmount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.lblLoanAmount1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoanAmount1.Location = new System.Drawing.Point(170, 38);
            this.lblLoanAmount1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanAmount1.Name = "lblLoanAmount1";
            this.lblLoanAmount1.Size = new System.Drawing.Size(170, 20);
            this.lblLoanAmount1.TabIndex = 14;
            // 
            // lblMonthlyPayment1
            // 
            this.lblMonthlyPayment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.lblMonthlyPayment1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyPayment1.Location = new System.Drawing.Point(170, 74);
            this.lblMonthlyPayment1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonthlyPayment1.Name = "lblMonthlyPayment1";
            this.lblMonthlyPayment1.Size = new System.Drawing.Size(170, 20);
            this.lblMonthlyPayment1.TabIndex = 15;
            // 
            // lblFirstInterest1
            // 
            this.lblFirstInterest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.lblFirstInterest1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblFirstInterest1.Location = new System.Drawing.Point(170, 110);
            this.lblFirstInterest1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstInterest1.Name = "lblFirstInterest1";
            this.lblFirstInterest1.Size = new System.Drawing.Size(170, 20);
            this.lblFirstInterest1.TabIndex = 16;
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblFirstPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblFirstPrincipal.Location = new System.Drawing.Point(52, 146);
            this.lblFirstPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(74, 21);
            this.lblFirstPrincipal.TabIndex = 23;
            this.lblFirstPrincipal.Text = "首期本金";
            // 
            // lblFirstPrincipal1
            // 
            this.lblFirstPrincipal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.lblFirstPrincipal1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblFirstPrincipal1.Location = new System.Drawing.Point(170, 146);
            this.lblFirstPrincipal1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstPrincipal1.Name = "lblFirstPrincipal1";
            this.lblFirstPrincipal1.Size = new System.Drawing.Size(170, 20);
            this.lblFirstPrincipal1.TabIndex = 17;
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblFirstInterest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblFirstInterest.Location = new System.Drawing.Point(52, 110);
            this.lblFirstInterest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(74, 21);
            this.lblFirstInterest.TabIndex = 22;
            this.lblFirstInterest.Text = "首期利息";
            // 
            // lblTotalInterest1
            // 
            this.lblTotalInterest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.lblTotalInterest1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalInterest1.Location = new System.Drawing.Point(170, 182);
            this.lblTotalInterest1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalInterest1.Name = "lblTotalInterest1";
            this.lblTotalInterest1.Size = new System.Drawing.Size(170, 20);
            this.lblTotalInterest1.TabIndex = 18;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.lblMonthlyPayment.Location = new System.Drawing.Point(51, 74);
            this.lblMonthlyPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(74, 21);
            this.lblMonthlyPayment.TabIndex = 21;
            this.lblMonthlyPayment.Text = "每月還款";
            // 
            // lblTotalPayment1
            // 
            this.lblTotalPayment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.lblTotalPayment1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPayment1.Location = new System.Drawing.Point(170, 218);
            this.lblTotalPayment1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPayment1.Name = "lblTotalPayment1";
            this.lblTotalPayment1.Size = new System.Drawing.Size(170, 20);
            this.lblTotalPayment1.TabIndex = 19;
            // 
            // chkGrace
            // 
            this.chkGrace.AutoSize = true;
            this.chkGrace.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.chkGrace.Location = new System.Drawing.Point(53, 222);
            this.chkGrace.Name = "chkGrace";
            this.chkGrace.Size = new System.Drawing.Size(105, 25);
            this.chkGrace.TabIndex = 28;
            this.chkGrace.Text = "寬限期(年)";
            this.chkGrace.UseVisualStyleBackColor = true;
            // 
            // frmMortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(758, 662);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpOutput);
            this.Name = "frmMortgageCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸試算器";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMortgageCalculator_KeyDown);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.RadioButton rbPercent;
        private System.Windows.Forms.TextBox txtDownPercent;
        private System.Windows.Forms.RadioButton rdAmount;
        private System.Windows.Forms.TextBox txtDownAmount;
        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtGrace;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblLoanAmount1;
        private System.Windows.Forms.Label lblMonthlyPayment1;
        private System.Windows.Forms.Label lblFirstInterest1;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblFirstPrincipal1;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblTotalInterest1;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblTotalPayment1;
        private System.Windows.Forms.CheckBox chkGrace;
    }
}

