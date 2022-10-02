namespace GethGUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnRunClicked(object sender, EventArgs e)
    {
        var result = GethCommand.Run("", $"--networkid \"15\" --nodiscover --datadir ./ console 2>> ./geth_err.log");
    }

    private async void OnCounterClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//MakeGenesisJsonPage");

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}

    
}

