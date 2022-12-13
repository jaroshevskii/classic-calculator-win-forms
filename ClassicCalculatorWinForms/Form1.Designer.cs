using System.Runtime.InteropServices;

namespace ClassicCalculatorWinForms
{
  partial class Form
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(11, 36);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(268, 32);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(11, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(79, 182);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(147, 182);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(11, 146);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(79, 146);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 32);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(147, 146);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 32);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(11, 110);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 32);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(79, 110);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 32);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(147, 110);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 32);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(11, 218);
            this.button0.Margin = new System.Windows.Forms.Padding(2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(132, 32);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDot.FlatAppearance.BorderSize = 0;
            this.buttonDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDot.Location = new System.Drawing.Point(147, 218);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(64, 32);
            this.buttonDot.TabIndex = 11;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEqual.Location = new System.Drawing.Point(215, 182);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(64, 68);
            this.buttonEqual.TabIndex = 12;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(215, 146);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(64, 32);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSubtract.FlatAppearance.BorderSize = 0;
            this.buttonSubtract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubtract.Location = new System.Drawing.Point(215, 110);
            this.buttonSubtract.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(64, 32);
            this.buttonSubtract.TabIndex = 14;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMultiply.FlatAppearance.BorderSize = 0;
            this.buttonMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.Location = new System.Drawing.Point(215, 74);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(64, 32);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDivide.FlatAppearance.BorderSize = 0;
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDivide.Location = new System.Drawing.Point(147, 74);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(64, 32);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClearAll.FlatAppearance.BorderSize = 0;
            this.buttonClearAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearAll.Location = new System.Drawing.Point(79, 74);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(64, 32);
            this.buttonClearAll.TabIndex = 17;
            this.buttonClearAll.Text = "CA";
            this.buttonClearAll.UseVisualStyleBackColor = false;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(11, 74);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(64, 32);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Location = new System.Drawing.Point(11, 9);
            this.textBoxPreview.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.ReadOnly = true;
            this.textBoxPreview.Size = new System.Drawing.Size(268, 23);
            this.textBoxPreview.TabIndex = 19;
            this.textBoxPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(this.textBoxPreview);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Classic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox textBox;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button0;
    private Button buttonDot;
    private Button buttonEqual;
    private Button buttonAdd;
    private Button buttonSubtract;
    private Button buttonMultiply;
    private Button buttonDivide;
    private Button buttonClearAll;
    private Button buttonClear;
    private TextBox textBoxPreview;

    private double firstNumber = 0.0;
    private double secondNumber = 0.0;
    private string operation = "";
    private bool isFirstNumber = true;
    private bool isEqual = false;
  }
}