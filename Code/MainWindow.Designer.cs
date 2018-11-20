namespace Turtle
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.topPanel = new System.Windows.Forms.Panel();
            this.examplesComboBox = new System.Windows.Forms.ComboBox();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.valuesLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.RulesLabel = new System.Windows.Forms.Label();
            this.ruleValue2 = new System.Windows.Forms.TextBox();
            this.ruleKey2 = new System.Windows.Forms.TextBox();
            this.ruleValue1 = new System.Windows.Forms.TextBox();
            this.ruleKey1 = new System.Windows.Forms.TextBox();
            this.lengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.angleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.angleLabel = new System.Windows.Forms.Label();
            this.positionList = new System.Windows.Forms.ComboBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.repeatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.repBraPanel = new System.Windows.Forms.Panel();
            this.randomButton = new System.Windows.Forms.Button();
            this.patternBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.botPanel = new System.Windows.Forms.Panel();
            this.genHelpButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumericUpDown)).BeginInit();
            this.botPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Silver;
            this.topPanel.Controls.Add(this.examplesComboBox);
            this.topPanel.Controls.Add(this.exampleLabel);
            this.topPanel.Controls.Add(this.valuesLabel);
            this.topPanel.Controls.Add(this.keyLabel);
            this.topPanel.Controls.Add(this.RulesLabel);
            this.topPanel.Controls.Add(this.ruleValue2);
            this.topPanel.Controls.Add(this.ruleKey2);
            this.topPanel.Controls.Add(this.ruleValue1);
            this.topPanel.Controls.Add(this.ruleKey1);
            this.topPanel.Controls.Add(this.lengthNumericUpDown);
            this.topPanel.Controls.Add(this.lengthLabel);
            this.topPanel.Controls.Add(this.angleNumericUpDown);
            this.topPanel.Controls.Add(this.angleLabel);
            this.topPanel.Controls.Add(this.positionList);
            this.topPanel.Controls.Add(this.positionLabel);
            this.topPanel.Controls.Add(this.repeatNumericUpDown);
            this.topPanel.Controls.Add(this.repBraPanel);
            this.topPanel.Controls.Add(this.randomButton);
            this.topPanel.Controls.Add(this.patternBox);
            this.topPanel.Controls.Add(this.startButton);
            this.topPanel.Controls.Add(this.repeatLabel);
            this.topPanel.Controls.Add(this.patternLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1305, 87);
            this.topPanel.TabIndex = 1;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // examplesComboBox
            // 
            this.examplesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examplesComboBox.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.examplesComboBox, "You can choose an example in the list.");
            this.examplesComboBox.Items.AddRange(new object[] {
            "",
            "Plante",
            "Koch curve",
            "Dragon curve",
            "Sierpinski triangle"
            });
            this.examplesComboBox.Location = new System.Drawing.Point(517, 39);
            this.examplesComboBox.Name = "examplesComboBox";
            this.helpProvider1.SetShowHelp(this.examplesComboBox, true);
            this.examplesComboBox.Size = new System.Drawing.Size(75, 21);
            this.examplesComboBox.TabIndex = 23;
            this.examplesComboBox.SelectedIndexChanged += new System.EventHandler(this.examplesComboBox_SelectedIndexChanged);
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleLabel.Location = new System.Drawing.Point(514, 16);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(73, 18);
            this.exampleLabel.TabIndex = 22;
            this.exampleLabel.Text = "Examples";
            // 
            // valuesLabel
            // 
            this.valuesLabel.AutoSize = true;
            this.valuesLabel.Location = new System.Drawing.Point(369, 4);
            this.valuesLabel.Name = "valuesLabel";
            this.valuesLabel.Size = new System.Drawing.Size(45, 13);
            this.valuesLabel.TabIndex = 21;
            this.valuesLabel.Text = "Values :";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(306, 4);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(36, 13);
            this.keyLabel.TabIndex = 20;
            this.keyLabel.Text = "Keys :";
            // 
            // RulesLabel
            // 
            this.RulesLabel.AutoSize = true;
            this.RulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesLabel.Location = new System.Drawing.Point(209, 9);
            this.RulesLabel.Name = "RulesLabel";
            this.RulesLabel.Size = new System.Drawing.Size(91, 40);
            this.RulesLabel.TabIndex = 19;
            this.RulesLabel.Text = "Create your\r\nrules :";
            this.RulesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ruleValue2
            // 
            this.ruleValue2.Location = new System.Drawing.Point(369, 55);
            this.ruleValue2.Name = "ruleValue2";
            this.ruleValue2.Size = new System.Drawing.Size(100, 20);
            this.ruleValue2.TabIndex = 18;
            // 
            // ruleKey2
            // 
            this.ruleKey2.Location = new System.Drawing.Point(309, 55);
            this.ruleKey2.MaxLength = 3;
            this.ruleKey2.Name = "ruleKey2";
            this.ruleKey2.Size = new System.Drawing.Size(36, 20);
            this.ruleKey2.TabIndex = 17;
            // 
            // ruleValue1
            // 
            this.ruleValue1.Location = new System.Drawing.Point(369, 23);
            this.ruleValue1.Name = "ruleValue1";
            this.ruleValue1.Size = new System.Drawing.Size(100, 20);
            this.ruleValue1.TabIndex = 16;
            // 
            // ruleKey1
            // 
            this.ruleKey1.Location = new System.Drawing.Point(309, 23);
            this.ruleKey1.MaxLength = 3;
            this.ruleKey1.Name = "ruleKey1";
            this.ruleKey1.Size = new System.Drawing.Size(36, 20);
            this.ruleKey1.TabIndex = 15;
            // 
            // lengthNumericUpDown
            // 
            this.helpProvider1.SetHelpString(this.lengthNumericUpDown, "Set the repeat number to draw the pattern.");
            this.lengthNumericUpDown.Location = new System.Drawing.Point(808, 39);
            this.lengthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthNumericUpDown.Name = "lengthNumericUpDown";
            this.helpProvider1.SetShowHelp(this.lengthNumericUpDown, true);
            this.lengthNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.lengthNumericUpDown.TabIndex = 14;
            this.lengthNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(804, 16);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(116, 20);
            this.lengthLabel.TabIndex = 13;
            this.lengthLabel.Text = "Which Length?";
            // 
            // angleNumericUpDown
            // 
            this.helpProvider1.SetHelpString(this.angleNumericUpDown, "Set the angle to each turn action.");
            this.angleNumericUpDown.Location = new System.Drawing.Point(939, 39);
            this.angleNumericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.angleNumericUpDown.Name = "angleNumericUpDown";
            this.helpProvider1.SetShowHelp(this.angleNumericUpDown, true);
            this.angleNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.angleNumericUpDown.TabIndex = 12;
            this.angleNumericUpDown.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleLabel.Location = new System.Drawing.Point(935, 16);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(105, 20);
            this.angleLabel.TabIndex = 11;
            this.angleLabel.Text = "Which angle?";
            // 
            // positionList
            // 
            this.positionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionList.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.positionList, "Set the start position for the drawing.");
            this.positionList.ItemHeight = 16;
            this.positionList.Items.AddRange(new object[] {
            "Bottom",
            "Top",
            "Center",
            "Left",
            "Right"});
            this.positionList.Location = new System.Drawing.Point(1054, 39);
            this.positionList.Name = "positionList";
            this.helpProvider1.SetShowHelp(this.positionList, true);
            this.positionList.Size = new System.Drawing.Size(119, 24);
            this.positionList.TabIndex = 10;
            this.positionList.SelectedIndexChanged += new System.EventHandler(this.positionList_SelectedIndexChanged);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(1046, 16);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(175, 20);
            this.positionLabel.TabIndex = 9;
            this.positionLabel.Text = "Which position to start?";
            // 
            // repeatNumericUpDown
            // 
            this.helpProvider1.SetHelpString(this.repeatNumericUpDown, "Set the repeat number to draw the pattern.");
            this.repeatNumericUpDown.Location = new System.Drawing.Point(621, 39);
            this.repeatNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repeatNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatNumericUpDown.Name = "repeatNumericUpDown";
            this.helpProvider1.SetShowHelp(this.repeatNumericUpDown, true);
            this.repeatNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.repeatNumericUpDown.TabIndex = 8;
            this.repeatNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // repBraPanel
            // 
            this.repBraPanel.AutoSize = true;
            this.repBraPanel.Location = new System.Drawing.Point(178, 28);
            this.repBraPanel.Name = "repBraPanel";
            this.repBraPanel.Size = new System.Drawing.Size(15, 15);
            this.repBraPanel.TabIndex = 7;
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomButton.Location = new System.Drawing.Point(16, 55);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(71, 26);
            this.randomButton.TabIndex = 5;
            this.randomButton.Text = "Random Pattern";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // patternBox
            // 
            this.helpProvider1.SetHelpString(this.patternBox, "Enter the pattern in this box.");
            this.patternBox.Location = new System.Drawing.Point(16, 32);
            this.patternBox.Name = "patternBox";
            this.helpProvider1.SetShowHelp(this.patternBox, true);
            this.patternBox.Size = new System.Drawing.Size(156, 20);
            this.patternBox.TabIndex = 4;
            this.patternBox.TextChanged += new System.EventHandler(this.patternBox_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(1240, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(65, 87);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatLabel.Location = new System.Drawing.Point(617, 16);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(170, 20);
            this.repeatLabel.TabIndex = 1;
            this.repeatLabel.Text = "How many repetitions?";
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLabel.Location = new System.Drawing.Point(12, 9);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(173, 20);
            this.patternLabel.TabIndex = 0;
            this.patternLabel.Text = "Which pattern to draw?";
            // 
            // botPanel
            // 
            this.botPanel.BackColor = System.Drawing.Color.Silver;
            this.botPanel.Controls.Add(this.genHelpButton);
            this.botPanel.Controls.Add(this.authorLabel);
            this.botPanel.Controls.Add(this.versionLabel);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botPanel.Location = new System.Drawing.Point(0, 423);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(1305, 27);
            this.botPanel.TabIndex = 0;
            // 
            // genHelpButton
            // 
            this.genHelpButton.BackColor = System.Drawing.Color.Black;
            this.genHelpButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.genHelpButton.FlatAppearance.BorderSize = 3;
            this.genHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genHelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genHelpButton.ForeColor = System.Drawing.Color.White;
            this.genHelpButton.Location = new System.Drawing.Point(12, 1);
            this.genHelpButton.Name = "genHelpButton";
            this.genHelpButton.Size = new System.Drawing.Size(19, 23);
            this.genHelpButton.TabIndex = 5;
            this.genHelpButton.Text = "?";
            this.genHelpButton.UseVisualStyleBackColor = true;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(1162, 8);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(69, 13);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Pereira Hugo";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(1237, 8);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(65, 13);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "version : 0.1";
            // 
            // centerPanel
            // 
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 87);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1305, 336);
            this.centerPanel.TabIndex = 2;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.centerPanel_Paint);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 450);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.botPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Turtle";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumericUpDown)).EndInit();
            this.botPanel.ResumeLayout(false);
            this.botPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel repBraPanel;
        private System.Windows.Forms.Label repeatLabel;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label angleLabel;

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button genHelpButton;

        private System.Windows.Forms.TextBox patternBox;

        private System.Windows.Forms.NumericUpDown repeatNumericUpDown;
        private System.Windows.Forms.NumericUpDown angleNumericUpDown;

        private System.Windows.Forms.ComboBox positionList;
        private System.Windows.Forms.NumericUpDown lengthNumericUpDown;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label RulesLabel;
        private System.Windows.Forms.TextBox ruleValue2;
        private System.Windows.Forms.TextBox ruleKey2;
        private System.Windows.Forms.TextBox ruleValue1;
        private System.Windows.Forms.TextBox ruleKey1;
        private System.Windows.Forms.Label valuesLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.ComboBox examplesComboBox;
        private System.Windows.Forms.Label exampleLabel;
    }
}