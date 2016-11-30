namespace FrontEnd
{
    partial class CadastrarClienteView
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.TextBoxCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxRg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cpf";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(38, 92);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(122, 23);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "Finalizar Cadastro";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // TextBoxCpf
            // 
            this.TextBoxCpf.Location = new System.Drawing.Point(49, 23);
            this.TextBoxCpf.Name = "TextBoxCpf";
            this.TextBoxCpf.Size = new System.Drawing.Size(134, 20);
            this.TextBoxCpf.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rg";
            // 
            // TextBoxRg
            // 
            this.TextBoxRg.Location = new System.Drawing.Point(49, 55);
            this.TextBoxRg.Name = "TextBoxRg";
            this.TextBoxRg.Size = new System.Drawing.Size(134, 20);
            this.TextBoxRg.TabIndex = 4;
            // 
            // CadastrarClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 127);
            this.Controls.Add(this.TextBoxRg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxCpf);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarClienteView";
            this.Text = "Informações Adicionais Usuário";
            this.Load += new System.EventHandler(this.CadastrarClienteView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox TextBoxCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxRg;
    }
}