namespace GethGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CommandInputTextBox = new System.Windows.Forms.TextBox();
            this.CommandOutputTextBox = new System.Windows.Forms.TextBox();
            this.CommandInputRunButton = new System.Windows.Forms.Button();
            this.EthAccountsButton = new System.Windows.Forms.Button();
            this.PersonalNewAccountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.GenesisFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenesisButton = new System.Windows.Forms.Button();
            this.InitButton = new System.Windows.Forms.Button();
            this.EthCoinbaseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.GetBlockNumberTextBox = new System.Windows.Forms.TextBox();
            this.GetBlockButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.DataDirectoryButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DataDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.DataDirectoryFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.MinerSetEtherbaseButton = new System.Windows.Forms.Button();
            this.SetEtherbaseEthAccountsNumberTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmdRunPanel = new System.Windows.Forms.Panel();
            this.UnlockAccountPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.UnlockEthAccountTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.PersonalUnlockAccountButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.ValueEtherTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ToEthAccountTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.EthSendTransactionButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.FromEthAccountTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.EthGetBalanceEtherButton = new System.Windows.Forms.Button();
            this.EthGetBalanceWeiButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.GetBalanceEthAccountsNumberTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EthHashrateButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.EthMiningButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.EthBlockNumberButton = new System.Windows.Forms.Button();
            this.MinerStopButton = new System.Windows.Forms.Button();
            this.MinerStartButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label9 = new System.Windows.Forms.Label();
            this.CmdResultPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EthGetTransactionButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.GetTransactionIdTextBox = new System.Windows.Forms.TextBox();
            this.CmdRunPanel.SuspendLayout();
            this.CmdResultPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandInputTextBox
            // 
            this.CommandInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandInputTextBox.Location = new System.Drawing.Point(12, 3);
            this.CommandInputTextBox.Name = "CommandInputTextBox";
            this.CommandInputTextBox.PlaceholderText = ">";
            this.CommandInputTextBox.Size = new System.Drawing.Size(967, 31);
            this.CommandInputTextBox.TabIndex = 0;
            this.CommandInputTextBox.TextChanged += new System.EventHandler(this.CommandInputTextBox_TextChanged);
            this.CommandInputTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CommandInputTextBox_PreviewKeyDown);
            // 
            // CommandOutputTextBox
            // 
            this.CommandOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandOutputTextBox.Location = new System.Drawing.Point(21, 55);
            this.CommandOutputTextBox.Multiline = true;
            this.CommandOutputTextBox.Name = "CommandOutputTextBox";
            this.CommandOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CommandOutputTextBox.Size = new System.Drawing.Size(1064, 358);
            this.CommandOutputTextBox.TabIndex = 1;
            // 
            // CommandInputRunButton
            // 
            this.CommandInputRunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandInputRunButton.Enabled = false;
            this.CommandInputRunButton.Location = new System.Drawing.Point(985, 3);
            this.CommandInputRunButton.Name = "CommandInputRunButton";
            this.CommandInputRunButton.Size = new System.Drawing.Size(112, 34);
            this.CommandInputRunButton.TabIndex = 2;
            this.CommandInputRunButton.Text = "Run";
            this.CommandInputRunButton.UseVisualStyleBackColor = true;
            this.CommandInputRunButton.Click += new System.EventHandler(this.CommandInputRunButton_Click);
            // 
            // EthAccountsButton
            // 
            this.EthAccountsButton.Location = new System.Drawing.Point(164, 131);
            this.EthAccountsButton.Name = "EthAccountsButton";
            this.EthAccountsButton.Size = new System.Drawing.Size(132, 34);
            this.EthAccountsButton.TabIndex = 3;
            this.EthAccountsButton.Text = "Eth.Accounts";
            this.EthAccountsButton.UseVisualStyleBackColor = true;
            this.EthAccountsButton.Click += new System.EventHandler(this.EthAccountsButton_Click);
            // 
            // PersonalNewAccountButton
            // 
            this.PersonalNewAccountButton.Location = new System.Drawing.Point(164, 166);
            this.PersonalNewAccountButton.Name = "PersonalNewAccountButton";
            this.PersonalNewAccountButton.Size = new System.Drawing.Size(203, 34);
            this.PersonalNewAccountButton.TabIndex = 4;
            this.PersonalNewAccountButton.Text = "personal.newAccount";
            this.PersonalNewAccountButton.UseVisualStyleBackColor = true;
            this.PersonalNewAccountButton.Click += new System.EventHandler(this.PersonalNewAccountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(474, 171);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(161, 31);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // GenesisFileNameTextBox
            // 
            this.GenesisFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenesisFileNameTextBox.Location = new System.Drawing.Point(163, 49);
            this.GenesisFileNameTextBox.Name = "GenesisFileNameTextBox";
            this.GenesisFileNameTextBox.ReadOnly = true;
            this.GenesisFileNameTextBox.Size = new System.Drawing.Size(880, 31);
            this.GenesisFileNameTextBox.TabIndex = 7;
            this.GenesisFileNameTextBox.TextChanged += new System.EventHandler(this.GenesisFileNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Genesis FileName";
            // 
            // GenesisButton
            // 
            this.GenesisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenesisButton.Location = new System.Drawing.Point(1049, 47);
            this.GenesisButton.Name = "GenesisButton";
            this.GenesisButton.Size = new System.Drawing.Size(36, 34);
            this.GenesisButton.TabIndex = 9;
            this.GenesisButton.Text = "...";
            this.GenesisButton.UseVisualStyleBackColor = true;
            this.GenesisButton.Click += new System.EventHandler(this.GenesisButton_Click);
            // 
            // InitButton
            // 
            this.InitButton.Location = new System.Drawing.Point(163, 86);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(132, 34);
            this.InitButton.TabIndex = 10;
            this.InitButton.Text = "Init";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // EthCoinbaseButton
            // 
            this.EthCoinbaseButton.Location = new System.Drawing.Point(164, 200);
            this.EthCoinbaseButton.Name = "EthCoinbaseButton";
            this.EthCoinbaseButton.Size = new System.Drawing.Size(132, 34);
            this.EthCoinbaseButton.TabIndex = 18;
            this.EthCoinbaseButton.Text = "Eth.Coinbase";
            this.EthCoinbaseButton.UseVisualStyleBackColor = true;
            this.EthCoinbaseButton.Click += new System.EventHandler(this.EthCoinbaseButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Coinbase";
            // 
            // GetBlockNumberTextBox
            // 
            this.GetBlockNumberTextBox.Location = new System.Drawing.Point(302, 93);
            this.GetBlockNumberTextBox.Name = "GetBlockNumberTextBox";
            this.GetBlockNumberTextBox.Size = new System.Drawing.Size(60, 31);
            this.GetBlockNumberTextBox.TabIndex = 17;
            this.GetBlockNumberTextBox.Text = "0";
            // 
            // GetBlockButton
            // 
            this.GetBlockButton.Location = new System.Drawing.Point(164, 91);
            this.GetBlockButton.Name = "GetBlockButton";
            this.GetBlockButton.Size = new System.Drawing.Size(132, 34);
            this.GetBlockButton.TabIndex = 15;
            this.GetBlockButton.Text = "Eth.GetBlock";
            this.GetBlockButton.UseVisualStyleBackColor = true;
            this.GetBlockButton.Click += new System.EventHandler(this.GetBlockButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Block";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(149, 40);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 34);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(21, 15);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(132, 34);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(11, 40);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(132, 34);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DataDirectoryButton
            // 
            this.DataDirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataDirectoryButton.Location = new System.Drawing.Point(1049, 10);
            this.DataDirectoryButton.Name = "DataDirectoryButton";
            this.DataDirectoryButton.Size = new System.Drawing.Size(36, 34);
            this.DataDirectoryButton.TabIndex = 14;
            this.DataDirectoryButton.Text = "...";
            this.DataDirectoryButton.UseVisualStyleBackColor = true;
            this.DataDirectoryButton.Click += new System.EventHandler(this.DataDirectoryButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Directory";
            // 
            // DataDirectoryTextBox
            // 
            this.DataDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataDirectoryTextBox.Location = new System.Drawing.Point(163, 12);
            this.DataDirectoryTextBox.Name = "DataDirectoryTextBox";
            this.DataDirectoryTextBox.Size = new System.Drawing.Size(880, 31);
            this.DataDirectoryTextBox.TabIndex = 12;
            this.DataDirectoryTextBox.TextChanged += new System.EventHandler(this.DataDirectoryTextBox_TextChanged);
            // 
            // DataDirectoryFolderBrowserDialog
            // 
            this.DataDirectoryFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "SetEtherbase";
            // 
            // MinerSetEtherbaseButton
            // 
            this.MinerSetEtherbaseButton.Location = new System.Drawing.Point(163, 240);
            this.MinerSetEtherbaseButton.Name = "MinerSetEtherbaseButton";
            this.MinerSetEtherbaseButton.Size = new System.Drawing.Size(179, 34);
            this.MinerSetEtherbaseButton.TabIndex = 21;
            this.MinerSetEtherbaseButton.Text = "miner.setEtherbase";
            this.MinerSetEtherbaseButton.UseVisualStyleBackColor = true;
            this.MinerSetEtherbaseButton.Click += new System.EventHandler(this.MinerSetEtherbaseButton_Click);
            // 
            // SetEtherbaseEthAccountsNumberTextBox
            // 
            this.SetEtherbaseEthAccountsNumberTextBox.Location = new System.Drawing.Point(465, 242);
            this.SetEtherbaseEthAccountsNumberTextBox.Name = "SetEtherbaseEthAccountsNumberTextBox";
            this.SetEtherbaseEthAccountsNumberTextBox.Size = new System.Drawing.Size(60, 31);
            this.SetEtherbaseEthAccountsNumberTextBox.TabIndex = 22;
            this.SetEtherbaseEthAccountsNumberTextBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Eth.Accounts";
            // 
            // CmdRunPanel
            // 
            this.CmdRunPanel.Controls.Add(this.GetTransactionIdTextBox);
            this.CmdRunPanel.Controls.Add(this.EthGetTransactionButton);
            this.CmdRunPanel.Controls.Add(this.label23);
            this.CmdRunPanel.Controls.Add(this.UnlockAccountPasswordTextBox);
            this.CmdRunPanel.Controls.Add(this.label22);
            this.CmdRunPanel.Controls.Add(this.UnlockEthAccountTextBox);
            this.CmdRunPanel.Controls.Add(this.label21);
            this.CmdRunPanel.Controls.Add(this.PersonalUnlockAccountButton);
            this.CmdRunPanel.Controls.Add(this.label20);
            this.CmdRunPanel.Controls.Add(this.ValueEtherTextBox);
            this.CmdRunPanel.Controls.Add(this.label19);
            this.CmdRunPanel.Controls.Add(this.ToEthAccountTextBox);
            this.CmdRunPanel.Controls.Add(this.label18);
            this.CmdRunPanel.Controls.Add(this.EthSendTransactionButton);
            this.CmdRunPanel.Controls.Add(this.label16);
            this.CmdRunPanel.Controls.Add(this.FromEthAccountTextBox);
            this.CmdRunPanel.Controls.Add(this.label17);
            this.CmdRunPanel.Controls.Add(this.EthGetBalanceEtherButton);
            this.CmdRunPanel.Controls.Add(this.EthGetBalanceWeiButton);
            this.CmdRunPanel.Controls.Add(this.label14);
            this.CmdRunPanel.Controls.Add(this.GetBalanceEthAccountsNumberTextBox);
            this.CmdRunPanel.Controls.Add(this.label15);
            this.CmdRunPanel.Controls.Add(this.label13);
            this.CmdRunPanel.Controls.Add(this.EthHashrateButton);
            this.CmdRunPanel.Controls.Add(this.label12);
            this.CmdRunPanel.Controls.Add(this.EthMiningButton);
            this.CmdRunPanel.Controls.Add(this.label11);
            this.CmdRunPanel.Controls.Add(this.EthBlockNumberButton);
            this.CmdRunPanel.Controls.Add(this.MinerStopButton);
            this.CmdRunPanel.Controls.Add(this.MinerStartButton);
            this.CmdRunPanel.Controls.Add(this.label10);
            this.CmdRunPanel.Controls.Add(this.splitter1);
            this.CmdRunPanel.Controls.Add(this.label9);
            this.CmdRunPanel.Controls.Add(this.PasswordTextBox);
            this.CmdRunPanel.Controls.Add(this.label1);
            this.CmdRunPanel.Controls.Add(this.PersonalNewAccountButton);
            this.CmdRunPanel.Controls.Add(this.EthAccountsButton);
            this.CmdRunPanel.Controls.Add(this.CommandInputRunButton);
            this.CmdRunPanel.Controls.Add(this.CommandInputTextBox);
            this.CmdRunPanel.Controls.Add(this.StartButton);
            this.CmdRunPanel.Controls.Add(this.label4);
            this.CmdRunPanel.Controls.Add(this.ExitButton);
            this.CmdRunPanel.Controls.Add(this.label5);
            this.CmdRunPanel.Controls.Add(this.GetBlockButton);
            this.CmdRunPanel.Controls.Add(this.GetBlockNumberTextBox);
            this.CmdRunPanel.Controls.Add(this.label6);
            this.CmdRunPanel.Controls.Add(this.EthCoinbaseButton);
            this.CmdRunPanel.Controls.Add(this.MinerSetEtherbaseButton);
            this.CmdRunPanel.Controls.Add(this.label7);
            this.CmdRunPanel.Controls.Add(this.SetEtherbaseEthAccountsNumberTextBox);
            this.CmdRunPanel.Controls.Add(this.label8);
            this.CmdRunPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdRunPanel.Location = new System.Drawing.Point(0, 135);
            this.CmdRunPanel.Name = "CmdRunPanel";
            this.CmdRunPanel.Size = new System.Drawing.Size(1109, 624);
            this.CmdRunPanel.TabIndex = 24;
            // 
            // UnlockAccountPasswordTextBox
            // 
            this.UnlockAccountPasswordTextBox.Location = new System.Drawing.Point(669, 486);
            this.UnlockAccountPasswordTextBox.Name = "UnlockAccountPasswordTextBox";
            this.UnlockAccountPasswordTextBox.Size = new System.Drawing.Size(161, 31);
            this.UnlockAccountPasswordTextBox.TabIndex = 53;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(575, 486);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 25);
            this.label22.TabIndex = 54;
            this.label22.Text = "Password";
            // 
            // UnlockEthAccountTextBox
            // 
            this.UnlockEthAccountTextBox.Location = new System.Drawing.Point(500, 483);
            this.UnlockEthAccountTextBox.Name = "UnlockEthAccountTextBox";
            this.UnlockEthAccountTextBox.Size = new System.Drawing.Size(60, 31);
            this.UnlockEthAccountTextBox.TabIndex = 51;
            this.UnlockEthAccountTextBox.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(383, 486);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 25);
            this.label21.TabIndex = 52;
            this.label21.Text = "Eth.Accounts";
            // 
            // PersonalUnlockAccountButton
            // 
            this.PersonalUnlockAccountButton.Location = new System.Drawing.Point(163, 481);
            this.PersonalUnlockAccountButton.Name = "PersonalUnlockAccountButton";
            this.PersonalUnlockAccountButton.Size = new System.Drawing.Size(214, 34);
            this.PersonalUnlockAccountButton.TabIndex = 50;
            this.PersonalUnlockAccountButton.Text = "personal.unlockAccount";
            this.PersonalUnlockAccountButton.UseVisualStyleBackColor = true;
            this.PersonalUnlockAccountButton.Click += new System.EventHandler(this.PersonalUnlockAccountButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 486);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 25);
            this.label20.TabIndex = 49;
            this.label20.Text = "UnlockAccount";
            // 
            // ValueEtherTextBox
            // 
            this.ValueEtherTextBox.Location = new System.Drawing.Point(919, 526);
            this.ValueEtherTextBox.Name = "ValueEtherTextBox";
            this.ValueEtherTextBox.Size = new System.Drawing.Size(60, 31);
            this.ValueEtherTextBox.TabIndex = 47;
            this.ValueEtherTextBox.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(810, 528);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 25);
            this.label19.TabIndex = 48;
            this.label19.Text = "value(ether)";
            // 
            // ToEthAccountTextBox
            // 
            this.ToEthAccountTextBox.Location = new System.Drawing.Point(731, 523);
            this.ToEthAccountTextBox.Name = "ToEthAccountTextBox";
            this.ToEthAccountTextBox.Size = new System.Drawing.Size(60, 31);
            this.ToEthAccountTextBox.TabIndex = 45;
            this.ToEthAccountTextBox.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(588, 526);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 25);
            this.label18.TabIndex = 46;
            this.label18.Text = "To Eth.Accounts";
            // 
            // EthSendTransactionButton
            // 
            this.EthSendTransactionButton.Location = new System.Drawing.Point(163, 521);
            this.EthSendTransactionButton.Name = "EthSendTransactionButton";
            this.EthSendTransactionButton.Size = new System.Drawing.Size(179, 34);
            this.EthSendTransactionButton.TabIndex = 42;
            this.EthSendTransactionButton.Text = "eth.sendTransaction";
            this.EthSendTransactionButton.UseVisualStyleBackColor = true;
            this.EthSendTransactionButton.Click += new System.EventHandler(this.EthSendTransactionButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 526);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 25);
            this.label16.TabIndex = 41;
            this.label16.Text = "sendTransaction";
            // 
            // FromEthAccountTextBox
            // 
            this.FromEthAccountTextBox.Location = new System.Drawing.Point(514, 523);
            this.FromEthAccountTextBox.Name = "FromEthAccountTextBox";
            this.FromEthAccountTextBox.Size = new System.Drawing.Size(60, 31);
            this.FromEthAccountTextBox.TabIndex = 43;
            this.FromEthAccountTextBox.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(348, 526);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "From Eth.Accounts";
            // 
            // EthGetBalanceEtherButton
            // 
            this.EthGetBalanceEtherButton.Location = new System.Drawing.Point(348, 442);
            this.EthGetBalanceEtherButton.Name = "EthGetBalanceEtherButton";
            this.EthGetBalanceEtherButton.Size = new System.Drawing.Size(189, 34);
            this.EthGetBalanceEtherButton.TabIndex = 40;
            this.EthGetBalanceEtherButton.Text = "eth.getBalance(ether)";
            this.EthGetBalanceEtherButton.UseVisualStyleBackColor = true;
            this.EthGetBalanceEtherButton.Click += new System.EventHandler(this.EthGetBalanceEtherButton_Click);
            // 
            // EthGetBalanceWeiButton
            // 
            this.EthGetBalanceWeiButton.Location = new System.Drawing.Point(163, 442);
            this.EthGetBalanceWeiButton.Name = "EthGetBalanceWeiButton";
            this.EthGetBalanceWeiButton.Size = new System.Drawing.Size(179, 34);
            this.EthGetBalanceWeiButton.TabIndex = 36;
            this.EthGetBalanceWeiButton.Text = "eth.getBalance(wei)";
            this.EthGetBalanceWeiButton.UseVisualStyleBackColor = true;
            this.EthGetBalanceWeiButton.Click += new System.EventHandler(this.EthGetBalanceButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "GetBalance";
            // 
            // GetBalanceEthAccountsNumberTextBox
            // 
            this.GetBalanceEthAccountsNumberTextBox.Location = new System.Drawing.Point(660, 444);
            this.GetBalanceEthAccountsNumberTextBox.Name = "GetBalanceEthAccountsNumberTextBox";
            this.GetBalanceEthAccountsNumberTextBox.Size = new System.Drawing.Size(60, 31);
            this.GetBalanceEthAccountsNumberTextBox.TabIndex = 37;
            this.GetBalanceEthAccountsNumberTextBox.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(543, 447);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 25);
            this.label15.TabIndex = 38;
            this.label15.Text = "Eth.Accounts";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 25);
            this.label13.TabIndex = 34;
            this.label13.Text = "Hashrate";
            // 
            // EthHashrateButton
            // 
            this.EthHashrateButton.Location = new System.Drawing.Point(164, 402);
            this.EthHashrateButton.Name = "EthHashrateButton";
            this.EthHashrateButton.Size = new System.Drawing.Size(132, 34);
            this.EthHashrateButton.TabIndex = 33;
            this.EthHashrateButton.Text = "eth.hashrate";
            this.EthHashrateButton.UseVisualStyleBackColor = true;
            this.EthHashrateButton.Click += new System.EventHandler(this.EthHashrateButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Mining";
            // 
            // EthMiningButton
            // 
            this.EthMiningButton.Location = new System.Drawing.Point(163, 320);
            this.EthMiningButton.Name = "EthMiningButton";
            this.EthMiningButton.Size = new System.Drawing.Size(132, 34);
            this.EthMiningButton.TabIndex = 31;
            this.EthMiningButton.Text = "eth.mining";
            this.EthMiningButton.UseVisualStyleBackColor = true;
            this.EthMiningButton.Click += new System.EventHandler(this.EthMiningButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "BlockNumber";
            // 
            // EthBlockNumberButton
            // 
            this.EthBlockNumberButton.Location = new System.Drawing.Point(164, 360);
            this.EthBlockNumberButton.Name = "EthBlockNumberButton";
            this.EthBlockNumberButton.Size = new System.Drawing.Size(179, 34);
            this.EthBlockNumberButton.TabIndex = 29;
            this.EthBlockNumberButton.Text = "eth.blockNumber";
            this.EthBlockNumberButton.UseVisualStyleBackColor = true;
            this.EthBlockNumberButton.Click += new System.EventHandler(this.EthBlockNumberButton_Click);
            // 
            // MinerStopButton
            // 
            this.MinerStopButton.Location = new System.Drawing.Point(301, 280);
            this.MinerStopButton.Name = "MinerStopButton";
            this.MinerStopButton.Size = new System.Drawing.Size(132, 34);
            this.MinerStopButton.TabIndex = 28;
            this.MinerStopButton.Text = "miner.stop";
            this.MinerStopButton.UseVisualStyleBackColor = true;
            this.MinerStopButton.Click += new System.EventHandler(this.MinerStopButton_Click);
            // 
            // MinerStartButton
            // 
            this.MinerStartButton.Location = new System.Drawing.Point(163, 280);
            this.MinerStartButton.Name = "MinerStartButton";
            this.MinerStartButton.Size = new System.Drawing.Size(132, 34);
            this.MinerStartButton.TabIndex = 27;
            this.MinerStartButton.Text = "miner.start";
            this.MinerStartButton.UseVisualStyleBackColor = true;
            this.MinerStartButton.Click += new System.EventHandler(this.MinerStartButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Miner";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 620);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1109, 4);
            this.splitter1.TabIndex = 25;
            this.splitter1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "NewAccount";
            // 
            // CmdResultPanel
            // 
            this.CmdResultPanel.Controls.Add(this.ClearButton);
            this.CmdResultPanel.Controls.Add(this.CommandOutputTextBox);
            this.CmdResultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdResultPanel.Location = new System.Drawing.Point(0, 759);
            this.CmdResultPanel.Name = "CmdResultPanel";
            this.CmdResultPanel.Size = new System.Drawing.Size(1109, 425);
            this.CmdResultPanel.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataDirectoryButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DataDirectoryTextBox);
            this.panel1.Controls.Add(this.GenesisButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.GenesisFileNameTextBox);
            this.panel1.Controls.Add(this.InitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 135);
            this.panel1.TabIndex = 26;
            // 
            // EthGetTransactionButton
            // 
            this.EthGetTransactionButton.Location = new System.Drawing.Point(164, 561);
            this.EthGetTransactionButton.Name = "EthGetTransactionButton";
            this.EthGetTransactionButton.Size = new System.Drawing.Size(179, 34);
            this.EthGetTransactionButton.TabIndex = 56;
            this.EthGetTransactionButton.Text = "eth.getTransaction";
            this.EthGetTransactionButton.UseVisualStyleBackColor = true;
            this.EthGetTransactionButton.Click += new System.EventHandler(this.EthGetTransactionButton_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 566);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 25);
            this.label23.TabIndex = 55;
            this.label23.Text = "getTransaction";
            // 
            // GetTransactionIdTextBox
            // 
            this.GetTransactionIdTextBox.Location = new System.Drawing.Point(349, 563);
            this.GetTransactionIdTextBox.Name = "GetTransactionIdTextBox";
            this.GetTransactionIdTextBox.Size = new System.Drawing.Size(630, 31);
            this.GetTransactionIdTextBox.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 1184);
            this.Controls.Add(this.CmdResultPanel);
            this.Controls.Add(this.CmdRunPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CmdRunPanel.ResumeLayout(false);
            this.CmdRunPanel.PerformLayout();
            this.CmdResultPanel.ResumeLayout(false);
            this.CmdResultPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox CommandInputTextBox;
        private TextBox CommandOutputTextBox;
        private Button CommandInputRunButton;
        private Button EthAccountsButton;
        private Button PersonalNewAccountButton;
        private Label label1;
        private TextBox PasswordTextBox;
        private TextBox GenesisFileNameTextBox;
        private Label label2;
        private Button GenesisButton;
        private Button InitButton;
        private Button StartButton;
        private Button DataDirectoryButton;
        private Label label3;
        private TextBox DataDirectoryTextBox;
        private FolderBrowserDialog DataDirectoryFolderBrowserDialog;
        private Button ClearButton;
        private Label label4;
        private Button ExitButton;
        private TextBox GetBlockNumberTextBox;
        private Button GetBlockButton;
        private Label label5;
        private Button EthCoinbaseButton;
        private Label label6;
        private Label label7;
        private Button MinerSetEtherbaseButton;
        private TextBox SetEtherbaseEthAccountsNumberTextBox;
        private Label label8;
        private Panel CmdRunPanel;
        private Label label9;
        private Panel CmdResultPanel;
        private Splitter splitter1;
        private Panel panel1;
        private Button MinerStartButton;
        private Label label10;
        private Button MinerStopButton;
        private Label label11;
        private Button EthBlockNumberButton;
        private Label label13;
        private Button EthHashrateButton;
        private Label label12;
        private Button EthMiningButton;
        private Button EthGetBalanceWeiButton;
        private Label label14;
        private TextBox GetBalanceEthAccountsNumberTextBox;
        private Label label15;
        private Button EthGetBalanceEtherButton;
        private TextBox ValueEtherTextBox;
        private Label label19;
        private TextBox ToEthAccountTextBox;
        private Label label18;
        private Button EthSendTransactionButton;
        private Label label16;
        private TextBox FromEthAccountTextBox;
        private Label label17;
        private TextBox UnlockEthAccountTextBox;
        private Label label21;
        private Button PersonalUnlockAccountButton;
        private Label label20;
        private TextBox UnlockAccountPasswordTextBox;
        private Label label22;
        private TextBox GetTransactionIdTextBox;
        private Button EthGetTransactionButton;
        private Label label23;
    }
}