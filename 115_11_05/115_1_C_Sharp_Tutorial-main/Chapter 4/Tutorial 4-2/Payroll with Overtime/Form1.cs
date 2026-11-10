using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        //建架構:初始化表單與元件
        public Form1()
        {
            InitializeComponent();
        }

        //按下「計算總薪資」按鈕時觸發

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int BASE_HOURS = 40; //基本工時
            const decimal OVERTIME_RATE = 1.5m; //加班費率
            decimal hoursWorked; // 工作時數
            decimal hourlyPayRate; // 時薪
            decimal grossPay; // 總薪資

            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text); // 取得工作時數
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);// 取得時薪

                // 計算總薪資 
                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate; // 未加班

                }
                else
                {
                    decimal overtimeHours = hoursWorked - BASE_HOURS; // 計算加班時數
                    grossPay = (BASE_HOURS * hourlyPayRate) + (overtimeHours * hourlyPayRate * OVERTIME_RATE); // 計算總薪資
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
