﻿namespace WorkApp.UI
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
            this.edit1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.delete1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textbox1 = new ns1.BunifuMaterialTextbox();
            this.addButton1 = new ns1.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dateListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edit1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.delete1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 37);
            this.panel1.TabIndex = 1;
            // 
            // edit1
            // 
            this.edit1.BackColor = System.Drawing.Color.Transparent;
            this.edit1.Image = global::WorkApp.Properties.Resources.edit;
            this.edit1.Location = new System.Drawing.Point(482, 9);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(25, 25);
            this.edit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edit1.TabIndex = 4;
            this.edit1.TabStop = false;
            this.edit1.Visible = false;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
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
            // delete1
            // 
            this.delete1.BackColor = System.Drawing.Color.Transparent;
            this.delete1.Image = global::WorkApp.Properties.Resources.delete;
            this.delete1.Location = new System.Drawing.Point(513, 6);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(24, 28);
            this.delete1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete1.TabIndex = 3;
            this.delete1.TabStop = false;
            this.delete1.Visible = false;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Montos:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textbox1);
            this.panel2.Controls.Add(this.addButton1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.total1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 38);
            this.panel2.TabIndex = 2;
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
            this.textbox1.Location = new System.Drawing.Point(369, -4);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(74, 33);
            this.textbox1.TabIndex = 39;
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton1
            // 
            this.addButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton1.BorderRadius = 0;
            this.addButton1.ButtonText = "Agregar";
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
            this.addButton1.Location = new System.Drawing.Point(460, 3);
            this.addButton1.Name = "addButton1";
            this.addButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.addButton1.selected = false;
            this.addButton1.Size = new System.Drawing.Size(77, 26);
            this.addButton1.TabIndex = 37;
            this.addButton1.Text = "Agregar";
            this.addButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton1.Textcolor = System.Drawing.Color.White;
            this.addButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total:";
            // 
            // total1
            // 
            this.total1.AutoSize = true;
            this.total1.Location = new System.Drawing.Point(222, 3);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(33, 13);
            this.total1.TabIndex = 21;
            this.total1.Text = "total1";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.Location = new System.Drawing.Point(61, 68);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(37, 13);
            this.name1.TabIndex = 23;
            this.name1.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(14, 58);
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
            this.dateListView.Location = new System.Drawing.Point(14, 131);
            this.dateListView.Name = "dateListView";
            this.dateListView.Size = new System.Drawing.Size(250, 231);
            this.dateListView.TabIndex = 40;
            this.dateListView.UseCompatibleStateImageBehavior = false;
            this.dateListView.View = System.Windows.Forms.View.Details;
            this.dateListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.dateListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 34;
            // 
            // amountListView
            // 
            this.amountListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.amountListView.Location = new System.Drawing.Point(281, 43);
            this.amountListView.Name = "amountListView";
            this.amountListView.Size = new System.Drawing.Size(256, 319);
            this.amountListView.TabIndex = 41;
            this.amountListView.UseCompatibleStateImageBehavior = false;
            this.amountListView.View = System.Windows.Forms.View.Details;
            this.amountListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.amountListView_ItemSelectionChanged);
            // 
            // WorkerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total1;
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
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private ns1.BunifuMaterialTextbox textbox1;
    }
}
