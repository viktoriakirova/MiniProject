namespace MiniProjectPart1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            replacedTownTextBox = new TextBox();
            townTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            countryTextBox = new TextBox();
            replaceCountryTextBox = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(296, 371);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(128, 38);
            button1.TabIndex = 0;
            button1.Text = "Add Town";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddTownButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(296, 443);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(128, 38);
            button2.TabIndex = 1;
            button2.Text = "Update Town";
            button2.UseVisualStyleBackColor = true;
            button2.Click += UpdateTownButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(296, 513);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(128, 38);
            button3.TabIndex = 2;
            button3.Text = "Delete Town";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteTownButton_Click;
            // 
            // replacedTownTextBox
            // 
            replacedTownTextBox.Location = new Point(356, 282);
            replacedTownTextBox.Margin = new Padding(4, 5, 4, 5);
            replacedTownTextBox.Name = "replacedTownTextBox";
            replacedTownTextBox.Size = new Size(141, 31);
            replacedTownTextBox.TabIndex = 3;
            // 
            // townTextBox
            // 
            townTextBox.Location = new Point(356, 167);
            townTextBox.Margin = new Padding(4, 5, 4, 5);
            townTextBox.Name = "townTextBox";
            townTextBox.Size = new Size(141, 31);
            townTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 172);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 5;
            label1.Text = "Town";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 295);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 6;
            label2.Text = "Replace town with:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(587, 288);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 10;
            label3.Text = "Replace country with";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(637, 170);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 9;
            label4.Text = "Country";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(806, 172);
            countryTextBox.Margin = new Padding(4, 5, 4, 5);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(141, 31);
            countryTextBox.TabIndex = 8;
            // 
            // replaceCountryTextBox
            // 
            replaceCountryTextBox.Location = new Point(806, 282);
            replaceCountryTextBox.Margin = new Padding(4, 5, 4, 5);
            replaceCountryTextBox.Name = "replaceCountryTextBox";
            replaceCountryTextBox.Size = new Size(141, 31);
            replaceCountryTextBox.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(739, 513);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(164, 38);
            button4.TabIndex = 13;
            button4.Text = "Delete Country";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DeleCountryButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(739, 443);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(164, 38);
            button5.TabIndex = 12;
            button5.Text = "Update Country";
            button5.UseVisualStyleBackColor = true;
            button5.Click += UpdateCountryName_Click;
            // 
            // button6
            // 
            button6.Location = new Point(728, 371);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(175, 38);
            button6.TabIndex = 11;
            button6.Text = "Add Country";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AddCountryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(countryTextBox);
            Controls.Add(replaceCountryTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(townTextBox);
            Controls.Add(replacedTownTextBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox replacedTownTextBox;
        private TextBox townTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox countryTextBox;
        private TextBox replaceCountryTextBox;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}