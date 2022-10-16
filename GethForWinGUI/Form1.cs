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

        private void CommandInputTextBox_TextChanged(object sender, EventArgs e)
        {
            CommandInputRunButton.Enabled = CommandInputTextBox.Text != "";
        }

        private void CommandInputRunButton_Click(object sender, EventArgs e)
        {
            if (GethProcess.IsConsole)
            {
                GethProcess.Writer(CommandInputTextBox.Text);
            }
            else if (CommandInputTextBox.Text.Contains("console"))
            {
                CommandOutputTextBox.Text += GethProcess.Run(CommandInputTextBox.Text);
            }
            else
            {
                CommandOutputTextBox.Text += GethProcess.Run(ExeDirectoryName, CommandInputTextBox.Text);
            }
            CommandInputTextBox.Text = "";
        }

        private void SetGethGroupBox()
        {
            bool enabled = true;
            if (DataDirectoryTextBox.Text == "") enabled = false;
            if (GenesisFileNameTextBox.Text == "") enabled = false;

            CmdRunPanel.Enabled = enabled;
            CmdResultPanel.Enabled = enabled;
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"exit");
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

        private void CommandInputTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CommandInputRunButton_Click(sender, e);
        }

        private void EthAccountsButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"eth.accounts");
        }

        private void GetBlockButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"eth.getBlock({GetBlockNumberTextBox.Text})");
        }

        private void PersonalNewAccountButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"personal.newAccount(\"{PasswordTextBox.Text}\")");
        }

        private void EthCoinbaseButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"eth.coinbase");
        }

        private void MinerSetEtherbaseButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"miner.setEtherbase(eth.accounts[{EthAccountsNumberTextBox.Text}])");
        }

        private void MinerStartButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"miner.start()");
        }

        private void MinerStopButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"miner.stop()");
        }

        private void EthBlockNumberButton_Click(object sender, EventArgs e)
        {
            GethProcess.Writer($"eth.blockNumber");
        }
    }
}