using System;
using System.Data;

class Program
{
    static void Main()
    {
        Console.Write("Введіть математичний вираз: ");
        string expression = Console.ReadLine();

        try
        {
            double result = EvaluateExpression(expression);
            Console.WriteLine($"Результат обчислення: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static double EvaluateExpression(string expression)
    {
        DataTable table = new DataTable();
        table.Columns.Add("expression", typeof(string), expression);

        DataRow row = table.NewRow();
        table.Rows.Add(row);

        double result = double.Parse((string)row["expression"]);

        return result;
    }
}

