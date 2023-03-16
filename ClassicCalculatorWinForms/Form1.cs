using System.Data;
using System.Resources.Extensions;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ClassicCalculatorWinForms
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool isExpretionMode = false;

        private double ParseDouble(string text)
        {
            try { return double.Parse(text); }
            catch { return 0.0; }
        }

        public Form()
        {
            InitializeComponent();
            setupClassic();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button number = (Button)sender;
                if (isExpretionMode)
                {
                    textBoxPreview.Text += number.Text;
                    textBox.Text = textBoxPreview.Text;
                    return;
                }

                if (number.Text == "." && (textBox.Text == "" || textBox.Text.Contains(".")))
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
                if (isExpretionMode)
                {
                    textBoxPreview.Text += operation.Text;
                    textBox.Text = textBoxPreview.Text;
                    return;
                }
                if (operation.Text == "-" && textBox.Text == "")
                {
                    textBox.Text = "-";
                    return;
                }
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
            if (isExpretionMode) { return; }

            if (!isFirstNumber && operation == "")
            {
                secondNumber = ParseDouble(textBox.Text);
                if (textBoxPreview.Text.StartsWith("pow"))
                {
                    textBoxPreview.Text = $"pow({firstNumber}, {secondNumber})";
                    return;
                }
            }

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
                    firstNumber = ParseDouble(textBox.Text);
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
                    secondNumber = ParseDouble(textBox.Text);
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
            if (isExpretionMode)
            {
                textBoxPreview.Text = textBoxPreview.Text.Remove(textBoxPreview.Text.Length - 1);
                textBox.Text = textBoxPreview.Text;
                if (textBoxPreview.Text == "")
                {
                    enableButtomsForExpretionMode();
                    isExpretionMode = false;
                }
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
            isExpretionMode = false;
            enableButtomsForExpretionMode();
        }

        private double Evaluate(string expression)
        {
            try
            {
                var loDataTable = new DataTable();
                var loDataColumn = new DataColumn("Eval", typeof(double), expression);
                loDataTable.Columns.Add(loDataColumn);
                loDataTable.Rows.Add(0);
                return (double)(loDataTable.Rows[0]["Eval"]);
            }
            catch { return Double.NaN; }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (isExpretionMode)
            {
                enableButtomsForExpretionMode();

                isEqual = true;

                firstNumber = Evaluate(textBoxPreview.Text);

                secondNumber = 0.0;
                operation = "";
                isFirstNumber = true;
                isExpretionMode = false;

                textBoxPreview.Text += $"={firstNumber}";
                textBox.Text = $"{firstNumber}";
            }
            if (!isFirstNumber && textBox.Text != "")
            {
                isEqual = true;
                if (operation == "")
                {
                    if (textBoxPreview.Text.StartsWith("pow"))
                    {
                        firstNumber = Math.Pow(firstNumber, secondNumber);
                    }
                }
                else
                {
                    switch (operation)
                    {
                        case "+": firstNumber += secondNumber; break;
                        case "-": firstNumber -= secondNumber; break;
                        case "*": firstNumber *= secondNumber; break;
                        case "/": firstNumber /= secondNumber; break;
                        case "mod": firstNumber = firstNumber % secondNumber; break;
                    }
                }

                secondNumber = 0.0;
                operation = "";
                isFirstNumber = true;

                textBoxPreview.Text += $" = {firstNumber}";
                textBox.Text = $"{firstNumber}";
            }
        }

        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            if (isFirstNumber && textBox.Text != "")
            {
                double number = ParseDouble(textBox.Text);
                double result = Math.Sqrt(number);
                textBox.Text = $"{result}";
                textBoxPreview.Text = $"sqrt({number}) = {result}";
                operation = "";
            }
        }

        private void buttonPOW_Click(object sender, EventArgs e)
        {
            if (isFirstNumber && textBox.Text != "")
            {
                double number = ParseDouble(textBox.Text);
                double result = Math.Pow(number, 2);
                textBox.Text = $"{result}";
                textBoxPreview.Text = $"pow2({number}) = {result}";
                operation = "";
            }
        }
        private void classic_Click(object sender, EventArgs e) { setupClassic(); }

        private void engineering_Click(object sender, EventArgs e) { setupEngineering(); }

        private void enableAllButtomsFromClassic()
        {
            button0.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;

            buttonDot.Visible = true;
            buttonClear.Visible = true;
            buttonClearAll.Visible = true;
            buttonDivide.Visible = true;
            buttonMultiply.Visible = true;
            buttonAdd.Visible = true;
            buttonSubtract.Visible = true;
            buttonEqual.Visible = true;

            buttonPOW.Visible = true;
            buttonSQRT.Visible = true;
        }

        private void disableAllButtomsFromClassic()
        {
            button0.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            buttonDot.Visible = false;
            buttonClear.Visible = false;
            buttonClearAll.Visible = false;
            buttonDivide.Visible = false;
            buttonMultiply.Visible = false;
            buttonAdd.Visible = false;
            buttonSubtract.Visible = false;
            buttonEqual.Visible = false;

            buttonPOW.Visible = false;
            buttonSQRT.Visible = false;
        }

        private void enableFormulasButtonms()
        {
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
        }

        private void disableFormulasButtonms()
        {
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
        }

        private void formulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(302, 250);
            textBoxPreview.Size = new Size(268, textBoxPreview.Size.Height);
            textBox.Size = new Size(268, textBox.Size.Height);

            buttonOpeningBracket.Visible = false;
            buttonABS.Visible = false;
            buttonPOWX.Visible = false;
            buttonLOG.Visible = false;
            buttonLOG10.Visible = false;
            buttonMOD.Visible = false;

            textBox.Text = "";
            textBoxPreview.Text = "";

            firstNumber = 0.0;
            secondNumber = 0.0;
            operation = "";
            isFirstNumber = true;
            isExpretionMode = false;

            disableAllButtomsFromClassic();
            enableFormulasButtonms();
            isExpretionMode = true;
        }

        private void setupClassic()
        {
            Size = new Size(302, 358);
            textBoxPreview.Size = new Size(268, textBoxPreview.Size.Height);
            textBox.Size = new Size(268, textBox.Size.Height);

            buttonOpeningBracket.Visible = false;
            buttonABS.Visible = false;
            buttonPOWX.Visible = false;
            buttonLOG.Visible = false;
            buttonLOG10.Visible = false;
            buttonMOD.Visible = false;

            textBox.Text = "";
            textBoxPreview.Text = "";

            firstNumber = 0.0;
            secondNumber = 0.0;
            operation = "";
            isFirstNumber = true;
            isExpretionMode = false;

            enableButtomsForExpretionMode();
            enableAllButtomsFromClassic();
            disableFormulasButtonms();
        }

        private void setupEngineering()
        {
            Size = new Size(438, 358);
            textBoxPreview.Size = new Size(404, textBoxPreview.Size.Height);
            textBox.Size = new Size(404, textBox.Size.Height);

            buttonOpeningBracket.Visible = true;
            buttonABS.Visible = true;
            buttonPOWX.Visible = true;
            buttonLOG.Visible = true;
            buttonLOG10.Visible = true;
            buttonMOD.Visible = true;

            textBox.Text = "";
            textBoxPreview.Text = "";

            firstNumber = 0.0;
            secondNumber = 0.0;
            operation = "";
            isFirstNumber = true;
            isExpretionMode = false;

            enableButtomsForExpretionMode();
            enableAllButtomsFromClassic();
            disableFormulasButtonms();
        }

        private void buttonABS_Click(object sender, EventArgs e)
        {
            if (isFirstNumber && textBox.Text != "")
            {
                double number = ParseDouble(textBox.Text);
                double result = Math.Abs(number);
                textBox.Text = $"{result}";
                textBoxPreview.Text = $"abs({number}) = {result}";
                operation = "";
            }
        }

        private long CalculateFactorial(int number)
        {
            return number < 2 ? 1 : number * CalculateFactorial(number - 1);
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            if (isFirstNumber && textBox.Text != "")
            {
                double number = ParseDouble(textBox.Text);
                double result = CalculateFactorial((int)number);
                textBox.Text = $"{result}";
                textBoxPreview.Text = $"{number}! = {result}";
                operation = "";
            }
        }

        private void buttonPOWX_Click(object sender, EventArgs e)
        {
            if (isFirstNumber && textBox.Text != "")
            {
                firstNumber = ParseDouble(textBox.Text);
                textBox.Text = "";
                textBoxPreview.Text = $"pow({firstNumber}, x)";
                operation = "";
                isFirstNumber = false;
            }
        }

        private void buttonPI_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "" || textBox.Text == "-")
            {
                textBox.Text += $"{Math.PI}";
            }
            if (isExpretionMode) { Braket($"{Math.PI}"); }
        }

        private void buttonLOG_Click(object sender, EventArgs e)
        {
            if (isFirstNumber && textBox.Text != "")
            {
                double number = ParseDouble(textBox.Text);
                double result = Math.Log(number);
                textBox.Text = $"{result}";
                textBoxPreview.Text = $"log({number}) = {result}";
                operation = "";
            }
        }

        private void buttonLOG10_Click(object sender, EventArgs e)
        {
            if (isFirstNumber && textBox.Text != "")
            {
                double number = ParseDouble(textBox.Text);
                double result = Math.Log10(number);
                textBox.Text = $"{result}";
                textBoxPreview.Text = $"log10({number}) = {result}";
                operation = "";
            }
        }

        void disableButtomsForExpretionMode()
        {
            buttonSQRT.Enabled = false;
            buttonPOW.Enabled = false;
            buttonABS.Enabled = false;
            buttonFactorial.Enabled = false;
            buttonPOWX.Enabled = false;
            buttonLOG.Enabled = false;
            buttonLOG10.Enabled = false;
            buttonMOD.Enabled = false;
        }

        void enableButtomsForExpretionMode()
        {
            buttonSQRT.Enabled = true;
            buttonPOW.Enabled = true;
            buttonABS.Enabled = true;
            buttonFactorial.Enabled = true;
            buttonPOWX.Enabled = true;
            buttonLOG.Enabled = true;
            buttonLOG10.Enabled = true;
            buttonMOD.Enabled = true;
        }

        void Braket(string braketText)
        {
            if (operation != "mod")
            {
                disableButtomsForExpretionMode();

                if (textBoxPreview.Text.Contains("="))
                {
                    textBoxPreview.Text = textBox.Text;
                }

                isExpretionMode = true;
                textBoxPreview.Text = textBoxPreview.Text.Replace(" ", "") + braketText;
                textBox.Text = textBoxPreview.Text;
            }
        }

        private void buttonOpeningBracket_Click(object sender, EventArgs e)
        {
            Braket("(");
        }

        private void buttonClosingBracket_Click(object sender, EventArgs e)
        {
            Braket(")");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "                       Classic Calculator\n" +
                "\n\n" +
                "   Developer: Sasha Jaroshevskii\n" +
                "   GitHub: https://github.com/jaroshevskii", "About");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxPreview.Text = $"(a + b)² = a² + 2ab + b²";
            textBox.Text = $"a² + 2ab + b²";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxPreview.Text = $"(a - b)² = a² - 2ab + b²";
            textBox.Text = $"a² - 2ab + b²";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxPreview.Text = $"(a + b)³ = a³ + 3a³b + 3ab³ + b³";
            textBox.Text = $"a³ + 3a³b + 3ab³ + b³";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxPreview.Text = $"(a - b)³ = a³ - 3a³b + 3ab³ - b³";
            textBox.Text = $"a³ - 3a³b + 3ab³ - b³";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxPreview.Text = $"a³ + b³ = ( a + b )( a² - ab + b²)";
            textBox.Text = $"( a + b )( a² - ab + b²)";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxPreview.Text = $"a³ - b³ = ( a - b )( a² + ab + b²)";
            textBox.Text = $"( a - b )( a² + ab + b²)";
        }
    }
}