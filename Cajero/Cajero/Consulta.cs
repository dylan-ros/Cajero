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
    public partial class Consulta : Form
    {
        private BaseDatosUsuariosDataContext dataContext = new BaseDatosUsuariosDataContext();
        private Users usuarioLogueado;
        public Consulta(Users usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {
            try
            {
                //Busca el ID del usuario
                var usuarioDB = dataContext.Users.FirstOrDefault(u => u.ID == usuarioLogueado.ID);

                // si el usuario si existe entonces muestra su saldo 
                if (usuarioDB != null)
                {
                    txt_saldo.Text = $"Q{usuarioDB.Saldo:F2}"; //Decimal F2 el 2 por dos decimales 
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var resultado = MessageBox.Show("¿Desea realizar otra operación?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    //Si si se quiere hacer otro deposito solamente se limpia el txt
                    txt_saldo.Text = string.Empty;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un clavo bro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
   
    
    
        // Corchetes Finales -----------------    
    }
}

