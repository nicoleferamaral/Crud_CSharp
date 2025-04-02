namespace empresa
{
    partial class Excluir
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
            this.exclui = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exclui
            // 
            this.exclui.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exclui.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exclui.Location = new System.Drawing.Point(158, 386);
            this.exclui.Name = "exclui";
            this.exclui.Size = new System.Drawing.Size(131, 41);
            this.exclui.TabIndex = 21;
            this.exclui.Text = "Excluir";
            this.exclui.UseVisualStyleBackColor = false;
            this.exclui.Click += new System.EventHandler(this.exclui_Click);
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(173, 202);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(593, 31);
            this.codigo.TabIndex = 17;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Código: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 62);
            this.label1.TabIndex = 12;
            this.label1.Text = "Excluir";
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Voltar.Location = new System.Drawing.Point(515, 386);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(131, 41);
            this.Voltar.TabIndex = 22;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.exclui);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.Load += new System.EventHandler(this.Excluir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exclui;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Voltar;
    }
}