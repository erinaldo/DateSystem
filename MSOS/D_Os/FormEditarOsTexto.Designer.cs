namespace DateSystem
{
    partial class FormEditarOsTexto
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
            this.txtOrigemChamado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServicoExecutado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOrigemChamado
            // 
            this.txtOrigemChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigemChamado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtOrigemChamado.Location = new System.Drawing.Point(12, 16);
            this.txtOrigemChamado.Multiline = true;
            this.txtOrigemChamado.Name = "txtOrigemChamado";
            this.txtOrigemChamado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrigemChamado.Size = new System.Drawing.Size(464, 181);
            this.txtOrigemChamado.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 123;
            this.label7.Text = "ORIGEM DO CHAMADO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 121;
            this.label3.Text = "SERVIÇO EXECUTADOS:";
            // 
            // txtServicoExecutado
            // 
            this.txtServicoExecutado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicoExecutado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtServicoExecutado.Location = new System.Drawing.Point(8, 218);
            this.txtServicoExecutado.Multiline = true;
            this.txtServicoExecutado.Name = "txtServicoExecutado";
            this.txtServicoExecutado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtServicoExecutado.Size = new System.Drawing.Size(464, 180);
            this.txtServicoExecutado.TabIndex = 120;
            // 
            // FormEditarOsTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 410);
            this.ControlBox = false;
            this.Controls.Add(this.txtOrigemChamado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServicoExecutado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarOsTexto";
            this.Text = "Copia Texto Criado";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormEditarOsTexto_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrigemChamado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServicoExecutado;
    }
}