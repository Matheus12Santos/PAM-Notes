namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
        //É um metodo ASSÍNCRONO que abre um recurso (URI)
        await Launcher.OpenAsync("https://www.google.com.br");
    }
}