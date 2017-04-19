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
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit1 = new System.Windows.Forms.PictureBox();
            this.delete1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.percentButton1 = new ns1.BunifuFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.paymentCell28 = new WorkApp.UI.PaymentCell();
            this.paymentCell27 = new WorkApp.UI.PaymentCell();
            this.paymentCell26 = new WorkApp.UI.PaymentCell();
            this.paymentCell21 = new WorkApp.UI.PaymentCell();
            this.paymentCell20 = new WorkApp.UI.PaymentCell();
            this.paymentCell19 = new WorkApp.UI.PaymentCell();
            this.paymentCell14 = new WorkApp.UI.PaymentCell();
            this.paymentCell13 = new WorkApp.UI.PaymentCell();
            this.paymentCell12 = new WorkApp.UI.PaymentCell();
            this.paymentCell7 = new WorkApp.UI.PaymentCell();
            this.paymentCell6 = new WorkApp.UI.PaymentCell();
            this.paymentCell5 = new WorkApp.UI.PaymentCell();
            this.paymentCell25 = new WorkApp.UI.PaymentCell();
            this.paymentCell24 = new WorkApp.UI.PaymentCell();
            this.paymentCell23 = new WorkApp.UI.PaymentCell();
            this.paymentCell22 = new WorkApp.UI.PaymentCell();
            this.paymentCell18 = new WorkApp.UI.PaymentCell();
            this.paymentCell17 = new WorkApp.UI.PaymentCell();
            this.paymentCell16 = new WorkApp.UI.PaymentCell();
            this.paymentCell15 = new WorkApp.UI.PaymentCell();
            this.paymentCell11 = new WorkApp.UI.PaymentCell();
            this.paymentCell10 = new WorkApp.UI.PaymentCell();
            this.paymentCell9 = new WorkApp.UI.PaymentCell();
            this.paymentCell8 = new WorkApp.UI.PaymentCell();
            this.paymentCell4 = new WorkApp.UI.PaymentCell();
            this.paymentCell3 = new WorkApp.UI.PaymentCell();
            this.paymentCell2 = new WorkApp.UI.PaymentCell();
            this.paymentCell1 = new WorkApp.UI.PaymentCell();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // panel2
            // 
            this.panel2.Controls.Add(this.edit1);
            this.panel2.Controls.Add(this.delete1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 38);
            this.panel2.TabIndex = 2;
            // 
            // edit1
            // 
            this.edit1.BackColor = System.Drawing.Color.Transparent;
            this.edit1.Image = global::WorkApp.Properties.Resources.edit;
            this.edit1.Location = new System.Drawing.Point(462, 3);
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
            this.delete1.Location = new System.Drawing.Point(505, 0);
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
            this.label4.Location = new System.Drawing.Point(9, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Montos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total:";
            // 
            // total1
            // 
            this.total1.AutoSize = true;
            this.total1.Location = new System.Drawing.Point(257, 67);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(33, 13);
            this.total1.TabIndex = 21;
            this.total1.Text = "total1";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.Location = new System.Drawing.Point(61, 66);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(37, 13);
            this.name1.TabIndex = 23;
            this.name1.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // percentButton1
            // 
            this.percentButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.percentButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.percentButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.percentButton1.BorderRadius = 0;
            this.percentButton1.ButtonText = "Percent";
            this.percentButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percentButton1.DisabledColor = System.Drawing.Color.Gray;
            this.percentButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.percentButton1.Iconimage = null;
            this.percentButton1.Iconimage_right = null;
            this.percentButton1.Iconimage_right_Selected = null;
            this.percentButton1.Iconimage_Selected = null;
            this.percentButton1.IconMarginLeft = 0;
            this.percentButton1.IconMarginRight = 0;
            this.percentButton1.IconRightVisible = true;
            this.percentButton1.IconRightZoom = 0D;
            this.percentButton1.IconVisible = true;
            this.percentButton1.IconZoom = 90D;
            this.percentButton1.IsTab = false;
            this.percentButton1.Location = new System.Drawing.Point(415, 67);
            this.percentButton1.Name = "percentButton1";
            this.percentButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.percentButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.percentButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.percentButton1.selected = false;
            this.percentButton1.Size = new System.Drawing.Size(115, 75);
            this.percentButton1.TabIndex = 37;
            this.percentButton1.Text = "Percent";
            this.percentButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.percentButton1.Textcolor = System.Drawing.Color.White;
            this.percentButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentButton1.Click += new System.EventHandler(this.percent1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(14, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // paymentCell28
            // 
            this.paymentCell28.BackColor = System.Drawing.Color.White;
            this.paymentCell28.Location = new System.Drawing.Point(463, 314);
            this.paymentCell28.Name = "paymentCell28";
            this.paymentCell28.Size = new System.Drawing.Size(67, 37);
            this.paymentCell28.TabIndex = 36;
            // 
            // paymentCell27
            // 
            this.paymentCell27.BackColor = System.Drawing.Color.White;
            this.paymentCell27.Location = new System.Drawing.Point(388, 314);
            this.paymentCell27.Name = "paymentCell27";
            this.paymentCell27.Size = new System.Drawing.Size(67, 37);
            this.paymentCell27.TabIndex = 35;
            // 
            // paymentCell26
            // 
            this.paymentCell26.BackColor = System.Drawing.Color.White;
            this.paymentCell26.Location = new System.Drawing.Point(313, 314);
            this.paymentCell26.Name = "paymentCell26";
            this.paymentCell26.Size = new System.Drawing.Size(67, 37);
            this.paymentCell26.TabIndex = 34;
            // 
            // paymentCell21
            // 
            this.paymentCell21.BackColor = System.Drawing.Color.White;
            this.paymentCell21.Location = new System.Drawing.Point(463, 271);
            this.paymentCell21.Name = "paymentCell21";
            this.paymentCell21.Size = new System.Drawing.Size(67, 37);
            this.paymentCell21.TabIndex = 33;
            // 
            // paymentCell20
            // 
            this.paymentCell20.BackColor = System.Drawing.Color.White;
            this.paymentCell20.Location = new System.Drawing.Point(388, 271);
            this.paymentCell20.Name = "paymentCell20";
            this.paymentCell20.Size = new System.Drawing.Size(67, 37);
            this.paymentCell20.TabIndex = 32;
            // 
            // paymentCell19
            // 
            this.paymentCell19.BackColor = System.Drawing.Color.White;
            this.paymentCell19.Location = new System.Drawing.Point(313, 271);
            this.paymentCell19.Name = "paymentCell19";
            this.paymentCell19.Size = new System.Drawing.Size(67, 37);
            this.paymentCell19.TabIndex = 31;
            // 
            // paymentCell14
            // 
            this.paymentCell14.BackColor = System.Drawing.Color.White;
            this.paymentCell14.Location = new System.Drawing.Point(463, 228);
            this.paymentCell14.Name = "paymentCell14";
            this.paymentCell14.Size = new System.Drawing.Size(67, 37);
            this.paymentCell14.TabIndex = 30;
            // 
            // paymentCell13
            // 
            this.paymentCell13.BackColor = System.Drawing.Color.White;
            this.paymentCell13.Location = new System.Drawing.Point(388, 228);
            this.paymentCell13.Name = "paymentCell13";
            this.paymentCell13.Size = new System.Drawing.Size(67, 37);
            this.paymentCell13.TabIndex = 29;
            // 
            // paymentCell12
            // 
            this.paymentCell12.BackColor = System.Drawing.Color.White;
            this.paymentCell12.Location = new System.Drawing.Point(313, 228);
            this.paymentCell12.Name = "paymentCell12";
            this.paymentCell12.Size = new System.Drawing.Size(67, 37);
            this.paymentCell12.TabIndex = 28;
            // 
            // paymentCell7
            // 
            this.paymentCell7.BackColor = System.Drawing.Color.White;
            this.paymentCell7.Location = new System.Drawing.Point(463, 185);
            this.paymentCell7.Name = "paymentCell7";
            this.paymentCell7.Size = new System.Drawing.Size(67, 37);
            this.paymentCell7.TabIndex = 27;
            // 
            // paymentCell6
            // 
            this.paymentCell6.BackColor = System.Drawing.Color.White;
            this.paymentCell6.Location = new System.Drawing.Point(388, 185);
            this.paymentCell6.Name = "paymentCell6";
            this.paymentCell6.Size = new System.Drawing.Size(67, 37);
            this.paymentCell6.TabIndex = 26;
            // 
            // paymentCell5
            // 
            this.paymentCell5.BackColor = System.Drawing.Color.White;
            this.paymentCell5.Location = new System.Drawing.Point(313, 185);
            this.paymentCell5.Name = "paymentCell5";
            this.paymentCell5.Size = new System.Drawing.Size(67, 37);
            this.paymentCell5.TabIndex = 25;
            // 
            // paymentCell25
            // 
            this.paymentCell25.BackColor = System.Drawing.Color.White;
            this.paymentCell25.Location = new System.Drawing.Point(238, 314);
            this.paymentCell25.Name = "paymentCell25";
            this.paymentCell25.Size = new System.Drawing.Size(67, 37);
            this.paymentCell25.TabIndex = 19;
            // 
            // paymentCell24
            // 
            this.paymentCell24.BackColor = System.Drawing.Color.White;
            this.paymentCell24.Location = new System.Drawing.Point(163, 314);
            this.paymentCell24.Name = "paymentCell24";
            this.paymentCell24.Size = new System.Drawing.Size(67, 37);
            this.paymentCell24.TabIndex = 18;
            // 
            // paymentCell23
            // 
            this.paymentCell23.BackColor = System.Drawing.Color.White;
            this.paymentCell23.Location = new System.Drawing.Point(88, 314);
            this.paymentCell23.Name = "paymentCell23";
            this.paymentCell23.Size = new System.Drawing.Size(67, 37);
            this.paymentCell23.TabIndex = 17;
            // 
            // paymentCell22
            // 
            this.paymentCell22.BackColor = System.Drawing.Color.White;
            this.paymentCell22.Location = new System.Drawing.Point(12, 314);
            this.paymentCell22.Name = "paymentCell22";
            this.paymentCell22.Size = new System.Drawing.Size(67, 37);
            this.paymentCell22.TabIndex = 16;
            // 
            // paymentCell18
            // 
            this.paymentCell18.BackColor = System.Drawing.Color.White;
            this.paymentCell18.Location = new System.Drawing.Point(238, 271);
            this.paymentCell18.Name = "paymentCell18";
            this.paymentCell18.Size = new System.Drawing.Size(67, 37);
            this.paymentCell18.TabIndex = 15;
            // 
            // paymentCell17
            // 
            this.paymentCell17.BackColor = System.Drawing.Color.White;
            this.paymentCell17.Location = new System.Drawing.Point(163, 271);
            this.paymentCell17.Name = "paymentCell17";
            this.paymentCell17.Size = new System.Drawing.Size(67, 37);
            this.paymentCell17.TabIndex = 14;
            // 
            // paymentCell16
            // 
            this.paymentCell16.BackColor = System.Drawing.Color.White;
            this.paymentCell16.Location = new System.Drawing.Point(88, 271);
            this.paymentCell16.Name = "paymentCell16";
            this.paymentCell16.Size = new System.Drawing.Size(67, 37);
            this.paymentCell16.TabIndex = 13;
            // 
            // paymentCell15
            // 
            this.paymentCell15.BackColor = System.Drawing.Color.White;
            this.paymentCell15.Location = new System.Drawing.Point(12, 271);
            this.paymentCell15.Name = "paymentCell15";
            this.paymentCell15.Size = new System.Drawing.Size(67, 37);
            this.paymentCell15.TabIndex = 12;
            // 
            // paymentCell11
            // 
            this.paymentCell11.BackColor = System.Drawing.Color.White;
            this.paymentCell11.Location = new System.Drawing.Point(238, 228);
            this.paymentCell11.Name = "paymentCell11";
            this.paymentCell11.Size = new System.Drawing.Size(67, 37);
            this.paymentCell11.TabIndex = 11;
            // 
            // paymentCell10
            // 
            this.paymentCell10.BackColor = System.Drawing.Color.White;
            this.paymentCell10.Location = new System.Drawing.Point(163, 228);
            this.paymentCell10.Name = "paymentCell10";
            this.paymentCell10.Size = new System.Drawing.Size(67, 37);
            this.paymentCell10.TabIndex = 10;
            // 
            // paymentCell9
            // 
            this.paymentCell9.BackColor = System.Drawing.Color.White;
            this.paymentCell9.Location = new System.Drawing.Point(88, 228);
            this.paymentCell9.Name = "paymentCell9";
            this.paymentCell9.Size = new System.Drawing.Size(67, 37);
            this.paymentCell9.TabIndex = 9;
            // 
            // paymentCell8
            // 
            this.paymentCell8.BackColor = System.Drawing.Color.White;
            this.paymentCell8.Location = new System.Drawing.Point(12, 228);
            this.paymentCell8.Name = "paymentCell8";
            this.paymentCell8.Size = new System.Drawing.Size(67, 37);
            this.paymentCell8.TabIndex = 8;
            // 
            // paymentCell4
            // 
            this.paymentCell4.BackColor = System.Drawing.Color.White;
            this.paymentCell4.Location = new System.Drawing.Point(238, 185);
            this.paymentCell4.Name = "paymentCell4";
            this.paymentCell4.Size = new System.Drawing.Size(67, 37);
            this.paymentCell4.TabIndex = 7;
            // 
            // paymentCell3
            // 
            this.paymentCell3.BackColor = System.Drawing.Color.White;
            this.paymentCell3.Location = new System.Drawing.Point(163, 185);
            this.paymentCell3.Name = "paymentCell3";
            this.paymentCell3.Size = new System.Drawing.Size(67, 37);
            this.paymentCell3.TabIndex = 6;
            // 
            // paymentCell2
            // 
            this.paymentCell2.BackColor = System.Drawing.Color.White;
            this.paymentCell2.Location = new System.Drawing.Point(88, 185);
            this.paymentCell2.Name = "paymentCell2";
            this.paymentCell2.Size = new System.Drawing.Size(67, 37);
            this.paymentCell2.TabIndex = 5;
            // 
            // paymentCell1
            // 
            this.paymentCell1.BackColor = System.Drawing.Color.White;
            this.paymentCell1.Location = new System.Drawing.Point(12, 185);
            this.paymentCell1.Name = "paymentCell1";
            this.paymentCell1.Size = new System.Drawing.Size(67, 37);
            this.paymentCell1.TabIndex = 4;
            // 
            // WorkerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.percentButton1);
            this.Controls.Add(this.paymentCell28);
            this.Controls.Add(this.paymentCell27);
            this.Controls.Add(this.paymentCell26);
            this.Controls.Add(this.paymentCell21);
            this.Controls.Add(this.paymentCell20);
            this.Controls.Add(this.paymentCell19);
            this.Controls.Add(this.paymentCell14);
            this.Controls.Add(this.paymentCell13);
            this.Controls.Add(this.paymentCell12);
            this.Controls.Add(this.paymentCell7);
            this.Controls.Add(this.paymentCell6);
            this.Controls.Add(this.paymentCell5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.total1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymentCell25);
            this.Controls.Add(this.paymentCell24);
            this.Controls.Add(this.paymentCell23);
            this.Controls.Add(this.paymentCell22);
            this.Controls.Add(this.paymentCell18);
            this.Controls.Add(this.paymentCell17);
            this.Controls.Add(this.paymentCell16);
            this.Controls.Add(this.paymentCell15);
            this.Controls.Add(this.paymentCell11);
            this.Controls.Add(this.paymentCell10);
            this.Controls.Add(this.paymentCell9);
            this.Controls.Add(this.paymentCell8);
            this.Controls.Add(this.paymentCell4);
            this.Controls.Add(this.paymentCell3);
            this.Controls.Add(this.paymentCell2);
            this.Controls.Add(this.paymentCell1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WorkerDetail";
            this.Size = new System.Drawing.Size(553, 406);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private PaymentCell paymentCell1;
        private PaymentCell paymentCell2;
        private PaymentCell paymentCell3;
        private PaymentCell paymentCell4;
        private PaymentCell paymentCell8;
        private PaymentCell paymentCell9;
        private PaymentCell paymentCell10;
        private PaymentCell paymentCell11;
        private PaymentCell paymentCell15;
        private PaymentCell paymentCell16;
        private PaymentCell paymentCell17;
        private PaymentCell paymentCell18;
        private PaymentCell paymentCell22;
        private PaymentCell paymentCell23;
        private PaymentCell paymentCell24;
        private PaymentCell paymentCell25;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label label1;
        private PaymentCell paymentCell28;
        private PaymentCell paymentCell27;
        private PaymentCell paymentCell26;
        private PaymentCell paymentCell21;
        private PaymentCell paymentCell20;
        private PaymentCell paymentCell19;
        private PaymentCell paymentCell14;
        private PaymentCell paymentCell13;
        private PaymentCell paymentCell12;
        private PaymentCell paymentCell7;
        private PaymentCell paymentCell6;
        private PaymentCell paymentCell5;
        private ns1.BunifuFlatButton percentButton1;
    }
}
