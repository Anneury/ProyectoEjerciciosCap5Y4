
namespace ProyectoEjercicios
{
    partial class Ejercicio5Cap5cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio5Cap5cs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textNumeroConver = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Este ejercicio recibe un numero del 1 al 15 y lo escribe en letras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero convertido a letras:";
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(216, 61);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(125, 27);
            this.textNumero.TabIndex = 3;
            // 
            // textNumeroConver
            // 
            this.textNumeroConver.Location = new System.Drawing.Point(216, 113);
            this.textNumeroConver.Name = "textNumeroConver";
            this.textNumeroConver.Size = new System.Drawing.Size(360, 27);
            this.textNumeroConver.TabIndex = 4;
            // 
            // Aceptar
            // 
            this.Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Aceptar.Image")));
            this.Aceptar.Location = new System.Drawing.Point(335, 207);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(85, 68);
            this.Aceptar.TabIndex = 13;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.Location = new System.Drawing.Point(192, 206);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(82, 69);
            this.Nuevo.TabIndex = 14;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Ejercicio5Cap5cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 329);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.textNumeroConver);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5Cap5cs";
            this.Text = "Ejercicio5Cap5cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textNumeroConver;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Nuevo;
    }
}