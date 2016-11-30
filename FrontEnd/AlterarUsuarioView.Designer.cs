namespace FrontEnd
{
    partial class AlterarUsuarioView
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
            this.bAlterarUsuario = new System.Windows.Forms.Button();
            this.tNomeUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAlterarUsuario
            // 
            this.bAlterarUsuario.Location = new System.Drawing.Point(56, 119);
            this.bAlterarUsuario.Name = "bAlterarUsuario";
            this.bAlterarUsuario.Size = new System.Drawing.Size(75, 23);
            this.bAlterarUsuario.TabIndex = 0;
            this.bAlterarUsuario.Text = "Salvar";
            this.bAlterarUsuario.UseVisualStyleBackColor = true;
            this.bAlterarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // tNomeUsuario
            // 
            this.tNomeUsuario.Location = new System.Drawing.Point(56, 66);
            this.tNomeUsuario.Name = "tNomeUsuario";
            this.tNomeUsuario.Size = new System.Drawing.Size(100, 20);
            this.tNomeUsuario.TabIndex = 1;
            // 
            // AlterarUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tNomeUsuario);
            this.Controls.Add(this.bAlterarUsuario);
            this.Name = "AlterarUsuarioView";
            this.Text = "AlterarUsuario";
            this.Load += new System.EventHandler(this.AlterarUsuarioView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAlterarUsuario;
        private System.Windows.Forms.TextBox tNomeUsuario;
    }
}