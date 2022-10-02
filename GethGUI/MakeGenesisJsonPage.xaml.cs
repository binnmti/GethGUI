using System.Diagnostics;
using System.Reflection;

namespace GethGUI;

public partial class MakeGenesisJsonPage : ContentPage
{
    private readonly string GenesisTemplate = @"{
  ""config"": {
    ""chainId"": 15,
    ""homesteadBlock"": 0,
    ""eip150Block"": 0,
    ""eip155Block"": 0,
    ""eip158Block"": 0,
    ""byzantiumBlock"": 0,
    ""constantinopleBlock"": 0,
    ""petersburgBlock"": 0,
    ""istanbulBlock"": 0,
    ""berlinBlock"": 0
  },
  ""nonce"": ""0x0000000000000042"",
  ""timestamp"": ""0x0"",
  ""parentHash"": ""0x0000000000000000000000000000000000000000000000000000000000000000"",
  ""extraData"": """",
  ""gasLimit"": ""0x8000000"",
  ""difficulty"": ""0x4000"",
  ""mixhash"": ""0x0000000000000000000000000000000000000000000000000000000000000000"",
  ""coinbase"": ""0x3333333333333333333333333333333333333333"",
  ""alloc"": {}
}";

	public MakeGenesisJsonPage()
	{
		InitializeComponent();
	}

    private void OnMakeTemplateClicked(object sender, EventArgs e)
    {
        GenesisJson.Text = GenesisTemplate;
    }

    private async void OnInitClicked(object sender, EventArgs e)
    {
        //TODO:This Case is Button Disable
        if (GenesisJson.Text == "")
        {
            await DisplayAlert("Alert", "GenesisJson.Text is empty", "OK");
            return;
        }
        var jsonFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        var jsonFile = Path.Combine(jsonFolder, "Genesis.json");
        await File.WriteAllTextAsync(jsonFile, GenesisJson.Text);
        //geth --datadir /home/ubuntu/eth_private_net init /home/ubuntu/eth_private_net/myGenesis.json
        var result = GethCommand.Run(jsonFolder, $"--datadir ./result init Genesis.json");

        GenesisJson.Text = GenesisTemplate;

        await Shell.Current.GoToAsync("//MainPage");

    }

}

