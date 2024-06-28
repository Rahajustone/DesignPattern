using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLIDNEW.OCP;

// Once you write the class don't change it otherwise it will break other people codes
// 
internal class ExporterBeforeOCP
{
    public ExporterBeforeOCP() { }
    public void Export(string filePath, List<Object> empObjects, string format)
    {
        switch (format)
        {
            case "csv":
                StreamWriter sw = new StreamWriter(filePath, false);
                StringBuilder sb = new StringBuilder();
                sb.Append(empObjects);
                sw.Write(sb.ToString());
            break;
            case "excel":
                Console.WriteLine("Export to excell");
            break;
            default:

            break;
        }
    }
}

public abstract class Exporter
{
    public string FileName { get; set; }
    public abstract void ExporterEmployees(List<Object> empObjects);
}

public class CSVExporter : Exporter
{
    public override void ExporterEmployees(List<object> empObjects)
    {
        Console.WriteLine($"CSV Implementatio file name:{FileName}");
    }
}

public class ExcellExporter : Exporter
{
    public override void ExporterEmployees(List<object> empObjects)
    {
        Console.WriteLine($"Excell implementation file name:{FileName}");
    }
}

