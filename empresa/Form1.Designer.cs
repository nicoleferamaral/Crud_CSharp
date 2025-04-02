namespace empresa
{
    partial class Form1
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
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Página Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(319, 148);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(131, 41);
            this.Cadastrar.TabIndex = 2;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(319, 212);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(131, 38);
            this.Consultar.TabIndex = 3;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.Location = new System.Drawing.Point(319, 267);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(131, 37);
            this.Atualizar.TabIndex = 4;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.Location = new System.Drawing.Point(319, 326);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(131, 41);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Titulo da pagina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Excluir;
    }
}