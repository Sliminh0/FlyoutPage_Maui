namespace app_hamburguer;

public partial class CalculoAutonomia : ContentPage
{
	public CalculoAutonomia()
	{
		InitializeComponent();
	}

    private void OnCalcularAutonomiaClicked(object sender, EventArgs e)
	{
		double distancia;
		double litros;

        if (double.TryParse(txtLitros.Text, out litros) && litros > 0 && double.TryParse(txtDistancia.Text, out distancia) && distancia > 0)
		{
			double autonomia = distancia / litros;
			lblResultado.Text = $"Autonomia: {autonomia:F2} km/l";
		}
		else
		{
			lblResultado.Text = "Por Favor, insira os valores validos e maiores que zero para distancia e litros";
		}

    }

    private void OnLimparClicked(object sender, EventArgs e)
    {
        txtLitros.Text = string.Empty;
        txtDistania.Text = string.Empty;
        lblResultado.Text = string.Empty;
    }
}