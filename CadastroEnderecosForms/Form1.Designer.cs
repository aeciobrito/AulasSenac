
namespace CadastroEnderecosForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtLinkSite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeLugar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosicaoX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosicaoY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(214, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLinkSite
            // 
            this.txtLinkSite.Location = new System.Drawing.Point(116, 23);
            this.txtLinkSite.Name = "txtLinkSite";
            this.txtLinkSite.Size = new System.Drawing.Size(517, 27);
            this.txtLinkSite.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link do Maps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Lugar";
            // 
            // txtNomeLugar
            // 
            this.txtNomeLugar.Location = new System.Drawing.Point(136, 142);
            this.txtNomeLugar.Name = "txtNomeLugar";
            this.txtNomeLugar.Size = new System.Drawing.Size(252, 27);
            this.txtNomeLugar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posição X";
            // 
            // txtPosicaoX
            // 
            this.txtPosicaoX.Location = new System.Drawing.Point(136, 185);
            this.txtPosicaoX.Name = "txtPosicaoX";
            this.txtPosicaoX.Size = new System.Drawing.Size(252, 27);
            this.txtPosicaoX.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Posição Y";
            // 
            // txtPosicaoY
            // 
            this.txtPosicaoY.Location = new System.Drawing.Point(136, 228);
            this.txtPosicaoY.Name = "txtPosicaoY";
            this.txtPosicaoY.Size = new System.Drawing.Size(252, 27);
            this.txtPosicaoY.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPosicaoY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPosicaoX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeLugar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLinkSite);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLinkSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeLugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosicaoX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPosicaoY;
    }
}

