namespace InformationSystemDesign.Forms
{
    partial class ReportForm
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
            _reportGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)_reportGridView).BeginInit();
            SuspendLayout();
            // 
            // _reportGridView
            // 
            _reportGridView.AllowUserToAddRows = false;
            _reportGridView.AllowUserToDeleteRows = false;
            _reportGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _reportGridView.Location = new Point(12, 12);
            _reportGridView.Name = "_reportGridView";
            _reportGridView.ReadOnly = true;
            _reportGridView.RowTemplate.Height = 25;
            _reportGridView.Size = new Size(776, 426);
            _reportGridView.TabIndex = 0;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_reportGridView);
            Name = "ReportForm";
            Text = "Отчёт";
            ((System.ComponentModel.ISupportInitialize)_reportGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView _reportGridView;
    }
}