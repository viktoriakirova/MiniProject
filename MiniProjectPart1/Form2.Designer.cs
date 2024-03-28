namespace MiniProjectPart1
{
    partial class Form2
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
            adminButton = new Button();
            comboBoxTowns = new ComboBox();
            comboBoxCountries = new ComboBox();
            SuspendLayout();
            // 
            // adminButton
            // 
            adminButton.Location = new Point(198, 181);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(121, 23);
            adminButton.TabIndex = 0;
            adminButton.Text = "Make Changes";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
            // 
            // comboBoxTowns
            // 
            comboBoxTowns.FormattingEnabled = true;
            comboBoxTowns.Location = new Point(291, 96);
            comboBoxTowns.Name = "comboBoxTowns";
            comboBoxTowns.Size = new Size(121, 23);
            comboBoxTowns.TabIndex = 1;
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Location = new Point(87, 96);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(121, 23);
            comboBoxCountries.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxCountries);
            Controls.Add(comboBoxTowns);
            Controls.Add(adminButton);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button adminButton;
        private ComboBox comboBoxTowns;
        private ComboBox comboBoxCountries;
    }
}