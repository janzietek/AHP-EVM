namespace CoffeeMachinesComparator.Forms
{
    partial class CriteriaWindowForm
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.CalculateEVM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Experts = new System.Windows.Forms.Label();
            this.Consistency4 = new System.Windows.Forms.Label();
            this.Consistency3 = new System.Windows.Forms.Label();
            this.Consistency2 = new System.Windows.Forms.Label();
            this.CalculateGVM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(277, 23);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(157, 32);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Add Expert";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(60, 138);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(157, 32);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "button2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(60, 197);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(157, 32);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "button3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(60, 259);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(157, 32);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "button4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // CalculateEVM
            // 
            this.CalculateEVM.Location = new System.Drawing.Point(80, 328);
            this.CalculateEVM.Name = "CalculateEVM";
            this.CalculateEVM.Size = new System.Drawing.Size(157, 32);
            this.CalculateEVM.TabIndex = 4;
            this.CalculateEVM.Text = "Calculate With EVG";
            this.CalculateEVM.UseVisualStyleBackColor = true;
            this.CalculateEVM.Click += new System.EventHandler(this.CalculateEVG_CalculateWithEVG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matrices To Fill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(288, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Consistency Index";
            // 
            // Experts
            // 
            this.Experts.AutoSize = true;
            this.Experts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Experts.Location = new System.Drawing.Point(96, 27);
            this.Experts.Name = "Experts";
            this.Experts.Size = new System.Drawing.Size(0, 21);
            this.Experts.TabIndex = 7;
            this.Experts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Consistency4
            // 
            this.Consistency4.AutoSize = true;
            this.Consistency4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Consistency4.Location = new System.Drawing.Point(347, 263);
            this.Consistency4.Name = "Consistency4";
            this.Consistency4.Size = new System.Drawing.Size(0, 21);
            this.Consistency4.TabIndex = 8;
            this.Consistency4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Consistency3
            // 
            this.Consistency3.AutoSize = true;
            this.Consistency3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Consistency3.Location = new System.Drawing.Point(347, 201);
            this.Consistency3.Name = "Consistency3";
            this.Consistency3.Size = new System.Drawing.Size(0, 21);
            this.Consistency3.TabIndex = 9;
            this.Consistency3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Consistency2
            // 
            this.Consistency2.AutoSize = true;
            this.Consistency2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Consistency2.Location = new System.Drawing.Point(347, 142);
            this.Consistency2.Name = "Consistency2";
            this.Consistency2.Size = new System.Drawing.Size(0, 21);
            this.Consistency2.TabIndex = 10;
            this.Consistency2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateGVM
            // 
            this.CalculateGVM.Location = new System.Drawing.Point(265, 328);
            this.CalculateGVM.Name = "CalculateGVM";
            this.CalculateGVM.Size = new System.Drawing.Size(157, 32);
            this.CalculateGVM.TabIndex = 11;
            this.CalculateGVM.Text = "Calculate With GVM";
            this.CalculateGVM.UseVisualStyleBackColor = true;
            this.CalculateGVM.Click += new System.EventHandler(this.CalculateGVM_CalculateWithGVM_Click);
            // 
            // CriteriaWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 391);
            this.Controls.Add(this.CalculateGVM);
            this.Controls.Add(this.Consistency2);
            this.Controls.Add(this.Consistency3);
            this.Controls.Add(this.Consistency4);
            this.Controls.Add(this.Experts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateEVM);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "CriteriaWindowForm";
            this.Text = "CriteriaWindowForm";
            this.Load += new System.EventHandler(this.CriteriaWindowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button CalculateEVM;
        private Label label1;
        private Label label2;
        private Label Experts;
        private Label Consistency4;
        private Label Consistency3;
        private Label Consistency2;
        private Button CalculateGVM;
    }
}