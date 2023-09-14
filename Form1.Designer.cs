namespace SLAP_Week1_Exercise_CostCalculator
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
            TbInputExpenses = new TextBox();
            TbInputIncome = new TextBox();
            BtnCalculate = new Button();
            LblExpenses = new Label();
            LblIncome = new Label();
            TbAvgExpenses = new TextBox();
            TbAvgIncome = new TextBox();
            LblAvgExpenses = new Label();
            LblAvgIncome = new Label();
            TbSavingsRate = new TextBox();
            LblSavingsRate = new Label();
            TbDate = new TextBox();
            LblDate = new Label();
            BtnDate = new Button();
            SuspendLayout();
            // 
            // TbInputExpenses
            // 
            TbInputExpenses.Location = new Point(131, 25);
            TbInputExpenses.Name = "TbInputExpenses";
            TbInputExpenses.Size = new Size(100, 23);
            TbInputExpenses.TabIndex = 0;
            // 
            // TbInputIncome
            // 
            TbInputIncome.Location = new Point(131, 55);
            TbInputIncome.Name = "TbInputIncome";
            TbInputIncome.Size = new Size(100, 23);
            TbInputIncome.TabIndex = 1;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(140, 85);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(75, 23);
            BtnCalculate.TabIndex = 2;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // LblExpenses
            // 
            LblExpenses.AutoSize = true;
            LblExpenses.Location = new Point(4, 30);
            LblExpenses.Name = "LblExpenses";
            LblExpenses.Size = new Size(114, 15);
            LblExpenses.TabIndex = 3;
            LblExpenses.Text = "Expenses since start:";
            // 
            // LblIncome
            // 
            LblIncome.AutoSize = true;
            LblIncome.Location = new Point(4, 60);
            LblIncome.Name = "LblIncome";
            LblIncome.Size = new Size(106, 15);
            LblIncome.TabIndex = 4;
            LblIncome.Text = "Income since start:";
            // 
            // TbAvgExpenses
            // 
            TbAvgExpenses.Location = new Point(406, 25);
            TbAvgExpenses.Name = "TbAvgExpenses";
            TbAvgExpenses.ReadOnly = true;
            TbAvgExpenses.Size = new Size(100, 23);
            TbAvgExpenses.TabIndex = 5;
            // 
            // TbAvgIncome
            // 
            TbAvgIncome.Location = new Point(406, 55);
            TbAvgIncome.Name = "TbAvgIncome";
            TbAvgIncome.ReadOnly = true;
            TbAvgIncome.Size = new Size(100, 23);
            TbAvgIncome.TabIndex = 6;
            // 
            // LblAvgExpenses
            // 
            LblAvgExpenses.AutoSize = true;
            LblAvgExpenses.Location = new Point(256, 30);
            LblAvgExpenses.Name = "LblAvgExpenses";
            LblAvgExpenses.Size = new Size(104, 15);
            LblAvgExpenses.TabIndex = 7;
            LblAvgExpenses.Text = "Average expenses:";
            // 
            // LblAvgIncome
            // 
            LblAvgIncome.AutoSize = true;
            LblAvgIncome.Location = new Point(256, 60);
            LblAvgIncome.Name = "LblAvgIncome";
            LblAvgIncome.Size = new Size(96, 15);
            LblAvgIncome.TabIndex = 8;
            LblAvgIncome.Text = "Average income:";
            // 
            // TbSavingsRate
            // 
            TbSavingsRate.Location = new Point(406, 85);
            TbSavingsRate.Name = "TbSavingsRate";
            TbSavingsRate.ReadOnly = true;
            TbSavingsRate.Size = new Size(100, 23);
            TbSavingsRate.TabIndex = 9;
            // 
            // LblSavingsRate
            // 
            LblSavingsRate.AutoSize = true;
            LblSavingsRate.Location = new Point(256, 90);
            LblSavingsRate.Name = "LblSavingsRate";
            LblSavingsRate.Size = new Size(70, 15);
            LblSavingsRate.TabIndex = 10;
            LblSavingsRate.Text = "Savingsrate:";
            // 
            // TbDate
            // 
            TbDate.Location = new Point(68, 129);
            TbDate.Name = "TbDate";
            TbDate.ReadOnly = true;
            TbDate.Size = new Size(100, 23);
            TbDate.TabIndex = 11;
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.Location = new Point(4, 132);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(58, 15);
            LblDate.TabIndex = 12;
            LblDate.Text = "Startdato:";
            // 
            // BtnDate
            // 
            BtnDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDate.Location = new Point(68, 158);
            BtnDate.Name = "BtnDate";
            BtnDate.Size = new Size(100, 23);
            BtnDate.TabIndex = 13;
            BtnDate.Text = "Change date";
            BtnDate.UseVisualStyleBackColor = true;
            BtnDate.Click += BtnDate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 188);
            Controls.Add(BtnDate);
            Controls.Add(LblDate);
            Controls.Add(TbDate);
            Controls.Add(LblSavingsRate);
            Controls.Add(TbSavingsRate);
            Controls.Add(LblAvgIncome);
            Controls.Add(LblAvgExpenses);
            Controls.Add(TbAvgIncome);
            Controls.Add(TbAvgExpenses);
            Controls.Add(LblIncome);
            Controls.Add(LblExpenses);
            Controls.Add(BtnCalculate);
            Controls.Add(TbInputIncome);
            Controls.Add(TbInputExpenses);
            Name = "Form1";
            Text = "Cost calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbInputExpenses;
        private TextBox TbInputIncome;
        private Button BtnCalculate;
        private Label LblExpenses;
        private Label LblIncome;
        private TextBox TbAvgExpenses;
        private TextBox TbAvgIncome;
        private Label LblAvgExpenses;
        private Label LblAvgIncome;
        private TextBox TbSavingsRate;
        private Label LblSavingsRate;
        private TextBox TbDate;
        private Label LblDate;
        private Button BtnDate;
    }
}