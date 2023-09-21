using AndisbankAPI_GraphQL.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndisbankAPI_GraphQL.Repositories
{
    public class LoanRepository
    {

        public IEnumerable<Loan> GetAllLoans(int userId)
        {
            try
            {
                string jsonFilePath = "./loans.json";
                List<Loan> resultList = new List<Loan>();
                if (System.IO.File.Exists(jsonFilePath))
                {
                    string json = System.IO.File.ReadAllText(jsonFilePath);
                    List<Loan> loanList = System.Text.Json.JsonSerializer.Deserialize<List<Loan>>(json);
                    
                    if (loanList != null)
                    {
                        // Filtrar los préstamos por UserId
                        resultList = loanList.Where(loan => loan.ClienteId == userId).ToList();
                        return resultList;
                    }
                    else
                    {
                        string error = "No se pudo deserializar el archivo JSON correctamente.";
                        Console.WriteLine(error);
                        return null;
                    }
                }
                else
                {
                    string error = "El archivo no existe.";
                    Console.WriteLine(error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                string error = "Ocurrio un error al leer el archivo JSON: " + ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }
    }
}
