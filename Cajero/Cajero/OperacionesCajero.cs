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
    public partial class OperacionesCajero : Form
    {
        BaseDatosUsuariosDataContext dataContext = new BaseDatosUsuariosDataContext();
        private Users usuarioLogueado;
        public OperacionesCajero(Users usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;

        }

        private void OperacionesCajero_Load(object sender, EventArgs e)
        {

        }
    }
}
