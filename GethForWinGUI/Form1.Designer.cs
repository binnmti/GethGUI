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
            this.GethGroupBox = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.DataDirectoryButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DataDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.DataDirectoryFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.GethGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandInputTextBox
            // 
            this.CommandInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandInputTextBox.Location = new System.Drawing.Point(12, 35);
            this.CommandInputTextBox.Name = "CommandInputTextBox";
            this.CommandInputTextBox.Size = new System.Drawing.Size(883, 31);
            this.CommandInputTextBox.TabIndex = 0;
            // 
            // CommandOutputTextBox
            // 
            this.CommandOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandOutputTextBox.Location = new System.Drawing.Point(15, 241);
            this.CommandOutputTextBox.Multiline = true;
            this.CommandOutputTextBox.Name = "CommandOutputTextBox";
            this.CommandOutputTextBox.Size = new System.Drawing.Size(994, 389);
            this.CommandOutputTextBox.TabIndex = 1;
            // 
            // CommandInputRunButton
            // 
            this.CommandInputRunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandInputRunButton.Location = new System.Drawing.Point(902, 33);
            this.CommandInputRunButton.Name = "CommandInputRunButton";
            this.CommandInputRunButton.Size = new System.Drawing.Size(112, 34);
            this.CommandInputRunButton.TabIndex = 2;
            this.CommandInputRunButton.Text = "Run";
            this.CommandInputRunButton.UseVisualStyleBackColor = true;
            this.CommandInputRunButton.Click += new System.EventHandler(this.CommandInputRunButton_Click);
            // 
            // EthAccountsButton
            // 
            this.EthAccountsButton.Location = new System.Drawing.Point(97, 155);
            this.EthAccountsButton.Name = "EthAccountsButton";
            this.EthAccountsButton.Size = new System.Drawing.Size(132, 34);
            this.EthAccountsButton.TabIndex = 3;
            this.EthAccountsButton.Text = "Eth.Accounts";
            this.EthAccountsButton.UseVisualStyleBackColor = true;
            this.EthAccountsButton.Click += new System.EventHandler(this.EthAccountsButton_Click);
            // 
            // PersonalNewAccountButton
            // 
            this.PersonalNewAccountButton.Location = new System.Drawing.Point(264, 191);
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
            this.label1.Location = new System.Drawing.Point(14, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(97, 194);
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
            this.GenesisFileNameTextBox.Size = new System.Drawing.Size(803, 31);
            this.GenesisFileNameTextBox.TabIndex = 7;
            this.GenesisFileNameTextBox.TextChanged += new System.EventHandler(this.GenesisFileNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Genesis FileName";
            // 
            // GenesisButton
            // 
            this.GenesisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenesisButton.Location = new System.Drawing.Point(972, 47);
            this.GenesisButton.Name = "GenesisButton";
            this.GenesisButton.Size = new System.Drawing.Size(36, 34);
            this.GenesisButton.TabIndex = 9;
            this.GenesisButton.Text = "...";
            this.GenesisButton.UseVisualStyleBackColor = true;
            this.GenesisButton.Click += new System.EventHandler(this.GenesisButton_Click);
            // 
            // InitButton
            // 
            this.InitButton.Location = new System.Drawing.Point(13, 76);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(132, 34);
            this.InitButton.TabIndex = 10;
            this.InitButton.Text = "Init";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // GethGroupBox
            // 
            this.GethGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GethGroupBox.Controls.Add(this.StartButton);
            this.GethGroupBox.Controls.Add(this.InitButton);
            this.GethGroupBox.Controls.Add(this.CommandInputTextBox);
            this.GethGroupBox.Controls.Add(this.CommandOutputTextBox);
            this.GethGroupBox.Controls.Add(this.CommandInputRunButton);
            this.GethGroupBox.Controls.Add(this.EthAccountsButton);
            this.GethGroupBox.Controls.Add(this.PersonalNewAccountButton);
            this.GethGroupBox.Controls.Add(this.label1);
            this.GethGroupBox.Controls.Add(this.PasswordTextBox);
            this.GethGroupBox.Enabled = false;
            this.GethGroupBox.Location = new System.Drawing.Point(-3, 104);
            this.GethGroupBox.Name = "GethGroupBox";
            this.GethGroupBox.Size = new System.Drawing.Size(1023, 647);
            this.GethGroupBox.TabIndex = 11;
            this.GethGroupBox.TabStop = false;
            this.GethGroupBox.Text = "geth.exe";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(14, 115);
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
            this.DataDirectoryButton.Location = new System.Drawing.Point(972, 10);
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
            this.label3.Location = new System.Drawing.Point(10, 15);
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
            this.DataDirectoryTextBox.Size = new System.Drawing.Size(803, 31);
            this.DataDirectoryTextBox.TabIndex = 12;
            this.DataDirectoryTextBox.TextChanged += new System.EventHandler(this.DataDirectoryTextBox_TextChanged);
            // 
            // DataDirectoryFolderBrowserDialog
            // 
            this.DataDirectoryFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 763);
            this.Controls.Add(this.DataDirectoryButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataDirectoryTextBox);
            this.Controls.Add(this.GenesisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenesisFileNameTextBox);
            this.Controls.Add(this.GethGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GethGroupBox.ResumeLayout(false);
            this.GethGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private GroupBox GethGroupBox;
        private Button StartButton;
        private Button DataDirectoryButton;
        private Label label3;
        private TextBox DataDirectoryTextBox;
        private FolderBrowserDialog DataDirectoryFolderBrowserDialog;
    }
}