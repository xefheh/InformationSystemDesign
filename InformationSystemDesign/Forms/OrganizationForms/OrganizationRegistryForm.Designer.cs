namespace InformationSystemDesign.Forms.OrganizationForms
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
            this._registryView = new System.Windows.Forms.DataGridView();
            this._addButton = new System.Windows.Forms.Button();
            this._openButton = new System.Windows.Forms.Button();
            this._idBox = new System.Windows.Forms.TextBox();
            this._openByIdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._registryView)).BeginInit();
            this.SuspendLayout();
            // 
            // _registryView
            // 
            this._registryView.AllowUserToAddRows = false;
            this._registryView.AllowUserToDeleteRows = false;
            this._registryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._registryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._registryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this._registryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._registryView.Location = new System.Drawing.Point(13, 32);
            this._registryView.Name = "_registryView";
            this._registryView.ReadOnly = true;
            this._registryView.RowTemplate.Height = 25;
            this._registryView.Size = new System.Drawing.Size(775, 406);
            this._registryView.TabIndex = 0;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(12, 3);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(187, 23);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "Добавить";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // _openButton
            // 
            this._openButton.Location = new System.Drawing.Point(205, 2);
            this._openButton.Name = "_openButton";
            this._openButton.Size = new System.Drawing.Size(214, 23);
            this._openButton.TabIndex = 2;
            this._openButton.Text = "Открыть карточку";
            this._openButton.UseVisualStyleBackColor = true;
            this._openButton.Click += new System.EventHandler(this._openButton_Click);
            // 
            // _idBox
            // 
            this._idBox.Location = new System.Drawing.Point(454, 2);
            this._idBox.Name = "_idBox";
            this._idBox.Size = new System.Drawing.Size(155, 23);
            this._idBox.TabIndex = 3;
            // 
            // _openByIdButton
            // 
            this._openByIdButton.Location = new System.Drawing.Point(615, 2);
            this._openByIdButton.Name = "_openByIdButton";
            this._openByIdButton.Size = new System.Drawing.Size(173, 23);
            this._openByIdButton.TabIndex = 4;
            this._openByIdButton.Text = "Получить карту по ИНН:";
            this._openByIdButton.UseVisualStyleBackColor = true;
            this._openByIdButton.Click += new System.EventHandler(this._openByIdButton_Click);
            // 
            // OrganizationRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._openByIdButton);
            this.Controls.Add(this._idBox);
            this.Controls.Add(this._openButton);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._registryView);
            this.Name = "OrganizationRegistryForm";
            this.Text = "Реестр организаций";
            ((System.ComponentModel.ISupportInitialize)(this._registryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView _registryView;
        private Button _addButton;
        private Button _openButton;
        private TextBox _idBox;
        private Button _openByIdButton;
    }
}