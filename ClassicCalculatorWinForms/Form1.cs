namespace ClassicCalculatorWinForms
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button number = (Button)sender;
                if (number.Text == "." && textBox.Text.Contains("."))
                {
                    return;
                }
                textBox.Text += number.Text;
            }
        }
        private void buttonOperation_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button operation = (Button)sender;
                if (isFirstNumber)
                {
                    isFirstNumber = false;
                    this.operation = operation.Text;

                    if (textBox.Text == "")
                    {
                        textBox_TextChanged(sender, e);
                    }
                    else
                    {
                        textBox.Text = "";
                    }
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "NaN" || textBox.Text == "∞")
            {
                firstNumber = 0.0;
                textBox.Text = $"{firstNumber}";
                return;
            }

            if (isEqual)
            {
                isEqual = false;
                return;
            }

            if (isFirstNumber)
            {
                if (textBox.Text == "")
                {
                    textBoxPreview.Text = "";
                    return;
                }
                else
                {
                    firstNumber = double.Parse(textBox.Text);
                }

                textBoxPreview.Text = $"{firstNumber}";
            }
            else
            {
                if (textBox.Text == "")
                {
                    textBoxPreview.Text = $"{firstNumber} {operation}";
                    return;
                }
                else
                {
                    secondNumber = double.Parse(textBox.Text);
                }
                textBoxPreview.Text = $"{firstNumber} {operation} {secondNumber}";
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (textBoxPreview.Text == "")
            {
                return;
            }

            if (textBox.Text == "")
            {
                if (!isFirstNumber)
                {
                    operation = "";
                    isFirstNumber = true;
                }

                textBox.Text = $"{firstNumber}";
            }
            else
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBoxPreview.Text = "";

            firstNumber = 0.0;
            secondNumber = 0.0;
            operation = "";
            isFirstNumber = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (!isFirstNumber && textBox.Text != "")
            {
                isEqual = true;

                switch (operation)
                {
                    case "+": firstNumber += secondNumber; break;
                    case "-": firstNumber -= secondNumber; break;
                    case "*": firstNumber *= secondNumber; break;
                    case "/": firstNumber /= secondNumber; break;
                }

                secondNumber = 0.0;
                operation = "";
                isFirstNumber = true;

                textBoxPreview.Text += $" = {firstNumber}";
                textBox.Text = $"{firstNumber}";
            }
        }
    }
}