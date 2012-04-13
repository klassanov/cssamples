using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      LogToFile("Avvio dell'applicazione");

      LogToFile("Esecuzione del codice di Esempio");

      LogToFile("Chiusura dell'applicazione");
    }

    static void LogToFile(string message)
    {
      string basepath = @"c:\temp\Pegaso2000\io";
      if (!Directory.Exists(basepath))
      {
        Directory.CreateDirectory(basepath);
      }

      try
      {
        FileStream fs = File.Open(Path.Combine(basepath, "logfile.log"),
                        FileMode.OpenOrCreate,
                        FileAccess.Write,
                        FileShare.None);

        try
        {
          StreamWriter sw2 = new StreamWriter(fs);
          //      BinaryWriter bw = new BinaryWriter(fs);
        }
        catch (ArgumentException ex)
        { 
        
        }
        finally
        {
          fs.Flush();
          fs.Close();
        }

      }
      catch (System.IO.IOException ex)
      {
        
      }
      catch (System.UnauthorizedAccessException ex)
      { 
      
      }
      catch (Exception ex)
      { }

      using (StreamWriter sw = File.AppendText(Path.Combine(basepath, "logfile.log")))
      {
        sw.WriteLine(message);
      }
      //} sw.Flush();
      //sw.Close();
    }
  }
}
