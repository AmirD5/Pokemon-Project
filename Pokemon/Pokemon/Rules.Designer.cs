namespace Pokemon
{
    partial class Rules
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
            label1 = new System.Windows.Forms.Label();
            labelRules = new System.Windows.Forms.Label();
            buttonReturn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(339, 6);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(174, 37);
            label1.TabIndex = 0;
            label1.Text = "Game Rules:";
            // 
            // labelRules
            // 
            labelRules.AutoSize = true;
            labelRules.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelRules.Location = new System.Drawing.Point(36, 59);
            labelRules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelRules.Name = "labelRules";
            labelRules.Size = new System.Drawing.Size(43, 23);
            labelRules.TabIndex = 1;
            labelRules.Text = "N/A";
            labelRules.Click += labelRules_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new System.Drawing.Point(18, 836);
            buttonReturn.Margin = new System.Windows.Forms.Padding(2);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new System.Drawing.Size(173, 56);
            buttonReturn.TabIndex = 2;
            buttonReturn.Text = "Return to menu";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // Rules
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(967, 907);
            Controls.Add(buttonReturn);
            Controls.Add(labelRules);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Rules";
            Text = "Rules";
            Load += Rules_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.Button buttonReturn;
    }
}