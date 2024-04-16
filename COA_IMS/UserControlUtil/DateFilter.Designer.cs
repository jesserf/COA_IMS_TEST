namespace COA_IMS.UserControlUtil
{
    partial class DateFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.from_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.to_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // from_DateTimePicker
            // 
            this.from_DateTimePicker.CalendarFont = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.from_DateTimePicker.Font = new System.Drawing.Font("Bahnschrift", 13.25F);
            this.from_DateTimePicker.Location = new System.Drawing.Point(2, 3);
            this.from_DateTimePicker.Name = "from_DateTimePicker";
            this.from_DateTimePicker.Size = new System.Drawing.Size(293, 29);
            this.from_DateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(301, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "TO";
            // 
            // to_DateTimePicker
            // 
            this.to_DateTimePicker.CalendarFont = new System.Drawing.Font("Bahnschrift", 15.25F);
            this.to_DateTimePicker.Font = new System.Drawing.Font("Bahnschrift", 13.25F);
            this.to_DateTimePicker.Location = new System.Drawing.Point(344, 3);
            this.to_DateTimePicker.Name = "to_DateTimePicker";
            this.to_DateTimePicker.Size = new System.Drawing.Size(293, 29);
            this.to_DateTimePicker.TabIndex = 2;
            this.to_DateTimePicker.Value = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // DateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.to_DateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from_DateTimePicker);
            this.Name = "DateFilter";
            this.Size = new System.Drawing.Size(653, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker from_DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker to_DateTimePicker;
    }
}
