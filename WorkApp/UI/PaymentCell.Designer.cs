namespace WorkApp.UI
{
    partial class PaymentCell
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textbox1 = new ns1.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "amount";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaymentCell_MouseClick);
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PaymentCell_MouseDoubleClick);
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.textbox1.Location = new System.Drawing.Point(0, 0);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(69, 33);
            this.textbox1.TabIndex = 38;
            this.textbox1.Text = "textbox1";
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox1_KeyUp);
            this.textbox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textbox1_MouseClick);
            // 
            // PaymentCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label1);
            this.Name = "PaymentCell";
            this.Size = new System.Drawing.Size(69, 37);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaymentCell_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PaymentCell_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox textbox1;
    }
}
