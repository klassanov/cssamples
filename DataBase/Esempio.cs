using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBase
{
  public class Esempio
  {
    public void ApriDB()
    { 
      SqlConnection conn = new SqlConnection(@"Persist Security Info=True;User ID=pegaso;Initial Catalog=pegaso;Data Source=ARCHERAIR\SQLEXPRESS;Password=pegaso;");
      conn.Open();

      SqlCommand cmd = new SqlCommand();
      cmd.Connection = conn;
      cmd.CommandText = "SELECT * FROM tabella1";

      SqlDataReader reader = cmd.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          string nome = reader.GetName(i);
          object value = reader.GetValue(i);
          
        }
      }
      reader.Close();


      conn.Close();
    }
  }
}
