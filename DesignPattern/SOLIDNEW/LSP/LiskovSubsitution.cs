using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPattern.SOLIDNEW.LSP;

// Object in a program should be replace with the instance of their subtypes
// without altering the correctness of that program

internal class LiskovSubsitution
{

}

class Employee
{
    int _sal, _empId;
    public int CalculateSalary()
    {
        //calculate salary
        return _sal;
    }
    public int GetEmployeeId()
    {
        //fetch values from database
        return _empId;
    }
}

class Contractor : Employee
{
    int _contractDuration;
    public int ContractDuration()
    {
        return _contractDuration;
    }
    public int GetEmployeeId()
    {
        throw new NotImplementedException();
    }
}

abstract class Exporter
{
    public abstract string FileName { get; set; }
    public abstract string DatabaseName { get; set; }
    public abstract void ExportEmployees(List<Employee> employees);
}
class CSVExporter : Exporter
{
    public string _FileName;
    public override string FileName
    {
        get
        {
            return _FileName;
        }
        set
        {
            _FileName = value + ".csv";
        }
    }
    public override string DatabaseName
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
    public override void ExportEmployees(List<Employee> employees)
    {
        //Code to save in CSV format
    }
}
class ExcelExporter : Exporter
{
    public override string FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string DatabaseName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void ExportEmployees(List<Employee> employees)
    {
        //Code to save in Excel file
    }
}
class SqlServerExporter : Exporter
{
    public override string FileName
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
    public string _DatabaseName;
    public override string DatabaseName
    {
        get
        {
            return this._DatabaseName;
        }
        set
        {
            _DatabaseName = value;
        }
    }
    public override void ExportEmployees(List<Employee> employees)
    {
        //Code to save in Database
    }
}

//Solution
//1. Remove FileName and DatabaseName from the Exporter class
//2. Add constructors in both inherited classes to get the name of file or database as input.

abstract class SolutionExporter
{
    public abstract void ExportEmployees(List<Employee> employees);
}
class SolutionCSVExporter : SolutionExporter
{
    private string _FileName;
    public SolutionCSVExporter(string fileName)
    {
        _FileName = fileName;
    }
    public override void ExportEmployees(List<Employee> employees)
    {
        //Code to save in CSV format
    }
}
class SolutionSqlServerExporter : SolutionExporter
{
    public string _DatebaseName;
    public SolutionSqlServerExporter(string databaseName)
    {
        _DatebaseName = databaseName;
    }
    public override void ExportEmployees(List<Employee> employees)
    {
        //Code to save in Database
    }
    public static void Main()
    {
        SolutionExporter exp = new SolutionCSVExporter("Employees.csv");
        //exp.ExportEmployees(...);
    }
}
