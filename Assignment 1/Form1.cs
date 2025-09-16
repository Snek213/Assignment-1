namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public const double PAY_PER_HOUR = 10.50;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            string fName = txtFName.Text;
            string lName = txtLName.Text;

            try
            {
                int hoursWorked = int.Parse(txtHours.Text);
                double totalPay = hoursWorked * PAY_PER_HOUR;

                lblSummary.ForeColor = System.Drawing.Color.Black;
                lblSummary.Text = $"{fName} {lName} worked {hoursWorked} hours at " +
                      $"{PAY_PER_HOUR:C} an hour for a total of {totalPay:C}";
            }
            catch (Exception)
            {
                lblSummary.ForeColor = System.Drawing.Color.Red;
                lblSummary.Text = "Error: Please enter a valid number for Hours Worked.";
            }
        }
        

                   

        private void clrBtn_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtHours.Text = "";
            lblSummary.Text = "";
            lblSummary.ForeColor = System.Drawing.Color.Black;
        }
    }
}
