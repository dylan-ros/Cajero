using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cajero
{
    public partial class Form1 : Form
    {
        BaseDatosUsuariosDataContext dataContext = new BaseDatosUsuariosDataContext(); //dataContext 
        private int intentosFallidos = 0; //para la cantidad de intentos con la contraseña
        private Users usuarioLogueado;
        public Form1()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(1, 1);
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        { 
            //Declarar variables para los datos de ID, usuario y contraseña 
            var codigo = (int)nud_codigo.Value;
            var usuario = txt_usuario.Text.Trim().ToLower();
            var contrasena = txt_contrasena.Text;

            //Metodo LINQ donde busca la primera opcion que encuentra 
            var usuarioEncontrado = dataContext.Users.FirstOrDefault(u => u.ID == codigo && u.Usuario.ToLower() == usuario);

            //Valida si el usuario o el codigo estan o no, si no, tira erro de alguno de los dos
            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Código o usuario incorrecto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Valida si la contraseña del usuario es diferente a la que el usuario puso 
            if (usuarioEncontrado.Contraseña != contrasena)
            {
                //Empieza la suma de los errores de la contraseña, 3 intentos
                intentosFallidos++;
                if (intentosFallidos >= 3)
                {
                    //Si llega a 3 errores, el usuario es bloqueado en la base de datos
                    usuarioEncontrado.Bloqueado = true;
                    dataContext.SubmitChanges();
                    MessageBox.Show("Ha superado el número máximo de intentos. La cuenta ha sido bloqueada.", "Cuenta Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Contraseña incorrecta. Intento {intentosFallidos} de 3.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            //Los intentos se reinician y hace el login correctamente si la contraseña es la verdadera
            intentosFallidos = 0;
            usuarioLogueado = usuarioEncontrado;
            MessageBox.Show("Validación Correcta... Listo para utilizar el programa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl1.SelectTab(1);
           
            //OperacionesCajero operacionesCajero = new OperacionesCajero(usuarioEncontrado);
            //operacionesCajero.Show();


        }

        private void OpcionesCajero(object sender, EventArgs e)
        {
            Button aux = (Button)sender;

            switch(aux.Name)
            {
                case "btn_deposito":
                    Deposito deposito = new Deposito(usuarioLogueado);
                    deposito.Show();
                    break;

                case "btn_retiro":
                    Retiro retiro = new Retiro(usuarioLogueado); 
                    retiro.Show();
                    break;

                case "btn_consultaSaldo":
                    Consulta consulta = new Consulta(usuarioLogueado);
                    consulta.Show();
                    break;

                case "btn_regresar":
                    MessageBox.Show("Regresando al LOGIN...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.SelectTab(0);
                    nud_codigo.Value = 0;
                    txt_usuario.Text = string.Empty;
                    txt_contrasena.Text = string.Empty;
                    break;
            }
        }

        private void btn_crearCuenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear Cuenta...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl1.SelectTab(2);
        }

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            if (true)
            {
                try
                {
                    // Validar Nombre verifica el contenido del txt_nombre si esta vacio o contiene caracteres especiales
                    if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    {
                        MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar Apellido verifica el contenido del txt_apellido
                    if (string.IsNullOrWhiteSpace(txt_apellido.Text))
                    {
                        MessageBox.Show("El apellido es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar fecha de nacimiento
                    if (DateTime.Now.Year - date_nacimiento.Value.Year < 18)
                    {
                        MessageBox.Show("El usuario debe tener más de 18 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar DPI valida la longitud y si el texto son letras en vez de digitos
                    if (txt_dpi.Text.Length < 10 || txt_dpi.Text.Length > 15 || !txt_dpi.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("El DPI debe tener entre 10 y 15 dígitos y solo contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Si se cumple la condicion entonces el dpi ya esta registrado
                    if (dataContext.Users.Any(u => u.DPI == txt_dpi.Text))
                    {
                        MessageBox.Show("El DPI ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar Correo Electrónico
                    if (!string.IsNullOrWhiteSpace(txt_correo.Text))
                    {
                        if (!Regex.IsMatch(txt_correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                        {
                            MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (dataContext.Users.Any(u => u.Correo == txt_correo.Text))
                        {
                            MessageBox.Show("El correo electrónico ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Validar Número de Teléfono
                    if (!Regex.IsMatch(txt_telefono.Text, @"^\(\+502\) \d{4}-\d{4}$"))
                    {
                        MessageBox.Show("El número de teléfono debe tener el formato (+502) 1234-5678.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dataContext.Users.Any(u => u.Telefono == txt_telefono.Text))
                    {
                        MessageBox.Show("El número de teléfono ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar Usuario
                    if (txt_nuevoUsuario.Text.Length < 2)
                    {
                        MessageBox.Show("El usuario debe contener más de 1 letra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Validar contraseña 
                    //Variables para guardar la contrasena y el nombre para el match
                    string contrasena = txt_nuevaContrasena.Text;
                    string nombre = txt_nombre.Text;

                    //Valida primero que la contrasena no empiece con mayusculas
                    if (char.IsUpper(contrasena[0]))
                    {
                        MessageBox.Show("La contraseña no debe comenzar con una letra mayúscula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //Valida si la contraseña es diferente al match y tira error
                    if (!Regex.IsMatch(contrasena, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{7,}$"))
                    {
                        MessageBox.Show("La contraseña debe contener al menos 7 caracteres, una letra mayúscula, un número y un carácter especial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Valida si la contrasena tiene el nombre adentro en alguna parte
                    if (contrasena.ToLower().Contains(nombre.ToLower()))
                    {
                        MessageBox.Show("La contraseña no debe contener el nombre del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar Monto Inicial convierte la cadena de string a un numero decimal 
                    if (!decimal.TryParse(txt_saldoCrear.Text, out decimal montoInicial) || montoInicial <= 100)
                    {
                        MessageBox.Show("El monto inicial debe ser superior a Q100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (combo_banco.SelectedItem == null)
                    {
                        MessageBox.Show("Debe seleccionar un banco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Generar Código único sumandole uno al numero mas grande 
                    int nuevoCodigo = dataContext.Users.Max(u => u.ID) + 1;

                    // Crear nuevo usuario
                    Users nuevoUsuario = new Users
                    {
                        Nombre = txt_nombre.Text,
                        Apellido = txt_apellido.Text,
                        Nacimiento = date_nacimiento.Value,
                        DPI = txt_dpi.Text,
                        Correo = txt_correo.Text,
                        Telefono = txt_telefono.Text,
                        Usuario = txt_nuevoUsuario.Text,
                        Contraseña = txt_nuevaContrasena.Text,
                        Saldo = montoInicial,
                        ID = nuevoCodigo,
                        Banco = combo_banco.SelectedItem.ToString()
                    };

                    dataContext.Users.InsertOnSubmit(nuevoUsuario);
                    dataContext.SubmitChanges();

                    MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.SelectTab(0);

                    // Limpiar campos
                    txt_nombre.Text = string.Empty;
                    txt_apellido.Text = string.Empty;
                    txt_dpi.Text = string.Empty;
                    txt_correo.Text = string.Empty;
                    txt_telefono.Text = string.Empty;
                    txt_usuario.Text = string.Empty;
                    txt_contrasena.Text = string.Empty;
                    txt_saldoCrear.Text = string.Empty;
                    combo_banco.SelectedIndex = -1;
                    date_nacimiento.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }


        //CSV DEL CREADOR ---------------

        private void btn_creador_Click(object sender, EventArgs e)
        {

            String ruta = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;


                if (File.Exists(ruta))
                {
                    try
                    {
                        dgv_creador.Rows.Clear();
                        dgv_creador.Columns.Clear();


                        string[] lineasCsv = File.ReadAllLines(ruta);


                        if (lineasCsv.Length > 0)
                        {

                            string[] encabezados = lineasCsv[0].Split(';');

                            foreach (string encabezado in encabezados)
                            {
                                dgv_creador.Columns.Add(encabezado, encabezado);
                            }


                            for (int i = 1; i < lineasCsv.Length; i++)
                            {

                                string[] campos = lineasCsv[i].Split(';');


                                dgv_creador.Rows.Add(campos);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El archivo CSV está vacío.");
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Archivo no encontrado.");
                }
            }
           
        }

        private void btn_creadorPrograma_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            string url = "https://drive.google.com/drive/folders/1XBXIQNR48UgOvRDDxhyEdmTp5CPjxoAq?usp=drive_link";
            Process.Start(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regresando al LOGIN...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl1.SelectTab(0);
            nud_codigo.Value = 0;
            txt_usuario.Text = string.Empty;
            txt_contrasena.Text = string.Empty;
        }

        //Corchetes Finales -------
    }
}

