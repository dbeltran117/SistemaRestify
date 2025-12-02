using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorPrincipal
    {
        Base b = new Base("localhost", "root", "12345", "restauranteSft", 3306);
        #region VerPrecios
        public void MostrarProdutos(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idCategoria"].Visible = false;
            tabla.Columns["idProducto"].Visible = false;
            tabla.Columns["Precio"].DefaultCellStyle.Format = "C2";
            tabla.Columns["Importe"].DefaultCellStyle.Format = "C2";
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void LlenarCategorias(ComboBox cmb)
        {
            var dt = b.Consultar("select * from categorias", "categorias").Tables[0];

            // crear fila extra para "Todos los productos"
            DataRow filaExtra = dt.NewRow();
            filaExtra["idCategoria"] = 0; // valor especial
            filaExtra["nombreCategoria"] = "Todos los productos";
            dt.Rows.InsertAt(filaExtra, 0); // la insertamos al inicio

            cmb.DataSource = dt;
            cmb.DisplayMember = "nombreCategoria";
            cmb.ValueMember = "idCategoria";
        }
        #endregion

        #region AbrirMesa

        public string AbrirMesa(string nombreMesa, string etiqueta, string estado)
        {
            DataSet ds = b.Consultar($"call p_abrirMesas('{nombreMesa}','{etiqueta}','{estado}')", "rs");

            // valida que exista la tabla "rs" y que tenga filas
            if (ds != null && ds.Tables.Contains("rs") && ds.Tables["rs"].Rows.Count > 0)
            {
                return ds.Tables["rs"].Rows[0][0].ToString(); // mensaje de error
            }

            // éxito: sin mensaje
            return string.Empty;

        }

        public void CerrarMesa(string nombreMesa, string etiqueta, string estado)
        {
            b.Comando($"call p_cerrarMesas('{nombreMesa}','{etiqueta}','{estado}')");
        }

        public string MostrarEtiqueta(int IdMesa)
        {
            string etiqueta = "";

            // Ejecutamos la consulta y obtenemos el DataSet
            var ds = b.Consultar($"SELECT etiqueta FROM mesas WHERE idMesa = {IdMesa}", "mesas");

            // Validamos que haya al menos una fila
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                etiqueta = ds.Tables[0].Rows[0][0].ToString();
            }

            return etiqueta;
        }

        public void MostrarMesas(ComboBox cmb)
        {
            cmb.DataSource = b.Consultar("SELECT * FROM mesas", "mesas").Tables[0];
            cmb.DisplayMember = "nombreMesa";
            cmb.ValueMember = "idMesa";
        }

        public event Action<string> OnMesaSeleccionada;

        public void CrearBotonesMesas(Panel panel)
        {

            panel.Controls.Clear();
            panel.AutoScroll = true;

            var ds = b.Consultar("SELECT * FROM mesas where estado != 'Inactivo'", "mesas");
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                return;

            int columnas = 5;
            int filas = 3;
            int margen = 10;

            int btnAncho = (panel.Width - (columnas + 1) * margen) / columnas;
            int btnAlto = (panel.Height - (filas + 1) * margen) / filas;

            int x = 0, y = 0;
            int contador = 0;

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Button btn = new Button();
                btn.Size = new Size(btnAncho, btnAlto);
                btn.Text = fila["nombreMesa"].ToString();
                btn.Name = fila["nombreMesa"].ToString();
                btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                string estado = fila["estado"].ToString();
                int idMesa = Convert.ToInt32(fila["idMesa"]);

                if (VerificarReservacion(idMesa.ToString()))
                    btn.BackColor = Color.FromArgb(249, 236, 201);
                else if (estado == "Disponible")
                    btn.BackColor = ColorTranslator.FromHtml("#BA9470");
                else if (estado == "Ocupada")
                    btn.BackColor = ColorTranslator.FromHtml("#C66828");
                else
                    btn.BackColor = Color.LightGray;

                int col = contador % columnas;
                int filaY = contador / columnas;

                x = margen + col * (btnAncho + margen);
                y = margen + filaY * (btnAlto + margen);

                btn.Location = new Point(x, y);
                // 🎨 Bordes redondeados
                int radio = 20; // radio de curvatura
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(0, 0, radio, radio, 180, 90);
                path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
                path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
                path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
                path.CloseAllFigures();
                btn.Region = new Region(path);

                panel.Controls.Add(btn);
                contador++;

                btn.Click += (s, e) =>
                {
                    string nombreMesa = btn.Name;
                    if (OnMesaSeleccionada != null)
                        OnMesaSeleccionada(nombreMesa);
                };
            }
        }

        public void ActualizarEstadoMesa(Panel panel, string nombreMesa, string nuevoEstado)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is Button btn && btn.Name == nombreMesa)
                {
                    if (nuevoEstado == "Disponible")
                        btn.BackColor = ColorTranslator.FromHtml("#BA9470");
                    else if (nuevoEstado == "Ocupada")
                        btn.BackColor = ColorTranslator.FromHtml("#C66828");
                    else
                        btn.BackColor = Color.LightGray;
                }
            }
        }

        #endregion

        #region Cuentas
        public void LlenarGridCuenta(DataGridView tabla)
        {
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

            tabla.Columns.Add("idProducto", "idProducto");
            tabla.Columns["idProducto"].Visible = false;

            tabla.Columns.Add("Producto", "Producto");
            tabla.Columns["Producto"].ReadOnly = true;

            tabla.Columns.Add("Cantidad", "Cantidad");
            tabla.Columns["Cantidad"].ReadOnly = true;

            tabla.Columns.Add("Precio Unitario", "Precio Unitario");
            tabla.Columns["Precio Unitario"].ReadOnly = true;

            tabla.Columns["Precio Unitario"].DefaultCellStyle.Format = "C2";
        }

        public void LlenarMeseros(ComboBox cmb)
        {
            cmb.DataSource = b.Consultar("select * from meseros where estado = 'Activo'", "meseros").Tables[0];
            cmb.DisplayMember = "nombreMesero";
            cmb.ValueMember = "idMesero";
        }

        public List<ProductosVenta> ObtenerProductos()
        {
            List<ProductosVenta> lista = new List<ProductosVenta>();

            // consulta SQL
            string sql = "select idProducto, nombreProducto, precio from productosVenta";

            // usar tu método Consultar
            DataSet ds = b.Consultar(sql, "productosVenta");

            // recorrer las filas
            foreach (DataRow row in ds.Tables["productosVenta"].Rows)
            {
                ProductosVenta p = new ProductosVenta
                {
                    IdProductoVenta = Convert.ToInt32(row["idProducto"]),
                    Nombre = row["nombreProducto"].ToString(),
                    Precio = Convert.ToDouble(row["precio"])
                };
                lista.Add(p);
            }

            return lista;
        }

        public void InsertarCuenta(int FkIdMesa, int CantidadPersonas, int FkIdMesero)
        {
            b.Comando($"call p_insertCuenta({FkIdMesa}, {CantidadPersonas}, {FkIdMesero})");
        }

        public void InsertarDetalleCuenta(int cantidad, double precio, int idProducto)
        {
            b.Comando($"call p_insertDetalleCuenta({cantidad},{precio},{idProducto})");
        }

        #endregion

        #region Rereservaciones
        public void AgegarReservacion(int numMesa, string cliente,int cantidadP,string fecha)
        {
            b.Comando($"call p_insertReservacion({numMesa},'{cliente}',{cantidadP},'{fecha}')");
        }

        public bool VerificarReservacion(string nombreMesa)
        {
            string query = $"SELECT COUNT(*) FROM reservaciones WHERE fkIdMesa = {nombreMesa} AND fecha = CURDATE() AND estado = 'Activa'";

            DataSet ds = b.Consultar(query, "reservaciones");
            int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            return count > 0;
        }

        public void CerrarReservacion()
        {
            b.Comando($"call p_updateReservacion()");
        }

        #endregion

        #region Dividir Cuenta
        public int cuentaActiva = -1;
        public void GenerarCuentasVisuales(Panel panelContenedor, int totalCuentas)
        {
            // Configuración del panel
            panelContenedor.AutoScroll = true;
            panelContenedor.AutoSize = false;
            panelContenedor.Controls.Clear();

            int alturaBloque = 320;  // espacio fijo por bloque
            int margen = 10;

            for (int i = 0; i < totalCuentas; i++)
            {
                int numeroCuenta = i + 1;
                int offsetY = i * (alturaBloque + margen);

                // 🔹 Label título
                Label lblCuenta = new Label
                {
                    Text = $"Cuenta {numeroCuenta}",
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Size = new Size(panelContenedor.Width - 200, 30),
                    Location = new Point(10, offsetY),
                    BackColor = Color.FromArgb(169, 180, 137),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                // 🔹 Botón
                Button btnAgregar = new Button
                {
                    Text = "Seleccionar Cuenta",
                    Size = new Size(150, 30),
                    Location = new Point(panelContenedor.Width - 160, offsetY),
                    BackColor = Color.FromArgb(169, 180, 137),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = numeroCuenta
                };
                btnAgregar.FlatAppearance.BorderSize = 0;
                btnAgregar.Click += (s, e) =>
                {
                    cuentaActiva = numeroCuenta; // marcar esta cuenta como activa
                    MessageBox.Show($"Cuenta activa: {cuentaActiva}");
                };


                // 🔹 Grid
                DataGridView dgvCuenta = new DataGridView
                {
                    Size = new Size(panelContenedor.Width - 20, 200),
                    Location = new Point(10, offsetY + 40),
                    AutoGenerateColumns = false,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    BackgroundColor = Color.White,
                    BorderStyle = BorderStyle.Fixed3D,
                    Tag = numeroCuenta,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    RowHeadersVisible = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect
                };

                // Ajustar encabezados para que no se vean raros
                dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dgvCuenta.ColumnHeadersHeight = 35;

                dgvCuenta.Columns.Add("Producto", "Producto");
                dgvCuenta.Columns.Add("Cantidad", "Cantidad");
                dgvCuenta.Columns.Add("Precio Unitario", "Precio Unitario");
                dgvCuenta.Columns.Add("Subtotal", "Subtotal");

                // 🔹 Label de total
                Label lblTotal = new Label
                {
                    Text = "Total: 0.00",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Size = new Size(panelContenedor.Width - 20, 25),
                    Location = new Point(10, offsetY + 250),
                    BackColor = Color.FromArgb(169, 180, 137),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleRight,
                    Tag = $"Total_{numeroCuenta}"
                };

                // 🔹 Agregar en orden correcto
                panelContenedor.Controls.Add(lblCuenta);
                panelContenedor.Controls.Add(btnAgregar);
                panelContenedor.Controls.Add(dgvCuenta);
                panelContenedor.Controls.Add(lblTotal);
            }
        }

        public void ActualizarTotal(Panel panelContenedor, int numeroCuenta)
        {
            decimal total = 0;

            foreach (Control ctrl in panelContenedor.Controls)
            {
                if (ctrl is DataGridView dgv && (int)dgv.Tag == numeroCuenta)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells["Subtotal"].Value != null)
                            total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                    }
                }

                if (ctrl is Label lbl && lbl.Tag?.ToString() == $"Total_{numeroCuenta}")
                {
                    lbl.Text = $"Total: {total:N2}";
                }
            }
        }

        public void ActualizarTotalOrigen(DataGridView dtg,Label lbl)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dtg.Rows)
            {
                if (row.Cells["Cantidad"].Value != null && row.Cells["Precio Unitario"].Value != null)
                {
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["Precio Unitario"].Value);

                    total += cantidad * precio;
                }

            }

            lbl.Text = $"Total: {total:N2}";
        }


        #endregion
    }
}
