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
            this.topPanel = new System.Windows.Forms.Panel();
            this.angleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.angleLabel = new System.Windows.Forms.Label();
            this.positionList = new System.Windows.Forms.ComboBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.repeatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.repBraPanel = new System.Windows.Forms.Panel();
            this.randomButton = new System.Windows.Forms.Button();
            this.patternBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.informationLabel = new System.Windows.Forms.Label();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.botPanel = new System.Windows.Forms.Panel();
            this.genHelpButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumericUpDown)).BeginInit();
            this.botPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Silver;
            this.topPanel.Controls.Add(this.angleNumericUpDown);
            this.topPanel.Controls.Add(this.angleLabel);
            this.topPanel.Controls.Add(this.positionList);
            this.topPanel.Controls.Add(this.positionLabel);
            this.topPanel.Controls.Add(this.repeatNumericUpDown);
            this.topPanel.Controls.Add(this.repBraPanel);
            this.topPanel.Controls.Add(this.randomButton);
            this.topPanel.Controls.Add(this.patternBox);
            this.topPanel.Controls.Add(this.startButton);
            this.topPanel.Controls.Add(this.informationLabel);
            this.topPanel.Controls.Add(this.repeatLabel);
            this.topPanel.Controls.Add(this.patternLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1305, 87);
            this.topPanel.TabIndex = 1;
            // 
            // angleNumericUpDown
            // 
            this.angleNumericUpDown.Location = new System.Drawing.Point(830, 32);
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
            this.angleLabel.Location = new System.Drawing.Point(826, 9);
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
            this.positionList.ItemHeight = 16;
            this.positionList.Items.AddRange(new object[] {
            "Bottom",
            "Top",
            "Center",
            "Left",
            "Right"});
            this.positionList.Location = new System.Drawing.Point(1014, 32);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(119, 24);
            this.positionList.TabIndex = 10;
            this.positionList.SelectedIndexChanged += new System.EventHandler(this.positionList_SelectedIndexChanged);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(1006, 9);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(175, 20);
            this.positionLabel.TabIndex = 9;
            this.positionLabel.Text = "Which position to start?";
            // 
            // repeatNumericUpDown
            // 
            this.repeatNumericUpDown.Location = new System.Drawing.Point(585, 32);
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
            this.repBraPanel.Location = new System.Drawing.Point(499, 28);
            this.repBraPanel.Name = "repBraPanel";
            this.repBraPanel.Size = new System.Drawing.Size(15, 15);
            this.repBraPanel.TabIndex = 7;
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomButton.Location = new System.Drawing.Point(337, 55);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(71, 26);
            this.randomButton.TabIndex = 5;
            this.randomButton.Text = "Random Pattern";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // patternBox
            // 
            this.patternBox.Location = new System.Drawing.Point(337, 32);
            this.patternBox.Name = "patternBox";
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
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel.Location = new System.Drawing.Point(23, 21);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(148, 24);
            this.informationLabel.TabIndex = 2;
            this.informationLabel.Text = "informationLabel";
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatLabel.Location = new System.Drawing.Point(581, 9);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(170, 20);
            this.repeatLabel.TabIndex = 1;
            this.repeatLabel.Text = "How many repetitions?";
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLabel.Location = new System.Drawing.Point(333, 9);
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
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumericUpDown)).EndInit();
            this.botPanel.ResumeLayout(false);
            this.botPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel repBraPanel;

        private System.Windows.Forms.Label informationLabel;
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
    }
}