namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal prevNum = 0;
        string currentOperator = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void num_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            calcDisplay.Text = calcDisplay.Text + button.Text;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            //bool isTrue = !false;

            if (!calcDisplay.Text.Contains("."))
            {
                calcDisplay.Text = calcDisplay.Text + ".";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = string.Empty;
            prevNum = 0;
            currentOperator = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text.Length > 0)
            {
                calcDisplay.Text = calcDisplay.Text.Substring(0, calcDisplay.Text.Length - 1);
            }

        }

        private void operator_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var displayValue = calcDisplay.Text == "" ? "0" : calcDisplay.Text;

            //if (calcDisplay.Text == "")
            //{
            //    displayValue = "0";
            //}
            //else
            //{
            //    displayValue = calcDisplay.Text;
            //}

            try
            {
                switch (button.Text)
                {
                    case "+":
                        prevNum = prevNum + decimal.Parse(calcDisplay.Text);
                        currentOperator = "+";
                        calcDisplay.Text = string.Empty;
                        break;

                    case "-":
                        prevNum = prevNum != 0 ? (prevNum - decimal.Parse(displayValue)) : decimal.Parse(calcDisplay.Text); //Tenary conditional statement
                        currentOperator = "-";
                        calcDisplay.Text = string.Empty;
                        break;

                    case "÷":
                        prevNum = prevNum != 0 ? (prevNum / decimal.Parse(displayValue)) : decimal.Parse(calcDisplay.Text); //Tenary conditional statement
                        currentOperator = "÷";
                        calcDisplay.Text = string.Empty;
                        break;

                    case "X":
                        prevNum = prevNum != 0 ? (prevNum * decimal.Parse(displayValue)) : decimal.Parse(calcDisplay.Text); //Tenary conditional statement
                        currentOperator = "X";
                        calcDisplay.Text = string.Empty;
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void OperatorOperation()
        {
            if (prevNum != 0)
            {
                prevNum = prevNum - decimal.Parse(calcDisplay.Text);
            }
            else
            {
                prevNum = decimal.Parse(calcDisplay.Text);
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            var displayValue = calcDisplay.Text == "" ? "0" : calcDisplay.Text;
            try
            {
                switch (currentOperator)
                {
                    case "+":
                        calcDisplay.Text = (prevNum + decimal.Parse(displayValue)).ToString();
                        break;

                    case "-":
                        calcDisplay.Text = prevNum != 0 ? (prevNum - decimal.Parse(displayValue)).ToString() : decimal.Parse(calcDisplay.Text).ToString(); //Tenary conditional statement
                        break;

                    case "÷":
                        calcDisplay.Text = prevNum != 0 ? (prevNum / decimal.Parse(displayValue)).ToString() : decimal.Parse(calcDisplay.Text).ToString(); //Tenary conditional statement
                        break;

                    case "X":
                        calcDisplay.Text = prevNum != 0 ? (prevNum * decimal.Parse(displayValue)).ToString() : decimal.Parse(calcDisplay.Text).ToString(); //Tenary conditional statement
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
