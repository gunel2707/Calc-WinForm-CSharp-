namespace WinFormsApp1
{
    partial class Form1
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
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnMulti = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnDiv = new Button();
            btnSqrt = new Button();
            btnZero = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtTotal.Location = new Point(24, 30);
            txtTotal.Margin = new Padding(6, 4, 6, 4);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(668, 87);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(192, 255, 255);
            btn1.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn1.Location = new Point(24, 135);
            btn1.Margin = new Padding(6, 4, 6, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(124, 96);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(192, 255, 255);
            btn2.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn2.Location = new Point(160, 135);
            btn2.Margin = new Padding(6, 4, 6, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(124, 96);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(192, 255, 255);
            btn3.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn3.Location = new Point(296, 135);
            btn3.Margin = new Padding(6, 4, 6, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(124, 96);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(192, 255, 255);
            btn6.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn6.Location = new Point(296, 239);
            btn6.Margin = new Padding(6, 4, 6, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(124, 96);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(192, 255, 255);
            btn5.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn5.Location = new Point(160, 239);
            btn5.Margin = new Padding(6, 4, 6, 4);
            btn5.Name = "btn5";
            btn5.Size = new Size(124, 96);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(192, 255, 255);
            btn4.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn4.Location = new Point(24, 239);
            btn4.Margin = new Padding(6, 4, 6, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(124, 96);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(192, 255, 255);
            btn9.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn9.Location = new Point(296, 343);
            btn9.Margin = new Padding(6, 4, 6, 4);
            btn9.Name = "btn9";
            btn9.Size = new Size(124, 96);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(192, 255, 255);
            btn8.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn8.Location = new Point(160, 343);
            btn8.Margin = new Padding(6, 4, 6, 4);
            btn8.Name = "btn8";
            btn8.Size = new Size(124, 96);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(192, 255, 255);
            btn7.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn7.Location = new Point(24, 343);
            btn7.Margin = new Padding(6, 4, 6, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(124, 96);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.Blue;
            btnMulti.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnMulti.ForeColor = SystemColors.ButtonHighlight;
            btnMulti.Location = new Point(432, 343);
            btnMulti.Margin = new Padding(6, 4, 6, 4);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(124, 96);
            btnMulti.TabIndex = 12;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Blue;
            btnMinus.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnMinus.ForeColor = SystemColors.ButtonHighlight;
            btnMinus.Location = new Point(432, 239);
            btnMinus.Margin = new Padding(6, 4, 6, 4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(124, 96);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Blue;
            btnPlus.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnPlus.ForeColor = SystemColors.ButtonHighlight;
            btnPlus.Location = new Point(432, 135);
            btnPlus.Margin = new Padding(6, 4, 6, 4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(124, 96);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Blue;
            btnDiv.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnDiv.ForeColor = SystemColors.ButtonHighlight;
            btnDiv.Location = new Point(432, 448);
            btnDiv.Margin = new Padding(6, 4, 6, 4);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(124, 96);
            btnDiv.TabIndex = 16;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.Blue;
            btnSqrt.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSqrt.ForeColor = SystemColors.ButtonHighlight;
            btnSqrt.Location = new Point(296, 448);
            btnSqrt.Margin = new Padding(6, 4, 6, 4);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(124, 96);
            btnSqrt.TabIndex = 15;
            btnSqrt.Text = "SQRT";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(192, 255, 255);
            btnZero.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnZero.Location = new Point(160, 447);
            btnZero.Margin = new Padding(6, 4, 6, 4);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(124, 96);
            btnZero.TabIndex = 14;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(24, 447);
            btnClear.Margin = new Padding(6, 4, 6, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 96);
            btnClear.TabIndex = 17;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.LimeGreen;
            btnEqual.Font = new Font("Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnEqual.ForeColor = SystemColors.ButtonHighlight;
            btnEqual.Location = new Point(568, 136);
            btnEqual.Margin = new Padding(6, 4, 6, 4);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(124, 408);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 569);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnSqrt);
            Controls.Add(btnZero);
            Controls.Add(btnMulti);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 4, 6, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnMulti;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnDiv;
        private Button btnSqrt;
        private Button btnZero;
        private Button btnClear;
        private Button btnEqual;
    }
}
