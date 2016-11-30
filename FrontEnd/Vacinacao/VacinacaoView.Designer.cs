namespace FrontEnd.Vacinacao
{
    partial class VacinacaoView
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
            this.listDoseVacina = new System.Windows.Forms.ListView();
            this.Dosagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aplicacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vacina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proximaAplicacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboVacina = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboAnimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textAplicacoes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDosagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMedida = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonAddDoseVacina = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDoseVacina
            // 
            this.listDoseVacina.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dosagem,
            this.Medida,
            this.Aplicacoes,
            this.Vacina,
            this.proximaAplicacao});
            this.listDoseVacina.FullRowSelect = true;
            this.listDoseVacina.Location = new System.Drawing.Point(17, 49);
            this.listDoseVacina.Name = "listDoseVacina";
            this.listDoseVacina.Size = new System.Drawing.Size(526, 118);
            this.listDoseVacina.TabIndex = 0;
            this.listDoseVacina.UseCompatibleStateImageBehavior = false;
            this.listDoseVacina.View = System.Windows.Forms.View.Details;
            this.listDoseVacina.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listDoseVacina_MouseDoubleClick);
            // 
            // Dosagem
            // 
            this.Dosagem.Text = "Dosagem";
            // 
            // Medida
            // 
            this.Medida.Text = "Medida";
            // 
            // Aplicacoes
            // 
            this.Aplicacoes.Text = "Nº Aplicações";
            this.Aplicacoes.Width = 89;
            // 
            // Vacina
            // 
            this.Vacina.Text = "Vacina";
            this.Vacina.Width = 122;
            // 
            // proximaAplicacao
            // 
            this.proximaAplicacao.Text = "Data Próxima Aplicação";
            this.proximaAplicacao.Width = 186;
            // 
            // comboVacina
            // 
            this.comboVacina.FormattingEnabled = true;
            this.comboVacina.ItemHeight = 13;
            this.comboVacina.Location = new System.Drawing.Point(16, 28);
            this.comboVacina.Name = "comboVacina";
            this.comboVacina.Size = new System.Drawing.Size(200, 21);
            this.comboVacina.TabIndex = 1;
            this.comboVacina.SelectedIndexChanged += new System.EventHandler(this.comboVacina_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nova Vacina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboAnimal
            // 
            this.comboAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnimal.FormattingEnabled = true;
            this.comboAnimal.Location = new System.Drawing.Point(46, 63);
            this.comboAnimal.Name = "comboAnimal";
            this.comboAnimal.Size = new System.Drawing.Size(213, 21);
            this.comboAnimal.TabIndex = 5;
            this.comboAnimal.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vacinação";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textAplicacoes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textDosagem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboMedida);
            this.panel1.Location = new System.Drawing.Point(25, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 149);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nº aplicacoes";
            // 
            // textAplicacoes
            // 
            this.textAplicacoes.Location = new System.Drawing.Point(21, 106);
            this.textAplicacoes.Name = "textAplicacoes";
            this.textAplicacoes.Size = new System.Drawing.Size(121, 20);
            this.textAplicacoes.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dosagem";
            // 
            // textDosagem
            // 
            this.textDosagem.Location = new System.Drawing.Point(21, 67);
            this.textDosagem.Name = "textDosagem";
            this.textDosagem.Size = new System.Drawing.Size(121, 20);
            this.textDosagem.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Medida";
            // 
            // comboMedida
            // 
            this.comboMedida.FormattingEnabled = true;
            this.comboMedida.Location = new System.Drawing.Point(21, 27);
            this.comboMedida.Name = "comboMedida";
            this.comboMedida.Size = new System.Drawing.Size(121, 21);
            this.comboMedida.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.comboVacina);
            this.panel2.Location = new System.Drawing.Point(311, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 149);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selecionar Vacina";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSalvar);
            this.panel3.Controls.Add(this.buttonAddDoseVacina);
            this.panel3.Controls.Add(this.listDoseVacina);
            this.panel3.Location = new System.Drawing.Point(25, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 232);
            this.panel3.TabIndex = 10;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(397, 189);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(146, 32);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar Vacinação";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonAddDoseVacina
            // 
            this.buttonAddDoseVacina.Location = new System.Drawing.Point(18, 15);
            this.buttonAddDoseVacina.Name = "buttonAddDoseVacina";
            this.buttonAddDoseVacina.Size = new System.Drawing.Size(145, 28);
            this.buttonAddDoseVacina.TabIndex = 1;
            this.buttonAddDoseVacina.Text = "Registrar Vacina";
            this.buttonAddDoseVacina.UseVisualStyleBackColor = true;
            this.buttonAddDoseVacina.Click += new System.EventHandler(this.button3_Click);
            // 
            // VacinacaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAnimal);
            this.Name = "VacinacaoView";
            this.Text = "VacinacaoView";
            this.Load += new System.EventHandler(this.VacinacaoView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listDoseVacina;
        private System.Windows.Forms.ComboBox comboVacina;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonAddDoseVacina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAplicacoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDosagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMedida;
        private System.Windows.Forms.ColumnHeader Dosagem;
        private System.Windows.Forms.ColumnHeader Medida;
        private System.Windows.Forms.ColumnHeader Aplicacoes;
        private System.Windows.Forms.ColumnHeader Vacina;
        private System.Windows.Forms.ColumnHeader proximaAplicacao;
    }
}