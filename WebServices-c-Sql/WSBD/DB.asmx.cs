using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WSBD
{
    /// <summary>
    /// Descripción breve de DB
    /// </summary>
    [WebService(Namespace = "http://MyWebService00.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class DB : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public DataSet GetData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=Mickey;Initial Catalog=NetFramwork; user= mike;password=redes2;";
            SqlDataAdapter da = new SqlDataAdapter("Select * FROM Alumno", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}
