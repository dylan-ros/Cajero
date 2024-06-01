using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Retiro : Form
    {
        private BaseDatosUsuariosDataContext dataContext = new BaseDatosUsuariosDataContext();
        private Users usuarioLogueado;
        public Retiro(Users usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
           
        }

        private void OpcionRapida(object sender, EventArgs e)
        {
            Button button = sender as Button;
            txt_retiro.Text = button.Text; // Establece el texto del cuadro de texto con el monto del botón

            // Elimina los eventos de clic existentes de todos los botones de monto rápido
            btn_cincuenta.Click += MontoRapido_Click;
            btn_cien.Click += MontoRapido_Click;
            btn_doscientos.Click += MontoRapido_Click;
            btn_cuatrocientos.Click += MontoRapido_Click;
            btn_seiscientos.Click += MontoRapido_Click;
            btn_mil.Click += MontoRapido_Click;

         
        }
        private void MontoRapido_Click(object sender, EventArgs e)
        {
            //Evento clic donde se realiza el monto en el txt
            Button button = sender as Button;
            txt_retiro.Text = button.Text;
        }

        private void btn_retiro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txt_retiro.Text, out decimal montoRetiro) || montoRetiro <= 0 || montoRetiro % 50 != 0)
                {
                    MessageBox.Show("Ingrese un monto válido para retirar en múltiplos de 50.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Variables para la busqueda por ID del usuario 
                var usuarioDB = dataContext.Users.FirstOrDefault(u => u.ID == usuarioLogueado.ID);
                var usuarioDB1 = dataContext.Users.FirstOrDefault(u => u.ID == usuarioLogueado.ID);
                var usuarioDB2 = dataContext.Users.FirstOrDefault(u => u.ID == usuarioLogueado.ID);


                if (usuarioLogueado.Saldo < montoRetiro)
                {
                    MessageBox.Show("Fondos insuficientes para el retiro, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Verifica si el usuario ya ha tenido un registro de retiro entonces el hasvalue toma el valor de true
                if (usuarioLogueado.UltimoRetiro.HasValue && usuarioLogueado.UltimoRetiro.Value.Date == DateTime.Now.Date)
                {
                    if (usuarioLogueado.RetiroDiario + montoRetiro > 3000)
                    {
                        MessageBox.Show("No puede retirar más de Q3,000 en un día.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    usuarioLogueado.RetiroDiario = 0;
                }


                // Se valida el campo donde se va a guardar los cambios en la base de datos
                usuarioDB.Saldo -= montoRetiro;
                usuarioLogueado.Saldo = usuarioDB.Saldo;

                usuarioDB1.RetiroDiario += montoRetiro;
                usuarioLogueado.RetiroDiario += usuarioDB1.RetiroDiario;

                usuarioDB2.UltimoRetiro = DateTime.Now;
                usuarioLogueado.UltimoRetiro = usuarioDB2.UltimoRetiro;

                dataContext.SubmitChanges(); // Guardar cambios en el contexto

                MessageBox.Show("Operación realizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var resultado = MessageBox.Show("¿Desea realizar otra operación?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    txt_retiro.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al realizar el retiro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        //Corchetes Finales --------
    }
}
