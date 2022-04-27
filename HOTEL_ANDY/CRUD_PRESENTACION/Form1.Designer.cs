namespace CRUD_PRESENTACION
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
            System.Windows.Forms.Button button1;
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panelvertical = new System.Windows.Forms.Panel();
            this.lblcargo = new System.Windows.Forms.Label();
            this.carg = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PANELPRINCIPAL = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.REPORTES = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnempleado = new System.Windows.Forms.Button();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.maximisar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            this.panelvertical.SuspendLayout();
            this.PANELPRINCIPAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BarraTitulo.Controls.Add(this.restaurar);
            this.BarraTitulo.Controls.Add(this.pictureBox3);
            this.BarraTitulo.Controls.Add(this.maximisar);
            this.BarraTitulo.Controls.Add(this.cerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1834, 40);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // panelvertical
            // 
            this.panelvertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelvertical.Controls.Add(this.panel5);
            this.panelvertical.Controls.Add(this.panel4);
            this.panelvertical.Controls.Add(this.REPORTES);
            this.panelvertical.Controls.Add(button1);
            this.panelvertical.Controls.Add(this.lblcargo);
            this.panelvertical.Controls.Add(this.pictureBox2);
            this.panelvertical.Controls.Add(this.carg);
            this.panelvertical.Controls.Add(this.pictureBox1);
            this.panelvertical.Controls.Add(this.panel2);
            this.panelvertical.Controls.Add(this.btnempleado);
            this.panelvertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelvertical.Location = new System.Drawing.Point(0, 40);
            this.panelvertical.Name = "panelvertical";
            this.panelvertical.Size = new System.Drawing.Size(258, 921);
            this.panelvertical.TabIndex = 1;
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcargo.Location = new System.Drawing.Point(165, 125);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(50, 16);
            this.lblcargo.TabIndex = 14;
            this.lblcargo.Text = "Cargo";
            // 
            // carg
            // 
            this.carg.AutoSize = true;
            this.carg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.carg.Location = new System.Drawing.Point(165, 91);
            this.carg.Name = "carg";
            this.carg.Size = new System.Drawing.Size(50, 13);
            this.carg.TabIndex = 13;
            this.carg.Text = "CARGO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Location = new System.Drawing.Point(12, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 38);
            this.panel2.TabIndex = 3;
            // 
            // PANELPRINCIPAL
            // 
            this.PANELPRINCIPAL.Controls.Add(this.pictureBox4);
            this.PANELPRINCIPAL.Location = new System.Drawing.Point(256, 40);
            this.PANELPRINCIPAL.Name = "PANELPRINCIPAL";
            this.PANELPRINCIPAL.Size = new System.Drawing.Size(1578, 921);
            this.PANELPRINCIPAL.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel4.Location = new System.Drawing.Point(12, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 38);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel5.Location = new System.Drawing.Point(12, 237);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 38);
            this.panel5.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CRUD_PRESENTACION.Properties.Resources.hotel_hazel_1;
            this.pictureBox4.Location = new System.Drawing.Point(321, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1025, 684);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // REPORTES
            // 
            this.REPORTES.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.REPORTES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.REPORTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REPORTES.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.REPORTES.Image = global::CRUD_PRESENTACION.Properties.Resources.diagrama;
            this.REPORTES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.REPORTES.Location = new System.Drawing.Point(15, 237);
            this.REPORTES.Name = "REPORTES";
            this.REPORTES.Size = new System.Drawing.Size(146, 38);
            this.REPORTES.TabIndex = 16;
            this.REPORTES.Text = "REPORTES";
            this.REPORTES.UseVisualStyleBackColor = true;
            this.REPORTES.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Image = global::CRUD_PRESENTACION.Properties.Resources.hombre;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(15, 182);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(146, 38);
            button1.TabIndex = 15;
            button1.Text = "CLIENTE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRUD_PRESENTACION.Properties.Resources.empresarios;
            this.pictureBox2.Location = new System.Drawing.Point(159, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRUD_PRESENTACION.Properties.Resources.hotel;
            this.pictureBox1.Location = new System.Drawing.Point(9, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnempleado
            // 
            this.btnempleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnempleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnempleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnempleado.Image = global::CRUD_PRESENTACION.Properties.Resources.administracion;
            this.btnempleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleado.Location = new System.Drawing.Point(12, 293);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(149, 38);
            this.btnempleado.TabIndex = 2;
            this.btnempleado.Text = "EMPLEADO";
            this.btnempleado.UseVisualStyleBackColor = false;
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurar.Image = global::CRUD_PRESENTACION.Properties.Resources.res;
            this.restaurar.Location = new System.Drawing.Point(1748, 6);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(30, 31);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar.TabIndex = 3;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::CRUD_PRESENTACION.Properties.Resources.minimazar;
            this.pictureBox3.Location = new System.Drawing.Point(1706, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // maximisar
            // 
            this.maximisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximisar.Image = global::CRUD_PRESENTACION.Properties.Resources.maxi;
            this.maximisar.Location = new System.Drawing.Point(1748, 9);
            this.maximisar.Name = "maximisar";
            this.maximisar.Size = new System.Drawing.Size(27, 28);
            this.maximisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximisar.TabIndex = 1;
            this.maximisar.TabStop = false;
            this.maximisar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = global::CRUD_PRESENTACION.Properties.Resources.cerrar1;
            this.cerrar.Location = new System.Drawing.Point(1793, 4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(40, 33);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 961);
            this.Controls.Add(this.PANELPRINCIPAL);
            this.Controls.Add(this.panelvertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            this.panelvertical.ResumeLayout(false);
            this.panelvertical.PerformLayout();
            this.PANELPRINCIPAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panelvertical;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox maximisar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Panel PANELPRINCIPAL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label carg;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button REPORTES;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

