namespace Color_Picker
{

    internal sealed partial class Degradado
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
            this.TbColorInicial = new System.Windows.Forms.TextBox();
            this.LblInicio = new System.Windows.Forms.Label();
            this.TbColorFinal = new System.Windows.Forms.TextBox();
            this.LblColorFinal = new System.Windows.Forms.Label();
            this.LvColores = new System.Windows.Forms.ListView();
            this.ColHRGBA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumCantidadColores = new System.Windows.Forms.NumericUpDown();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnDegradado = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadColores)).BeginInit();
            this.SuspendLayout();
            // 
            // TbColorInicial
            // 
            this.TbColorInicial.Location = new System.Drawing.Point(17, 25);
            this.TbColorInicial.MaxLength = 9;
            this.TbColorInicial.Name = "TbColorInicial";
            this.TbColorInicial.Size = new System.Drawing.Size(69, 20);
            this.TbColorInicial.TabIndex = 0;
            this.TbColorInicial.DoubleClick += new System.EventHandler(this.TbColorInicial_DoubleClick);
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Location = new System.Drawing.Point(14, 9);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(74, 13);
            this.LblInicio.TabIndex = 1;
            this.LblInicio.Text = "Color Inicial: #";
            // 
            // TbColorFinal
            // 
            this.TbColorFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TbColorFinal.Location = new System.Drawing.Point(105, 25);
            this.TbColorFinal.MaxLength = 9;
            this.TbColorFinal.Name = "TbColorFinal";
            this.TbColorFinal.Size = new System.Drawing.Size(63, 20);
            this.TbColorFinal.TabIndex = 0;
            this.TbColorFinal.DoubleClick += new System.EventHandler(this.TbColorFinal_DoubleClick);
            // 
            // LblColorFinal
            // 
            this.LblColorFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblColorFinal.AutoSize = true;
            this.LblColorFinal.Location = new System.Drawing.Point(102, 9);
            this.LblColorFinal.Name = "LblColorFinal";
            this.LblColorFinal.Size = new System.Drawing.Size(69, 13);
            this.LblColorFinal.TabIndex = 1;
            this.LblColorFinal.Text = "Color Final: #";
            // 
            // LvColores
            // 
            this.LvColores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvColores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColHRGBA,
            this.ColHColor});
            this.LvColores.GridLines = true;
            this.LvColores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvColores.HideSelection = false;
            this.LvColores.LabelWrap = false;
            this.LvColores.Location = new System.Drawing.Point(12, 51);
            this.LvColores.Name = "LvColores";
            this.LvColores.Size = new System.Drawing.Size(222, 243);
            this.LvColores.TabIndex = 2;
            this.LvColores.UseCompatibleStateImageBehavior = false;
            this.LvColores.View = System.Windows.Forms.View.Details;
            // 
            // ColHRGBA
            // 
            this.ColHRGBA.Text = "RGBA";
            this.ColHRGBA.Width = 143;
            // 
            // ColHColor
            // 
            this.ColHColor.Text = "Color";
            // 
            // NumCantidadColores
            // 
            this.NumCantidadColores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumCantidadColores.Location = new System.Drawing.Point(183, 25);
            this.NumCantidadColores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumCantidadColores.Name = "NumCantidadColores";
            this.NumCantidadColores.Size = new System.Drawing.Size(51, 20);
            this.NumCantidadColores.TabIndex = 3;
            // 
            // LblCantidad
            // 
            this.LblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(184, 9);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(52, 13);
            this.LblCantidad.TabIndex = 4;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // BtnDegradado
            // 
            this.BtnDegradado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDegradado.Location = new System.Drawing.Point(15, 300);
            this.BtnDegradado.Name = "BtnDegradado";
            this.BtnDegradado.Size = new System.Drawing.Size(219, 23);
            this.BtnDegradado.TabIndex = 5;
            this.BtnDegradado.Text = "Formar Degradado";
            this.BtnDegradado.UseVisualStyleBackColor = true;
            this.BtnDegradado.Click += new System.EventHandler(this.BtnDegradado_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Location = new System.Drawing.Point(15, 329);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(219, 23);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar Seleccionados";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // Degradado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 361);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnDegradado);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.NumCantidadColores);
            this.Controls.Add(this.LvColores);
            this.Controls.Add(this.LblColorFinal);
            this.Controls.Add(this.LblInicio);
            this.Controls.Add(this.TbColorFinal);
            this.Controls.Add(this.TbColorInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(260, 4000);
            this.MinimumSize = new System.Drawing.Size(260, 400);
            this.Name = "Degradado";
            this.Text = "Degradado";
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadColores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbColorInicial;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.TextBox TbColorFinal;
        private System.Windows.Forms.Label LblColorFinal;
        private System.Windows.Forms.ListView LvColores;
        private System.Windows.Forms.ColumnHeader ColHRGBA;
        private System.Windows.Forms.ColumnHeader ColHColor;
        private System.Windows.Forms.NumericUpDown NumCantidadColores;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnDegradado;
        private System.Windows.Forms.Button BtnAgregar;
    }
}