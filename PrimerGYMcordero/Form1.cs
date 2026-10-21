using System;
using System.Windows.Forms;

namespace priCorderoGimnasio
{
    public partial class frmInscripcion : Form
    {
        // ARRAY PARA GUARDAR HASTA 100 CLIENTES
        string[] clientes = new string[100];

        // CONTADOR DE CLIENTES REGISTRADOS
        int cantidadClientes = 0;

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            // CARGAR PLANES
            cboPlan.Items.Add("Plan A - Pase Libre");
            cboPlan.Items.Add("Plan B - 3 Veces x Semana");
            cboPlan.Items.Add("Plan C - Musculación Básica");

            cboPlan.SelectedIndex = 0;

            // CARGAR TURNOS
            cboTurno.Items.Add("Mañana");
            cboTurno.Items.Add("Tarde");
            cboTurno.Items.Add("Noche");

            cboTurno.SelectedIndex = 0;

            // CARGAR CUOTAS
            cboCuotas.Items.Add("1 cuota");
            cboCuotas.Items.Add("3 cuotas");
            cboCuotas.Items.Add("6 cuotas");

            cboCuotas.SelectedIndex = 0;

            // INICIAR CON EFECTIVO SELECCIONADO
            rbtEfectivo.Checked = true;
            cboCuotas.Enabled = false;
        }

        // PERMITIR SOLAMENTE NUMEROS EN EDAD
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // PERMITIR SOLAMENTE NUMEROS EN MESES
        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // HABILITAR O DESHABILITAR LAS CUOTAS
        private void rbtEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEfectivo.Checked)
            {
                cboCuotas.Enabled = false;
            }
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
            }
        }

        // REGISTRAR CLIENTE
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cantidadClientes >= clientes.Length)
            {
                MessageBox.Show("Se alcanzó el límite de 100 clientes.");
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingresá el nombre del cliente.");
                txtNombre.Focus();
                return;
            }

            if (txtEdad.Text == "")
            {
                MessageBox.Show("Ingresá la edad.");
                txtEdad.Focus();
                return;
            }

            if (txtMeses.Text == "")
            {
                MessageBox.Show("Ingresá la cantidad de meses.");
                txtMeses.Focus();
                return;
            }

            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            if (edad < 1 || edad > 120)
            {
                MessageBox.Show("La edad debe estar entre 1 y 120 años.");
                return;
            }

            if (meses <= 0)
            {
                MessageBox.Show("Los meses deben ser mayores que cero.");
                return;
            }

            if (cboPlan.SelectedIndex == -1 ||
                cboTurno.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná un plan y un turno.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string plan = cboPlan.Text;
            string turno = cboTurno.Text;

            clientes[cantidadClientes] =
                "Nombre: " + nombre +
                " | Edad: " + edad +
                " | Plan: " + plan +
                " | Turno: " + turno +
                " | Meses: " + meses;

            cantidadClientes++;

            MessageBox.Show("Cliente registrado correctamente.");

            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Clear();

            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;

            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            txtNombre.Focus();
        }

        // MOSTRAR LOS CLIENTES REGISTRADOS
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            if (cantidadClientes == 0)
            {
                MessageBox.Show("Todavía no hay clientes registrados.");
                return;
            }

            string listado = "";

            for (int i = 0; i < cantidadClientes; i++)
            {
                listado += (i + 1) + ". " + clientes[i] +
                           Environment.NewLine +
                           Environment.NewLine;
            }

            MessageBox.Show(
                listado,
                "Lista de clientes registrados"
            );
        }

        // CALCULAR EL PRECIO DE LA INSCRIPCION
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtEdad.Text == "" || txtMeses.Text == "")
            {
                MessageBox.Show("Ingresá la edad y los meses.");
                return;
            }

            if (cboPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná un plan.");
                return;
            }

            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            if (edad < 1 || edad > 120)
            {
                MessageBox.Show("La edad debe estar entre 1 y 120.");
                return;
            }

            if (meses <= 0)
            {
                MessageBox.Show("Los meses deben ser mayores que cero.");
                return;
            }

            // PRECIO SEGUN EL PLAN
            double precioMensual = 10000;

            if (cboPlan.SelectedIndex == 0)
            {
                precioMensual = 15000;
            }
            else if (cboPlan.SelectedIndex == 1)
            {
                precioMensual = 12000;
            }
            else if (cboPlan.SelectedIndex == 2)
            {
                precioMensual = 10000;
            }

            // AGREGAR CASILLERO
            if (chkCasillero.Checked)
            {
                precioMensual += 2000;
            }

            // CALCULAR EL PRECIO POR TODOS LOS MESES
            double subtotal = precioMensual * meses;

            // APLICAR DESCUENTO POR EDAD O ESTUDIANTE
            double descuento = 0;

            if (chkEstudiante.Checked)
            {
                descuento = subtotal * 0.15;
            }
            else if (edad < 18)
            {
                descuento = subtotal * 0.10;
            }
            else if (edad >= 65)
            {
                descuento = subtotal * 0.20;
            }

            double total = subtotal - descuento;

            // DESCUENTO O RECARGO SEGUN EL MEDIO DE PAGO
            if (rbtEfectivo.Checked)
            {
                total = total - (total * 0.10);
            }
            else if (rbtTarjeta.Checked)
            {
                if (cboCuotas.SelectedIndex == 1)
                {
                    total = total + (total * 0.10);
                }
                else if (cboCuotas.SelectedIndex == 2)
                {
                    total = total + (total * 0.20);
                }
            }

            // MOSTRAR RESULTADO
            string resultado =
                "PLAN: " + cboPlan.Text + Environment.NewLine +
                "PRECIO MENSUAL: $" + precioMensual.ToString("N2") +
                Environment.NewLine +
                "CANTIDAD DE MESES: " + meses +
                Environment.NewLine +
                "SUBTOTAL: $" + subtotal.ToString("N2") +
                Environment.NewLine +
                "DESCUENTO POR EDAD/ESTUDIANTE: $" +
                descuento.ToString("N2") +
                Environment.NewLine +
                "MEDIO DE PAGO: " +
                (rbtEfectivo.Checked ? "Efectivo" : "Tarjeta") +
                Environment.NewLine +
                "TOTAL A PAGAR: $" + total.ToString("N2");

            MessageBox.Show(resultado, "Resultado del cálculo");
        }

        // LIMPIAR LOS CAMPOS
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Clear();

            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            cboCuotas.SelectedIndex = 0;

            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            rbtEfectivo.Checked = true;
            cboCuotas.Enabled = false;

            txtNombre.Focus();
        }
    }
}