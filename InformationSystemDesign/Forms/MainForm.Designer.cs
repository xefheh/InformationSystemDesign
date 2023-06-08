namespace InformationSystemDesign.Forms
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
            this._animalRegistryButton = new System.Windows.Forms.Button();
            this._municipalRegistryButton = new System.Windows.Forms.Button();
            this._organizationRegistryButton = new System.Windows.Forms.Button();
            this._reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _animalRegistryButton
            // 
            this._animalRegistryButton.Location = new System.Drawing.Point(31, 22);
            this._animalRegistryButton.Name = "_animalRegistryButton";
            this._animalRegistryButton.Size = new System.Drawing.Size(228, 23);
            this._animalRegistryButton.TabIndex = 0;
            this._animalRegistryButton.Text = "Реестр животных";
            this._animalRegistryButton.UseVisualStyleBackColor = true;
            this._animalRegistryButton.Click += new System.EventHandler(this._animalRegistryButton_Click);
            // 
            // _municipalRegistryButton
            // 
            this._municipalRegistryButton.Location = new System.Drawing.Point(31, 66);
            this._municipalRegistryButton.Name = "_municipalRegistryButton";
            this._municipalRegistryButton.Size = new System.Drawing.Size(228, 23);
            this._municipalRegistryButton.TabIndex = 1;
            this._municipalRegistryButton.Text = "Реестр муниципальных контрактов";
            this._municipalRegistryButton.UseVisualStyleBackColor = true;
            this._municipalRegistryButton.Click += new System.EventHandler(this._municipalRegistryButton_Click);
            // 
            // _organizationRegistryButton
            // 
            this._organizationRegistryButton.Location = new System.Drawing.Point(31, 105);
            this._organizationRegistryButton.Name = "_organizationRegistryButton";
            this._organizationRegistryButton.Size = new System.Drawing.Size(228, 23);
            this._organizationRegistryButton.TabIndex = 2;
            this._organizationRegistryButton.Text = "Реестр организаций";
            this._organizationRegistryButton.UseVisualStyleBackColor = true;
            this._organizationRegistryButton.Click += new System.EventHandler(this._organizationRegistryButton_Click);
            // 
            // _reportButton
            // 
            this._reportButton.Location = new System.Drawing.Point(31, 145);
            this._reportButton.Name = "_reportButton";
            this._reportButton.Size = new System.Drawing.Size(228, 23);
            this._reportButton.TabIndex = 3;
            this._reportButton.Text = "Отчёт";
            this._reportButton.UseVisualStyleBackColor = true;
            this._reportButton.Click += new System.EventHandler(this._reportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 198);
            this.Controls.Add(this._reportButton);
            this.Controls.Add(this._organizationRegistryButton);
            this.Controls.Add(this._municipalRegistryButton);
            this.Controls.Add(this._animalRegistryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Система учёта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button _animalRegistryButton;
        private Button _municipalRegistryButton;
        private Button _organizationRegistryButton;
        private Button _reportButton;
    }
}