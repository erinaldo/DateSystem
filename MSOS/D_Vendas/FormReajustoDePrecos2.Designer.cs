namespace DateSystem
{
    partial class FormReajustoDePrecos2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPrecoCusto = new System.Windows.Forms.RadioButton();
            this.radioButtonPrecoVenda = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExt1 = new DateSystem.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReajusta = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonPrecoVenda);
            this.panel1.Controls.Add(this.radioButtonPrecoCusto);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reajuste de Preços";
            // 
            // radioButtonPrecoCusto
            // 
            this.radioButtonPrecoCusto.AutoSize = true;
            this.radioButtonPrecoCusto.Location = new System.Drawing.Point(18, 20);
            this.radioButtonPrecoCusto.Name = "radioButtonPrecoCusto";
            this.radioButtonPrecoCusto.Size = new System.Drawing.Size(97, 17);
            this.radioButtonPrecoCusto.TabIndex = 3;
            this.radioButtonPrecoCusto.TabStop = true;
            this.radioButtonPrecoCusto.Text = "Preço de custo";
            this.radioButtonPrecoCusto.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrecoVenda
            // 
            this.radioButtonPrecoVenda.AutoSize = true;
            this.radioButtonPrecoVenda.Location = new System.Drawing.Point(18, 43);
            this.radioButtonPrecoVenda.Name = "radioButtonPrecoVenda";
            this.radioButtonPrecoVenda.Size = new System.Drawing.Size(101, 17);
            this.radioButtonPrecoVenda.TabIndex = 4;
            this.radioButtonPrecoVenda.TabStop = true;
            this.radioButtonPrecoVenda.Text = "Preço de venda";
            this.radioButtonPrecoVenda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Percentual de reajuste";
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.Location = new System.Drawing.Point(128, 115);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(153, 20);
            this.textBoxExt1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "%";
            // 
            // buttonReajusta
            // 
            this.buttonReajusta.Location = new System.Drawing.Point(128, 167);
            this.buttonReajusta.Name = "buttonReajusta";
            this.buttonReajusta.Size = new System.Drawing.Size(75, 23);
            this.buttonReajusta.TabIndex = 6;
            this.buttonReajusta.Text = "Reajustar";
            this.buttonReajusta.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(209, 167);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(42, 23);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.Text = "F";
            this.buttonFechar.UseVisualStyleBackColor = true;
            // 
            // FormReajustoDePrecos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 200);
            this.ControlBox = false;
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonReajusta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxExt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReajustoDePrecos2";
            this.Text = "Reajuste de Preços";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPrecoVenda;
        private System.Windows.Forms.RadioButton radioButtonPrecoCusto;
        private System.Windows.Forms.Label label2;
        private TextBoxExt textBoxExt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReajusta;
        private System.Windows.Forms.Button buttonFechar;
    }
}