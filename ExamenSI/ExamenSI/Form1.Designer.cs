namespace ExamenSI
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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregunta1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregunta2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuV1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarRandomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(213, 327);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(419, 20);
            this.textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(213, 268);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(419, 20);
            this.textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(213, 215);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(419, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(213, 172);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(419, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(532, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menuV1ToolStripMenuItem,
            this.menuV2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregunta1ToolStripMenuItem,
            this.pregunta2ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.menuToolStripMenuItem.Text = "Examen";
            // 
            // pregunta1ToolStripMenuItem
            // 
            this.pregunta1ToolStripMenuItem.Name = "pregunta1ToolStripMenuItem";
            this.pregunta1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pregunta1ToolStripMenuItem.Text = "Pregunta 1";
            this.pregunta1ToolStripMenuItem.Click += new System.EventHandler(this.pregunta1ToolStripMenuItem_Click);
            // 
            // pregunta2ToolStripMenuItem
            // 
            this.pregunta2ToolStripMenuItem.Name = "pregunta2ToolStripMenuItem";
            this.pregunta2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pregunta2ToolStripMenuItem.Text = "Pregunta 2";
            this.pregunta2ToolStripMenuItem.Click += new System.EventHandler(this.pregunta2ToolStripMenuItem_Click);
            // 
            // menuV1ToolStripMenuItem
            // 
            this.menuV1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarRandomToolStripMenuItem,
            this.descargarToolStripMenuItem});
            this.menuV1ToolStripMenuItem.Name = "menuV1ToolStripMenuItem";
            this.menuV1ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.menuV1ToolStripMenuItem.Text = "Menu v1";
            // 
            // menuV2ToolStripMenuItem
            // 
            this.menuV2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarRandomToolStripMenuItem1,
            this.descargarToolStripMenuItem1});
            this.menuV2ToolStripMenuItem.Name = "menuV2ToolStripMenuItem";
            this.menuV2ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.menuV2ToolStripMenuItem.Text = "Menu v2";
            // 
            // cargarRandomToolStripMenuItem
            // 
            this.cargarRandomToolStripMenuItem.Name = "cargarRandomToolStripMenuItem";
            this.cargarRandomToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cargarRandomToolStripMenuItem.Text = "Cargar random";
            this.cargarRandomToolStripMenuItem.Click += new System.EventHandler(this.cargarRandomToolStripMenuItem_Click);
            // 
            // cargarRandomToolStripMenuItem1
            // 
            this.cargarRandomToolStripMenuItem1.Name = "cargarRandomToolStripMenuItem1";
            this.cargarRandomToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.cargarRandomToolStripMenuItem1.Text = "Cargar random";
            this.cargarRandomToolStripMenuItem1.Click += new System.EventHandler(this.cargarRandomToolStripMenuItem1_Click);
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.descargarToolStripMenuItem.Text = "Descargar";
            this.descargarToolStripMenuItem.Click += new System.EventHandler(this.descargarToolStripMenuItem_Click);
            // 
            // descargarToolStripMenuItem1
            // 
            this.descargarToolStripMenuItem1.Name = "descargarToolStripMenuItem1";
            this.descargarToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.descargarToolStripMenuItem1.Text = "Descargar";
            this.descargarToolStripMenuItem1.Click += new System.EventHandler(this.descargarToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 423);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregunta1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregunta2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuV1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarRandomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem1;
    }
}

