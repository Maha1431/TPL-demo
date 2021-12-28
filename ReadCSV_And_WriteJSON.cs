using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Globalization;
using System.Linq;


namespace TPL_Projects
{
    class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVToJSON()
        {
            string importFilePath = @"C:\Users\CSC\source\repos\TPL Projects\TPL Projects\Utility\address.csv";
            string expoertFilePath = @"C:\Users\CSC\source\repos\TPL Projects\TPL Projects\Utility\export.json";

            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Addressdata>().ToList();
                Console.WriteLine("Read data Successfully from address.csv here are codes");
                foreach (Addressdata addressdata in records)
                {


                    Console.Write("\t", addressdata.firstname);
                    Console.Write("\t", addressdata.lastname);
                    Console.Write("\t", addressdata.email);
                    Console.Write("\t", addressdata.mobilenumber);
                    Console.Write("\t", addressdata.state);

                }
                Console.WriteLine("\n********** reading Csv from write it to JSON file ****** ");

                //write dat to json file
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(expoertFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }

            }
        }
    }
}
