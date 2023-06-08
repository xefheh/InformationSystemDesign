namespace InformationSystemDesign.Forms.AnimalForms
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
            this._registryView = new System.Windows.Forms.DataGridView();
            this._addButton = new System.Windows.Forms.Button();
            this._openCard = new System.Windows.Forms.Button();
            this._idBox = new System.Windows.Forms.TextBox();
            this._openByIdButton = new System.Windows.Forms.Button();
            this._inspectionButton = new System.Windows.Forms.Button();
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
            this._registryView.Location = new System.Drawing.Point(0, 41);
            this._registryView.Name = "_registryView";
            this._registryView.ReadOnly = true;
            this._registryView.RowTemplate.Height = 25;
            this._registryView.Size = new System.Drawing.Size(800, 446);
            this._registryView.TabIndex = 0;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(12, 12);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(181, 23);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "Добавить";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // _openCard
            // 
            this._openCard.Location = new System.Drawing.Point(199, 12);
            this._openCard.Name = "_openCard";
            this._openCard.Size = new System.Drawing.Size(192, 23);
            this._openCard.TabIndex = 3;
            this._openCard.Text = "Открыть карту";
            this._openCard.UseVisualStyleBackColor = true;
            this._openCard.Click += new System.EventHandler(this._openButton_Click);
            // 
            // _idBox
            // 
            this._idBox.Location = new System.Drawing.Point(408, 12);
            this._idBox.Name = "_idBox";
            this._idBox.Size = new System.Drawing.Size(133, 23);
            this._idBox.TabIndex = 4;
            // 
            // _openByIdButton
            // 
            this._openByIdButton.Location = new System.Drawing.Point(547, 12);
            this._openByIdButton.Name = "_openByIdButton";
            this._openByIdButton.Size = new System.Drawing.Size(114, 23);
            this._openByIdButton.TabIndex = 5;
            this._openByIdButton.Text = "Открыть по ID";
            this._openByIdButton.UseVisualStyleBackColor = true;
            this._openByIdButton.Click += new System.EventHandler(this._openByIdButton_Click);
            // 
            // _inspectionButton
            // 
            this._inspectionButton.Location = new System.Drawing.Point(667, 12);
            this._inspectionButton.Name = "_inspectionButton";
            this._inspectionButton.Size = new System.Drawing.Size(121, 23);
            this._inspectionButton.TabIndex = 6;
            this._inspectionButton.Text = "Осмотры";
            this._inspectionButton.UseVisualStyleBackColor = true;
            this._inspectionButton.Click += new System.EventHandler(this._inspectionButton_Click);
            // 
            // AnimalRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this._inspectionButton);
            this.Controls.Add(this._openByIdButton);
            this.Controls.Add(this._idBox);
            this.Controls.Add(this._openCard);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._registryView);
            this.Name = "AnimalRegistryForm";
            this.Text = "Реестр животных";
            ((System.ComponentModel.ISupportInitialize)(this._registryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView _registryView;
        private Button _addButton;
        private Button _openCard;
        private TextBox _idBox;
        private Button _openByIdButton;
        private Button _inspectionButton;
    }
}