namespace WorkApp
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.username = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.homeMenu1 = new WorkApp.UI.HomeMenu();
            this.workersMenu1 = new WorkApp.UI.WorkersMenu();
            this.settingsMenu1 = new WorkApp.UI.SettingsMenu();
            this.menu3 = new ns1.BunifuFlatButton();
            this.menu2 = new ns1.BunifuFlatButton();
            this.menu1 = new ns1.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(17, 13);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(84, 17);
            this.username.TabIndex = 1;
            this.username.Text = "username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.topPanel.Controls.Add(this.username);
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(706, 42);
            this.topPanel.TabIndex = 12;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.sidePanel.Controls.Add(this.menu3);
            this.sidePanel.Controls.Add(this.menu2);
            this.sidePanel.Controls.Add(this.menu1);
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 42);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(153, 406);
            this.sidePanel.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 84);
            this.panel1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // homeMenu1
            // 
            this.homeMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeMenu1.Location = new System.Drawing.Point(153, 42);
            this.homeMenu1.Name = "homeMenu1";
            this.homeMenu1.Size = new System.Drawing.Size(553, 406);
            this.homeMenu1.TabIndex = 15;
            // 
            // workersMenu1
            // 
            this.workersMenu1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.workersMenu1.Location = new System.Drawing.Point(153, 42);
            this.workersMenu1.Name = "workersMenu1";
            this.workersMenu1.Size = new System.Drawing.Size(553, 406);
            this.workersMenu1.TabIndex = 15;
            // 
            // settingsMenu1
            // 
            this.settingsMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsMenu1.Location = new System.Drawing.Point(153, 42);
            this.settingsMenu1.Name = "settingsMenu1";
            this.settingsMenu1.Size = new System.Drawing.Size(553, 406);
            this.settingsMenu1.TabIndex = 14;
            // 
            // menu3
            // 
            this.menu3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.menu3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.menu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu3.BorderRadius = 0;
            this.menu3.ButtonText = "Opciones";
            this.menu3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu3.DisabledColor = System.Drawing.Color.Gray;
            this.menu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu3.Iconcolor = System.Drawing.Color.Transparent;
            this.menu3.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu3.Iconimage")));
            this.menu3.Iconimage_right = null;
            this.menu3.Iconimage_right_Selected = null;
            this.menu3.Iconimage_Selected = null;
            this.menu3.IconMarginLeft = 0;
            this.menu3.IconMarginRight = 0;
            this.menu3.IconRightVisible = true;
            this.menu3.IconRightZoom = 0D;
            this.menu3.IconVisible = true;
            this.menu3.IconZoom = 90D;
            this.menu3.IsTab = true;
            this.menu3.Location = new System.Drawing.Point(0, 180);
            this.menu3.Name = "menu3";
            this.menu3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.menu3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.menu3.OnHoverTextColor = System.Drawing.Color.White;
            this.menu3.selected = false;
            this.menu3.Size = new System.Drawing.Size(153, 48);
            this.menu3.TabIndex = 3;
            this.menu3.Text = "Opciones";
            this.menu3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu3.Textcolor = System.Drawing.Color.White;
            this.menu3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu3.Click += new System.EventHandler(this.menu3_Click);
            // 
            // menu2
            // 
            this.menu2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.menu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.menu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu2.BorderRadius = 0;
            this.menu2.ButtonText = "Trabajo";
            this.menu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu2.DisabledColor = System.Drawing.Color.Gray;
            this.menu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2.Iconcolor = System.Drawing.Color.Transparent;
            this.menu2.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu2.Iconimage")));
            this.menu2.Iconimage_right = null;
            this.menu2.Iconimage_right_Selected = null;
            this.menu2.Iconimage_Selected = null;
            this.menu2.IconMarginLeft = 0;
            this.menu2.IconMarginRight = 0;
            this.menu2.IconRightVisible = true;
            this.menu2.IconRightZoom = 0D;
            this.menu2.IconVisible = true;
            this.menu2.IconZoom = 90D;
            this.menu2.IsTab = true;
            this.menu2.Location = new System.Drawing.Point(0, 132);
            this.menu2.Name = "menu2";
            this.menu2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.menu2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.menu2.OnHoverTextColor = System.Drawing.Color.White;
            this.menu2.selected = false;
            this.menu2.Size = new System.Drawing.Size(153, 48);
            this.menu2.TabIndex = 2;
            this.menu2.Text = "Trabajo";
            this.menu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2.Textcolor = System.Drawing.Color.White;
            this.menu2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2.Click += new System.EventHandler(this.menu2_Click);
            // 
            // menu1
            // 
            this.menu1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.menu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu1.BorderRadius = 0;
            this.menu1.ButtonText = "Inicio";
            this.menu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu1.DisabledColor = System.Drawing.Color.Gray;
            this.menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1.Iconcolor = System.Drawing.Color.Transparent;
            this.menu1.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu1.Iconimage")));
            this.menu1.Iconimage_right = null;
            this.menu1.Iconimage_right_Selected = null;
            this.menu1.Iconimage_Selected = null;
            this.menu1.IconMarginLeft = 0;
            this.menu1.IconMarginRight = 0;
            this.menu1.IconRightVisible = true;
            this.menu1.IconRightZoom = 0D;
            this.menu1.IconVisible = true;
            this.menu1.IconZoom = 90D;
            this.menu1.IsTab = true;
            this.menu1.Location = new System.Drawing.Point(0, 84);
            this.menu1.Name = "menu1";
            this.menu1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.menu1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.menu1.OnHoverTextColor = System.Drawing.Color.White;
            this.menu1.selected = false;
            this.menu1.Size = new System.Drawing.Size(153, 48);
            this.menu1.TabIndex = 1;
            this.menu1.Text = "Inicio";
            this.menu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu1.Textcolor = System.Drawing.Color.White;
            this.menu1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(664, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(706, 448);
            this.Controls.Add(this.homeMenu1);
            this.Controls.Add(this.workersMenu1);
            this.Controls.Add(this.settingsMenu1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "WorkApp";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel sidePanel;
        private ns1.BunifuFlatButton menu3;
        private ns1.BunifuFlatButton menu2;
        private ns1.BunifuFlatButton menu1;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private UI.SettingsMenu settingsMenu1;
        private UI.WorkersMenu workersMenu1;
        private UI.HomeMenu homeMenu1;
    }
}

