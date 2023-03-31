namespace sdq.forms
{
    partial class Main
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
            this.btnCrear = new ReaLTaiizor.Controls.MaterialButton();
            this.btnAsc = new ReaLTaiizor.Controls.MaterialButton();
            this.materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btnDes = new ReaLTaiizor.Controls.MaterialButton();
            this.tabla__alumnos = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaja = new ReaLTaiizor.Controls.MaterialButton();
            this.btnBusqueda = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabla__alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrear.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrear.Depth = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.HighEmphasis = true;
            this.btnCrear.Icon = null;
            this.btnCrear.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCrear.Location = new System.Drawing.Point(13, 15);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrear.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrear.Size = new System.Drawing.Size(111, 36);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Dar de alta";
            this.btnCrear.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrear.UseAccentColor = false;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsc.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsc.Depth = 0;
            this.btnAsc.HighEmphasis = true;
            this.btnAsc.Icon = null;
            this.btnAsc.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnAsc.Location = new System.Drawing.Point(132, 15);
            this.btnAsc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAsc.Size = new System.Drawing.Size(185, 36);
            this.btnAsc.TabIndex = 1;
            this.btnAsc.Text = "Ordenar Ascendente";
            this.btnAsc.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAsc.UseAccentColor = false;
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 73);
            this.materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(775, 5);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 97);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Alumnos";
            // 
            // btnDes
            // 
            this.btnDes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDes.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDes.Depth = 0;
            this.btnDes.HighEmphasis = true;
            this.btnDes.Icon = null;
            this.btnDes.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnDes.Location = new System.Drawing.Point(325, 15);
            this.btnDes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnDes.Name = "btnDes";
            this.btnDes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDes.Size = new System.Drawing.Size(194, 36);
            this.btnDes.TabIndex = 4;
            this.btnDes.Text = "Ordenar Descendente";
            this.btnDes.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDes.UseAccentColor = false;
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // tabla__alumnos
            // 
            this.tabla__alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla__alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nombre,
            this.grado,
            this.grupo,
            this.promedio});
            this.tabla__alumnos.Location = new System.Drawing.Point(12, 135);
            this.tabla__alumnos.Name = "tabla__alumnos";
            this.tabla__alumnos.Size = new System.Drawing.Size(775, 260);
            this.tabla__alumnos.TabIndex = 5;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // grado
            // 
            this.grado.HeaderText = "Grado";
            this.grado.Name = "grado";
            // 
            // grupo
            // 
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            // 
            // promedio
            // 
            this.promedio.HeaderText = "Promedio";
            this.promedio.Name = "promedio";
            // 
            // btnBaja
            // 
            this.btnBaja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaja.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaja.Depth = 0;
            this.btnBaja.HighEmphasis = true;
            this.btnBaja.Icon = null;
            this.btnBaja.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnBaja.Location = new System.Drawing.Point(527, 15);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaja.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaja.Size = new System.Drawing.Size(123, 36);
            this.btnBaja.TabIndex = 6;
            this.btnBaja.Text = "Baja Alumno";
            this.btnBaja.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaja.UseAccentColor = false;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBusqueda.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBusqueda.Depth = 0;
            this.btnBusqueda.HighEmphasis = true;
            this.btnBusqueda.Icon = null;
            this.btnBusqueda.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnBusqueda.Location = new System.Drawing.Point(658, 15);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBusqueda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBusqueda.Size = new System.Drawing.Size(123, 36);
            this.btnBusqueda.TabIndex = 7;
            this.btnBusqueda.Text = "Buscar Alumno";
            this.btnBusqueda.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBusqueda.UseAccentColor = false;
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(808, 703);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.tabla__alumnos);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.btnCrear);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabla__alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btnCrear;
        private ReaLTaiizor.Controls.MaterialButton btnAsc;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private ReaLTaiizor.Controls.MaterialButton btnDes;
        private System.Windows.Forms.DataGridView tabla__alumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedio;
        private ReaLTaiizor.Controls.MaterialButton btnBaja;
        private ReaLTaiizor.Controls.MaterialButton btnBusqueda;
    }
}

