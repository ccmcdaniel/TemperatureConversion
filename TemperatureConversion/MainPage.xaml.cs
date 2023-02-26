namespace TemperatureConversion;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void CalcCelsius(object sender, EventArgs e)
	{
		try
		{
			//Get the entered Fahrenheit from the text box.
			//NOTE: The try block will catch if the user entered a non-numerical
			//      number.
			double fahrenheit = Convert.ToDouble(txtFahrenheit.Text);

			//Convert to Celsius
			double celsius = (fahrenheit - 32.0) * (5.0 / 9.0);

			//Display the Celsius in the result label.
			lblCelsiusResult.Text = celsius.ToString("#.#####");

			//Change the color of the label's text to white.
			//We do this in case the text was previously red from
			//the catch statement below.
			lblCelsiusResult.TextColor = Color.Parse("White");
		}
		catch(FormatException)
		{
			//If the user entered a non-numerical temperature, then
			//output an error message to the result label and set its
			//text color to red.
			lblCelsiusResult.Text = "Error: This is not a decimal number.  Enter again...";
			lblCelsiusResult.TextColor = Color.Parse("Red");
		}
	}
}

