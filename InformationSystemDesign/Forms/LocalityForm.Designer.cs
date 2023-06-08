namespace InformationSystemDesign.Forms
{
    partial class LocalityForm
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
            this._localityView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._localityView)).BeginInit();
            this.SuspendLayout();
            // 
            // _localityView
            // 
            this._localityView.AllowUserToAddRows = false;
            this._localityView.AllowUserToDeleteRows = false;
            this._localityView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._localityView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._localityView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this._localityView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._localityView.Location = new System.Drawing.Point(12, 12);
            this._localityView.Name = "_localityView";
            this._localityView.ReadOnly = true;
            this._localityView.RowTemplate.Height = 25;
            this._localityView.Size = new System.Drawing.Size(776, 426);
            this._localityView.TabIndex = 0;
            // 
            // LocalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._localityView);
            this.Name = "LocalityForm";
            this.Text = "Список городов";
            ((System.ComponentModel.ISupportInitialize)(this._localityView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView _localityView;
    }
}