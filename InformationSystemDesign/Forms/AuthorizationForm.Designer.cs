namespace InformationSystemDesign.Forms
{
    partial class AuthorizationForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            _loginButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 1;
            // 
            // _loginButton
            // 
            _loginButton.Location = new Point(89, 111);
            _loginButton.Name = "_loginButton";
            _loginButton.Size = new Size(123, 23);
            _loginButton.TabIndex = 2;
            _loginButton.Text = "Авторизация";
            _loginButton.UseVisualStyleBackColor = true;
            _loginButton.Click += _loginButton_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_loginButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AuthorizationForm";
            Text = "AuthorizationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button _loginButton;
    }
}