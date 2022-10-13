using GethForWinGUI.Model;
using GethGUI.Model;
using Nethereum.Geth;
using System.Reflection;

namespace GethGUI
{
    public partial class Form1 : Form
    {
        private Web3Geth Web3Geth { get; } = new();
        private GethProcess GethProcess { get; } 
        private string ExeDirectoryName { get; } = "";
        private int ChainId { get; set; }

        private readonly GethGUIElement GethGUIElement = new();

        public Form1()
        {
            InitializeComponent();

            var settingFileName = Path.ChangeExtension(Assembly.GetEntryAssembly()?.Location, ".json")!;
            GethGUIElement = GethGUIElementFileIO.Load(settingFileName);
            ExeDirectoryName = AppContext.BaseDirectory;
            GethProcess = new GethProcess(ExeDirectoryName);
            GethProcess.OnOutputDataReceived += (data) =>
            {
                Invoke(() => {
                    CommandOutputTextBox.Text += data + Environment.NewLine;
                    CommandOutputTextBox.SelectionStart = CommandOutputTextBox.Text.Length;
                    CommandOutputTextBox.Focus();
                    CommandOutputTextBox.ScrollToCaret();
                });
            };
        }

        private void SetGethGUI()
        {
            if (!File.Exists(GethGUIElement.Genesis.FileName)) return;

            GenesisFileNameTextBox.Text = Path.GetFileName(GethGUIElement.Genesis.FileName);
            ChainId = GenesisUtility.GetChainId(GethGUIElement.Genesis.FileName);
            SetGethGroupBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataDirectoryTextBox.Text = GethGUIElement.DataDirectory;
            if (DataDirectoryTextBox.Text == "")
            {
                DataDirectoryTextBox.Text = ExeDirectoryName;
            }
            SetGethGUI();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var settingFileName = Path.ChangeExtension(Assembly.GetEntryAssembly()?.Location, ".json")!;

            GethGUIElement.Save(settingFileName);
        }


        private void CommandInputRunButton_Click(object sender, EventArgs e)
        {
        }

        private async void EthAccountsButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"eth.accounts");
        }

        private void PersonalNewAccountButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"personal.newAccount(\"{PasswordTextBox.Text}\")");
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
            GethGUIElement.DataDirectory = DataDirectoryTextBox.Text;
        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            CommandOutputTextBox.Text += GethProcess.Run(ExeDirectoryName, $"--datadir {GethGUIElement.DataDirectory} init {GethGUIElement.Genesis.FileName}");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            CommandOutputTextBox.Text += GethProcess.Run($"--networkid {ChainId} --nodiscover --datadir {GethGUIElement.DataDirectory} console");
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CommandOutputTextBox.Text = "";
        }
    }
}