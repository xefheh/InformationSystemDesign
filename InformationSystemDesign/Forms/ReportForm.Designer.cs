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
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)_reportGridView).BeginInit();
            SuspendLayout();
            // 
            // _reportGridView
            // 
            _reportGridView.AllowUserToAddRows = false;
            _reportGridView.AllowUserToDeleteRows = false;
            _reportGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _reportGridView.Location = new Point(12, 31);
            _reportGridView.Name = "_reportGridView";
            _reportGridView.ReadOnly = true;
            _reportGridView.RowTemplate.Height = 25;
            _reportGridView.Size = new Size(776, 407);
            _reportGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 1;
            label1.Text = "Итоговые затраты на осмотры:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 2;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(_reportGridView);
            Name = "ReportForm";
            Text = "Отчёт";
            ((System.ComponentModel.ISupportInitialize)_reportGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView _reportGridView;
        private Label label1;
        private TextBox textBox1;
    }
}