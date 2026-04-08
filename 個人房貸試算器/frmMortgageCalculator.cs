using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 個人房貸試算器
{
    public partial class frmMortgageCalculator : Form
    {
        public frmMortgageCalculator()
        {
            InitializeComponent();

            //輸入限制
            txtHousePrice.KeyPress += OnlyNumber_KeyPress;
            txtRate.KeyPress += OnlyNumber_KeyPress;
            txtYears.KeyPress += OnlyInteger_KeyPress;
            txtGrace.KeyPress += OnlyInteger_KeyPress;
            txtDownPercent.KeyPress += OnlyNumber_KeyPress;
            txtDownAmount.KeyPress += OnlyNumber_KeyPress;

            this.KeyPreview = true;

            this.AcceptButton = btnCalculate;

            chkGrace.CheckedChanged += ChkGrace_CheckedChanged;
            txtGrace.Enabled = false; // 預設不可輸入
        }

        //小數輸入限制
        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            //避免輸入超過一個小數點
            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //整數輸入限制
        private void OnlyInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void ShowError(string msg, Control ctrl = null)
        {
            MessageBox.Show(msg, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (ctrl != null)
            {
                ctrl.Focus();

                if (ctrl is TextBox tb)
                {
                    tb.SelectAll();
                }
            }
        }

        private bool TryGetDouble(TextBox txt, string name, out double value, double min = double.MinValue, double max = double.MaxValue)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                ShowError($"{name}不可為空", txt);
                return false;
            }

            if (!double.TryParse(txt.Text, out value))
            {
                ShowError($"{name}格式錯誤", txt);
                return false;
            }

            if (value < min || value > max)
            {
                ShowError($"{name}需介於 {min} ~ {max}", txt);
                return false;
            }

            return true;
        }

        private bool TryGetInt(TextBox txt, string name, out int value, int min = int.MinValue, int max = int.MaxValue)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                ShowError($"{name}不可為空", txt);
                return false;
            }

            if (!int.TryParse(txt.Text, out value))
            {
                ShowError($"{name}格式錯誤", txt);
                return false;
            }

            if (value < min || value > max)
            {
                ShowError($"{name}需介於 {min} ~ {max}", txt);
                return false;
            }

            return true;
        }

        //計算
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double housePrice, rate;
            int years, graceYears = 0;

            if (!TryGetDouble(txtHousePrice, "房價", out housePrice, 1)) return;
            if (!TryGetDouble(txtRate, "利率", out rate, 0.01, 100)) return;
            if (!TryGetInt(txtYears, "貸款年數", out years, 1, 100)) return;
            if (chkGrace.Checked)
            {
                if (!TryGetInt(txtGrace, "寬限期", out graceYears, 0, 100)) return;
                if (graceYears > years)
                {
                    ShowError("寬限期不能大於貸款年數", txtGrace);
                    return;
                }
            }

            rate /= 100.0;

            double downPayment = 0;

            if (rbPercent.Checked)
            {
                double percent;
                if (!TryGetDouble(txtDownPercent, "自備款%", out percent, 0, 100)) return;

                downPayment = housePrice * (percent / 100.0);
            }
            else
            {
                if (!TryGetDouble(txtDownAmount, "自備款金額", out downPayment, 0)) return;
            }

            if (downPayment >= housePrice)
            {
                ShowError("自備款不能 >= 房價",
                    rbPercent.Checked ? txtDownPercent : txtDownAmount);
                return;
            }

            double loanAmount = housePrice - downPayment;

            double monthlyRate = rate / 12.0;
            int totalMonths = years * 12;
            int graceMonths = graceYears * 12;

            double monthlyPayment = 0;
            double totalInterest = 0;

            if (graceMonths > 0)
            {
                double graceInterest = loanAmount * monthlyRate * graceMonths;
                int remainingMonths = totalMonths - graceMonths;

                if (remainingMonths <= 0)
                {
                    monthlyPayment = 0;
                    totalInterest = graceInterest;
                }
                else
                {
                    double normalPayment = loanAmount *
                        monthlyRate *
                        Math.Pow(1 + monthlyRate, remainingMonths) /
                        (Math.Pow(1 + monthlyRate, remainingMonths) - 1);

                    monthlyPayment = normalPayment;
                    totalInterest = graceInterest + (normalPayment * remainingMonths - loanAmount);
                }
            }
            else
            {
                monthlyPayment = loanAmount *
                    monthlyRate *
                    Math.Pow(1 + monthlyRate, totalMonths) /
                    (Math.Pow(1 + monthlyRate, totalMonths) - 1);

                totalInterest = monthlyPayment * totalMonths - loanAmount;
            }

            double firstInterest = loanAmount * monthlyRate;
            double firstPrincipal = monthlyPayment > 0 ? monthlyPayment - firstInterest : 0;
            double totalPayment = loanAmount + totalInterest;

            lblLoanAmount1.Text = loanAmount.ToString("N2");
            lblMonthlyPayment1.Text = monthlyPayment.ToString("N2");
            lblFirstInterest1.Text = firstInterest.ToString("N2");
            lblFirstPrincipal1.Text = firstPrincipal.ToString("N2");
            lblTotalInterest1.Text = totalInterest.ToString("N2");
            lblTotalPayment1.Text = totalPayment.ToString("N2");
        }

        //RadioButton
        private void rdAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAmount.Checked)
            {
                txtDownPercent.Text = "";
                txtDownAmount.Focus();
            }
        }
        private void rbPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPercent.Checked)
            {
                txtDownAmount.Text = "";
                txtDownPercent.Focus();
            }
        }

        //鍵盤控制
        private void frmMortgageCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            // Esc 清除
            if (e.KeyCode == Keys.Escape)
            {
                Clear();
                e.Handled = true;
                return;
            }
            //左右鍵控制
            if (e.KeyCode == Keys.Right)
            {
                rdAmount.Checked = true;
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                rbPercent.Checked = true;
                e.Handled = true;
            }
            // 上下鍵控制
            if (e.KeyCode == Keys.Up)
            {
                if (ActiveControl == txtHousePrice)
                {
                    // 最上面不動
                }
                else if (ActiveControl == txtDownPercent || ActiveControl == txtDownAmount)
                {
                    txtHousePrice.Focus();
                }
                else if (ActiveControl == txtRate)
                {
                    if (rbPercent.Checked)
                    {
                        txtDownPercent.Focus();
                    }
                    else
                    {
                        txtDownAmount.Focus();
                    }
                }
                else if (ActiveControl == txtYears)
                {
                    txtRate.Focus();
                }
                else if (ActiveControl == txtGrace)
                {
                    txtYears.Focus();
                }

                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (ActiveControl == txtHousePrice)
                {
                    if (rbPercent.Checked)
                    {
                        txtDownPercent.Focus();
                    }
                    else
                    {
                        txtDownAmount.Focus();
                    }
                }
                else if (ActiveControl == txtDownPercent || ActiveControl == txtDownAmount)
                {
                    txtRate.Focus();
                }
                else if (ActiveControl == txtRate)
                {
                    txtYears.Focus();
                }
                else if (ActiveControl == txtYears)
                {
                    if (chkGrace.Checked)
                        txtGrace.Focus();
                    // 否則不動或跳下一格
                }
                else if (ActiveControl == txtGrace)
                {
                    // 最下面不動
                }
                e.Handled = true;
            }
        }
        private void Clear()
        {
            txtHousePrice.Text = "";
            txtDownPercent.Text = "";
            txtDownAmount.Text = "";
            txtRate.Text = "";
            txtYears.Text = "";
            txtGrace.Text = "";

            // 清除結果
            lblLoanAmount1.Text = "";
            lblMonthlyPayment1.Text = "";
            lblFirstInterest1.Text = "";
            lblFirstPrincipal1.Text = "";
            lblTotalInterest1.Text = "";
            lblTotalPayment1.Text = "";

            // 游標回到第一格
            txtHousePrice.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void ChkGrace_CheckedChanged(object sender, EventArgs e)
        {
            txtGrace.Enabled = chkGrace.Checked;

            if (chkGrace.Checked)
            {
                txtGrace.Focus();
            }
            else
            {
                txtGrace.Text = ""; // 清空輸入
            }
        }
    }
}