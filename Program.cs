using System;

namespace TPL_Projects
{
    public class Program
    {
        static void Main(string[] args)
        {/*
            csvHandler.ImplementCSVDataHandling();
            Console.WriteLine("Hello World!");
            Console.WriteLine(" # Read data from CSv and Write data from in CSV");
            Console.WriteLine();
        */
            Console.WriteLine(" # Read data from Csv and write it  to JSON");
            //Read the data from csv to json
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
            Console.WriteLine();

            Console.WriteLine("# Read data from JSON And write it to CSV");
            //Read the data from JSON to Csv
           // ReadJSON_And_CSV.ImplementJSONToCSV();

        

        }
    }
}
