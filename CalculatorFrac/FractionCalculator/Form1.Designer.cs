namespace CalculatorFrac
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numerator1 = new System.Windows.Forms.TextBox();
            this.numerator2 = new System.Windows.Forms.TextBox();
            this.denominator1 = new System.Windows.Forms.TextBox();
            this.denominator2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.RadioButton();
            this.subtractButton = new System.Windows.Forms.RadioButton();
            this.multiplyButton = new System.Windows.Forms.RadioButton();
            this.divideButton = new System.Windows.Forms.RadioButton();
            this.equalsButton = new System.Windows.Forms.Button();
            this.answerField = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numerator 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numerator 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Denominator 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Denominator 2:";
            // 
            // numerator1
            // 
            this.numerator1.Location = new System.Drawing.Point(48, 50);
            this.numerator1.Name = "numerator1";
            this.numerator1.Size = new System.Drawing.Size(100, 20);
            this.numerator1.TabIndex = 1;
            this.numerator1.TextChanged += new System.EventHandler(this.numerator1_TextChanged);
            // 
            // numerator2
            // 
            this.numerator2.Location = new System.Drawing.Point(190, 50);
            this.numerator2.Name = "numerator2";
            this.numerator2.Size = new System.Drawing.Size(100, 20);
            this.numerator2.TabIndex = 3;
            this.numerator2.TextChanged += new System.EventHandler(this.numerator2_TextChanged);
            // 
            // denominator1
            // 
            this.denominator1.Location = new System.Drawing.Point(48, 105);
            this.denominator1.Name = "denominator1";
            this.denominator1.Size = new System.Drawing.Size(100, 20);
            this.denominator1.TabIndex = 2;
            this.denominator1.TextChanged += new System.EventHandler(this.denominator1_TextChanged);
            // 
            // denominator2
            // 
            this.denominator2.Location = new System.Drawing.Point(190, 105);
            this.denominator2.Name = "denominator2";
            this.denominator2.Size = new System.Drawing.Size(100, 20);
            this.denominator2.TabIndex = 4;
            this.denominator2.TextChanged += new System.EventHandler(this.denominator2_TextChanged);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(48, 150);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(44, 17);
            this.addButton.TabIndex = 5;
            this.addButton.TabStop = true;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.CheckedChanged += new System.EventHandler(this.addButton_CheckedChanged);
            // 
            // subtractButton
            // 
            this.subtractButton.AutoSize = true;
            this.subtractButton.Location = new System.Drawing.Point(98, 150);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(65, 17);
            this.subtractButton.TabIndex = 6;
            this.subtractButton.TabStop = true;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.CheckedChanged += new System.EventHandler(this.subtractButton_CheckedChanged);
            // 
            // multiplyButton
            // 
            this.multiplyButton.AutoSize = true;
            this.multiplyButton.Location = new System.Drawing.Point(169, 150);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(60, 17);
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.TabStop = true;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.CheckedChanged += new System.EventHandler(this.multiplyButton_CheckedChanged);
            // 
            // divideButton
            // 
            this.divideButton.AutoSize = true;
            this.divideButton.Location = new System.Drawing.Point(235, 150);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(55, 17);
            this.divideButton.TabIndex = 8;
            this.divideButton.TabStop = true;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.CheckedChanged += new System.EventHandler(this.divideButton_CheckedChanged);
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(127, 196);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(75, 23);
            this.equalsButton.TabIndex = 9;
            this.equalsButton.Text = "Equals";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // answerField
            // 
            this.answerField.AutoSize = true;
            this.answerField.Location = new System.Drawing.Point(144, 241);
            this.answerField.Name = "answerField";
            this.answerField.Size = new System.Drawing.Size(42, 13);
            this.answerField.TabIndex = 13;
            this.answerField.Text = "Answer";
            this.answerField.Visible = false;
            this.answerField.Click += new System.EventHandler(this.answerField_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Left Fraction:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Right Fraction:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 293);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.answerField);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.denominator2);
            this.Controls.Add(this.denominator1);
            this.Controls.Add(this.numerator2);
            this.Controls.Add(this.numerator1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numerator1;
        private System.Windows.Forms.TextBox numerator2;
        private System.Windows.Forms.TextBox denominator1;
        private System.Windows.Forms.TextBox denominator2;
        private System.Windows.Forms.RadioButton addButton;
        private System.Windows.Forms.RadioButton subtractButton;
        private System.Windows.Forms.RadioButton multiplyButton;
        private System.Windows.Forms.RadioButton divideButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Label answerField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

