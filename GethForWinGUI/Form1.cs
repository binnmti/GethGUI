using GethForWinGUI.Model;
using GethGUI.Model;
using Nethereum.Geth;
using System.Reflection;

namespace GethGUI
{
    public partial class Form1 : Form
    {
        private Web3Geth Web3Geth { get; } = new();
        private string ExeDirectoryName { get; } = "";
        private int ChainId { get; set; }

        private readonly GethGUIElement GethGUIElement = new();

        public Form1()
        {
            InitializeComponent();

            var settingFileName = Path.ChangeExtension(Assembly.GetEntryAssembly()?.Location, ".json")!;
            GethGUIElement = GethGUIElementFileIO.Load(settingFileName);
            ExeDirectoryName = AppContext.BaseDirectory;
        }

        private void SetGethGUI()
        {
            DataDirectoryTextBox.Text = GethGUIElement.DataDirectory;
            if (!File.Exists(GethGUIElement.Genesis.FileName)) return;

            GenesisFileNameTextBox.Text = Path.GetFileName(GethGUIElement.Genesis.FileName);
            ChainId = GenesisUtility.GetChainId(GethGUIElement.Genesis.FileName);
            SetGethGroupBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetGethGUI();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var settingFileName = Path.ChangeExtension(Assembly.GetEntryAssembly()?.Location, ".json")!;

            GethGUIElement.DataDirectory = DataDirectoryTextBox.Text;
            GethGUIElement.Save(settingFileName);
        }


        private void CommandInputRunButton_Click(object sender, EventArgs e)
        {
        }

        private async void EthAccountsButton_Click(object sender, EventArgs e)
        {
            var request = await Web3Geth.Eth.Accounts.SendRequestAsync();
            CommandOutputTextBox.Text += string.Concat(request);
        }

        private async void PersonalNewAccountButton_Click(object sender, EventArgs e)
        {
            CommandOutputTextBox.Text += await Web3Geth.Personal.NewAccount.SendRequestAsync(PasswordTextBox.Text);
        }


        private void SetGethGroupBox()
        {
            bool enabled = true;
            if (DataDirectoryTextBox.Text == "") enabled = false;
            if (GenesisFileNameTextBox.Text == "") enabled = false;

            GethGroupBox.Enabled = enabled;
        }

        private void GenesisButton_Click(object sender, EventArgs e)
        {
            var form = new GenesisForm(GethGUIElement.Genesis);
            if (form.ShowDialog() != DialogResult.OK) return;

            SetGethGUI();
        }

        private void GenesisFileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            CommandOutputTextBox.Text = GethExe.Run(ExeDirectoryName, $"--datadir {DataDirectoryTextBox.Text} init {GenesisFileNameTextBox.Text}");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            CommandOutputTextBox.Text = GethExe.Run(ExeDirectoryName, $"--networkid {ChainId} --nodiscover --datadir {DataDirectoryTextBox.Text} console");
        }

        private void DataDirectoryButton_Click(object sender, EventArgs e)
        {
            if (DataDirectoryFolderBrowserDialog.InitialDirectory == "")
            {
                DataDirectoryFolderBrowserDialog.InitialDirectory = AppContext.BaseDirectory;
            }
            if (DataDirectoryFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DataDirectoryTextBox.Text = DataDirectoryFolderBrowserDialog.InitialDirectory;
            }
        }

        private void DataDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            SetGethGroupBox();
        }
    }
}