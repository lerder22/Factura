namespace FactuxD
{
    partial class MantenimientoProductos
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
            this.txtIdPro = new MiLibreria2.ErrorTxtBox();
            this.txtDesPro = new MiLibreria2.ErrorTxtBox();
            this.txtPrePro = new MiLibreria2.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 90);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 134);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 183);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 228);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(372, 269);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID_Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio:";
            // 
            // txtIdPro
            // 
            this.txtIdPro.Location = new System.Drawing.Point(178, 93);
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.Size = new System.Drawing.Size(100, 20);
            this.txtIdPro.TabIndex = 15;
            this.txtIdPro.Validar = true;
            this.txtIdPro.TextChanged += new System.EventHandler(this.txtIdPro_TextChanged);
            // 
            // txtDesPro
            // 
            this.txtDesPro.Location = new System.Drawing.Point(178, 155);
            this.txtDesPro.Name = "txtDesPro";
            this.txtDesPro.Size = new System.Drawing.Size(100, 20);
            this.txtDesPro.TabIndex = 16;
            this.txtDesPro.Validar = true;
            // 
            // txtPrePro
            // 
            this.txtPrePro.Location = new System.Drawing.Point(178, 222);
            this.txtPrePro.Name = "txtPrePro";
            this.txtPrePro.Size = new System.Drawing.Size(100, 20);
            this.txtPrePro.TabIndex = 17;
            this.txtPrePro.Validar = true;
            // 
            // MantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 357);
            this.Controls.Add(this.txtPrePro);
            this.Controls.Add(this.txtDesPro);
            this.Controls.Add(this.txtIdPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoProductos";
            this.Text = "MantenimientoProductos";
            this.Load += new System.EventHandler(this.MantenimientoProductos_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdPro, 0);
            this.Controls.SetChildIndex(this.txtDesPro, 0);
            this.Controls.SetChildIndex(this.txtPrePro, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MiLibreria2.ErrorTxtBox txtIdPro;
        private MiLibreria2.ErrorTxtBox txtDesPro;
        private MiLibreria2.ErrorTxtBox txtPrePro;
    }
}