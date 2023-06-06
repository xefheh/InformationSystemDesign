namespace InformationSystemDesign.Forms
{
    partial class AnimalRegistryForm
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
            _registryView = new DataGridView();
            _addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)_registryView).BeginInit();
            SuspendLayout();
            // 
            // _registryView
            // 
            _registryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _registryView.Location = new Point(12, 75);
            _registryView.Name = "_registryView";
            _registryView.RowTemplate.Height = 25;
            _registryView.Size = new Size(776, 363);
            _registryView.TabIndex = 0;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(12, 12);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(75, 23);
            _addButton.TabIndex = 1;
            _addButton.Text = "Добавить";
            _addButton.UseVisualStyleBackColor = true;
            _addButton.Click += _addButton_Click;
            // 
            // AnimalRegistryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_addButton);
            Controls.Add(_registryView);
            Name = "AnimalRegistryForm";
            Text = "AnimalRegistryForm";
            ((System.ComponentModel.ISupportInitialize)_registryView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView _registryView;
        private Button _addButton;
    }
}