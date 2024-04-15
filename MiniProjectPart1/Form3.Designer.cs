namespace MiniProjectPart1
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(176, 273);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += loginButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 273);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 139);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(271, 195);
            passwordTextBox.Margin = new Padding(4, 5, 4, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(141, 31);
            passwordTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(271, 136);
            usernameTextBox.Margin = new Padding(4, 5, 4, 5);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(141, 31);
            usernameTextBox.TabIndex = 5;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(435, 275);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(112, 34);
            RegisterButton.TabIndex = 6;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 513);
            Controls.Add(RegisterButton);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button RegisterButton;
    }
}