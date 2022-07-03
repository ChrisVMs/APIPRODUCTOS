using System.Data.SqlClient;
using System.Data;
using APIPRODUCTOS.Entidades;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Collections.Generic;

namespace APIPRODUCTOS.DAO
{
    public class ProductoDAO
    {
        private string cadena;

        public ProductoDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cadenaSQL");
        }

        public IEnumerable<EntidadProducto> GetProductos()
        {
            List<EntidadProducto> temporal = new List<EntidadProducto>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_Listar_Productos", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    temporal.Add(new EntidadProducto()
                    {
                        IdProducto = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        Marca = dr.GetString(2),
                        Stock = dr.GetInt32(3)
                    });
                }
            }
            return temporal;
        }

    }
}
