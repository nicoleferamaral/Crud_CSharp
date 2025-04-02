namespace empresa
{
    partial class Cadastrar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Endereço:";
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(162, 151);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(593, 31);
            this.codigo.TabIndex = 6;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(162, 197);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(593, 31);
            this.nome.TabIndex = 7;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(162, 242);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(593, 31);
            this.telefone.TabIndex = 8;
            this.telefone.TextChanged += new System.EventHandler(this.telefone_TextChanged);
            // 
            // endereco
            // 
            this.endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(162, 286);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(593, 31);
            this.endereco.TabIndex = 9;
            this.endereco.TextChanged += new System.EventHandler(this.endereco_TextChanged);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(518, 374);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(131, 38);
            this.Voltar.TabIndex = 11;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro.Location = new System.Drawing.Point(162, 371);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(131, 41);
            this.cadastro.TabIndex = 10;
            this.cadastro.Text = "Cadastrar";
            this.cadastro.UseVisualStyleBackColor = false;
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button cadastro;
    }
}