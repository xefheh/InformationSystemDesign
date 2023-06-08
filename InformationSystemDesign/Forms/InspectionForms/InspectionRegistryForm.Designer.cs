namespace InformationSystemDesign.Forms
{
    partial class InspectionRegistryForm
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
            this._addInspectionButton = new System.Windows.Forms.Button();
            this._openButton = new System.Windows.Forms.Button();
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
            this._registryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._registryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._registryView.Location = new System.Drawing.Point(12, 32);
            this._registryView.Name = "_registryView";
            this._registryView.ReadOnly = true;
            this._registryView.RowTemplate.Height = 25;
            this._registryView.Size = new System.Drawing.Size(776, 406);
            this._registryView.TabIndex = 0;
            // 
            // _addInspectionButton
            // 
            this._addInspectionButton.Location = new System.Drawing.Point(12, 3);
            this._addInspectionButton.Name = "_addInspectionButton";
            this._addInspectionButton.Size = new System.Drawing.Size(375, 23);
            this._addInspectionButton.TabIndex = 1;
            this._addInspectionButton.Text = "Добавить осмотр";
            this._addInspectionButton.UseVisualStyleBackColor = true;
            this._addInspectionButton.Click += new System.EventHandler(this._addInspectionButton_Click);
            // 
            // _openButton
            // 
            this._openButton.Location = new System.Drawing.Point(393, 3);
            this._openButton.Name = "_openButton";
            this._openButton.Size = new System.Drawing.Size(395, 23);
            this._openButton.TabIndex = 2;
            this._openButton.Text = "Открыть карточку";
            this._openButton.UseVisualStyleBackColor = true;
            this._openButton.Click += new System.EventHandler(this._openButton_Click);
            // 
            // InspectionRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._openButton);
            this.Controls.Add(this._addInspectionButton);
            this.Controls.Add(this._registryView);
            this.Name = "InspectionRegistryForm";
            this.Text = "Карточки осмотра";
            ((System.ComponentModel.ISupportInitialize)(this._registryView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView _registryView;
        private Button _addInspectionButton;
        private Button _openButton;
    }
}