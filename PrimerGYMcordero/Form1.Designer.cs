namespace priCorderoGimnasio
{
    partial class frmInscripcion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();

            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.cboCuotas = new System.Windows.Forms.ComboBox();

            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.chkCasillero = new System.Windows.Forms.CheckBox();

            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();

            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // VENTANA
            this.Text = "Inscripción al Gimnasio";
            this.ClientSize = new System.Drawing.Size(500, 570);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            // TITULO
            this.lblTitulo.Text = "INSCRIPCIÓN AL GIMNASIO";
            this.lblTitulo.Location = new System.Drawing.Point(110, 20);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font =
                new System.Drawing.Font("Arial", 14,
                System.Drawing.FontStyle.Bold);

            // NOMBRE
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(30, 75);
            this.lblNombre.AutoSize = true;

            this.txtNombre.Location = new System.Drawing.Point(150, 70);
            this.txtNombre.Size = new System.Drawing.Size(250, 23);

            // EDAD
            this.lblEdad.Text = "Edad:";
            this.lblEdad.Location = new System.Drawing.Point(30, 115);
            this.lblEdad.AutoSize = true;

            this.txtEdad.Location = new System.Drawing.Point(150, 110);
            this.txtEdad.Size = new System.Drawing.Size(250, 23);

            // PLAN
            this.lblPlan.Text = "Plan:";
            this.lblPlan.Location = new System.Drawing.Point(30, 155);
            this.lblPlan.AutoSize = true;

            this.cboPlan.Location = new System.Drawing.Point(150, 150);
            this.cboPlan.Size = new System.Drawing.Size(250, 23);
            this.cboPlan.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // TURNO
            this.lblTurno.Text = "Turno:";
            this.lblTurno.Location = new System.Drawing.Point(30, 195);
            this.lblTurno.AutoSize = true;

            this.cboTurno.Location = new System.Drawing.Point(150, 190);
            this.cboTurno.Size = new System.Drawing.Size(250, 23);
            this.cboTurno.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // MESES
            this.lblMeses.Text = "Meses:";
            this.lblMeses.Location = new System.Drawing.Point(30, 235);
            this.lblMeses.AutoSize = true;

            this.txtMeses.Location = new System.Drawing.Point(150, 230);
            this.txtMeses.Size = new System.Drawing.Size(250, 23);

            // ESTUDIANTE
            this.chkEstudiante.Text = "Soy estudiante";
            this.chkEstudiante.Location =
                new System.Drawing.Point(150, 270);
            this.chkEstudiante.AutoSize = true;

            // CASILLERO
            this.chkCasillero.Text = "Agregar casillero (+$2000/mes)";
            this.chkCasillero.Location =
                new System.Drawing.Point(150, 300);
            this.chkCasillero.AutoSize = true;

            // EFECTIVO
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.Location =
                new System.Drawing.Point(150, 335);
            this.rbtEfectivo.AutoSize = true;

            // TARJETA
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.Location =
                new System.Drawing.Point(250, 335);
            this.rbtTarjeta.AutoSize = true;

            // CUOTAS
            this.cboCuotas.Location =
                new System.Drawing.Point(150, 370);
            this.cboCuotas.Size = new System.Drawing.Size(250, 23);
            this.cboCuotas.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // BOTON REGISTRAR
            this.btnRegistrar.Text = "Registrar cliente";
            this.btnRegistrar.Location =
                new System.Drawing.Point(30, 420);
            this.btnRegistrar.Size =
                new System.Drawing.Size(200, 35);

            // BOTON VER CLIENTES
            this.btnVerClientes.Text = "Ver clientes";
            this.btnVerClientes.Location =
                new System.Drawing.Point(250, 420);
            this.btnVerClientes.Size =
                new System.Drawing.Size(200, 35);

            // BOTON CALCULAR
            this.btnCalcular.Text = "Calcular precio";
            this.btnCalcular.Location =
                new System.Drawing.Point(30, 470);
            this.btnCalcular.Size =
                new System.Drawing.Size(200, 35);

            // BOTON LIMPIAR
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Location =
                new System.Drawing.Point(250, 470);
            this.btnLimpiar.Size =
                new System.Drawing.Size(200, 35);

            // EVENTOS
            this.Load += new System.EventHandler(
                this.frmInscripcion_Load);

            this.txtEdad.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                this.txtEdad_KeyPress);

            this.txtMeses.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                this.txtMeses_KeyPress);

            this.rbtEfectivo.CheckedChanged +=
                new System.EventHandler(
                this.rbtEfectivo_CheckedChanged);

            this.rbtTarjeta.CheckedChanged +=
                new System.EventHandler(
                this.rbtTarjeta_CheckedChanged);

            this.btnRegistrar.Click +=
                new System.EventHandler(
                this.btnRegistrar_Click);

            this.btnVerClientes.Click +=
                new System.EventHandler(
                this.btnVerClientes_Click);

            this.btnCalcular.Click +=
                new System.EventHandler(
                this.btnCalcular_Click);

            this.btnLimpiar.Click +=
                new System.EventHandler(
                this.btnLimpiar_Click);

            // AGREGAR CONTROLES A LA VENTANA
            this.Controls.Add(this.lblTitulo);

            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);

            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);

            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.cboPlan);

            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cboTurno);

            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.txtMeses);

            this.Controls.Add(this.chkEstudiante);
            this.Controls.Add(this.chkCasillero);

            this.Controls.Add(this.rbtEfectivo);
            this.Controls.Add(this.rbtTarjeta);
            this.Controls.Add(this.cboCuotas);

            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnVerClientes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblMeses;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtMeses;

        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.ComboBox cboCuotas;

        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.CheckBox chkCasillero;

        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjeta;

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}