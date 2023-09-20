using AndisbankAPI_GraphQL.Models;

namespace AndisbankAPI_GraphQL.GraphQL.SchemaGraph
{
    public class LoanSchema
    {
        public Loan GetAllLoans()
        {
            return new Loan { id = 1, Descripcion = "Prestamo 1", Tipo = new LoanType { Name = "Prestamos de autos" }, Monto = 1000, Tasa = 0.1, Plazo = DateTime.Now, Fecha = DateTime.Now, ClienteId = 1, Estado = 0 };
        }
    }
}
