namespace CoffeeMachinesComparator.Forms
{
    partial class FillMatrixByComparison
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
            this.CheckBox11 = new System.Windows.Forms.CheckBox();
            this.CheckBox12 = new System.Windows.Forms.CheckBox();
            this.CheckBox22 = new System.Windows.Forms.CheckBox();
            this.CheckBox21 = new System.Windows.Forms.CheckBox();
            this.CheckBox32 = new System.Windows.Forms.CheckBox();
            this.CheckBox31 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassData = new System.Windows.Forms.Button();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBox11
            // 
            this.CheckBox11.AutoSize = true;
            this.CheckBox11.Checked = true;
            this.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox11.Location = new System.Drawing.Point(122, 94);
            this.CheckBox11.Name = "CheckBox11";
            this.CheckBox11.Size = new System.Drawing.Size(83, 19);
            this.CheckBox11.TabIndex = 2;
            this.CheckBox11.Text = "checkBox1";
            this.CheckBox11.UseVisualStyleBackColor = true;
            this.CheckBox11.CheckedChanged += new System.EventHandler(this.CheckBox11_CheckedChanged);
            // 
            // CheckBox12
            // 
            this.CheckBox12.AutoSize = true;
            this.CheckBox12.Location = new System.Drawing.Point(240, 94);
            this.CheckBox12.Name = "CheckBox12";
            this.CheckBox12.Size = new System.Drawing.Size(83, 19);
            this.CheckBox12.TabIndex = 3;
            this.CheckBox12.Text = "checkBox2";
            this.CheckBox12.UseVisualStyleBackColor = true;
            this.CheckBox12.CheckedChanged += new System.EventHandler(this.CheckBox12_CheckedChanged);
            // 
            // CheckBox22
            // 
            this.CheckBox22.AutoSize = true;
            this.CheckBox22.Location = new System.Drawing.Point(240, 158);
            this.CheckBox22.Name = "CheckBox22";
            this.CheckBox22.Size = new System.Drawing.Size(83, 19);
            this.CheckBox22.TabIndex = 6;
            this.CheckBox22.Text = "checkBox3";
            this.CheckBox22.UseVisualStyleBackColor = true;
            this.CheckBox22.CheckedChanged += new System.EventHandler(this.CheckBox22_CheckedChanged);
            // 
            // CheckBox21
            // 
            this.CheckBox21.AutoSize = true;
            this.CheckBox21.Checked = true;
            this.CheckBox21.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox21.Location = new System.Drawing.Point(122, 158);
            this.CheckBox21.Name = "CheckBox21";
            this.CheckBox21.Size = new System.Drawing.Size(83, 19);
            this.CheckBox21.TabIndex = 5;
            this.CheckBox21.Text = "checkBox4";
            this.CheckBox21.UseVisualStyleBackColor = true;
            this.CheckBox21.CheckedChanged += new System.EventHandler(this.CheckBox21_CheckedChanged);
            // 
            // CheckBox32
            // 
            this.CheckBox32.AutoSize = true;
            this.CheckBox32.Location = new System.Drawing.Point(240, 224);
            this.CheckBox32.Name = "CheckBox32";
            this.CheckBox32.Size = new System.Drawing.Size(83, 19);
            this.CheckBox32.TabIndex = 9;
            this.CheckBox32.Text = "checkBox5";
            this.CheckBox32.UseVisualStyleBackColor = true;
            this.CheckBox32.CheckedChanged += new System.EventHandler(this.CheckBox32_CheckedChanged);
            // 
            // CheckBox31
            // 
            this.CheckBox31.AutoSize = true;
            this.CheckBox31.Checked = true;
            this.CheckBox31.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox31.Location = new System.Drawing.Point(122, 224);
            this.CheckBox31.Name = "CheckBox31";
            this.CheckBox31.Size = new System.Drawing.Size(83, 19);
            this.CheckBox31.TabIndex = 8;
            this.CheckBox31.Text = "checkBox6";
            this.CheckBox31.UseVisualStyleBackColor = true;
            this.CheckBox31.CheckedChanged += new System.EventHandler(this.CheckBox31_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose which is better and by how much";
            // 
            // PassData
            // 
            this.PassData.Location = new System.Drawing.Point(214, 276);
            this.PassData.Name = "PassData";
            this.PassData.Size = new System.Drawing.Size(109, 23);
            this.PassData.TabIndex = 11;
            this.PassData.Text = "Pass Data";
            this.PassData.UseVisualStyleBackColor = true;
            this.PassData.Click += new System.EventHandler(this.PassData_Click);
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(357, 90);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(34, 23);
            this.NumericUpDown1.TabIndex = 12;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDown3
            // 
            this.NumericUpDown3.Location = new System.Drawing.Point(357, 220);
            this.NumericUpDown3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown3.Name = "NumericUpDown3";
            this.NumericUpDown3.Size = new System.Drawing.Size(34, 23);
            this.NumericUpDown3.TabIndex = 15;
            this.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Location = new System.Drawing.Point(357, 154);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(34, 23);
            this.NumericUpDown2.TabIndex = 16;
            this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FillMatrixByComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 335);
            this.Controls.Add(this.NumericUpDown2);
            this.Controls.Add(this.NumericUpDown3);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.PassData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBox32);
            this.Controls.Add(this.CheckBox31);
            this.Controls.Add(this.CheckBox22);
            this.Controls.Add(this.CheckBox21);
            this.Controls.Add(this.CheckBox12);
            this.Controls.Add(this.CheckBox11);
            this.Name = "FillMatrixByComparison";
            this.Text = "FillMatrixByComparison";
            this.Load += new System.EventHandler(this.FillMatrixByComparison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox CheckBox11;
        private CheckBox CheckBox12;
        private CheckBox CheckBox22;
        private CheckBox CheckBox21;
        private CheckBox CheckBox32;
        private CheckBox CheckBox31;
        private Label label1;
        private Button PassData;
        private NumericUpDown NumericUpDown1;
        private NumericUpDown NumericUpDown3;
        private NumericUpDown NumericUpDown2;
    }
}