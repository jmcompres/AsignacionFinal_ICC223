namespace AsignacionFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabMenuPrincipal = new TabPage();
            tabCiudades = new TabPage();
            tabJugadores = new TabPage();
            tabEquipos = new TabPage();
            tabJuegos = new TabPage();
            tabEstads = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMenuPrincipal);
            tabControl1.Controls.Add(tabCiudades);
            tabControl1.Controls.Add(tabJugadores);
            tabControl1.Controls.Add(tabEquipos);
            tabControl1.Controls.Add(tabJuegos);
            tabControl1.Controls.Add(tabEstads);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabMenuPrincipal
            // 
            tabMenuPrincipal.Location = new Point(4, 24);
            tabMenuPrincipal.Name = "tabMenuPrincipal";
            tabMenuPrincipal.Padding = new Padding(3);
            tabMenuPrincipal.Size = new Size(792, 422);
            tabMenuPrincipal.TabIndex = 0;
            tabMenuPrincipal.Text = "Menú Principal";
            tabMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // tabCiudades
            // 
            tabCiudades.Location = new Point(4, 24);
            tabCiudades.Name = "tabCiudades";
            tabCiudades.Padding = new Padding(3);
            tabCiudades.Size = new Size(792, 422);
            tabCiudades.TabIndex = 1;
            tabCiudades.Text = "Ciudades";
            tabCiudades.UseVisualStyleBackColor = true;
            // 
            // tabJugadores
            // 
            tabJugadores.Location = new Point(4, 24);
            tabJugadores.Name = "tabJugadores";
            tabJugadores.Padding = new Padding(3);
            tabJugadores.Size = new Size(792, 422);
            tabJugadores.TabIndex = 2;
            tabJugadores.Text = "Jugadores";
            tabJugadores.UseVisualStyleBackColor = true;
            // 
            // tabEquipos
            // 
            tabEquipos.Location = new Point(4, 24);
            tabEquipos.Name = "tabEquipos";
            tabEquipos.Padding = new Padding(3);
            tabEquipos.Size = new Size(792, 422);
            tabEquipos.TabIndex = 3;
            tabEquipos.Text = "Equipos";
            tabEquipos.UseVisualStyleBackColor = true;
            // 
            // tabJuegos
            // 
            tabJuegos.Location = new Point(4, 24);
            tabJuegos.Name = "tabJuegos";
            tabJuegos.Padding = new Padding(3);
            tabJuegos.Size = new Size(792, 422);
            tabJuegos.TabIndex = 4;
            tabJuegos.Text = "Juegos";
            tabJuegos.UseVisualStyleBackColor = true;
            // 
            // tabEstads
            // 
            tabEstads.Location = new Point(4, 24);
            tabEstads.Name = "tabEstads";
            tabEstads.Padding = new Padding(3);
            tabEstads.Size = new Size(792, 422);
            tabEstads.TabIndex = 5;
            tabEstads.Text = "Estadísticas";
            tabEstads.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gestor de torneo";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabMenuPrincipal;
        private TabPage tabCiudades;
        private TabPage tabJugadores;
        private TabPage tabEquipos;
        private TabPage tabJuegos;
        private TabPage tabEstads;
    }
}
