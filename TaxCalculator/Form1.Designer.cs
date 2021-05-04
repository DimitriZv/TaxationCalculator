namespace TaxCalculator
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
            this.tntCalculate = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.ComboBox();
            this.notFullYearResident = new System.Windows.Forms.CheckBox();
            this.fullYearResident = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_result = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tntCalculate
            // 
            this.tntCalculate.BackColor = System.Drawing.Color.DimGray;
            this.tntCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.tntCalculate.ForeColor = System.Drawing.Color.White;
            this.tntCalculate.Location = new System.Drawing.Point(366, 556);
            this.tntCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.tntCalculate.Name = "tntCalculate";
            this.tntCalculate.Size = new System.Drawing.Size(146, 54);
            this.tntCalculate.TabIndex = 0;
            this.tntCalculate.Text = "Calculate";
            this.tntCalculate.UseVisualStyleBackColor = false;
            this.tntCalculate.Click += new System.EventHandler(this.tntCalculate_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(315, 136);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(185, 30);
            this.txtInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Income:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tax Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year:";
            // 
            // yearInput
            // 
            this.yearInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.yearInput.FormattingEnabled = true;
            this.yearInput.Items.AddRange(new object[] {
            "2019-20",
            "2018-19",
            "2017-18"});
            this.yearInput.Location = new System.Drawing.Point(315, 199);
            this.yearInput.Name = "yearInput";
            this.yearInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yearInput.Size = new System.Drawing.Size(185, 32);
            this.yearInput.TabIndex = 6;
            // 
            // notFullYearResident
            // 
            this.notFullYearResident.AutoSize = true;
            this.notFullYearResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.notFullYearResident.Location = new System.Drawing.Point(195, 328);
            this.notFullYearResident.Name = "notFullYearResident";
            this.notFullYearResident.Size = new System.Drawing.Size(298, 33);
            this.notFullYearResident.TabIndex = 8;
            this.notFullYearResident.Text = "Non-resident for full year";
            this.notFullYearResident.UseVisualStyleBackColor = true;
            this.notFullYearResident.CheckedChanged += new System.EventHandler(this.notFullYearResident_CheckedChanged);
            // 
            // fullYearResident
            // 
            this.fullYearResident.AutoSize = true;
            this.fullYearResident.Checked = true;
            this.fullYearResident.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fullYearResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.fullYearResident.Location = new System.Drawing.Point(195, 270);
            this.fullYearResident.Name = "fullYearResident";
            this.fullYearResident.Size = new System.Drawing.Size(254, 33);
            this.fullYearResident.TabIndex = 9;
            this.fullYearResident.Text = "Resident for full year";
            this.fullYearResident.UseVisualStyleBackColor = true;
            this.fullYearResident.CheckedChanged += new System.EventHandler(this.fullYearResident_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.notFullYearResident);
            this.panel1.Controls.Add(this.fullYearResident);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.yearInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(93, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 393);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lbl_result);
            this.panel2.Location = new System.Drawing.Point(93, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 92);
            this.panel2.TabIndex = 11;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(4, 9);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 26);
            this.lbl_result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tntCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Tax Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tntCalculate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearInput;
        private System.Windows.Forms.CheckBox notFullYearResident;
        private System.Windows.Forms.CheckBox fullYearResident;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_result;
    }
}

