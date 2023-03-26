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
            groupBoxBParty = new GroupBox();
            groupBoxParty = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBoxBParty.SuspendLayout();
            groupBoxParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(34, 65);
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
            label1.Location = new Point(34, 42);
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
            fancyBox.Location = new Point(34, 98);
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
            healthyBox.Location = new Point(34, 128);
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
            label2.Location = new Point(34, 155);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Razem:";
            // 
            // CostLabel
            // 
            CostLabel.BorderStyle = BorderStyle.Fixed3D;
            CostLabel.Location = new Point(114, 160);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(81, 25);
            CostLabel.TabIndex = 5;
            CostLabel.Text = " ";
            // 
            // groupBoxBParty
            // 
            groupBoxBParty.Controls.Add(numericUpDown2);
            groupBoxBParty.Controls.Add(label3);
            groupBoxBParty.Controls.Add(label4);
            groupBoxBParty.Controls.Add(checkBox1);
            groupBoxBParty.Controls.Add(label5);
            groupBoxBParty.Location = new Point(285, 17);
            groupBoxBParty.Name = "groupBoxBParty";
            groupBoxBParty.Size = new Size(250, 201);
            groupBoxBParty.TabIndex = 6;
            groupBoxBParty.TabStop = false;
            groupBoxBParty.Text = "Impreza urodzinowa";
            // 
            // groupBoxParty
            // 
            groupBoxParty.Controls.Add(numericUpDown1);
            groupBoxParty.Controls.Add(label1);
            groupBoxParty.Controls.Add(CostLabel);
            groupBoxParty.Controls.Add(fancyBox);
            groupBoxParty.Controls.Add(label2);
            groupBoxParty.Controls.Add(healthyBox);
            groupBoxParty.Location = new Point(12, 12);
            groupBoxParty.Name = "groupBoxParty";
            groupBoxParty.Size = new Size(250, 234);
            groupBoxParty.TabIndex = 0;
            groupBoxParty.TabStop = false;
            groupBoxParty.Text = "Impreza";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(40, 52);
            numericUpDown2.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 29);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 7;
            label3.Text = "Ilość osób";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(120, 147);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 11;
            label4.Text = " ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(40, 85);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Dekoracje fantazyjne";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 142);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 10;
            label5.Text = "Razem:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 271);
            Controls.Add(groupBoxParty);
            Controls.Add(groupBoxBParty);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calc App";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBoxBParty.ResumeLayout(false);
            groupBoxBParty.PerformLayout();
            groupBoxParty.ResumeLayout(false);
            groupBoxParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private CheckBox fancyBox;
        private CheckBox healthyBox;
        private Label label2;
        private Label CostLabel;
        private GroupBox groupBoxBParty;
        private GroupBox groupBoxParty;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private Label label5;
    }
}