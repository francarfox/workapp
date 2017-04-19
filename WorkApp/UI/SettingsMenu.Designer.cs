namespace WorkApp.UI
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.slider1 = new ns1.BunifuSlider();
            this.circleProgressbar1 = new ns1.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porcentaje:";
            // 
            // slider1
            // 
            this.slider1.BackColor = System.Drawing.Color.Transparent;
            this.slider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.slider1.BorderRadius = 0;
            this.slider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.slider1.Location = new System.Drawing.Point(78, 249);
            this.slider1.MaximumValue = 100;
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(415, 28);
            this.slider1.TabIndex = 1;
            this.slider1.Value = 0;
            this.slider1.ValueChanged += new System.EventHandler(this.slider1_ValueChanged);
            // 
            // circleProgressbar1
            // 
            this.circleProgressbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleProgressbar1.animated = false;
            this.circleProgressbar1.animationIterval = 5;
            this.circleProgressbar1.animationSpeed = 300;
            this.circleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.circleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleProgressbar1.BackgroundImage")));
            this.circleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.circleProgressbar1.LabelVisible = true;
            this.circleProgressbar1.LineProgressThickness = 8;
            this.circleProgressbar1.LineThickness = 5;
            this.circleProgressbar1.Location = new System.Drawing.Point(204, 86);
            this.circleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circleProgressbar1.MaxValue = 100;
            this.circleProgressbar1.Name = "circleProgressbar1";
            this.circleProgressbar1.ProgressBackColor = System.Drawing.Color.DarkGray;
            this.circleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.circleProgressbar1.Size = new System.Drawing.Size(151, 151);
            this.circleProgressbar1.TabIndex = 2;
            this.circleProgressbar1.Value = 0;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.circleProgressbar1);
            this.Controls.Add(this.slider1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsMenu";
            this.Size = new System.Drawing.Size(553, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ns1.BunifuSlider slider1;
        private ns1.BunifuCircleProgressbar circleProgressbar1;
    }
}
