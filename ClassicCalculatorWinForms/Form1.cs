namespace ClassicCalculatorWinForms
{
  public partial class Form : System.Windows.Forms.Form
  {
    public Form()
    {
      InitializeComponent();
    }

    private void Form_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox.Text += "1";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox.Text += "2";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      textBox.Text += "3";
    }

    private void button4_Click(object sender, EventArgs e)
    {
      textBox.Text += "4";
    }

    private void button5_Click(object sender, EventArgs e)
    {
      textBox.Text += "5";
    }

    private void button6_Click(object sender, EventArgs e)
    {
      textBox.Text += "6";
    }

    private void button7_Click(object sender, EventArgs e)
    {
      textBox.Text += "7";
    }

    private void button8_Click(object sender, EventArgs e)
    {
      textBox.Text += "8";
    }

    private void button9_Click(object sender, EventArgs e)
    {
      textBox.Text += "9";
    }

    private void button0_Click(object sender, EventArgs e)
    {
      textBox.Text += "0";
    }

    private void buttonDot_Click(object sender, EventArgs e)
    {
      textBox.Text += ".";
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

    private void setOpetation(string operation, object sender, EventArgs e)
    {
      if (isFirstNumber)
      {
        isFirstNumber = false;
        this.operation = operation;

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

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      setOpetation("+", sender, e);
    }

    private void buttonSubtract_Click(object sender, EventArgs e)
    {
      setOpetation("-", sender, e);
    }

    private void buttonMultiply_Click(object sender, EventArgs e)
    {
      setOpetation("*", sender, e);
    }

    private void buttonDivide_Click(object sender, EventArgs e)
    {
      setOpetation("/", sender, e);
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

    private void textBoxPreview_TextChanged(object sender, EventArgs e)
    {

    }
  }
}