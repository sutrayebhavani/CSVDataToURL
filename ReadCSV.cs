using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReadCSV
{
    //This class reads a CSV file from the provided file path and returns a list of Employee objects.
    //Each Employee object contains an Email and a BadgeTemplateId as read from the CSV file.
    public List<Employee> ReadEmployeesFromCsv(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            return csv.GetRecords<Employee>().ToList();
        }
    }
    public class Employee
    {
        public string Email { get; set; }
        public string BadgeTemplateId { get; set; }
    }

}

