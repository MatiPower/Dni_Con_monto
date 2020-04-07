namespace Dni_Con_Monto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.inputDni = new System.Windows.Forms.TextBox();
            this.inputMonto = new System.Windows.Forms.TextBox();
            this.lblErrorDni = new System.Windows.Forms.Label();
            this.lblErrorMonto = new System.Windows.Forms.Label();
            this.lblCheckDni = new System.Windows.Forms.Label();
            this.lblCheckMonto = new System.Windows.Forms.Label();
            this.lblPlataIngresada = new System.Windows.Forms.Label();
            this.txtPlataIngresada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            resources.ApplyResources(this.btnEnviar, "btnEnviar");
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblDni
            // 
            resources.ApplyResources(this.lblDni, "lblDni");
            this.lblDni.Name = "lblDni";
            this.lblDni.Click += new System.EventHandler(this.lblDni_Click);
            // 
            // lblMonto
            // 
            resources.ApplyResources(this.lblMonto, "lblMonto");
            this.lblMonto.Name = "lblMonto";
            // 
            // inputDni
            // 
            resources.ApplyResources(this.inputDni, "inputDni");
            this.inputDni.Name = "inputDni";
            // 
            // inputMonto
            // 
            resources.ApplyResources(this.inputMonto, "inputMonto");
            this.inputMonto.Name = "inputMonto";
            // 
            // lblErrorDni
            // 
            resources.ApplyResources(this.lblErrorDni, "lblErrorDni");
            this.lblErrorDni.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorDni.Name = "lblErrorDni";
            // 
            // lblErrorMonto
            // 
            resources.ApplyResources(this.lblErrorMonto, "lblErrorMonto");
            this.lblErrorMonto.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorMonto.Name = "lblErrorMonto";
            // 
            // lblCheckDni
            // 
            resources.ApplyResources(this.lblCheckDni, "lblCheckDni");
            this.lblCheckDni.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCheckDni.Name = "lblCheckDni";
            // 
            // lblCheckMonto
            // 
            resources.ApplyResources(this.lblCheckMonto, "lblCheckMonto");
            this.lblCheckMonto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCheckMonto.Name = "lblCheckMonto";
            // 
            // lblPlataIngresada
            // 
            resources.ApplyResources(this.lblPlataIngresada, "lblPlataIngresada");
            this.lblPlataIngresada.Name = "lblPlataIngresada";
            // 
            // txtPlataIngresada
            // 
            resources.ApplyResources(this.txtPlataIngresada, "txtPlataIngresada");
            this.txtPlataIngresada.Name = "txtPlataIngresada";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPlataIngresada);
            this.Controls.Add(this.lblPlataIngresada);
            this.Controls.Add(this.lblCheckMonto);
            this.Controls.Add(this.lblCheckDni);
            this.Controls.Add(this.lblErrorMonto);
            this.Controls.Add(this.lblErrorDni);
            this.Controls.Add(this.inputMonto);
            this.Controls.Add(this.inputDni);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnEnviar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox inputDni;
        private System.Windows.Forms.TextBox inputMonto;
        private System.Windows.Forms.Label lblErrorDni;
        private System.Windows.Forms.Label lblErrorMonto;
        private System.Windows.Forms.Label lblCheckDni;
        private System.Windows.Forms.Label lblCheckMonto;
        private System.Windows.Forms.Label lblPlataIngresada;
        private System.Windows.Forms.TextBox txtPlataIngresada;
    }
}

