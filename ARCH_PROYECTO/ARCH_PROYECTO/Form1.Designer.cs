namespace ARCH_PROYECTO
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HectDescan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HectNoProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superfTotalDecadaHectporCoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPSeleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionDeCoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(831, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "LIMPIAR CUADRO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(733, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "TERMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(640, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "GRABAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Violet;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.HectDescan,
            this.HectNoProduct,
            this.Ubicación});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridView1.Location = new System.Drawing.Point(52, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 164);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NombreCoop";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoria";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CantCabezas";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CostoXcabezas($)";
            this.Column5.Name = "Column5";
            // 
            // HectDescan
            // 
            this.HectDescan.HeaderText = "PesoXcabeza(kgr)";
            this.HectDescan.Name = "HectDescan";
            // 
            // HectNoProduct
            // 
            this.HectNoProduct.HeaderText = "IngresosAnual($)";
            this.HectNoProduct.Name = "HectNoProduct";
            // 
            // Ubicación
            // 
            this.Ubicación.HeaderText = "Ubicación";
            this.Ubicación.Name = "Ubicación";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saToolStripMenuItem,
            this.oPSeleccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saToolStripMenuItem
            // 
            this.saToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creacionToolStripMenuItem,
            this.accesarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.superfTotalDecadaHectporCoopToolStripMenuItem});
            this.saToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saToolStripMenuItem.Name = "saToolStripMenuItem";
            this.saToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.saToolStripMenuItem.Text = "Menu A1";
            // 
            // creacionToolStripMenuItem
            // 
            this.creacionToolStripMenuItem.Name = "creacionToolStripMenuItem";
            this.creacionToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.creacionToolStripMenuItem.Text = "Creacion";
            this.creacionToolStripMenuItem.Click += new System.EventHandler(this.creacionToolStripMenuItem_Click);
            // 
            // accesarToolStripMenuItem
            // 
            this.accesarToolStripMenuItem.Name = "accesarToolStripMenuItem";
            this.accesarToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.accesarToolStripMenuItem.Text = "Accesar";
            this.accesarToolStripMenuItem.Click += new System.EventHandler(this.accesarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.bajasToolStripMenuItem,
            this.modificacionesToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuItem2.Text = "Operaciones de A/B/M";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bajasToolStripMenuItem.Text = "Bajas";
            this.bajasToolStripMenuItem.Click += new System.EventHandler(this.bajasToolStripMenuItem_Click);
            // 
            // modificacionesToolStripMenuItem
            // 
            this.modificacionesToolStripMenuItem.Name = "modificacionesToolStripMenuItem";
            this.modificacionesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modificacionesToolStripMenuItem.Text = "Modificaciones";
            this.modificacionesToolStripMenuItem.Click += new System.EventHandler(this.modificacionesToolStripMenuItem_Click);
            // 
            // superfTotalDecadaHectporCoopToolStripMenuItem
            // 
            this.superfTotalDecadaHectporCoopToolStripMenuItem.Name = "superfTotalDecadaHectporCoopToolStripMenuItem";
            this.superfTotalDecadaHectporCoopToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.superfTotalDecadaHectporCoopToolStripMenuItem.Text = "CantidadX  categoria";
            this.superfTotalDecadaHectporCoopToolStripMenuItem.Click += new System.EventHandler(this.superfTotalDecadaHectporCoopToolStripMenuItem_Click);
            // 
            // oPSeleccionToolStripMenuItem
            // 
            this.oPSeleccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionDeCoopToolStripMenuItem,
            this.seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem,
            this.sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem});
            this.oPSeleccionToolStripMenuItem.Name = "oPSeleccionToolStripMenuItem";
            this.oPSeleccionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.oPSeleccionToolStripMenuItem.Text = "OP.Seleccion";
            // 
            // seleccionDeCoopToolStripMenuItem
            // 
            this.seleccionDeCoopToolStripMenuItem.Name = "seleccionDeCoopToolStripMenuItem";
            this.seleccionDeCoopToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.seleccionDeCoopToolStripMenuItem.Text = "Seleccion de cooppor Cod Par/Impar ";
            this.seleccionDeCoopToolStripMenuItem.Click += new System.EventHandler(this.seleccionDeCoopToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(925, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "GRABAR MODIFICACION";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "COOPERATIVAS PECUARIAS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cant de X Categorias pecuarias";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ARCH_PROYECTO.Properties.Resources.df;
            this.pictureBox2.Location = new System.Drawing.Point(424, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(656, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ARCH_PROYECTO.Properties.Resources.Imagen_de_WhatsApp_2024_07_15_a_las_22_45_46_34d4114b;
            this.pictureBox1.Location = new System.Drawing.Point(925, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem
            // 
            this.seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem.Name = "seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem";
            this.seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem.Text = "Seleccionar coop con mas ingresos anuales desde X";
            this.seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem.Click += new System.EventHandler(this.seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem_Click);
            // 
            // sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem
            // 
            this.sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem.Name = "sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem";
            this.sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem.Text = "sellecionar coop con menos ingresos anuales desde X";
            this.sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem.Click += new System.EventHandler(this.sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(0, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 404);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionesToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem superfTotalDecadaHectporCoopToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn HectDescan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HectNoProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicación;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem oPSeleccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionDeCoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem;
        private System.Windows.Forms.Button button5;
    }
}

