namespace KwikEMart
{
    partial class FormPrincipal
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
            this.menuItemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAgregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInventarioUrgente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.generarDatosMockupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboxNuevoProducto = new System.Windows.Forms.ComboBox();
            this.cboxEmpleado = new System.Windows.Forms.ComboBox();
            this.gboxCaja = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dataCaja = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRestock = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gboxCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemProductos
            // 
            this.menuItemProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAgregarProducto,
            this.MenuItemInventario,
            this.MenuItemInventarioUrgente});
            this.menuItemProductos.Name = "menuItemProductos";
            this.menuItemProductos.Size = new System.Drawing.Size(92, 20);
            this.menuItemProductos.Text = "Productos";
            // 
            // MenuItemAgregarProducto
            // 
            this.MenuItemAgregarProducto.BackColor = System.Drawing.Color.Aqua;
            this.MenuItemAgregarProducto.Name = "MenuItemAgregarProducto";
            this.MenuItemAgregarProducto.Size = new System.Drawing.Size(276, 22);
            this.MenuItemAgregarProducto.Text = "Agregar";
            this.MenuItemAgregarProducto.Click += new System.EventHandler(this.MenuItemAgregarProducto_Click);
            // 
            // MenuItemInventario
            // 
            this.MenuItemInventario.BackColor = System.Drawing.Color.Aqua;
            this.MenuItemInventario.Name = "MenuItemInventario";
            this.MenuItemInventario.Size = new System.Drawing.Size(276, 22);
            this.MenuItemInventario.Text = "Inventario";
            this.MenuItemInventario.Click += new System.EventHandler(this.MenuItemInventario_Click);
            // 
            // MenuItemInventarioUrgente
            // 
            this.MenuItemInventarioUrgente.BackColor = System.Drawing.Color.Aqua;
            this.MenuItemInventarioUrgente.Name = "MenuItemInventarioUrgente";
            this.MenuItemInventarioUrgente.Size = new System.Drawing.Size(276, 22);
            this.MenuItemInventarioUrgente.Text = "Inventario urgente (<10)";
            this.MenuItemInventarioUrgente.Click += new System.EventHandler(this.MenuItemInventarioUrgente_Click);
            // 
            // menuItemVentas
            // 
            this.menuItemVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeVentasToolStripMenuItem});
            this.menuItemVentas.Name = "menuItemVentas";
            this.menuItemVentas.Size = new System.Drawing.Size(68, 20);
            this.menuItemVentas.Text = "Ventas";
            // 
            // listadoDeVentasToolStripMenuItem
            // 
            this.listadoDeVentasToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.listadoDeVentasToolStripMenuItem.Name = "listadoDeVentasToolStripMenuItem";
            this.listadoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.listadoDeVentasToolStripMenuItem.Text = "Listado de Ventas";
            this.listadoDeVentasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeVentasToolStripMenuItem_Click);
            // 
            // menuItemDebug
            // 
            this.menuItemDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarDatosMockupToolStripMenuItem});
            this.menuItemDebug.Name = "menuItemDebug";
            this.menuItemDebug.Size = new System.Drawing.Size(60, 20);
            this.menuItemDebug.Text = "Debug";
            // 
            // generarDatosMockupToolStripMenuItem
            // 
            this.generarDatosMockupToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.generarDatosMockupToolStripMenuItem.Name = "generarDatosMockupToolStripMenuItem";
            this.generarDatosMockupToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.generarDatosMockupToolStripMenuItem.Text = "Generar datos de prueba";
            this.generarDatosMockupToolStripMenuItem.Click += new System.EventHandler(this.generarDatosMockupToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Font = new System.Drawing.Font("Perfect DOS VGA 437 Win", 11.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemProductos,
            this.menuItemVentas,
            this.menuItemDebug,
            this.menuItemCliente});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(706, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemCliente
            // 
            this.menuItemCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem});
            this.menuItemCliente.Name = "menuItemCliente";
            this.menuItemCliente.Size = new System.Drawing.Size(84, 20);
            this.menuItemCliente.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de clientes";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // cboxCliente
            // 
            this.cboxCliente.BackColor = System.Drawing.Color.Aqua;
            this.cboxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCliente.Font = new System.Drawing.Font("Perfect DOS VGA 437 Win", 11.25F);
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(100, 30);
            this.cboxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(222, 24);
            this.cboxCliente.TabIndex = 1;
            this.cboxCliente.SelectedIndexChanged += new System.EventHandler(this.cboxCliente_ContextMenuStripChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Perfect DOS VGA 437 Win", 11.25F);
            this.lblCliente.Location = new System.Drawing.Point(13, 33);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(72, 16);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(13, 85);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(80, 16);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Producto:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(329, 33);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(80, 16);
            this.lblEmpleado.TabIndex = 5;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // cboxNuevoProducto
            // 
            this.cboxNuevoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNuevoProducto.FormattingEnabled = true;
            this.cboxNuevoProducto.Location = new System.Drawing.Point(100, 82);
            this.cboxNuevoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cboxNuevoProducto.Name = "cboxNuevoProducto";
            this.cboxNuevoProducto.Size = new System.Drawing.Size(222, 24);
            this.cboxNuevoProducto.TabIndex = 2;
            // 
            // cboxEmpleado
            // 
            this.cboxEmpleado.BackColor = System.Drawing.Color.Aqua;
            this.cboxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEmpleado.FormattingEnabled = true;
            this.cboxEmpleado.Location = new System.Drawing.Point(416, 30);
            this.cboxEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cboxEmpleado.Name = "cboxEmpleado";
            this.cboxEmpleado.Size = new System.Drawing.Size(281, 24);
            this.cboxEmpleado.TabIndex = 6;
            // 
            // gboxCaja
            // 
            this.gboxCaja.Controls.Add(this.btnQuitar);
            this.gboxCaja.Controls.Add(this.dataCaja);
            this.gboxCaja.Location = new System.Drawing.Point(12, 111);
            this.gboxCaja.Name = "gboxCaja";
            this.gboxCaja.Size = new System.Drawing.Size(682, 217);
            this.gboxCaja.TabIndex = 7;
            this.gboxCaja.TabStop = false;
            this.gboxCaja.Text = "Caja";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(496, 188);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(180, 23);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar producto";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dataCaja
            // 
            this.dataCaja.AllowUserToAddRows = false;
            this.dataCaja.AllowUserToDeleteRows = false;
            this.dataCaja.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCaja.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataCaja.GridColor = System.Drawing.Color.Aqua;
            this.dataCaja.Location = new System.Drawing.Point(6, 21);
            this.dataCaja.Name = "dataCaja";
            this.dataCaja.Size = new System.Drawing.Size(670, 161);
            this.dataCaja.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 334);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(148, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Terminar Compra";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(549, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // numCantidadProducto
            // 
            this.numCantidadProducto.Location = new System.Drawing.Point(329, 83);
            this.numCantidadProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidadProducto.Name = "numCantidadProducto";
            this.numCantidadProducto.Size = new System.Drawing.Size(53, 22);
            this.numCantidadProducto.TabIndex = 9;
            this.numCantidadProducto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(404, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(166, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 16);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // btnRestock
            // 
            this.btnRestock.Location = new System.Drawing.Point(567, 82);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(130, 23);
            this.btnRestock.TabIndex = 12;
            this.btnRestock.Text = "Reabastecer";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(706, 369);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.numCantidadProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gboxCaja);
            this.Controls.Add(this.cboxEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cboxNuevoProducto);
            this.Controls.Add(this.cboxCliente);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Perfect DOS VGA 437 Win", 11.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Kwik-e-Mart";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboxCaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuItemProductos;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAgregarProducto;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInventario;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInventarioUrgente;
        private System.Windows.Forms.ToolStripMenuItem menuItemVentas;
        private System.Windows.Forms.ToolStripMenuItem listadoDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemDebug;
        private System.Windows.Forms.ToolStripMenuItem generarDatosMockupToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboxNuevoProducto;
        private System.Windows.Forms.ComboBox cboxEmpleado;
        private System.Windows.Forms.GroupBox gboxCaja;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numCantidadProducto;
        private System.Windows.Forms.DataGridView dataCaja;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolStripMenuItem menuItemCliente;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRestock;
    }
}

