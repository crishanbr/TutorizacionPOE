
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
    }
}
