namespace DinnerPartyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            CostLabel.Text = Cost.ToString("C");
        }
        public void DisplayBirthdayPartyCost()
        {
            toLongText.Visible = birthdayParty.CakeWritingToLong;
            decimal Cost = birthdayParty.Cost;
            costLabel2.Text = Cost.ToString("C");
        }
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();

            // birthday party
            birthdayParty = new BirthdayParty((int)numericUpDown2.Value, fancyDecorationsBP.Checked, textBoxCake.Text);
            DisplayBirthdayPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }

        //birthday party
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyDecorationsBP_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyDecorationsBP.Checked;
            DisplayBirthdayPartyCost();
        }

        private void textBoxCake_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBoxCake.Text;
            DisplayBirthdayPartyCost() ;
        }
    }
}