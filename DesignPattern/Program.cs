using DesignPattern.memento;
using DesignPattern.SOLID;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "sandeep";
            string myName = "sandeep";
            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", name.Equals(myName));
            Console.ReadKey();


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
