namespace InformationSystemDesign.Forms.ReportForms
{
    partial class ReportCreateForm
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
            this._startPicker = new System.Windows.Forms.DateTimePicker();
            this._endPicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _startPicker
            // 
            this._startPicker.Location = new System.Drawing.Point(133, 55);
            this._startPicker.Name = "_startPicker";
            this._startPicker.Size = new System.Drawing.Size(200, 23);
            this._startPicker.TabIndex = 0;
            // 
            // _endPicker
            // 
            this._endPicker.Location = new System.Drawing.Point(133, 84);
            this._endPicker.Name = "_endPicker";
            this._endPicker.Size = new System.Drawing.Size(200, 23);
            this._endPicker.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // ReportCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._endPicker);
            this.Controls.Add(this._startPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportCreateForm";
            this.Text = "Формирование  отчёта";
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker _startPicker;
        private DateTimePicker _endPicker;
        private Button button1;
    }
}