namespace InformationSystemDesign.Forms.ReportForms
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
            this._reportGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this._gerenalDiseasesBox = new System.Windows.Forms.TextBox();
            this._generalInspectionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._reportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _reportGridView
            // 
            this._reportGridView.AllowUserToAddRows = false;
            this._reportGridView.AllowUserToDeleteRows = false;
            this._reportGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._reportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._reportGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this._reportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._reportGridView.Location = new System.Drawing.Point(12, 31);
            this._reportGridView.Name = "_reportGridView";
            this._reportGridView.ReadOnly = true;
            this._reportGridView.RowTemplate.Height = 25;
            this._reportGridView.Size = new System.Drawing.Size(776, 407);
            this._reportGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Итоговые затраты на осмотры:";
            // 
            // _gerenalDiseasesBox
            // 
            this._gerenalDiseasesBox.Location = new System.Drawing.Point(197, 5);
            this._gerenalDiseasesBox.Name = "_gerenalDiseasesBox";
            this._gerenalDiseasesBox.ReadOnly = true;
            this._gerenalDiseasesBox.Size = new System.Drawing.Size(190, 23);
            this._gerenalDiseasesBox.TabIndex = 2;
            // 
            // _generalInspectionBox
            // 
            this._generalInspectionBox.Location = new System.Drawing.Point(585, 5);
            this._generalInspectionBox.Name = "_generalInspectionBox";
            this._generalInspectionBox.ReadOnly = true;
            this._generalInspectionBox.Size = new System.Drawing.Size(190, 23);
            this._generalInspectionBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Общее количество осмотров:";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._generalInspectionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._gerenalDiseasesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._reportGridView);
            this.Name = "ReportForm";
            this.Text = "Отчёт";
            ((System.ComponentModel.ISupportInitialize)(this._reportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView _reportGridView;
        private Label label1;
        private TextBox _gerenalDiseasesBox;
        private TextBox _generalInspectionBox;
        private Label label2;
    }
}