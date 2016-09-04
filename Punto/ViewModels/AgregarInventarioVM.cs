using System;
namespace Punto { 
public class AgregarInventarioVM
{
        string mensaje,query;
        Conexion c;
	public AgregarInventarioVM()
	{
            c = new Conexion();
	}
        public string insertar(string descripcion, string nomcorto, decimal precio, decimal cantidad,string codigo)
        {

            try
            {
                query = string.Format("insert into inventarios (descripcion, nomcorto, precio, cantidad, codigo)"+
                    " VALUES ('{0}','{1}',{2},{3},'{4}')",descripcion,nomcorto,precio,cantidad,codigo);
                Console.WriteLine(query);
                mensaje = c.crud(query);
            }catch(Exception e) { mensaje = mensaje + e.Message; }
            return mensaje;
        }
}
}