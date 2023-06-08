namespace InformationSystemDesign.Forms
{
    partial class OrganizationRegistryForm
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
            _openButton = new Button();
            _idBox = new TextBox();
            _openByIdButton = new Button();
            ((System.ComponentModel.ISupportInitialize)_registryView).BeginInit();
            SuspendLayout();
            // 
            // _registryView
            // 
            _registryView.AllowUserToAddRows = false;
            _registryView.AllowUserToDeleteRows = false;
            _registryView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _registryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _registryView.Location = new Point(13, 61);
            _registryView.Name = "_registryView";
            _registryView.ReadOnly = true;
            _registryView.RowTemplate.Height = 25;
            _registryView.Size = new Size(775, 377);
            _registryView.TabIndex = 0;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(25, 3);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(75, 23);
            _addButton.TabIndex = 1;
            _addButton.Text = "Добавить";
            _addButton.UseVisualStyleBackColor = true;
            _addButton.Click += _addButton_Click;
            // 
            // _openButton
            // 
            _openButton.Location = new Point(106, 3);
            _openButton.Name = "_openButton";
            _openButton.Size = new Size(214, 23);
            _openButton.TabIndex = 2;
            _openButton.Text = "Открыть карточку";
            _openButton.UseVisualStyleBackColor = true;
            _openButton.Click += _openButton_Click;
            // 
            // _idBox
            // 
            _idBox.Location = new Point(326, 3);
            _idBox.Name = "_idBox";
            _idBox.Size = new Size(100, 23);
            _idBox.TabIndex = 3;
            // 
            // _openByIdButton
            // 
            _openByIdButton.Location = new Point(432, 3);
            _openByIdButton.Name = "_openByIdButton";
            _openByIdButton.Size = new Size(173, 23);
            _openByIdButton.TabIndex = 4;
            _openByIdButton.Text = "Получить карту по ИНН:";
            _openByIdButton.UseVisualStyleBackColor = true;
            _openByIdButton.Click += _openByIdButton_Click;
            // 
            // OrganizationRegistryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_openByIdButton);
            Controls.Add(_idBox);
            Controls.Add(_openButton);
            Controls.Add(_addButton);
            Controls.Add(_registryView);
            Name = "OrganizationRegistryForm";
            Text = "Реестр организаций";
            ((System.ComponentModel.ISupportInitialize)_registryView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView _registryView;
        private Button _addButton;
        private Button _openButton;
        private TextBox _idBox;
        private Button _openByIdButton;
    }
}