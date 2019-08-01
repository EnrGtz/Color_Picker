namespace Color_Picker
{

    internal sealed partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PnlContR = new System.Windows.Forms.Panel();
            this.NumR = new System.Windows.Forms.NumericUpDown();
            this.PnlR = new System.Windows.Forms.Panel();
            this.BtnMasR = new System.Windows.Forms.Button();
            this.BtnMenR = new System.Windows.Forms.Button();
            this.TrBarR = new System.Windows.Forms.TrackBar();
            this.LblR = new System.Windows.Forms.Label();
            this.PnlContG = new System.Windows.Forms.Panel();
            this.NumG = new System.Windows.Forms.NumericUpDown();
            this.PnlG = new System.Windows.Forms.Panel();
            this.BtnMasG = new System.Windows.Forms.Button();
            this.BtnMenG = new System.Windows.Forms.Button();
            this.TrBarG = new System.Windows.Forms.TrackBar();
            this.LblG = new System.Windows.Forms.Label();
            this.PnlContB = new System.Windows.Forms.Panel();
            this.NumB = new System.Windows.Forms.NumericUpDown();
            this.PnlB = new System.Windows.Forms.Panel();
            this.BtnMasB = new System.Windows.Forms.Button();
            this.BtnMenB = new System.Windows.Forms.Button();
            this.TrBarB = new System.Windows.Forms.TrackBar();
            this.LblB = new System.Windows.Forms.Label();
            this.PnlContA = new System.Windows.Forms.Panel();
            this.NumA = new System.Windows.Forms.NumericUpDown();
            this.PnlA = new System.Windows.Forms.Panel();
            this.BtnMasA = new System.Windows.Forms.Button();
            this.BtnMenA = new System.Windows.Forms.Button();
            this.TrBarA = new System.Windows.Forms.TrackBar();
            this.LblA = new System.Windows.Forms.Label();
            this.PnlCheck = new System.Windows.Forms.Panel();
            this.PnlColor = new System.Windows.Forms.Panel();
            this.LisVieColores = new System.Windows.Forms.ListView();
            this.CHColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHRGBA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHHex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHHSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.LblRGB = new System.Windows.Forms.Label();
            this.LblRGBA = new System.Windows.Forms.Label();
            this.TbRGB = new System.Windows.Forms.TextBox();
            this.TbRGBA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDegradado = new System.Windows.Forms.Button();
            this.TimControl = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlContR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarR)).BeginInit();
            this.PnlContG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarG)).BeginInit();
            this.PnlContB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarB)).BeginInit();
            this.PnlContA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarA)).BeginInit();
            this.PnlCheck.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlContR
            // 
            this.PnlContR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlContR.Controls.Add(this.NumR);
            this.PnlContR.Controls.Add(this.PnlR);
            this.PnlContR.Controls.Add(this.BtnMasR);
            this.PnlContR.Controls.Add(this.BtnMenR);
            this.PnlContR.Controls.Add(this.TrBarR);
            this.PnlContR.Controls.Add(this.LblR);
            this.PnlContR.Location = new System.Drawing.Point(12, 35);
            this.PnlContR.Name = "PnlContR";
            this.PnlContR.Size = new System.Drawing.Size(192, 83);
            this.PnlContR.TabIndex = 0;
            // 
            // NumR
            // 
            this.NumR.Location = new System.Drawing.Point(142, 20);
            this.NumR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumR.Name = "NumR";
            this.NumR.Size = new System.Drawing.Size(41, 20);
            this.NumR.TabIndex = 5;
            this.NumR.ValueChanged += new System.EventHandler(this.NumR_ValueChanged);
            // 
            // PnlR
            // 
            this.PnlR.Location = new System.Drawing.Point(49, 51);
            this.PnlR.Name = "PnlR";
            this.PnlR.Size = new System.Drawing.Size(87, 20);
            this.PnlR.TabIndex = 4;
            // 
            // BtnMasR
            // 
            this.BtnMasR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMasR.Location = new System.Drawing.Point(142, 51);
            this.BtnMasR.Name = "BtnMasR";
            this.BtnMasR.Size = new System.Drawing.Size(25, 20);
            this.BtnMasR.TabIndex = 3;
            this.BtnMasR.Text = "+";
            this.BtnMasR.UseVisualStyleBackColor = true;
            this.BtnMasR.Click += new System.EventHandler(this.BtnMasR_Click);
            // 
            // BtnMenR
            // 
            this.BtnMenR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMenR.Location = new System.Drawing.Point(18, 51);
            this.BtnMenR.Name = "BtnMenR";
            this.BtnMenR.Size = new System.Drawing.Size(25, 20);
            this.BtnMenR.TabIndex = 3;
            this.BtnMenR.Text = "-";
            this.BtnMenR.UseVisualStyleBackColor = true;
            this.BtnMenR.Click += new System.EventHandler(this.BtnMenR_Click);
            // 
            // TrBarR
            // 
            this.TrBarR.Location = new System.Drawing.Point(36, 15);
            this.TrBarR.Maximum = 255;
            this.TrBarR.Name = "TrBarR";
            this.TrBarR.Size = new System.Drawing.Size(100, 45);
            this.TrBarR.TabIndex = 1;
            this.TrBarR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrBarR.Scroll += new System.EventHandler(this.TrBarR_Scroll);
            // 
            // LblR
            // 
            this.LblR.AutoSize = true;
            this.LblR.Location = new System.Drawing.Point(15, 22);
            this.LblR.Name = "LblR";
            this.LblR.Size = new System.Drawing.Size(18, 13);
            this.LblR.TabIndex = 0;
            this.LblR.Text = "R:";
            // 
            // PnlContG
            // 
            this.PnlContG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlContG.Controls.Add(this.NumG);
            this.PnlContG.Controls.Add(this.PnlG);
            this.PnlContG.Controls.Add(this.BtnMasG);
            this.PnlContG.Controls.Add(this.BtnMenG);
            this.PnlContG.Controls.Add(this.TrBarG);
            this.PnlContG.Controls.Add(this.LblG);
            this.PnlContG.Location = new System.Drawing.Point(12, 124);
            this.PnlContG.Name = "PnlContG";
            this.PnlContG.Size = new System.Drawing.Size(192, 83);
            this.PnlContG.TabIndex = 1;
            // 
            // NumG
            // 
            this.NumG.Location = new System.Drawing.Point(142, 20);
            this.NumG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumG.Name = "NumG";
            this.NumG.Size = new System.Drawing.Size(41, 20);
            this.NumG.TabIndex = 6;
            this.NumG.ValueChanged += new System.EventHandler(this.NumG_ValueChanged);
            // 
            // PnlG
            // 
            this.PnlG.Location = new System.Drawing.Point(49, 51);
            this.PnlG.Name = "PnlG";
            this.PnlG.Size = new System.Drawing.Size(87, 20);
            this.PnlG.TabIndex = 4;
            // 
            // BtnMasG
            // 
            this.BtnMasG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMasG.Location = new System.Drawing.Point(142, 51);
            this.BtnMasG.Name = "BtnMasG";
            this.BtnMasG.Size = new System.Drawing.Size(25, 20);
            this.BtnMasG.TabIndex = 3;
            this.BtnMasG.Text = "+";
            this.BtnMasG.UseVisualStyleBackColor = true;
            this.BtnMasG.Click += new System.EventHandler(this.BtnMasG_Click);
            // 
            // BtnMenG
            // 
            this.BtnMenG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMenG.Location = new System.Drawing.Point(18, 51);
            this.BtnMenG.Name = "BtnMenG";
            this.BtnMenG.Size = new System.Drawing.Size(25, 20);
            this.BtnMenG.TabIndex = 3;
            this.BtnMenG.Text = "-";
            this.BtnMenG.UseVisualStyleBackColor = true;
            this.BtnMenG.Click += new System.EventHandler(this.BtnMenG_Click);
            // 
            // TrBarG
            // 
            this.TrBarG.Location = new System.Drawing.Point(36, 15);
            this.TrBarG.Maximum = 255;
            this.TrBarG.Name = "TrBarG";
            this.TrBarG.Size = new System.Drawing.Size(100, 45);
            this.TrBarG.TabIndex = 1;
            this.TrBarG.Scroll += new System.EventHandler(this.TrBarG_Scroll);
            // 
            // LblG
            // 
            this.LblG.AutoSize = true;
            this.LblG.Location = new System.Drawing.Point(15, 22);
            this.LblG.Name = "LblG";
            this.LblG.Size = new System.Drawing.Size(18, 13);
            this.LblG.TabIndex = 0;
            this.LblG.Text = "G:";
            // 
            // PnlContB
            // 
            this.PnlContB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlContB.Controls.Add(this.NumB);
            this.PnlContB.Controls.Add(this.PnlB);
            this.PnlContB.Controls.Add(this.BtnMasB);
            this.PnlContB.Controls.Add(this.BtnMenB);
            this.PnlContB.Controls.Add(this.TrBarB);
            this.PnlContB.Controls.Add(this.LblB);
            this.PnlContB.Location = new System.Drawing.Point(12, 213);
            this.PnlContB.Name = "PnlContB";
            this.PnlContB.Size = new System.Drawing.Size(192, 83);
            this.PnlContB.TabIndex = 2;
            // 
            // NumB
            // 
            this.NumB.Location = new System.Drawing.Point(142, 20);
            this.NumB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumB.Name = "NumB";
            this.NumB.Size = new System.Drawing.Size(41, 20);
            this.NumB.TabIndex = 6;
            this.NumB.ValueChanged += new System.EventHandler(this.NumB_ValueChanged);
            // 
            // PnlB
            // 
            this.PnlB.Location = new System.Drawing.Point(49, 51);
            this.PnlB.Name = "PnlB";
            this.PnlB.Size = new System.Drawing.Size(87, 20);
            this.PnlB.TabIndex = 4;
            // 
            // BtnMasB
            // 
            this.BtnMasB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMasB.Location = new System.Drawing.Point(142, 51);
            this.BtnMasB.Name = "BtnMasB";
            this.BtnMasB.Size = new System.Drawing.Size(25, 20);
            this.BtnMasB.TabIndex = 3;
            this.BtnMasB.Text = "+";
            this.BtnMasB.UseVisualStyleBackColor = true;
            this.BtnMasB.Click += new System.EventHandler(this.BtnMasB_Click);
            // 
            // BtnMenB
            // 
            this.BtnMenB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMenB.Location = new System.Drawing.Point(18, 51);
            this.BtnMenB.Name = "BtnMenB";
            this.BtnMenB.Size = new System.Drawing.Size(25, 20);
            this.BtnMenB.TabIndex = 3;
            this.BtnMenB.Text = "-";
            this.BtnMenB.UseVisualStyleBackColor = true;
            this.BtnMenB.Click += new System.EventHandler(this.BtnMenB_Click);
            // 
            // TrBarB
            // 
            this.TrBarB.Location = new System.Drawing.Point(36, 15);
            this.TrBarB.Maximum = 255;
            this.TrBarB.Name = "TrBarB";
            this.TrBarB.Size = new System.Drawing.Size(100, 45);
            this.TrBarB.TabIndex = 1;
            this.TrBarB.Scroll += new System.EventHandler(this.TrBarB_Scroll);
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(15, 22);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(17, 13);
            this.LblB.TabIndex = 0;
            this.LblB.Text = "B:";
            // 
            // PnlContA
            // 
            this.PnlContA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlContA.Controls.Add(this.NumA);
            this.PnlContA.Controls.Add(this.PnlA);
            this.PnlContA.Controls.Add(this.BtnMasA);
            this.PnlContA.Controls.Add(this.BtnMenA);
            this.PnlContA.Controls.Add(this.TrBarA);
            this.PnlContA.Controls.Add(this.LblA);
            this.PnlContA.Location = new System.Drawing.Point(12, 302);
            this.PnlContA.Name = "PnlContA";
            this.PnlContA.Size = new System.Drawing.Size(192, 83);
            this.PnlContA.TabIndex = 3;
            // 
            // NumA
            // 
            this.NumA.Location = new System.Drawing.Point(142, 22);
            this.NumA.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumA.Name = "NumA";
            this.NumA.Size = new System.Drawing.Size(41, 20);
            this.NumA.TabIndex = 6;
            this.NumA.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumA.ValueChanged += new System.EventHandler(this.NumA_ValueChanged);
            // 
            // PnlA
            // 
            this.PnlA.Location = new System.Drawing.Point(49, 51);
            this.PnlA.Name = "PnlA";
            this.PnlA.Size = new System.Drawing.Size(87, 20);
            this.PnlA.TabIndex = 4;
            // 
            // BtnMasA
            // 
            this.BtnMasA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMasA.Location = new System.Drawing.Point(142, 51);
            this.BtnMasA.Name = "BtnMasA";
            this.BtnMasA.Size = new System.Drawing.Size(25, 20);
            this.BtnMasA.TabIndex = 3;
            this.BtnMasA.Text = "+";
            this.BtnMasA.UseVisualStyleBackColor = true;
            this.BtnMasA.Click += new System.EventHandler(this.BtnMasA_Click);
            // 
            // BtnMenA
            // 
            this.BtnMenA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMenA.Location = new System.Drawing.Point(18, 51);
            this.BtnMenA.Name = "BtnMenA";
            this.BtnMenA.Size = new System.Drawing.Size(25, 20);
            this.BtnMenA.TabIndex = 3;
            this.BtnMenA.Text = "-";
            this.BtnMenA.UseVisualStyleBackColor = true;
            this.BtnMenA.Click += new System.EventHandler(this.BtnMenA_Click);
            // 
            // TrBarA
            // 
            this.TrBarA.Location = new System.Drawing.Point(36, 15);
            this.TrBarA.Maximum = 255;
            this.TrBarA.Name = "TrBarA";
            this.TrBarA.Size = new System.Drawing.Size(100, 45);
            this.TrBarA.TabIndex = 1;
            this.TrBarA.Scroll += new System.EventHandler(this.TrBarA_Scroll);
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(15, 22);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(17, 13);
            this.LblA.TabIndex = 0;
            this.LblA.Text = "A:";
            // 
            // PnlCheck
            // 
            this.PnlCheck.BackColor = System.Drawing.SystemColors.Control;
            this.PnlCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlCheck.BackgroundImage")));
            this.PnlCheck.Controls.Add(this.PnlColor);
            this.PnlCheck.Enabled = false;
            this.PnlCheck.Location = new System.Drawing.Point(220, 35);
            this.PnlCheck.Name = "PnlCheck";
            this.PnlCheck.Size = new System.Drawing.Size(112, 352);
            this.PnlCheck.TabIndex = 4;
            // 
            // PnlColor
            // 
            this.PnlColor.BackColor = System.Drawing.Color.White;
            this.PnlColor.Location = new System.Drawing.Point(0, 0);
            this.PnlColor.Name = "PnlColor";
            this.PnlColor.Size = new System.Drawing.Size(112, 352);
            this.PnlColor.TabIndex = 5;
            // 
            // LisVieColores
            // 
            this.LisVieColores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHColor,
            this.CHRGBA,
            this.CHHex,
            this.CHHSL});
            this.LisVieColores.GridLines = true;
            this.LisVieColores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LisVieColores.LabelWrap = false;
            this.LisVieColores.Location = new System.Drawing.Point(338, 35);
            this.LisVieColores.MultiSelect = false;
            this.LisVieColores.Name = "LisVieColores";
            this.LisVieColores.ShowGroups = false;
            this.LisVieColores.Size = new System.Drawing.Size(300, 352);
            this.LisVieColores.TabIndex = 5;
            this.LisVieColores.UseCompatibleStateImageBehavior = false;
            this.LisVieColores.View = System.Windows.Forms.View.Details;
            this.LisVieColores.SelectedIndexChanged += new System.EventHandler(this.LisVieColores_SelectedIndexChanged);
            // 
            // CHColor
            // 
            this.CHColor.Text = "Color";
            // 
            // CHRGBA
            // 
            this.CHRGBA.Text = "RGBA";
            this.CHRGBA.Width = 89;
            // 
            // CHHex
            // 
            this.CHHex.Text = "Hex";
            // 
            // CHHSL
            // 
            this.CHHSL.Text = "HSL";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnCargar);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.BtnAñadir);
            this.panel2.Controls.Add(this.LblRGB);
            this.panel2.Controls.Add(this.LblRGBA);
            this.panel2.Controls.Add(this.TbRGB);
            this.panel2.Controls.Add(this.TbRGBA);
            this.panel2.Location = new System.Drawing.Point(49, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 46);
            this.panel2.TabIndex = 6;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(294, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(456, 12);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 2;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(375, 12);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.Location = new System.Drawing.Point(213, 12);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(75, 23);
            this.BtnAñadir.TabIndex = 2;
            this.BtnAñadir.Text = "Añadir";
            this.BtnAñadir.UseVisualStyleBackColor = true;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // LblRGB
            // 
            this.LblRGB.AutoSize = true;
            this.LblRGB.Location = new System.Drawing.Point(115, 17);
            this.LblRGB.Name = "LblRGB";
            this.LblRGB.Size = new System.Drawing.Size(14, 13);
            this.LblRGB.TabIndex = 1;
            this.LblRGB.Text = "#";
            // 
            // LblRGBA
            // 
            this.LblRGBA.AutoSize = true;
            this.LblRGBA.Location = new System.Drawing.Point(13, 17);
            this.LblRGBA.Name = "LblRGBA";
            this.LblRGBA.Size = new System.Drawing.Size(21, 13);
            this.LblRGBA.TabIndex = 1;
            this.LblRGBA.Text = "#A";
            // 
            // TbRGB
            // 
            this.TbRGB.Location = new System.Drawing.Point(136, 14);
            this.TbRGB.MaxLength = 7;
            this.TbRGB.Name = "TbRGB";
            this.TbRGB.Size = new System.Drawing.Size(71, 20);
            this.TbRGB.TabIndex = 0;
            this.TbRGB.Text = "000000";
            this.TbRGB.TextChanged += new System.EventHandler(this.TbRGB_TextChanged);
            this.TbRGB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbRGB_KeyDown);
            // 
            // TbRGBA
            // 
            this.TbRGBA.Location = new System.Drawing.Point(40, 14);
            this.TbRGBA.MaxLength = 8;
            this.TbRGBA.Name = "TbRGBA";
            this.TbRGBA.Size = new System.Drawing.Size(69, 20);
            this.TbRGBA.TabIndex = 0;
            this.TbRGBA.Text = "000000FF";
            this.TbRGBA.TextChanged += new System.EventHandler(this.TbRGBA_TextChanged);
            this.TbRGBA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbRGBA_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnDegradado);
            this.panel1.Location = new System.Drawing.Point(49, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 42);
            this.panel1.TabIndex = 7;
            // 
            // BtnDegradado
            // 
            this.BtnDegradado.Location = new System.Drawing.Point(12, 10);
            this.BtnDegradado.Name = "BtnDegradado";
            this.BtnDegradado.Size = new System.Drawing.Size(75, 23);
            this.BtnDegradado.TabIndex = 0;
            this.BtnDegradado.Text = "Degradado";
            this.BtnDegradado.UseVisualStyleBackColor = true;
            this.BtnDegradado.Click += new System.EventHandler(this.BtnDegradado_Click);
            // 
            // TimControl
            // 
            this.TimControl.Enabled = true;
            this.TimControl.Tick += new System.EventHandler(this.TimControl_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.ActualizarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlCheck);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LisVieColores);
            this.Controls.Add(this.PnlContA);
            this.Controls.Add(this.PnlContB);
            this.Controls.Add(this.PnlContG);
            this.Controls.Add(this.PnlContR);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlContR.ResumeLayout(false);
            this.PnlContR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarR)).EndInit();
            this.PnlContG.ResumeLayout(false);
            this.PnlContG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarG)).EndInit();
            this.PnlContB.ResumeLayout(false);
            this.PnlContB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarB)).EndInit();
            this.PnlContA.ResumeLayout(false);
            this.PnlContA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBarA)).EndInit();
            this.PnlCheck.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlR;
        private System.Windows.Forms.Button BtnMasR;
        private System.Windows.Forms.Button BtnMenR;
        private System.Windows.Forms.TrackBar TrBarR;
        private System.Windows.Forms.Label LblR;
        private System.Windows.Forms.Panel PnlContR;
        private System.Windows.Forms.Panel PnlContG;
        private System.Windows.Forms.Panel PnlG;
        private System.Windows.Forms.Button BtnMasG;
        private System.Windows.Forms.Button BtnMenG;
        private System.Windows.Forms.TrackBar TrBarG;
        private System.Windows.Forms.Label LblG;
        private System.Windows.Forms.Panel PnlContB;
        private System.Windows.Forms.Panel PnlB;
        private System.Windows.Forms.Button BtnMasB;
        private System.Windows.Forms.Button BtnMenB;
        private System.Windows.Forms.TrackBar TrBarB;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Panel PnlContA;
        private System.Windows.Forms.Panel PnlA;
        private System.Windows.Forms.Button BtnMasA;
        private System.Windows.Forms.Button BtnMenA;
        private System.Windows.Forms.TrackBar TrBarA;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Panel PnlCheck;
        private System.Windows.Forms.Panel PnlColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Label LblRGB;
        private System.Windows.Forms.Label LblRGBA;
        private System.Windows.Forms.TextBox TbRGB;
        private System.Windows.Forms.TextBox TbRGBA;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.NumericUpDown NumR;
        private System.Windows.Forms.NumericUpDown NumG;
        private System.Windows.Forms.NumericUpDown NumB;
        private System.Windows.Forms.NumericUpDown NumA;
        private System.Windows.Forms.ColumnHeader CHRGBA;
        private System.Windows.Forms.ColumnHeader CHColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDegradado;
        public System.Windows.Forms.ListView LisVieColores;
        private System.Windows.Forms.Timer TimControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader CHHex;
        private System.Windows.Forms.ColumnHeader CHHSL;
    }
}

