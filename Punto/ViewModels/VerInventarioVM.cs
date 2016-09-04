using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Punto { 
public class VerInventarioVM
{
        Conexion c;
        string query;
        InventarioModel im;

       DataTable lid;
        List<InventarioModel> li;
	public VerInventarioVM()
	{
	}
        public List<InventarioModel> llenar()
        {
            lid = new DataTable();
            query = string.Format("select * from inventarios");
            c = new Conexion();
            li = new List<InventarioModel>();
            lid = c.tablas(query);
            foreach(DataRow row in lid.Rows)
            {
                
                Console.Write(row["Cantidad"].ToString());

                im.Cantidad = Decimal.Parse(row["cantidad"].ToString());
                //im.Codigo = row["codigo"].ToString();
                //im.Descripcion = row["descripcion"].ToString();
                //im.ID = row["idinventarios"].ToString();
                //im.Nomcorto = row["nomcorto"].ToString();
                //im.Precio = Decimal.Parse(row["precio"].ToString());

              
                li.Add(im);
                
            }
            var q = from x in li
                   
                    select x;

            

            return li;
        }

}
}