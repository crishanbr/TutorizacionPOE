namespace TutorizacionBaqueRodriguezPOE
{
    public partial class frmCustomAlert : Form
    {
        static frmCustomAlert customAlertBox;
        static string Button_id;

        public frmCustomAlert()
        {
            InitializeComponent();
        }

        public static string ShowAlertBox(string type, string txtTitle, string txtMessage)
        {
            customAlertBox = new frmCustomAlert();
            customAlertBox.msgTittle.Text = txtTitle;
            customAlertBox.msgLabel.Text = txtMessage;
            string str = type;
            switch (type)
            {
                case "error":
                    customAlertBox.headerPanel.BackColor = Color.FromArgb(160, 0, 0);
                    customAlertBox.iconAlert.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                    break;
                case "info":
                    customAlertBox.headerPanel.BackColor = Color.FromArgb(0, 160, 160);
                    customAlertBox.iconAlert.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                    break;
                case "warning":
                    customAlertBox.headerPanel.BackColor = Color.FromArgb(160, 90, 0);
                    customAlertBox.iconAlert.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                    break;
                case "succes":
                    customAlertBox.headerPanel.BackColor = Color.FromArgb(0, 160, 40);
                    customAlertBox.iconAlert.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    break;
                case "note":
                    customAlertBox.headerPanel.BackColor = Color.FromArgb(200, 200, 200);
                    customAlertBox.msgTittle.ForeColor = Color.Black;
                    customAlertBox.iconAlert.IconColor = Color.Black;
                    customAlertBox.iconAlert.IconChar = FontAwesome.Sharp.IconChar.Comments;
                    break;
            }
            customAlertBox.ShowDialog();
            return Button_id;
        }

        private void btnOk_MouseClick(object sender, MouseEventArgs e)
        {
            Button_id = "1";
            customAlertBox.Dispose();
        }

        private void frmCustomAlert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_id = "1";
                customAlertBox.Dispose();
            }
        }
    }
}
