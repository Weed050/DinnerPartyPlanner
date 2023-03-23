namespace DinnerPartyPlanner
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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            fancyBox = new CheckBox();
            healthyBox = new CheckBox();
            label2 = new Label();
            CostLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 27);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Ilość osób";
            // 
            // fancyBox
            // 
            fancyBox.AutoSize = true;
            fancyBox.Checked = true;
            fancyBox.CheckState = CheckState.Checked;
            fancyBox.Location = new Point(12, 60);
            fancyBox.Name = "fancyBox";
            fancyBox.Size = new Size(170, 24);
            fancyBox.TabIndex = 2;
            fancyBox.Text = "Dekoracje fantazyjne";
            fancyBox.UseVisualStyleBackColor = true;
            fancyBox.CheckedChanged += fancyBox_CheckedChanged;
            // 
            // healthyBox
            // 
            healthyBox.AutoSize = true;
            healthyBox.Location = new Point(12, 90);
            healthyBox.Name = "healthyBox";
            healthyBox.Size = new Size(123, 24);
            healthyBox.TabIndex = 3;
            healthyBox.Text = "Zdrowa opcja";
            healthyBox.UseVisualStyleBackColor = true;
            healthyBox.CheckedChanged += healthyBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Razem:";
            // 
            // CostLabel
            // 
            CostLabel.BorderStyle = BorderStyle.Fixed3D;
            CostLabel.Location = new Point(92, 122);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(81, 25);
            CostLabel.TabIndex = 5;
            CostLabel.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(185, 167);
            Controls.Add(CostLabel);
            Controls.Add(label2);
            Controls.Add(healthyBox);
            Controls.Add(fancyBox);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calc App";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private CheckBox fancyBox;
        private CheckBox healthyBox;
        private Label label2;
        private Label CostLabel;
    }
}