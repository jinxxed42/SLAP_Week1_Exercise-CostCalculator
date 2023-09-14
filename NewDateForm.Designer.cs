namespace SLAP_Week1_Exercise_CostCalculator
{
    partial class NewDateForm
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
            LblNewDate = new Label();
            TbNewDate = new TextBox();
            BtnNewDateOk = new Button();
            BtnNewDateCancel = new Button();
            SuspendLayout();
            // 
            // LblNewDate
            // 
            LblNewDate.AutoSize = true;
            LblNewDate.Location = new Point(12, 22);
            LblNewDate.Name = "LblNewDate";
            LblNewDate.Size = new Size(60, 15);
            LblNewDate.TabIndex = 0;
            LblNewDate.Text = "New date:";
            // 
            // TbNewDate
            // 
            TbNewDate.Location = new Point(78, 19);
            TbNewDate.Name = "TbNewDate";
            TbNewDate.Size = new Size(100, 23);
            TbNewDate.TabIndex = 1;
            // 
            // BtnNewDateOk
            // 
            BtnNewDateOk.Location = new Point(63, 48);
            BtnNewDateOk.Name = "BtnNewDateOk";
            BtnNewDateOk.Size = new Size(63, 23);
            BtnNewDateOk.TabIndex = 2;
            BtnNewDateOk.Text = "Confirm";
            BtnNewDateOk.UseVisualStyleBackColor = true;
            BtnNewDateOk.Click += BtnNewDateOk_Click;
            // 
            // BtnNewDateCancel
            // 
            BtnNewDateCancel.Location = new Point(126, 48);
            BtnNewDateCancel.Name = "BtnNewDateCancel";
            BtnNewDateCancel.Size = new Size(63, 23);
            BtnNewDateCancel.TabIndex = 3;
            BtnNewDateCancel.Text = "Cancel";
            BtnNewDateCancel.UseVisualStyleBackColor = true;
            BtnNewDateCancel.Click += BtnNewDateCancel_Click;
            // 
            // NewDateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 81);
            Controls.Add(BtnNewDateCancel);
            Controls.Add(BtnNewDateOk);
            Controls.Add(TbNewDate);
            Controls.Add(LblNewDate);
            Name = "NewDateForm";
            Text = "Input new date";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNewDate;
        private TextBox TbNewDate;
        private Button BtnNewDateOk;
        private Button BtnNewDateCancel;
    }
}