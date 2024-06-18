using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AccFuelCalculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void CalculateButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				double raceTime = Convert.ToDouble(RaceTimeTextBox.Text);
				double lapTime = Convert.ToDouble(LapTimeTextBox.Text);
				double fuelConsumption = Convert.ToDouble(FuelConsumptionTextBox.Text);

				double numberOfLaps = raceTime / lapTime;
				double requiredFuel = numberOfLaps * fuelConsumption;

				string resultMessage = $"Litros de gasolina necesarios: {requiredFuel:F2} litros";
				string warningMessage = "Advertencia: Esta cifra puede variar dependiendo de tu estilo de conducción.";

				MessageBox.Show($"{resultMessage}\n{warningMessage}", "Cálculo de combustible", MessageBoxButton.OK, MessageBoxImage.Information);
			}
			catch (FormatException)
			{
				MessageBox.Show("Porfavor introduce valores válidos.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}