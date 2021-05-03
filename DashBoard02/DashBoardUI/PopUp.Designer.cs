
namespace DashBoardUI
{
    partial class PopUp
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
            this.ttbMensajePU = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // ttbMensajePU
            // 
            this.ttbMensajePU.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttbMensajePU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbMensajePU.Location = new System.Drawing.Point(0, 0);
            this.ttbMensajePU.Multiline = true;
            this.ttbMensajePU.Name = "ttbMensajePU";
            this.ttbMensajePU.ReadOnly = true;
            this.ttbMensajePU.Size = new System.Drawing.Size(391, 45);
            this.ttbMensajePU.TabIndex = 0;
            this.ttbMensajePU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttbMensajePU.TextChanged += new System.EventHandler(this.ttbMensajePU_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpString(this.btnCerrar, "Pulsa para cerrar y selecciona un comercial en el menu de arriba");
            this.btnCerrar.Location = new System.Drawing.Point(304, 51);
            this.btnCerrar.Name = "btnCerrar";
            this.helpProvider1.SetShowHelp(this.btnCerrar, true);
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 81);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.ttbMensajePU);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUp";
            this.Text = "Ayuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ttbMensajePU;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}