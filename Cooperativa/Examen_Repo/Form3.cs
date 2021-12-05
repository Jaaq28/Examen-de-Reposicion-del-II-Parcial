using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Repo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void DatosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RetrocederButton_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();

            this.Hide();
            f3.ShowDialog();
        }

        Cuenta cuenta;
        List<MovimientoDeposito> listaMovimientosDepositos;

        private void DepositoButton_Click(object sender, EventArgs e)
        {
            if (DepositoTextBox.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el monto del movimiento");
                DepositoTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(DepositoTextBox.Text))
            {
                MessageBox.Show("Seleccione el tipo de movimiento");
                return;
            }

            if (DepositoTextBox.Text == "Depósito")
            {
                cuenta.Depositar(Convert.ToDecimal(DepositoTextBox.Text));

                MovimientoDeposito = new MovimientoDeposito(cuenta, DateTime.Now,
                                                Convert.ToDecimal(DepositoTextBox.Text));

                listaMovimientosDepositos = new List<MovimientoDeposito>();
                listaMovimientosDepositos.Add(MovimientoDeposito);

                DatosListBox.Items.Add("Depósito a la cuenta N." + cuenta.NumeroCuenta + " por la cantidad de L." +
                                                Convert.ToDecimal(DepositoTextBox.Text) + " con fecha: " +
                                                MovimientoDeposito.FechaMovimiento.ToShortDateString());

                SaldoTextBox.Text = cuenta.Saldo.ToString("N");
            }
    }
}
