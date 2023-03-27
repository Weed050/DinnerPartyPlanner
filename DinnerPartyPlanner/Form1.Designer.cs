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
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            costLabel2 = new Label();
            fancyDecorationsBP = new CheckBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            textBoxCake = new TextBox();
            toLongText = new Label();
            label8 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            healthyBox = new CheckBox();
            CostLabel = new Label();
            fancyBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(30, 57);
            numericUpDown2.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 34);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 7;
            label3.Text = "Ilość osób";
            // 
            // costLabel2
            // 
            costLabel2.BorderStyle = BorderStyle.Fixed3D;
            costLabel2.Location = new Point(119, 198);
            costLabel2.Name = "costLabel2";
            costLabel2.Size = new Size(81, 25);
            costLabel2.TabIndex = 11;
            costLabel2.Text = " ";
            // 
            // fancyDecorationsBP
            // 
            fancyDecorationsBP.AutoSize = true;
            fancyDecorationsBP.Checked = true;
            fancyDecorationsBP.CheckState = CheckState.Checked;
            fancyDecorationsBP.Location = new Point(30, 90);
            fancyDecorationsBP.Name = "fancyDecorationsBP";
            fancyDecorationsBP.Size = new Size(170, 24);
            fancyDecorationsBP.TabIndex = 8;
            fancyDecorationsBP.Text = "Dekoracje fantazyjne";
            fancyDecorationsBP.UseVisualStyleBackColor = true;
            fancyDecorationsBP.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 198);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 10;
            label5.Text = "Razem:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxCake);
            tabPage2.Controls.Add(toLongText);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(costLabel2);
            tabPage2.Controls.Add(fancyDecorationsBP);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 240);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Imprezy urodzinowe";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxCake
            // 
            textBoxCake.Location = new Point(30, 152);
            textBoxCake.Name = "textBoxCake";
            textBoxCake.Size = new Size(170, 27);
            textBoxCake.TabIndex = 14;
            textBoxCake.Text = "Sto lat!";
            // 
            // toLongText
            // 
            toLongText.AutoSize = true;
            toLongText.BackColor = Color.Red;
            toLongText.Location = new Point(145, 117);
            toLongText.Name = "toLongText";
            toLongText.Size = new Size(89, 20);
            toLongText.TabIndex = 13;
            toLongText.Text = "ZBYT DŁUGI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 117);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 12;
            label8.Text = "Napis na torcie";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(250, 273);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(healthyBox);
            tabPage1.Controls.Add(CostLabel);
            tabPage1.Controls.Add(fancyBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(242, 240);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Imrezy";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 40);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 12;
            label7.Text = "Ilość osób";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 158);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 11;
            label6.Text = "Razem:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(28, 63);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 153);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 4;
            // 
            // healthyBox
            // 
            healthyBox.AutoSize = true;
            healthyBox.Location = new Point(28, 126);
            healthyBox.Name = "healthyBox";
            healthyBox.Size = new Size(123, 24);
            healthyBox.TabIndex = 3;
            healthyBox.Text = "Zdrowa opcja";
            healthyBox.UseVisualStyleBackColor = true;
            healthyBox.CheckedChanged += healthyBox_CheckedChanged;
            // 
            // CostLabel
            // 
            CostLabel.BorderStyle = BorderStyle.Fixed3D;
            CostLabel.Location = new Point(108, 158);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(81, 25);
            CostLabel.TabIndex = 5;
            // 
            // fancyBox
            // 
            fancyBox.AutoSize = true;
            fancyBox.Checked = true;
            fancyBox.CheckState = CheckState.Checked;
            fancyBox.Location = new Point(28, 96);
            fancyBox.Name = "fancyBox";
            fancyBox.Size = new Size(170, 24);
            fancyBox.TabIndex = 2;
            fancyBox.Text = "Dekoracje fantazyjne";
            fancyBox.UseVisualStyleBackColor = true;
            fancyBox.CheckedChanged += fancyBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 271);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calc App";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label costLabel2;
        private CheckBox fancyDecorationsBP;
        private Label label5;
        private TabPage tabPage2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label7;
        private Label label6;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private CheckBox healthyBox;
        private Label CostLabel;
        private CheckBox fancyBox;
        private Label toLongText;
        private Label label8;
        private TextBox textBoxCake;
    }
}