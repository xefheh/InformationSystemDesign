namespace InformationSystemDesign
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
            _animalRegistryButton = new Button();
            _municipalRegistryButton = new Button();
            _organizationRegistryButton = new Button();
            SuspendLayout();
            // 
            // _animalRegistryButton
            // 
            _animalRegistryButton.Location = new Point(31, 49);
            _animalRegistryButton.Name = "_animalRegistryButton";
            _animalRegistryButton.Size = new Size(228, 23);
            _animalRegistryButton.TabIndex = 0;
            _animalRegistryButton.Text = "AnimalRegistry";
            _animalRegistryButton.UseVisualStyleBackColor = true;
            _animalRegistryButton.Click += _animalRegistryButton_Click;
            // 
            // _municipalRegistryButton
            // 
            _municipalRegistryButton.Location = new Point(31, 98);
            _municipalRegistryButton.Name = "_municipalRegistryButton";
            _municipalRegistryButton.Size = new Size(228, 23);
            _municipalRegistryButton.TabIndex = 1;
            _municipalRegistryButton.Text = "MunicipalRegistry";
            _municipalRegistryButton.UseVisualStyleBackColor = true;
            _municipalRegistryButton.Click += _municipalRegistryButton_Click;
            // 
            // _organizationRegistryButton
            // 
            _organizationRegistryButton.Location = new Point(31, 159);
            _organizationRegistryButton.Name = "_organizationRegistryButton";
            _organizationRegistryButton.Size = new Size(228, 23);
            _organizationRegistryButton.TabIndex = 2;
            _organizationRegistryButton.Text = "OrganizationRegistry";
            _organizationRegistryButton.UseVisualStyleBackColor = true;
            _organizationRegistryButton.Click += _organizationRegistryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 225);
            Controls.Add(_organizationRegistryButton);
            Controls.Add(_municipalRegistryButton);
            Controls.Add(_animalRegistryButton);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button _animalRegistryButton;
        private Button _municipalRegistryButton;
        private Button _organizationRegistryButton;
    }
}