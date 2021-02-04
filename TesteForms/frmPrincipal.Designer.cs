
namespace TesteForms {
    partial class frmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblContratosLocal = new System.Windows.Forms.Label();
            this.lstContratosLocal = new System.Windows.Forms.ListBox();
            this.grpContratosLocal = new System.Windows.Forms.GroupBox();
            this.grpContratosLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(327, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Teste Concilig";
            // 
            // lblContratosLocal
            // 
            this.lblContratosLocal.AutoSize = true;
            this.lblContratosLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratosLocal.Location = new System.Drawing.Point(6, 16);
            this.lblContratosLocal.Name = "lblContratosLocal";
            this.lblContratosLocal.Size = new System.Drawing.Size(204, 31);
            this.lblContratosLocal.TabIndex = 1;
            this.lblContratosLocal.Text = "Contratos: local";
            // 
            // lstContratosLocal
            // 
            this.lstContratosLocal.FormattingEnabled = true;
            this.lstContratosLocal.Location = new System.Drawing.Point(12, 51);
            this.lstContratosLocal.Name = "lstContratosLocal";
            this.lstContratosLocal.Size = new System.Drawing.Size(299, 342);
            this.lstContratosLocal.TabIndex = 2;
            // 
            // grpContratosLocal
            // 
            this.grpContratosLocal.Controls.Add(this.lblContratosLocal);
            this.grpContratosLocal.Controls.Add(this.lstContratosLocal);
            this.grpContratosLocal.Location = new System.Drawing.Point(23, 72);
            this.grpContratosLocal.Name = "grpContratosLocal";
            this.grpContratosLocal.Size = new System.Drawing.Size(317, 409);
            this.grpContratosLocal.TabIndex = 3;
            this.grpContratosLocal.TabStop = false;
            this.grpContratosLocal.Text = "Arquivos .CSV";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpContratosLocal);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste - Concilig";
            this.grpContratosLocal.ResumeLayout(false);
            this.grpContratosLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContratosLocal;
        private System.Windows.Forms.ListBox lstContratosLocal;
        private System.Windows.Forms.GroupBox grpContratosLocal;
    }
}

