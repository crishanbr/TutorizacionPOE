namespace TutorizacionBaqueRodriguezPOE
{
    partial class frmCustomAlert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconAlert = new FontAwesome.Sharp.IconPictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.msgTittle = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconAlert)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconAlert
            // 
            this.iconAlert.BackColor = System.Drawing.Color.Transparent;
            this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.Monero;
            this.iconAlert.IconColor = System.Drawing.Color.White;
            this.iconAlert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAlert.IconSize = 28;
            this.iconAlert.Location = new System.Drawing.Point(4, 3);
            this.iconAlert.Name = "iconAlert";
            this.iconAlert.Size = new System.Drawing.Size(29, 28);
            this.iconAlert.TabIndex = 0;
            this.iconAlert.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.headerPanel.Controls.Add(this.msgTittle);
            this.headerPanel.Controls.Add(this.iconAlert);
            this.headerPanel.Location = new System.Drawing.Point(9, 9);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(336, 28);
            this.headerPanel.TabIndex = 1;
            // 
            // msgTittle
            // 
            this.msgTittle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.msgTittle.ForeColor = System.Drawing.Color.White;
            this.msgTittle.Location = new System.Drawing.Point(35, 0);
            this.msgTittle.Name = "msgTittle";
            this.msgTittle.Size = new System.Drawing.Size(298, 27);
            this.msgTittle.TabIndex = 1;
            this.msgTittle.Text = "label1";
            this.msgTittle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msgLabel
            // 
            this.msgLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.msgLabel.ForeColor = System.Drawing.Color.White;
            this.msgLabel.Location = new System.Drawing.Point(9, 40);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(336, 39);
            this.msgLabel.TabIndex = 2;
            this.msgLabel.Text = "label1";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.Location = new System.Drawing.Point(268, 82);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "ACEPTAR";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOk_MouseClick);
            // 
            // frmCustomAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(354, 113);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCustomAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.iconAlert)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconAlert;
        private Panel headerPanel;
        private Label msgTittle;
        private Label msgLabel;
        private Button btnOk;
    }
}