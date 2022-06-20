using Estudiante = ClassLibraryPOE.Estudiante;

namespace TutorizacionBaqueRodriguezPOE
{
    public partial class frmMain : Form
    {
        // Listas que su nombre dice de que son :)        
        List<Estudiante> listaEstudiantesAgregados = new List<Estudiante>();
        List<Estudiante> listaEstudiantesEliminados = new List<Estudiante>();
        
        public frmMain()
        {
            InitializeComponent();
        }

        // Evento al hacer click en el botón con icono de GitHub
        
        private void ibtnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "https://www.github.com/crishanbr");
        }        

        // Evento al hacer click en el boton con icono de Info
        private void ibtnInfo_Click(object sender, EventArgs e)
        {
            string result = frmInfo.ShowBox("Ficha del Estudiante:\n\n" +
                "Baque Rodriguez Cristhofer Ignacio\n" +
                "Programación Orientada a Eventos\n" +
                "2022-2023 Ciclo I\n" +
                "SOF-S-MA-5-2");
        }

        // Evento al hacer click en el boton Agregar
        private void ibtnAdd_Click(object sender, EventArgs e)
        {
                listaEstudiantesAgregados.Add(new Estudiante(
                    tbNombre.Text,
                    tbApellido.Text,
                    tbCarrera.Text,
                    Convert.ToInt32(tbCedula.Text)
                ));

                listarEstudiantesAgregados();

                CustomAlert("succes", "Estudiante agregado", "El estudiante con cedula \"" + tbCedula.Text + "\" ha sido agregado correctamente");
        }

    // EVENTOS PARA LOS TEXTBOXS
        private void tbCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerficarCamposTexto(sender, e);
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerficarCamposTexto(sender, e);
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerficarCamposTexto(sender, e);
        }

        private void tbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerficarCamposNumeros(sender, e);
        }

        private void CamposRellenados_TextChanged(object sender, EventArgs e)
        {
            if ((tbCedula.Text == "") || (tbNombre.Text == "") || (tbApellido.Text == "") || (tbCarrera.Text == ""))
            {
                ibtnAdd.BackColor = Color.FromArgb(134, 94, 94);
                ibtnAdd.Cursor = Cursors.No;
                ibtnAdd.Enabled = false;
            }
            else
            {
                ibtnAdd.Enabled = true;
                ibtnAdd.Cursor = Cursors.Default;
                ibtnAdd.BackColor = Color.FromArgb(98, 200, 100);
            }
        }
        // ----------------------------------------------------------------------------

        private void ibtnListarLobby_Click(object sender, EventArgs e)
        {
            ibtnDelete.Enabled = false;
            ibtnDelete.BackColor = Color.FromArgb(134, 94, 94);
            ListarEstudiantesEliminados();
        }
        private void ibtnListar_Click(object sender, EventArgs e)
        {
            ibtnDelete.Enabled = true;
            ibtnDelete.BackColor = Color.FromArgb(30, 41, 59);
            listarEstudiantesAgregados();
        }

        private void ibtnPalLobby_Click(object sender, EventArgs e)
        {
            if (listadoAlumnos.FocusedItem != null)
            {
                listaEstudiantesEliminados.Add(new Estudiante(listaEstudiantesAgregados[listadoAlumnos.FocusedItem.Index].Nombre,
                listaEstudiantesAgregados[listadoAlumnos.FocusedItem.Index].Apellido,
                listaEstudiantesAgregados[listadoAlumnos.FocusedItem.Index].Carrera,
                listaEstudiantesAgregados[listadoAlumnos.FocusedItem.Index].Cedula
            ));
                
            string deleted = listadoAlumnos.SelectedItems[0].SubItems[0].Text;

            listaEstudiantesAgregados.RemoveAt(listadoAlumnos.FocusedItem.Index);

            listarEstudiantesAgregados();

            CustomAlert("succes", "Estudiante eliminado", "El estudiante con cedula \"" + deleted + "\" ha sido eliminado correctamente\nPuede verificar los alumnos eliminados en la lista de eliminados");
            }
            else 
            {
                CustomAlert("error", "Acción denegada", "No se ha podido eliminar un registro debido a: que no existen registros o no a seleccionado ninguno");
            }
        }
        // MÉTODOS QUE SIRVEN PARA ALGO XD
        
        // Método para Mostrar los estudiantes eliminados en el ListView
        private void ListarEstudiantesEliminados()
        {
            listadoAlumnos.Items.Clear();
            listTittle.Text = "LISTA DE ESTUDIANTES ELIMINADOS";

            for (int i = 0; i < listaEstudiantesEliminados.Count; i++)
            {
                ListViewItem item = new ListViewItem(listaEstudiantesEliminados[i].Cedula.ToString());
                item.SubItems.Add((listaEstudiantesEliminados[i].Nombre));
                item.SubItems.Add((listaEstudiantesEliminados[i].Apellido));
                item.SubItems.Add((listaEstudiantesEliminados[i].Carrera));
                listadoAlumnos.Items.Add(item);
            }
        }

        // Método para Mostrar los estudiantes agregados en el ListView
        private void listarEstudiantesAgregados()
        {
            listadoAlumnos.Items.Clear();

            listTittle.Text = "LISTA DE ESTUDIANTES REGISTRADOS";

            for (int i = 0; i < listaEstudiantesAgregados.Count; i++)
            {
                ListViewItem item = new ListViewItem(listaEstudiantesAgregados[i].Cedula.ToString());
                item.SubItems.Add((listaEstudiantesAgregados[i].Nombre));
                item.SubItems.Add((listaEstudiantesAgregados[i].Apellido));
                item.SubItems.Add((listaEstudiantesAgregados[i].Carrera));
                listadoAlumnos.Items.Add(item);
            }
        }
        
        // Método para permitir el ingreso de únicamente números [0-9]
        public void VerficarCamposNumeros(object sender, KeyPressEventArgs e)
        {
            TextBox T = (TextBox)sender;

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                CustomAlert("info", "Entrada inválida", "Este campo puede contener unicamente numeros del 0-9\nNo ingrese espacios en blanco.");
                e.Handled = true;
            }
            if ((T.Text.Length == 10) && !char.IsControl(e.KeyChar))
            {
                CustomAlert("info", "Entrada inválida", "El número de cedula no puede tener más de 10 dígitos");
                e.Handled = true;
            }
        }

        // Método para permitir el ingreso de unicamente texto [a-z][A-Z]
        public void VerficarCamposTexto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /* Tipos de alertas
            - Error     => ( type: "error" )
            - Info      => ( type: "info" )
            - Warning   => ( type: "warning" )
            - Success   => ( type: "succes" )
            - Note      => ( type: "note" )
        
            Uso:
                CustomAlert("error", "Titulo", "Mensaje");
         */
        public void CustomAlert(string type, string tittle, string msg)
        {
            string result = frmCustomAlert.ShowAlertBox(type, tittle, msg);
        }

    }
}
