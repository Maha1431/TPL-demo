using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;


namespace TPL_Projects
{
    public class csvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            //initialization
            string importFilePath = @"C:\Users\CSC\source\repos\TPL Projects\TPL Projects\Utility\address.csv";
            string expoertFilePath = @"C:\Users\CSC\source\repos\TPL Projects\TPL Projects\Utility\export.csv";

            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Addressdata>().ToList();
                Console.WriteLine("Read data Successfully from address.csv.");
                foreach (Addressdata addressdata in records)
                {




                    Console.Write("\t", addressdata.firstname);
                    Console.Write("\t", addressdata.lastname);
                    Console.Write("\t", addressdata.email);
                    Console.Write("\t", addressdata.mobilenumber);
                    Console.Write("\t", addressdata.state);


                }

                Console.WriteLine("\n ********** Now Reading from csv file read and write to csv file ********* ");

                //writing csv file
                using (var writer = new StreamWriter(expoertFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                  csvExport.WriteRecords(records);
                }
            }
        }
    }
}


                




                
            
