using ReportesVentas.Helper;
using System.Data;

namespace ReportesVentas.Repositorios
{
    public class BicicletasReporitorio
    {

        public DataTable ObtenerCantidadBicicletasPorCategoria()
        {

            var sql = "select categorias.category_name as Categoria, count(*) as Cantidad from  bicicletas join categorias on bicicletas.category_id = categorias.category_id group by categorias.category_name";

            var tablaTmp = AccesoBD.Singleton().consulta(sql);

            return tablaTmp;
        }
    }
}
