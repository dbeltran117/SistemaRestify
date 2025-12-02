using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorPrincipalAdmin
    {
        Base b = new Base("localhost", "root", "12345", "restauranteSft", 3306);

        #region Usuarios
        public void AgregarUsuario(string nombre,string clave,string tipoU)
        {
            b.Comando($"call p_insertUsuarios('{nombre}','{clave}','{tipoU}')");
        }

        public void EliminarUsuario(int id)
        {
            b.Comando($"delete from usuarios where idUsuario = {id}");
        }

        public void MostrarUsuarios(string consulta,DataGridView tabla,string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idUsuario"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        #endregion

        #region AgregarProducto
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
            cmb.DataSource = b.Consultar("select * from categorias", "categorias").Tables[0];
            cmb.DisplayMember = "nombreCategoria";
            cmb.ValueMember = "idCategoria";
        }

        public void LlenarSubCategorias(ComboBox cmb, int idCat)
        {
            cmb.DataSource = b.Consultar($"select * from subCategorias where fkIdCategoria = {idCat}", "subCategorias").Tables[0];
            cmb.DisplayMember = "nombreSubC";
            cmb.ValueMember = "idSubC";
        }

        public void AgregarCategoria(string nombreCategoria)
        {
            DataSet ds = b.Consultar($"call p_insertCategorias('{nombreCategoria}')", "rs");
            string mensaje = ds.Tables["rs"].Rows[0][0].ToString();

            if (ds.Tables["rs"].Rows.Count > 0)
            {
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AgregarSubCategoria(string nombreSubC, int idCat)
        {
            DataSet ds = b.Consultar($"call p_insertSubCategoria('{nombreSubC}',{idCat})", "rs");
            string mensaje = ds.Tables["rs"].Rows[0][0].ToString();

            if (ds.Tables["rs"].Rows.Count > 0)
            {
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AgregarProducto(string codigo, string nombrePr, int idCat, double precio, double importe)
        {
            DataSet ds = b.Consultar($"call p_insertProductosVentas('{codigo}','{nombrePr}',{idCat},{precio},{importe})", "rs");
            string mensaje = ds.Tables["rs"].Rows[0][0].ToString();

            if (ds.Tables["rs"].Rows.Count > 0)
            {
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EliminarProducto(int id)
        {
            b.Comando($"call p_deleteProductosVentas({id})");
        }

        public void EditarProducto(int id, string nombrePr, int idCat, double precio, double importe)
        {
            b.Comando($"call p_updateProductosVentas({id},'{nombrePr}',{idCat},{precio},{importe})");
        }

        #endregion

        #region Mesas
        public void MostrarMesas(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idMesa"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void AgregarMesas(string numMesa)
        {
            DataSet ds = b.Consultar($"call p_insertMesas('{numMesa}')", "rs");
            string mensaje = ds.Tables["rs"].Rows[0][0].ToString();

            if (ds.Tables["rs"].Rows.Count > 0)
            {
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EliminarMesas(string numMesa)
        {
            b.Comando($"call p_deleteMesas('{numMesa}')");
        }

        #endregion

        #region Meseros
        public void MostrarMeseros(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idMesero"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void AgregarMeseros(string nombreMesero)
        {
            DataSet ds = b.Consultar($"call p_insertMeseros('{nombreMesero}')", "rs");

            if (ds.Tables.Contains("rs") && ds.Tables["rs"].Rows.Count > 0)
            {
                string mensaje = ds.Tables["rs"].Rows[0][0].ToString();
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EliminarMeseros(int id)
        {
            b.Comando($"call p_deleteMeseros({id})");
        }
        #endregion

        #region Insumos
        public void MostrarInsumos(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idProductoCompra"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void AgregarInsumos(string nombrePr,string unidad,double stockM)
        {
            DataSet ds = b.Consultar($"call p_insertInsumos('{nombrePr}','{unidad}',{stockM})", "rs");
            string mensaje = ds.Tables["rs"].Rows[0][0].ToString();
            if (ds.Tables["rs"].Rows.Count > 0)
            {
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EliminarInsumos(string nombrePr)
        {
            b.Comando($"call p_deleteInsumos('{nombrePr}')");
        }

        #endregion

        #region Entradas
        public void LlenarGridEntrada(DataGridView tabla)
        {
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

            tabla.Columns.Add("idProducto","idProducto");
            tabla.Columns["idProducto"].Visible = false;

            tabla.Columns.Add("Producto", "Producto");

            tabla.Columns.Add("Cantidad","Cantidad");

            tabla.Columns.Add("Costo", "Costo");

            tabla.Columns.Insert(4, Boton("Eliminar", Color.Red));
        }

        public void LlenarProductosCompra(ComboBox cmb)
        {
            cmb.DataSource = b.Consultar("select idProductoCompra,concat(nombreProducto,' ',unidad) as name,estado from productosCompra where estado = 'Activo'", "productosCompra").Tables[0];
            cmb.DisplayMember = "name";
            cmb.ValueMember = "idProductoCompra";
        }

        public void AgregarEntradas(string obs)
        {
            b.Comando($"call p_insertEntradas('{obs}')");
        }

        public void AgregarDetallesEntradas(int fkIdProducto, double cantidad, double costo)
        {
            b.Comando($"call p_insertDetallesEntradas({fkIdProducto},{cantidad},{costo})");
        }

        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.UseColumnTextForButtonValue = true;
            return btn;
        }

        public void VerEntradas(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns.Insert(3, Boton("Ver Detalles", Color.DarkBlue));
            tabla.Columns["idEntrada"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void VerDetallesEntradas(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idDetalleEntrada"].Visible = false;
            tabla.Columns["idEntrada"].Visible = false;
            tabla.Columns["Costo"].DefaultCellStyle.Format = "C2";
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        #endregion

        #region Salidas
        public void AgregarSalidas(string obs)
        {
            b.Comando($"call p_insertSalidas('{obs}')");
        }

        public void AgregarDetallesSalidas(int fkIdProducto, double cantidad, double costo)
        {
            b.Comando($"call p_insertDetallesSalidas({fkIdProducto},{cantidad},{costo})");
        }

        public void VerSalidas(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns.Insert(3, Boton("Ver Detalles", Color.DarkBlue));
            tabla.Columns["idSalida"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void VerDetallesSalidas(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idDetalleSalida"].Visible = false;
            tabla.Columns["idSalida"].Visible = false;
            tabla.Columns["Costo"].DefaultCellStyle.Format = "C2";
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        #endregion

        #region Ventas
        public void MostrarVentas(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idCuenta"].Visible = false;
            tabla.Columns.Insert(3,Boton("Detalle de la Cuenta",Color.DarkBlue));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarDetallesVentas(string consulta,DataGridView tabla,string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta,datos).Tables[0];
            tabla.Columns["idCuenta"].Visible = false;
            tabla.Columns["idDetalleMesa"].Visible = false;
            tabla.Columns["idProducto"].Visible = false;
            tabla.Columns["Precio"].DefaultCellStyle.Format = "C2";
            tabla.Columns["Total"].DefaultCellStyle.Format = "C2";
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        #endregion

        #region Inventario
        public void MostrarInventario(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idProductoCompra"].Visible = false;
            tabla.Columns["Stock Minimo"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarStockMinimo(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["idProductoCompra"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        #endregion
    }
}
