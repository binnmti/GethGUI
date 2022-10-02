using System.Reflection;

namespace GethGUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnRunClicked(object sender, EventArgs e)
    {
        var jsonFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        var result = GethCommand.Run(jsonFolder, $"--networkid \"15\" --nodiscover --datadir ./result console 2>> ./geth_err.log");
    }

    private async void OnCounterClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//MakeGenesisJsonPage");

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}

    
}

