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
            /* MessageBox.Show("¡CrishanDev!\n\n" +
                 "Este es un proyecto de programación orientada a objetos.\n" +
                 "Para ver el código fuente, visita mi repositorio en GitHub.\n" +
                 "https://www.github.com/crishanbr\n\n");*/
            string result = frmInfo.ShowBox("Ficha del Estudiante:\n\n" +
                "Baque Rodriguez Cristhofer Ignacio\n" +
                "Programación Orientada a Eventos\n" +
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

            if (nombre != "" && apellido != "" && carrera != "")
            {
                ListViewItem item = new ListViewItem(nombre);
                item.SubItems.Add(apellido);
                item.SubItems.Add(carrera);
                listView1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
        }
        
        public void AgregarItem()
        {
            
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
                CustomAlert("warning", "Entrada inválida", "Por favor ingrese unicamente numeros del 0-9\nNo ingrese espacios en blanco.");
                e.Handled = true;
            }
            if ((T.Text.Length == 10) && !char.IsControl(e.KeyChar)) 
                {
                    CustomAlert("warning", "Entrada inválida", "El número de cedula no puede tener más de 10 dígitos");
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
