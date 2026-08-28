namespace app_hamburguer;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void OnLimparClicked(object sender, EventArgs e)
    {
        txtGas.Text = string.Empty;
        txtEtanol.Text = string.Empty;
        lblResultado.Text = string.Empty;
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {

        double etanol;
        double gasolina;

        if(double.TryParse(txtEtanol.Text, out etanol)  && etanol > 0 && double.TryParse(txtGas.Text, out gasolina) && gasolina > 0)
        {
            double proporcao = etanol / gasolina;

            if (proporcao <= 0.70)
            {
                lblResultado.Text = $"Vale a pena abastecer com ETANOL!\n (Proporção: {proporcao: P1})";
                lblresultado.TextColor = Colors.Green;
            }
            else
            {
                lblResultado.Text = $"Vale a pena abastecer com GASOLINA!\n (Proporção: {proporcao: P1})";
                lblresultado.TextColor = Colors.Blue;
            }
        }
        else
        {
            lblResultado.Text = $"Por favor, digite valores validos e maiores que zero para o etanol e a gasolina.";
            lblResultado.TextColor = Colors.Red;
        }
    }
}