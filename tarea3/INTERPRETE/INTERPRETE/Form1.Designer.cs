
namespace INTERPRETE
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnejecutar = new System.Windows.Forms.Button();
            this.txtsoftware = new System.Windows.Forms.TextBox();
            this.btnleer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txterror = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.latbel4 = new System.Windows.Forms.Label();
            this.lstVtabla = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VALOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "software";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnejecutar
            // 
            this.btnejecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejecutar.Location = new System.Drawing.Point(648, 21);
            this.btnejecutar.Name = "btnejecutar";
            this.btnejecutar.Size = new System.Drawing.Size(98, 37);
            this.btnejecutar.TabIndex = 1;
            this.btnejecutar.Text = "ejecutar";
            this.btnejecutar.UseVisualStyleBackColor = true;
            this.btnejecutar.Click += new System.EventHandler(this.btnejecutar_Click);
            // 
            // txtsoftware
            // 
            this.txtsoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoftware.Location = new System.Drawing.Point(22, 76);
            this.txtsoftware.Multiline = true;
            this.txtsoftware.Name = "txtsoftware";
            this.txtsoftware.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsoftware.Size = new System.Drawing.Size(724, 389);
            this.txtsoftware.TabIndex = 2;
            this.txtsoftware.TextChanged += new System.EventHandler(this.txtsoftware_TextChanged);
            // 
            // btnleer
            // 
            this.btnleer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleer.Location = new System.Drawing.Point(521, 21);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(92, 37);
            this.btnleer.TabIndex = 4;
            this.btnleer.Text = "leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1162, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsalida
            // 
            this.txtsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalida.Location = new System.Drawing.Point(22, 500);
            this.txtsalida.Multiline = true;
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.ReadOnly = true;
            this.txtsalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsalida.Size = new System.Drawing.Size(724, 180);
            this.txtsalida.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "salida";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txterror
            // 
            this.txterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterror.Location = new System.Drawing.Point(763, 500);
            this.txterror.Multiline = true;
            this.txterror.Name = "txterror";
            this.txterror.ReadOnly = true;
            this.txterror.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txterror.Size = new System.Drawing.Size(503, 180);
            this.txterror.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(767, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "errores";
            // 
            // latbel4
            // 
            this.latbel4.AutoSize = true;
            this.latbel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latbel4.Location = new System.Drawing.Point(767, 41);
            this.latbel4.Name = "latbel4";
            this.latbel4.Size = new System.Drawing.Size(163, 25);
            this.latbel4.TabIndex = 11;
            this.latbel4.Text = "tabla de simbolos";
            // 
            // lstVtabla
            // 
            this.lstVtabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.tipo,
            this.VALOR});
            this.lstVtabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVtabla.HideSelection = false;
            this.lstVtabla.Location = new System.Drawing.Point(763, 76);
            this.lstVtabla.Name = "lstVtabla";
            this.lstVtabla.Size = new System.Drawing.Size(503, 389);
            this.lstVtabla.TabIndex = 12;
            this.lstVtabla.UseCompatibleStateImageBehavior = false;
            this.lstVtabla.View = System.Windows.Forms.View.Details;
            this.lstVtabla.SelectedIndexChanged += new System.EventHandler(this.lstVtabla_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 106;
            // 
            // tipo
            // 
            this.tipo.Text = "TIPO";
            this.tipo.Width = 137;
            // 
            // VALOR
            // 
            this.VALOR.Text = "VALOR";
            this.VALOR.Width = 134;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 692);
            this.Controls.Add(this.lstVtabla);
            this.Controls.Add(this.latbel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsalida);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.txtsoftware);
            this.Controls.Add(this.btnejecutar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnejecutar;
        private System.Windows.Forms.TextBox txtsoftware;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txterror;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label latbel4;
        private System.Windows.Forms.ListView lstVtabla;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.ColumnHeader VALOR;
    }
}

