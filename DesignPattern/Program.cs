using DesignPattern.memento;
using DesignPattern.SOLID;
using DesignPattern.SOLIDNEW.OCP;
using System;
using System.Collections.Generic;


namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Exporter exporter = new CSVExporter();
            exporter.FileName = "raha.png";
            exporter.ExporterEmployees(new List<object>() { new object()});

            Exporter exporter2 = new ExcellExporter();
            exporter2.FileName = "test.png";
            exporter2.ExporterEmployees(new List<object>() { new object() });

            //string name = "sandeep";
            //string myName = "sandeep";
            //Console.WriteLine("== operator result is {0}", name == myName);
            //Console.WriteLine("Equals method result is {0}", name.Equals(myName));
            //Console.ReadKey();


            //SingleResponsiblityPrinciple.TestSingleResposibility();
            //OpenClosedPrinciple.TestOpenClosedPrinciple();
            //ListkovSubsituationPrinciple.TestLSP();

            //var editor = new Editor();
            //History history = new History();
            //editor.SetContent("A");
            //history.pushState(editor.CreateState());

            //editor.SetContent("B");
            //history.pushState(editor.CreateState());

            //editor.SetContent("C");
            //editor.Restore(history.popState());


            //Console.WriteLine(editor.GetContent());
        }
    }
}
