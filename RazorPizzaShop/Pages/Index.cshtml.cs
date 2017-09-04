using System;
using System.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzaShop.Pages
{
  public class IndexModel : PageModel
  {
    [BindProperty]
    public string Sausages {get; set;}

    [BindProperty]
    public string Pepperoni {get; set;}

    [BindProperty]
    public string Onions {get; set;}

    [BindProperty]
    public string GreenPeppers {get; set;}

    [BindProperty]
    public string Name {get; set;}

    [BindProperty]
    public string Address {get; set;}

    [BindProperty]
    public int Zip {get; set;}

    [BindProperty]
    public string Phone {get; set;}

    [BindProperty]
    public Boolean Cash {get; set;}

    [BindProperty]
    public Boolean Credit {get; set;}

    public IActionResult OnPost()
    {
      *try
      {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "your_server.database.windows.net";
        builder.UserID = "your_user";
        builder.Password = "your_password";
        builder.InitialCatalog = "your_database";

        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
        {
          Console.WriteLine("\nQuery data example:");
          Console.WriteLine("=========================================\n");

          connection.Open();
          StringBuilder sb = new StringBuilder();
          sb.Append("SELECT TOP 20 pc.Name as CategoryName, p.name as ProductName ");
          sb.Append("FROM [SalesLT].[ProductCategory] pc ");
          sb.Append("JOIN [SalesLT].[Product] p ");
          sb.Append("ON pc.productcategoryid = p.productcategoryid;");
          String sql = sb.ToString();

          using (SqlCommand command = new SqlCommand(sql, connection))
          {
            using (SqlDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
              }
            }
          }
        }
      }
      catch (SqlException e)
      {
        Console.WriteLine(e.ToString());
      }
      Console.ReadLine();*/
      return Page();
    }
  }
}
