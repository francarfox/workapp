namespace WorkApp.UI
{
    partial class PaymentForm
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
            this.textbox1 = new ns1.BunifuMaterialTextbox();
            this.acceptButton1 = new ns1.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateButton1 = new ns1.BunifuFlatButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.Control;
            this.textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox1.HintForeColor = System.Drawing.Color.Empty;
            this.textbox1.HintText = "";
            this.textbox1.isPassword = false;
            this.textbox1.LineFocusedColor = System.Drawing.Color.Green;
            this.textbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.textbox1.LineMouseHoverColor = System.Drawing.Color.Green;
            this.textbox1.LineThickness = 3;
            this.textbox1.Location = new System.Drawing.Point(106, 38);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(90, 33);
            this.textbox1.TabIndex = 40;
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox1_KeyUp);
            // 
            // acceptButton1
            // 
            this.acceptButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.acceptButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.acceptButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acceptButton1.BorderRadius = 0;
            this.acceptButton1.ButtonText = "Aceptar";
            this.acceptButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton1.DisabledColor = System.Drawing.Color.Gray;
            this.acceptButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.acceptButton1.Iconimage = null;
            this.acceptButton1.Iconimage_right = null;
            this.acceptButton1.Iconimage_right_Selected = null;
            this.acceptButton1.Iconimage_Selected = null;
            this.acceptButton1.IconMarginLeft = 0;
            this.acceptButton1.IconMarginRight = 0;
            this.acceptButton1.IconRightVisible = true;
            this.acceptButton1.IconRightZoom = 0D;
            this.acceptButton1.IconVisible = true;
            this.acceptButton1.IconZoom = 90D;
            this.acceptButton1.IsTab = false;
            this.acceptButton1.Location = new System.Drawing.Point(92, 209);
            this.acceptButton1.Name = "acceptButton1";
            this.acceptButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.acceptButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.acceptButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.acceptButton1.selected = false;
            this.acceptButton1.Size = new System.Drawing.Size(114, 40);
            this.acceptButton1.TabIndex = 41;
            this.acceptButton1.Text = "Aceptar";
            this.acceptButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.acceptButton1.Textcolor = System.Drawing.Color.White;
            this.acceptButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton1.Click += new System.EventHandler(this.acceptButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Fecha:";
            // 
            // dateButton1
            // 
            this.dateButton1.Activecolor = System.Drawing.SystemColors.ActiveBorder;
            this.dateButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dateButton1.BorderRadius = 0;
            this.dateButton1.ButtonText = "Fecha";
            this.dateButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateButton1.DisabledColor = System.Drawing.Color.Gray;
            this.dateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.dateButton1.Iconimage = null;
            this.dateButton1.Iconimage_right = null;
            this.dateButton1.Iconimage_right_Selected = null;
            this.dateButton1.Iconimage_Selected = null;
            this.dateButton1.IconMarginLeft = 0;
            this.dateButton1.IconMarginRight = 0;
            this.dateButton1.IconRightVisible = true;
            this.dateButton1.IconRightZoom = 0D;
            this.dateButton1.IconVisible = true;
            this.dateButton1.IconZoom = 90D;
            this.dateButton1.IsTab = false;
            this.dateButton1.Location = new System.Drawing.Point(92, 109);
            this.dateButton1.Name = "dateButton1";
            this.dateButton1.Normalcolor = System.Drawing.SystemColors.ActiveBorder;
            this.dateButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dateButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.dateButton1.selected = false;
            this.dateButton1.Size = new System.Drawing.Size(121, 32);
            this.dateButton1.TabIndex = 44;
            this.dateButton1.Text = "Fecha";
            this.dateButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateButton1.Textcolor = System.Drawing.Color.White;
            this.dateButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateButton1.Click += new System.EventHandler(this.dateButton1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 90);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 45;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.acceptButton1);
            this.Controls.Add(this.textbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.ShowIcon = false;
            this.Text = "Editar Monto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuMaterialTextbox textbox1;
        private ns1.BunifuFlatButton acceptButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton dateButton1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}