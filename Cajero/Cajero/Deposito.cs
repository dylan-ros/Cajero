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
    public partial class Deposito : Form
    {
        BaseDatosUsuariosDataContext dataContext = new BaseDatosUsuariosDataContext();
        private Users usuarioLogueado;
        public Deposito(Users usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal montoDeposito;

                //Se verifica si el usuario coloco un formato valido, convierte el valor del txt hacia la variable montoDeposito
                //Entonces como aqui es diferente de, tira mensaje de error 
                if(!decimal.TryParse(txt_deposito.Text, out montoDeposito) || montoDeposito <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido para depositar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Busca el usuario en la base de datos por el ID
                var usuarioDB = dataContext.Users.FirstOrDefault(u => u.ID == usuarioLogueado.ID);


                //Si sí es correcto, hace el cambio en la base de datos y guarda los cambios
                usuarioDB.Saldo += montoDeposito;
                dataContext.SubmitChanges();
                usuarioLogueado.Saldo = usuarioDB.Saldo;
                MessageBox.Show("Depósito realizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var resultado = MessageBox.Show("¿Desea realizar otra operación?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    //Si si se quiere hacer otro deposito solamente se limpia el txt
                    txt_deposito.Text = string.Empty;
                }
            
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al realizar el depósito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
   
    
    
    
        //Corchetes Finales -------------
    }
}
