namespace WorkApp.UI
{
    partial class WorkerDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            this.edit1 = new System.Windows.Forms.PictureBox();
            this.delete1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addButton1 = new ns1.BunifuFlatButton();
            this.name1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dateListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textbox1 = new ns1.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 37);
            this.panel1.TabIndex = 1;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(14, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(20, 25);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 0;
            this.back.TabStop = false;
            this.back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.back_MouseClick);
            // 
            // edit1
            // 
            this.edit1.BackColor = System.Drawing.Color.Transparent;
            this.edit1.Image = global::WorkApp.Properties.Resources.edit;
            this.edit1.Location = new System.Drawing.Point(460, 361);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(25, 25);
            this.edit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edit1.TabIndex = 4;
            this.edit1.TabStop = false;
            this.edit1.Visible = false;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // delete1
            // 
            this.delete1.BackColor = System.Drawing.Color.Transparent;
            this.delete1.Image = global::WorkApp.Properties.Resources.delete;
            this.delete1.Location = new System.Drawing.Point(494, 358);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(24, 28);
            this.delete1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete1.TabIndex = 3;
            this.delete1.TabStop = false;
            this.delete1.Visible = false;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 38);
            this.panel2.TabIndex = 2;
            // 
            // addButton1
            // 
            this.addButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton1.BorderRadius = 0;
            this.addButton1.ButtonText = "Nuevo Monto";
            this.addButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton1.DisabledColor = System.Drawing.Color.Gray;
            this.addButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.addButton1.Iconimage = null;
            this.addButton1.Iconimage_right = null;
            this.addButton1.Iconimage_right_Selected = null;
            this.addButton1.Iconimage_Selected = null;
            this.addButton1.IconMarginLeft = 0;
            this.addButton1.IconMarginRight = 0;
            this.addButton1.IconRightVisible = true;
            this.addButton1.IconRightZoom = 0D;
            this.addButton1.IconVisible = true;
            this.addButton1.IconZoom = 90D;
            this.addButton1.IsTab = false;
            this.addButton1.Location = new System.Drawing.Point(294, 358);
            this.addButton1.Name = "addButton1";
            this.addButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.addButton1.selected = false;
            this.addButton1.Size = new System.Drawing.Size(99, 29);
            this.addButton1.TabIndex = 37;
            this.addButton1.Text = "Nuevo Monto";
            this.addButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton1.Textcolor = System.Drawing.Color.White;
            this.addButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.Location = new System.Drawing.Point(129, 48);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(37, 13);
            this.name1.TabIndex = 23;
            this.name1.Text = "name";
            this.name1.DoubleClick += new System.EventHandler(this.name1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(82, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // dateListView
            // 
            this.dateListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.dateListView.Location = new System.Drawing.Point(31, 119);
            this.dateListView.Name = "dateListView";
            this.dateListView.Size = new System.Drawing.Size(233, 218);
            this.dateListView.TabIndex = 40;
            this.dateListView.UseCompatibleStateImageBehavior = false;
            this.dateListView.View = System.Windows.Forms.View.Details;
            this.dateListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.dateListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Semana";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "40%";
            this.columnHeader2.Width = 80;
            // 
            // amountListView
            // 
            this.amountListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.amountListView.Location = new System.Drawing.Point(294, 35);
            this.amountListView.Name = "amountListView";
            this.amountListView.Size = new System.Drawing.Size(225, 302);
            this.amountListView.TabIndex = 41;
            this.amountListView.UseCompatibleStateImageBehavior = false;
            this.amountListView.View = System.Windows.Forms.View.Details;
            this.amountListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.amountListView_ItemSelectionChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Monto";
            this.columnHeader5.Width = 129;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "40%";
            this.columnHeader6.Width = 91;
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
            this.textbox1.Location = new System.Drawing.Point(131, 38);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(75, 25);
            this.textbox1.TabIndex = 42;
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox1.Visible = false;
            this.textbox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox1_KeyUp);
            // 
            // WorkerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.amountListView);
            this.Controls.Add(this.dateListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WorkerDetail";
            this.Size = new System.Drawing.Size(553, 406);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox edit1;
        private System.Windows.Forms.PictureBox delete1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton addButton1;
        private System.Windows.Forms.ListView dateListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView amountListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private ns1.BunifuMaterialTextbox textbox1;
    }
}
