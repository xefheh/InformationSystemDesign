namespace InformationSystemDesign.Forms
{
    partial class InspectionForm
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
            _inspectionGridView = new DataGridView();
            _addInspectionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)_inspectionGridView).BeginInit();
            SuspendLayout();
            // 
            // _inspectionGridView
            // 
            _inspectionGridView.AllowUserToAddRows = false;
            _inspectionGridView.AllowUserToDeleteRows = false;
            _inspectionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _inspectionGridView.Location = new Point(12, 32);
            _inspectionGridView.Name = "_inspectionGridView";
            _inspectionGridView.ReadOnly = true;
            _inspectionGridView.RowTemplate.Height = 25;
            _inspectionGridView.Size = new Size(776, 406);
            _inspectionGridView.TabIndex = 0;
            // 
            // _addInspectionButton
            // 
            _addInspectionButton.Location = new Point(12, 3);
            _addInspectionButton.Name = "_addInspectionButton";
            _addInspectionButton.Size = new Size(225, 23);
            _addInspectionButton.TabIndex = 1;
            _addInspectionButton.Text = "Добавить осмотр";
            _addInspectionButton.UseVisualStyleBackColor = true;
            _addInspectionButton.Click += _addInspectionButton_Click;
            // 
            // InspectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_addInspectionButton);
            Controls.Add(_inspectionGridView);
            Name = "InspectionForm";
            Text = "InspectionForm";
            ((System.ComponentModel.ISupportInitialize)_inspectionGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView _inspectionGridView;
        private Button _addInspectionButton;
    }
}