namespace DateHandling;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculateDays_Click(object sender, EventArgs e)
    {
        // TODO: Add code to calculate the days until due date
        // Figure out today's date
        DateTime currentdate = DateTime.Today;

        // Get future date
        DateTime futureDate = DateTime.Parse(txtFutureDate.Text);

        // Subtract the two dates
        TimeSpan ts = futureDate.Subtract(currentdate);

        // Pull the days from that
        int daysInTS = ts.Days;

        // Show the result
        MessageBox.Show(
            "Current Date:\t" + currentdate.ToShortDateString() + "\n"+
            "Future Date:\t" + futureDate.ToShortDateString() + "\n" +
            "Days until due date:\t" + daysInTS.ToString(),
         ""
        );

    }

    private void btnCalculateAge_Click(object sender, EventArgs e)
    {
        // TODO: Add code to calculate the age

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
