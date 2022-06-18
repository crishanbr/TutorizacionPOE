using Estudiante = ClassLibraryPOE.Estudiante;
using Timer = System.Windows.Forms.Timer;

namespace TutorizacionBaqueRodriguezPOE
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
            Color.White, 0, ButtonBorderStyle.None, // left
            Color.White, 0, ButtonBorderStyle.None, // top
            Color.DimGray, 0, ButtonBorderStyle.None, // right
            Color.DimGray, 1, ButtonBorderStyle.None);// bottom
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "https://www.github.com/crishanbr");
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            string result = frmInfo.ShowBox("Ficha del Estudiante:\n\n" +
                "Baque Rodriguez Cristhofer Ignacio\n" +
                "Programaci�n Orientada a Eventos\n" +
                "2022-2023 Ciclo I\n" +
                "SOF-S-MA-5-2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ibtnAdd_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string carrera = tbCarrera.Text;


                ListViewItem item = new ListViewItem(nombre);
                item.SubItems.Add(apellido);
                item.SubItems.Add(carrera);
                listadoAlumnos.Items.Add(item);
        }
        
        public void AgregarItem()
        {
            Estudiante objEstudiante = new Estudiante();
            objEstudiante.Cedula = Int32.Parse(tbCedula.Text.Trim());
            objEstudiante.Nombre = tbNombre.Text.Trim();
            objEstudiante.Apellido = tbApellido.Text.Trim();
            objEstudiante.Carrera = tbCarrera.Text.Trim();

            ListViewItem itemAlumno = new ListViewItem();
            itemAlumno = listadoAlumnos.Items.Add(objEstudiante.Cedula.ToString());
            itemAlumno.SubItems.Add(objEstudiante.Nombre);
            itemAlumno.SubItems.Add(objEstudiante.Apellido);
            itemAlumno.SubItems.Add(objEstudiante.Carrera);
        }
        
        public void VerficarCamposTexto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void VerficarCamposNumeros(object sender, KeyPressEventArgs e)
        {
            TextBox T = (TextBox)sender;
            
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                CustomAlert("warning", "Entrada inv�lida", "Por favor ingrese unicamente numeros del 0-9\nNo ingrese espacios en blanco.");
                e.Handled = true;
            }
            if ((T.Text.Length == 10) && !char.IsControl(e.KeyChar)) 
                {
                    CustomAlert("warning", "Entrada inv�lida", "El n�mero de cedula no puede tener m�s de 10 d�gitos");
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
    }
}
