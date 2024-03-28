
namespace Pokemon
{
    partial class PokemonAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemonAddForm));
            label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            comboBoxType = new System.Windows.Forms.ComboBox();
            textBoxName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            comboBoxAtks = new System.Windows.Forms.ComboBox();
            buttonAdd = new System.Windows.Forms.Button();
            numericUpDownHp = new System.Windows.Forms.NumericUpDown();
            buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHp).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(374, 45);
            label.Name = "label";
            label.Size = new System.Drawing.Size(571, 40);
            label.TabIndex = 0;
            label.Text = "Welcome To Pokemon Creation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(74, 211);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 32);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(74, 307);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 32);
            label2.TabIndex = 2;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(74, 402);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 32);
            label3.TabIndex = 3;
            label3.Text = "HP:";
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Fire", "Grass", "Water" });
            comboBoxType.Location = new System.Drawing.Point(249, 307);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(242, 40);
            comboBoxType.TabIndex = 4;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxName.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            textBoxName.Location = new System.Drawing.Point(249, 211);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(242, 32);
            textBoxName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(285, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(725, 32);
            label4.TabIndex = 7;
            label4.Text = "You can create any pokemon you want, even a new one";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(74, 502);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(111, 32);
            label5.TabIndex = 8;
            label5.Text = "Attacks";
            // 
            // comboBoxAtks
            // 
            comboBoxAtks.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            comboBoxAtks.FormattingEnabled = true;
            comboBoxAtks.Location = new System.Drawing.Point(249, 502);
            comboBoxAtks.Name = "comboBoxAtks";
            comboBoxAtks.Size = new System.Drawing.Size(242, 40);
            comboBoxAtks.TabIndex = 9;
            comboBoxAtks.SelectedIndexChanged += comboBoxAtks_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = System.Drawing.Color.AliceBlue;
            buttonAdd.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonAdd.Location = new System.Drawing.Point(475, 731);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(266, 122);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Create Pokemon";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // numericUpDownHp
            // 
            numericUpDownHp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            numericUpDownHp.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            numericUpDownHp.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownHp.Location = new System.Drawing.Point(249, 402);
            numericUpDownHp.Maximum = new decimal(new int[] { 550, 0, 0, 0 });
            numericUpDownHp.Minimum = new decimal(new int[] { 350, 0, 0, 0 });
            numericUpDownHp.Name = "numericUpDownHp";
            numericUpDownHp.Size = new System.Drawing.Size(240, 35);
            numericUpDownHp.TabIndex = 11;
            numericUpDownHp.Value = new decimal(new int[] { 350, 0, 0, 0 });
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = System.Drawing.Color.Red;
            buttonCancel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonCancel.Location = new System.Drawing.Point(475, 917);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(266, 61);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel Creation";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // PokemonAddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(1282, 1069);
            Controls.Add(buttonCancel);
            Controls.Add(numericUpDownHp);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxAtks);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            DoubleBuffered = true;
            Name = "PokemonAddForm";
            Text = "Pokemon Creation";
            Load += PokemonAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownHp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAtks;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownHp;
        private System.Windows.Forms.Button buttonCancel;
    }
}