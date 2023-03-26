namespace DinnerPartyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            CostLabel.Text = Cost.ToString("C");
        }
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, fancyBox.Checked, healthyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDown1.Value
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }
    }
}