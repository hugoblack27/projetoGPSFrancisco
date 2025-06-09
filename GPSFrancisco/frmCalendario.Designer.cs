namespace GPSFrancisco
{
    partial class frmCalendario
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
            this.dtpFormatlong = new System.Windows.Forms.DateTimePicker();
            this.cldCalendario = new System.Windows.Forms.MonthCalendar();
            this.dtpFormatshort = new System.Windows.Forms.DateTimePicker();
            this.dtpFormattime = new System.Windows.Forms.DateTimePicker();
            this.dtpFormatcustom = new System.Windows.Forms.DateTimePicker();
            this.btnCarregadata = new System.Windows.Forms.Button();
            this.txtCalendario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpFormatlong
            // 
            this.dtpFormatlong.Location = new System.Drawing.Point(34, 74);
            this.dtpFormatlong.Name = "dtpFormatlong";
            this.dtpFormatlong.Size = new System.Drawing.Size(220, 20);
            this.dtpFormatlong.TabIndex = 0;
            // 
            // cldCalendario
            // 
            this.cldCalendario.Location = new System.Drawing.Point(377, 48);
            this.cldCalendario.Name = "cldCalendario";
            this.cldCalendario.TabIndex = 1;
            this.cldCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cldCalendario_DateChanged);
            this.cldCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldCalendario_DateSelected);
            // 
            // dtpFormatshort
            // 
            this.dtpFormatshort.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFormatshort.Location = new System.Drawing.Point(34, 128);
            this.dtpFormatshort.Name = "dtpFormatshort";
            this.dtpFormatshort.Size = new System.Drawing.Size(200, 20);
            this.dtpFormatshort.TabIndex = 2;
            // 
            // dtpFormattime
            // 
            this.dtpFormattime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFormattime.Location = new System.Drawing.Point(34, 190);
            this.dtpFormattime.Name = "dtpFormattime";
            this.dtpFormattime.Size = new System.Drawing.Size(200, 20);
            this.dtpFormattime.TabIndex = 3;
            // 
            // dtpFormatcustom
            // 
            this.dtpFormatcustom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFormatcustom.Location = new System.Drawing.Point(34, 251);
            this.dtpFormatcustom.Name = "dtpFormatcustom";
            this.dtpFormatcustom.Size = new System.Drawing.Size(200, 20);
            this.dtpFormatcustom.TabIndex = 4;
            // 
            // btnCarregadata
            // 
            this.btnCarregadata.Location = new System.Drawing.Point(399, 281);
            this.btnCarregadata.Name = "btnCarregadata";
            this.btnCarregadata.Size = new System.Drawing.Size(188, 23);
            this.btnCarregadata.TabIndex = 5;
            this.btnCarregadata.Text = "Carregar data";
            this.btnCarregadata.UseVisualStyleBackColor = true;
            this.btnCarregadata.Click += new System.EventHandler(this.btnCarregadata_Click);
            // 
            // txtCalendario
            // 
            this.txtCalendario.Location = new System.Drawing.Point(377, 234);
            this.txtCalendario.Name = "txtCalendario";
            this.txtCalendario.Size = new System.Drawing.Size(227, 20);
            this.txtCalendario.TabIndex = 6;
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCalendario);
            this.Controls.Add(this.btnCarregadata);
            this.Controls.Add(this.dtpFormatcustom);
            this.Controls.Add(this.dtpFormattime);
            this.Controls.Add(this.dtpFormatshort);
            this.Controls.Add(this.cldCalendario);
            this.Controls.Add(this.dtpFormatlong);
            this.Name = "frmCalendario";
            this.Text = "frmCalendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFormatlong;
        private System.Windows.Forms.MonthCalendar cldCalendario;
        private System.Windows.Forms.DateTimePicker dtpFormatshort;
        private System.Windows.Forms.DateTimePicker dtpFormattime;
        private System.Windows.Forms.DateTimePicker dtpFormatcustom;
        private System.Windows.Forms.Button btnCarregadata;
        private System.Windows.Forms.TextBox txtCalendario;
    }
}