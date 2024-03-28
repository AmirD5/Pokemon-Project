
namespace Pokemon
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            comboBoxType = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            comboBoxName = new System.Windows.Forms.ComboBox();
            buttonAddPokemonToList = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            labelHP = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            labelWeakTo = new System.Windows.Forms.Label();
            buttonRemove = new System.Windows.Forms.Button();
            labelMainAtk = new System.Windows.Forms.Label();
            labelUltraAtk = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            labelLvl = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            buttonLoad = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            buttonQuit = new System.Windows.Forms.Button();
            buttonRules = new System.Windows.Forms.Button();
            pictureBoxPokemonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemonImage).BeginInit();
            SuspendLayout();
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new System.Drawing.Point(50, 135);
            comboBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(265, 27);
            comboBoxType.TabIndex = 0;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(321, 15);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(622, 33);
            label1.TabIndex = 3;
            label1.Text = "Welcome To Pokemon Fighting Simulation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(50, 99);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 19);
            label2.TabIndex = 4;
            label2.Text = "Pokemon Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(355, 99);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 19);
            label3.TabIndex = 5;
            label3.Text = "Pokemon Name:";
            // 
            // comboBoxName
            // 
            comboBoxName.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new System.Drawing.Point(355, 135);
            comboBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new System.Drawing.Size(243, 27);
            comboBoxName.TabIndex = 6;
            comboBoxName.SelectedIndexChanged += comboBoxName_SelectedIndexChanged;
            // 
            // buttonAddPokemonToList
            // 
            buttonAddPokemonToList.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAddPokemonToList.Location = new System.Drawing.Point(994, 97);
            buttonAddPokemonToList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonAddPokemonToList.Name = "buttonAddPokemonToList";
            buttonAddPokemonToList.Size = new System.Drawing.Size(183, 63);
            buttonAddPokemonToList.TabIndex = 7;
            buttonAddPokemonToList.Text = "Create a pokemon!";
            buttonAddPokemonToList.UseVisualStyleBackColor = true;
            buttonAddPokemonToList.Click += buttonAddPokemonToList_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(50, 196);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 19);
            label4.TabIndex = 8;
            label4.Text = "HP:";
            // 
            // labelHP
            // 
            labelHP.AutoSize = true;
            labelHP.BackColor = System.Drawing.Color.Transparent;
            labelHP.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelHP.Location = new System.Drawing.Point(198, 196);
            labelHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelHP.Name = "labelHP";
            labelHP.Size = new System.Drawing.Size(15, 19);
            labelHP.TabIndex = 9;
            labelHP.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(50, 311);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 19);
            label6.TabIndex = 10;
            label6.Text = "Attacks:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(50, 251);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 19);
            label7.TabIndex = 11;
            label7.Text = "Weak To:";
            // 
            // labelWeakTo
            // 
            labelWeakTo.AutoSize = true;
            labelWeakTo.BackColor = System.Drawing.Color.Transparent;
            labelWeakTo.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelWeakTo.Location = new System.Drawing.Point(198, 251);
            labelWeakTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelWeakTo.Name = "labelWeakTo";
            labelWeakTo.Size = new System.Drawing.Size(15, 19);
            labelWeakTo.TabIndex = 13;
            labelWeakTo.Text = "-";
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonRemove.Location = new System.Drawing.Point(994, 198);
            buttonRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new System.Drawing.Size(183, 55);
            buttonRemove.TabIndex = 14;
            buttonRemove.Text = "Remove Pokemon";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // labelMainAtk
            // 
            labelMainAtk.AutoSize = true;
            labelMainAtk.BackColor = System.Drawing.Color.Transparent;
            labelMainAtk.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelMainAtk.Location = new System.Drawing.Point(51, 342);
            labelMainAtk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelMainAtk.Name = "labelMainAtk";
            labelMainAtk.Size = new System.Drawing.Size(37, 19);
            labelMainAtk.TabIndex = 15;
            labelMainAtk.Text = "N/A";
            // 
            // labelUltraAtk
            // 
            labelUltraAtk.AutoSize = true;
            labelUltraAtk.BackColor = System.Drawing.Color.Transparent;
            labelUltraAtk.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelUltraAtk.Location = new System.Drawing.Point(50, 371);
            labelUltraAtk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelUltraAtk.Name = "labelUltraAtk";
            labelUltraAtk.Size = new System.Drawing.Size(37, 19);
            labelUltraAtk.TabIndex = 16;
            labelUltraAtk.Text = "N/A";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = System.Drawing.Color.Transparent;
            label.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(50, 429);
            label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label.Name = "label";
            label.Size = new System.Drawing.Size(56, 19);
            label.TabIndex = 17;
            label.Text = "Level:";
            // 
            // labelLvl
            // 
            labelLvl.AutoSize = true;
            labelLvl.BackColor = System.Drawing.Color.Transparent;
            labelLvl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelLvl.Location = new System.Drawing.Point(198, 429);
            labelLvl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelLvl.Name = "labelLvl";
            labelLvl.Size = new System.Drawing.Size(37, 19);
            labelLvl.TabIndex = 18;
            labelLvl.Text = "N/A";
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(994, 305);
            buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(183, 58);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Save Game";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonLoad.Location = new System.Drawing.Point(994, 391);
            buttonLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new System.Drawing.Size(183, 55);
            buttonLoad.TabIndex = 20;
            buttonLoad.Text = "Load Game";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            button1.Location = new System.Drawing.Point(-2, 614);
            button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(1200, 91);
            button1.TabIndex = 21;
            button1.Text = "Start Battle!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonQuit.Location = new System.Drawing.Point(994, 538);
            buttonQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new System.Drawing.Size(183, 43);
            buttonQuit.TabIndex = 22;
            buttonQuit.Text = "Quit Game";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonRules
            // 
            buttonRules.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonRules.Location = new System.Drawing.Point(507, 719);
            buttonRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new System.Drawing.Size(209, 67);
            buttonRules.TabIndex = 23;
            buttonRules.Text = "Game rules and info";
            buttonRules.UseVisualStyleBackColor = true;
            buttonRules.Click += buttonRules_Click;
            // 
            // pictureBoxPokemonImage
            // 
            pictureBoxPokemonImage.BackColor = System.Drawing.Color.Transparent;
            pictureBoxPokemonImage.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBoxPokemonImage.BackgroundImage");
            pictureBoxPokemonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBoxPokemonImage.Location = new System.Drawing.Point(399, 198);
            pictureBoxPokemonImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBoxPokemonImage.Name = "pictureBoxPokemonImage";
            pictureBoxPokemonImage.Size = new System.Drawing.Size(369, 375);
            pictureBoxPokemonImage.TabIndex = 24;
            pictureBoxPokemonImage.TabStop = false;
            pictureBoxPokemonImage.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(1204, 795);
            Controls.Add(pictureBoxPokemonImage);
            Controls.Add(buttonRules);
            Controls.Add(buttonQuit);
            Controls.Add(button1);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(labelLvl);
            Controls.Add(label);
            Controls.Add(labelUltraAtk);
            Controls.Add(labelMainAtk);
            Controls.Add(buttonRemove);
            Controls.Add(labelWeakTo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelHP);
            Controls.Add(label4);
            Controls.Add(buttonAddPokemonToList);
            Controls.Add(comboBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxType);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "Welcome";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemonImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button buttonAddPokemonToList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWeakTo;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelMainAtk;
        private System.Windows.Forms.Label labelUltraAtk;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelLvl;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.PictureBox pictureBoxPokemonImage;
    }
}

