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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonDot = new Button();
            buttonEqual = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonClearAll = new Button();
            buttonClear = new Button();
            textBoxPreview = new TextBox();
            textBox = new TextBox();
            buttonSQRT = new Button();
            buttonPOW = new Button();
            menuStrip1 = new MenuStrip();
            classic = new ToolStripMenuItem();
            engineering = new ToolStripMenuItem();
            formulasToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            buttonOpeningBracket = new Button();
            buttonClosingBracket = new Button();
            buttonABS = new Button();
            buttonFactorial = new Button();
            buttonPOWX = new Button();
            buttonPI = new Button();
            buttonLOG = new Button();
            buttonLOG10 = new Button();
            buttonMOD = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(9, 206);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(64, 32);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonNumber_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(77, 206);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(64, 32);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonNumber_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(145, 206);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(64, 32);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonNumber_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(9, 170);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(64, 32);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonNumber_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.FlatAppearance.BorderSize = 0;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(77, 170);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(64, 32);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonNumber_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(145, 170);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(64, 32);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonNumber_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLightLight;
            button7.FlatAppearance.BorderSize = 0;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(9, 134);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(64, 32);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonNumber_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLightLight;
            button8.FlatAppearance.BorderSize = 0;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(77, 134);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(64, 32);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonNumber_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLightLight;
            button9.FlatAppearance.BorderSize = 0;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(145, 134);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(64, 32);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttonNumber_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ControlLightLight;
            button0.FlatAppearance.BorderSize = 0;
            button0.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(9, 242);
            button0.Margin = new Padding(2);
            button0.Name = "button0";
            button0.Size = new Size(132, 32);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += buttonNumber_Click;
            // 
            // buttonDot
            // 
            buttonDot.BackColor = SystemColors.ControlLightLight;
            buttonDot.FlatAppearance.BorderColor = Color.White;
            buttonDot.FlatAppearance.BorderSize = 0;
            buttonDot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDot.Location = new Point(145, 242);
            buttonDot.Margin = new Padding(2);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(64, 32);
            buttonDot.TabIndex = 11;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += buttonNumber_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.ControlLight;
            buttonEqual.FlatAppearance.BorderSize = 0;
            buttonEqual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEqual.Location = new Point(213, 206);
            buttonEqual.Margin = new Padding(2);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(64, 68);
            buttonEqual.TabIndex = 12;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(213, 170);
            buttonAdd.Margin = new Padding(2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(64, 32);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonOperation_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.BackColor = SystemColors.ControlLight;
            buttonSubtract.FlatAppearance.BorderSize = 0;
            buttonSubtract.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubtract.Location = new Point(213, 134);
            buttonSubtract.Margin = new Padding(2);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(64, 32);
            buttonSubtract.TabIndex = 14;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += buttonOperation_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.ControlLight;
            buttonMultiply.FlatAppearance.BorderSize = 0;
            buttonMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.Location = new Point(213, 98);
            buttonMultiply.Margin = new Padding(2);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(64, 32);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonOperation_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.ControlLight;
            buttonDivide.FlatAppearance.BorderSize = 0;
            buttonDivide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivide.Location = new Point(145, 98);
            buttonDivide.Margin = new Padding(2);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(64, 32);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonOperation_Click;
            // 
            // buttonClearAll
            // 
            buttonClearAll.BackColor = SystemColors.ControlLight;
            buttonClearAll.FlatAppearance.BorderSize = 0;
            buttonClearAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClearAll.Location = new Point(77, 98);
            buttonClearAll.Margin = new Padding(2);
            buttonClearAll.Name = "buttonClearAll";
            buttonClearAll.Size = new Size(64, 32);
            buttonClearAll.TabIndex = 17;
            buttonClearAll.Text = "CA";
            buttonClearAll.UseVisualStyleBackColor = false;
            buttonClearAll.Click += buttonClearAll_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ControlLight;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(9, 98);
            buttonClear.Margin = new Padding(2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(64, 32);
            buttonClear.TabIndex = 18;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxPreview
            // 
            textBoxPreview.Location = new Point(9, 33);
            textBoxPreview.Margin = new Padding(0);
            textBoxPreview.Name = "textBoxPreview";
            textBoxPreview.ReadOnly = true;
            textBoxPreview.Size = new Size(404, 23);
            textBoxPreview.TabIndex = 19;
            textBoxPreview.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.ControlLightLight;
            textBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(9, 60);
            textBox.Margin = new Padding(2, 4, 2, 4);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(404, 32);
            textBox.TabIndex = 0;
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // buttonSQRT
            // 
            buttonSQRT.BackColor = SystemColors.ControlLight;
            buttonSQRT.FlatAppearance.BorderSize = 0;
            buttonSQRT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSQRT.Location = new Point(9, 278);
            buttonSQRT.Margin = new Padding(2);
            buttonSQRT.Name = "buttonSQRT";
            buttonSQRT.Size = new Size(132, 32);
            buttonSQRT.TabIndex = 20;
            buttonSQRT.Text = "sqrt";
            buttonSQRT.UseVisualStyleBackColor = false;
            buttonSQRT.Click += buttonSQRT_Click;
            // 
            // buttonPOW
            // 
            buttonPOW.BackColor = SystemColors.ControlLight;
            buttonPOW.FlatAppearance.BorderSize = 0;
            buttonPOW.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPOW.Location = new Point(145, 278);
            buttonPOW.Margin = new Padding(2);
            buttonPOW.Name = "buttonPOW";
            buttonPOW.Size = new Size(132, 32);
            buttonPOW.TabIndex = 21;
            buttonPOW.Text = "pow2";
            buttonPOW.UseVisualStyleBackColor = false;
            buttonPOW.Click += buttonPOW_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { classic, engineering, formulasToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(422, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // classic
            // 
            classic.Name = "classic";
            classic.Size = new Size(55, 20);
            classic.Text = "Classic";
            classic.Click += classic_Click;
            // 
            // engineering
            // 
            engineering.Name = "engineering";
            engineering.Size = new Size(82, 20);
            engineering.Text = "Engineering";
            engineering.Click += engineering_Click;
            // 
            // formulasToolStripMenuItem
            // 
            formulasToolStripMenuItem.Name = "formulasToolStripMenuItem";
            formulasToolStripMenuItem.Size = new Size(68, 20);
            formulasToolStripMenuItem.Text = "Formulas";
            formulasToolStripMenuItem.Click += formulasToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // buttonOpeningBracket
            // 
            buttonOpeningBracket.BackColor = SystemColors.ControlLight;
            buttonOpeningBracket.FlatAppearance.BorderSize = 0;
            buttonOpeningBracket.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpeningBracket.Location = new Point(281, 98);
            buttonOpeningBracket.Margin = new Padding(2);
            buttonOpeningBracket.Name = "buttonOpeningBracket";
            buttonOpeningBracket.Size = new Size(64, 32);
            buttonOpeningBracket.TabIndex = 23;
            buttonOpeningBracket.Text = "(";
            buttonOpeningBracket.UseVisualStyleBackColor = false;
            buttonOpeningBracket.Click += buttonOpeningBracket_Click;
            // 
            // buttonClosingBracket
            // 
            buttonClosingBracket.BackColor = SystemColors.ControlLight;
            buttonClosingBracket.FlatAppearance.BorderSize = 0;
            buttonClosingBracket.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClosingBracket.Location = new Point(349, 98);
            buttonClosingBracket.Margin = new Padding(2);
            buttonClosingBracket.Name = "buttonClosingBracket";
            buttonClosingBracket.Size = new Size(64, 32);
            buttonClosingBracket.TabIndex = 24;
            buttonClosingBracket.Text = ")";
            buttonClosingBracket.UseVisualStyleBackColor = false;
            buttonClosingBracket.Click += buttonClosingBracket_Click;
            // 
            // buttonABS
            // 
            buttonABS.BackColor = SystemColors.ControlLight;
            buttonABS.FlatAppearance.BorderSize = 0;
            buttonABS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonABS.Location = new Point(281, 134);
            buttonABS.Margin = new Padding(2);
            buttonABS.Name = "buttonABS";
            buttonABS.Size = new Size(64, 32);
            buttonABS.TabIndex = 25;
            buttonABS.Text = "abs";
            buttonABS.UseVisualStyleBackColor = false;
            buttonABS.Click += buttonABS_Click;
            // 
            // buttonFactorial
            // 
            buttonFactorial.BackColor = SystemColors.ControlLight;
            buttonFactorial.FlatAppearance.BorderSize = 0;
            buttonFactorial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFactorial.Location = new Point(349, 134);
            buttonFactorial.Margin = new Padding(2);
            buttonFactorial.Name = "buttonFactorial";
            buttonFactorial.Size = new Size(64, 32);
            buttonFactorial.TabIndex = 26;
            buttonFactorial.Text = "x!";
            buttonFactorial.UseVisualStyleBackColor = false;
            buttonFactorial.Click += buttonFactorial_Click;
            // 
            // buttonPOWX
            // 
            buttonPOWX.BackColor = SystemColors.ControlLight;
            buttonPOWX.FlatAppearance.BorderSize = 0;
            buttonPOWX.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPOWX.Location = new Point(281, 170);
            buttonPOWX.Margin = new Padding(2);
            buttonPOWX.Name = "buttonPOWX";
            buttonPOWX.Size = new Size(64, 32);
            buttonPOWX.TabIndex = 27;
            buttonPOWX.Text = "pow";
            buttonPOWX.UseVisualStyleBackColor = false;
            buttonPOWX.Click += buttonPOWX_Click;
            // 
            // buttonPI
            // 
            buttonPI.BackColor = SystemColors.ControlLight;
            buttonPI.FlatAppearance.BorderSize = 0;
            buttonPI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPI.Location = new Point(349, 170);
            buttonPI.Margin = new Padding(2);
            buttonPI.Name = "buttonPI";
            buttonPI.Size = new Size(64, 32);
            buttonPI.TabIndex = 28;
            buttonPI.Text = "pi";
            buttonPI.UseVisualStyleBackColor = false;
            buttonPI.Click += buttonPI_Click;
            // 
            // buttonLOG
            // 
            buttonLOG.BackColor = SystemColors.ControlLight;
            buttonLOG.FlatAppearance.BorderSize = 0;
            buttonLOG.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLOG.Location = new Point(281, 206);
            buttonLOG.Margin = new Padding(2);
            buttonLOG.Name = "buttonLOG";
            buttonLOG.Size = new Size(132, 32);
            buttonLOG.TabIndex = 29;
            buttonLOG.Text = "log";
            buttonLOG.UseVisualStyleBackColor = false;
            buttonLOG.Click += buttonLOG_Click;
            // 
            // buttonLOG10
            // 
            buttonLOG10.BackColor = SystemColors.ControlLight;
            buttonLOG10.FlatAppearance.BorderSize = 0;
            buttonLOG10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLOG10.Location = new Point(281, 242);
            buttonLOG10.Margin = new Padding(2);
            buttonLOG10.Name = "buttonLOG10";
            buttonLOG10.Size = new Size(132, 32);
            buttonLOG10.TabIndex = 30;
            buttonLOG10.Text = "log10";
            buttonLOG10.UseVisualStyleBackColor = false;
            buttonLOG10.Click += buttonLOG10_Click;
            // 
            // buttonMOD
            // 
            buttonMOD.BackColor = SystemColors.ControlLight;
            buttonMOD.FlatAppearance.BorderSize = 0;
            buttonMOD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMOD.Location = new Point(281, 278);
            buttonMOD.Margin = new Padding(2);
            buttonMOD.Name = "buttonMOD";
            buttonMOD.Size = new Size(132, 32);
            buttonMOD.TabIndex = 31;
            buttonMOD.Text = "mod";
            buttonMOD.UseVisualStyleBackColor = false;
            buttonMOD.Click += buttonOperation_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlLight;
            button10.FlatAppearance.BorderSize = 0;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(9, 98);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(132, 32);
            button10.TabIndex = 32;
            button10.Text = "( a + b )²";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ControlLight;
            button11.FlatAppearance.BorderSize = 0;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(145, 98);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(132, 32);
            button11.TabIndex = 33;
            button11.Text = "( a - b )²";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ControlLight;
            button12.FlatAppearance.BorderSize = 0;
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(9, 134);
            button12.Margin = new Padding(2);
            button12.Name = "button12";
            button12.Size = new Size(132, 32);
            button12.TabIndex = 34;
            button12.Text = "( a + b )³";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ControlLight;
            button13.FlatAppearance.BorderSize = 0;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(145, 134);
            button13.Margin = new Padding(2);
            button13.Name = "button13";
            button13.Size = new Size(132, 32);
            button13.TabIndex = 35;
            button13.Text = "( a - b )³";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ControlLight;
            button14.FlatAppearance.BorderSize = 0;
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(9, 170);
            button14.Margin = new Padding(2);
            button14.Name = "button14";
            button14.Size = new Size(132, 32);
            button14.TabIndex = 36;
            button14.Text = "a³ + b³";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ControlLight;
            button15.FlatAppearance.BorderSize = 0;
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(145, 170);
            button15.Margin = new Padding(2);
            button15.Name = "button15";
            button15.Size = new Size(132, 32);
            button15.TabIndex = 37;
            button15.Text = "a³ - b³";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(422, 319);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(buttonMOD);
            Controls.Add(buttonLOG10);
            Controls.Add(buttonLOG);
            Controls.Add(buttonPI);
            Controls.Add(buttonPOWX);
            Controls.Add(buttonFactorial);
            Controls.Add(buttonABS);
            Controls.Add(buttonClosingBracket);
            Controls.Add(buttonOpeningBracket);
            Controls.Add(buttonPOW);
            Controls.Add(buttonSQRT);
            Controls.Add(textBoxPreview);
            Controls.Add(buttonClear);
            Controls.Add(buttonClearAll);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEqual);
            Controls.Add(buttonDot);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form";
            Text = "Classic Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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

        private TextBox textBox;
        private Button buttonSQRT;
        private Button buttonPOW;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem classic;
        private ToolStripMenuItem engineering;
        private Button buttonOpeningBracket;
        private Button buttonClosingBracket;
        private Button buttonABS;
        private Button buttonFactorial;
        private Button buttonPOWX;
        private Button buttonPI;
        private Button buttonLOG;
        private Button buttonLOG10;
        private Button buttonMOD;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem formulasToolStripMenuItem;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
    }
}