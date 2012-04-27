using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBase
{
  public class EntityFramework
  {
    public void Test()
    {
      pegasoEntities db = new pegasoEntities();
      foreach (var riga in db.tabella1)
      {
        riga.Name = riga.Name + "..";
        foreach (var tel in riga.tabella2)
        {
          tel.NumeroTelefono = tel.NumeroTelefono + "..";

        }
      }
      db.SaveChanges();


      var r = db.tabella1.Where(t => t.Name == "paolo");
      var r2 = r.OrderBy(t => t.Id);
      var r3 = r2.Select(t => t.Name);


      var res = db.tabella1.Where(t => t.Name == "paolo")
                           .OrderBy(t => t.Id)
                           .Select(t => t.Name);

      var rl = from t in db.tabella1
               where t.Name == "paolo"
               orderby t.Id
               select t.Name;

    }
  }
}
