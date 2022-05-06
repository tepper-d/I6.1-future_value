namespace FutureValue
{
    public partial class FutureValue : Form
    {
        public FutureValue()
        {
            InitializeComponent();
        }

        /* ******************************************************
        * Exercise 6-1 Develop the Future Value application     *
        * Murach C# 7th ed, Chapter 6: How to code methods      *
        *                and event handlers                     *
        *       Form design: pg.157                             *
        *       Base code: pg. 159 (modified for Exercise 5-1)  *
        *       Exercise Instructions: pg. 192                  *
        * CIS 123: Introduction to Object-Oriented Programming  *
        * Dominique Tepper, 05MAY2022                           *
        * ******************************************************/

        // Step 4. Reverted code to original for 6-1 Part 2
        // Step 5. Add the CalculateFutureValue() method without using refactoring
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = (yearlyInterestRate / 12) / 100;

            
            // Calls CalculateFutureValue using a statement that passes args
            // for 3 required parameters in the new method 
            decimal futureValue = this.CalculateFutureValue(monthlyInvestment, months, monthlyInterestRate);

/****************************************************************************************************************
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            } 
****************************************************************************************************************/

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        // CalculateFutureValue args match parameters and their order in the call CFV statement
        // in the btnCalculate_Click method
        private decimal CalculateFutureValue(decimal monthlyInvestment, int months, decimal monthlyInterestRate)
        {
            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }     

    private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // New event handler created from the textbox Events Properties
        // Clears the FV textbox when MonthlyInvestment,
        // Yearly Interest Rate, or # of Years are changed
        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }
    }
}