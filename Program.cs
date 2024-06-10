// See https://aka.ms/new-console-template for more information
using credly;

Console.WriteLine("Hello, World!");

var csvFilePath = "path_to_your_csv_file.csv";
var url = "your_badge_assignment_api_url";

var csvReader = new ReadCSV();
var employees = csvReader.ReadEmployeesFromCsv(csvFilePath);

var badgeAssigner = new BadgeAssigner();
await badgeAssigner.AssignBadgesAsync(url, employees);