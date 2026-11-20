
using System;
using System.Globalization;
using System.Windows.Forms;

namespace EXAMEN_RentarCar_Christhopher
{
    public partial class Form1 : Form
    {
        decimal subtotal = 0m;

        const decimal SEGURO_COMPLETO = 1000;
        const decimal GPS = 100m;
        const decimal DOMICILIO = 2000;
        const decimal DESCUENTO = 0.15m;
        const decimal ITBIS = 0.18m;

        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;

            bntAgregar.Click += bntAgregar_Click;
            bntCalcular.Click += bntCalcular_Click;
            bntLimpiar.Click += bntLimpiar_Click;
            bntSalir.Click += bntSalir_Click;
        }

        // FORMATO DE DINERO
        private string Dinero(decimal valor)
        {
            return "RD$ " + valor.ToString("#,##0.00");
        }

        // INICIO DEL FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            subtotal = 0;

            dptSalida.Value = DateTime.Today;

            nudDias.Minimum = 1;
            nudDias.Maximum = 30;
            nudDias.Value = 1;

            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            chkCorpotativo.Checked = false;
            chkGps.Checked = false;

            Alquileres.Items.Clear();

            lblSubtotal.Text = Dinero(0);
            lblDescuento.Text = Dinero(0);
            lblDomicilio.Text = Dinero(0);
            lblItbis.Text = Dinero(0);
            lblTotal.Text = Dinero(0);
        }

        // AGREGAR ALQUILER
        private void bntAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                txtCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVehuculo.Text))
            {
                MessageBox.Show("Ingrese el nombre del vehículo.");
                txtVehuculo.Focus();
                return;
            }

            decimal tarifa;

            if (!decimal.TryParse(txtTarifa.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture, out tarifa)
                &&
                !decimal.TryParse(txtTarifa.Text,
                NumberStyles.Number,
                CultureInfo.InvariantCulture, out tarifa))
            {
                MessageBox.Show("Ingrese una tarifa válida.");
                txtTarifa.Focus();
                return;
            }

            if (tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser mayor que cero.");
                return;
            }

            int dias = (int)nudDias.Value;

            // Calcular seguro
            decimal tarifaDiaria = tarifa;
            string seguro = "Básico";

            if (rbtCompleto.Checked)
            {
                tarifaDiaria += SEGURO_COMPLETO;
                seguro = "Completo";
            }

            // Aplicar GPS
            if (chkGps.Checked)
            {
                tarifaDiaria += GPS;
            }

            // Calcular total de línea
            decimal totalLinea = tarifaDiaria * dias;

            // Preparar nombre del vehículo
            string vehiculo = txtVehuculo.Text.Trim()
                + " (" + seguro + ")";

            if (chkGps.Checked)
            {
                vehiculo += " (GPS)";
            }

            // Agregar a la lista
            string linea =
                dias.ToString().PadRight(6) +
                vehiculo.PadRight(24) +
                Dinero(tarifaDiaria).PadLeft(14) +
                Dinero(totalLinea).PadLeft(14);

            Alquileres.Items.Add(linea);

            // Acumular subtotal
            subtotal += totalLinea;

            lblSubtotal.Text = Dinero(subtotal);

            // Limpiar datos del vehículo
            txtVehuculo.Clear();
            txtTarifa.Clear();

            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;

            txtVehuculo.Focus();
        }

        // CALCULAR TOTAL
        private void bntCalcular_Click(object sender, EventArgs e)
        {
            if (Alquileres.Items.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un vehículo.");
                return;
            }

            // Descuento corporativo
            decimal descuento = 0;

            if (chkCorpotativo.Checked)
            {
                descuento = subtotal * DESCUENTO;
            }

            // Entrega a domicilio
            decimal entrega = 0;

            if (radioButton4.Checked)
            {
                entrega = DOMICILIO;
            }

            // Base imponible
            decimal baseImponible =
                subtotal - descuento + entrega;

            // Calcular ITBIS
            decimal impuesto = baseImponible * ITBIS;

            // Total a pagar
            decimal total = baseImponible + impuesto;

            // Mostrar resultados
            lblSubtotal.Text = Dinero(subtotal);
            lblDescuento.Text = Dinero(descuento);
            lblDomicilio.Text = Dinero(entrega);
            lblItbis.Text = Dinero(impuesto);
            lblTotal.Text = Dinero(total);

            MessageBox.Show(
                "RESUMEN DEL ALQUILER\n\n" +
                "Subtotal: " + Dinero(subtotal) + "\n" +
                "Descuento: " + Dinero(descuento) + "\n" +
                "Domicilio: " + Dinero(entrega) + "\n" +
                "ITBIS: " + Dinero(impuesto) + "\n" +
                "TOTAL A PAGAR: " + Dinero(total),
                "RentaCar Express"
            );
        }

        // NUEVO ALQUILER
        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtVehuculo.Clear();
            txtTarifa.Clear();

            dptSalida.Value = DateTime.Today;
            nudDias.Value = 1;

            chkCorpotativo.Checked = false;
            chkGps.Checked = false;

            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            Alquileres.Items.Clear();

            subtotal = 0;

            lblSubtotal.Text = Dinero(0);
            lblDescuento.Text = Dinero(0);
            lblDomicilio.Text = Dinero(0);
            lblItbis.Text = Dinero(0);
            lblTotal.Text = Dinero(0);

            txtCliente.Focus();
        }

        // SALIR
        private void bntSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del programa?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // EVENTOS QUE YA ESTÁN CONECTADOS EN EL DISEÑADOR
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}

