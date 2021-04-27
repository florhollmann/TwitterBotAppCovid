using System.Collections.Generic;
using System.Data;
using System.Linq;
using LINQtoCSV;
using System;
using TwitterBotAppCovid.Core;

namespace TwitterBotAppCovid.DataHandler
{
    
    public class CsvHandler
    {

        public static int[] GetFlagDataFromCSV(Country country)
        {
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true
            };

            CsvContext cc = new CsvContext();
            IEnumerable<Flag> flags = cc.Read<Flag>(Configurations.csvFlagPath, inputFileDescription);

            var countryFlag = flags.Where(i => i.Name == country.CountryName).FirstOrDefault();

            return new int[] { Convert.ToInt32(countryFlag.Unicode1, 16), Convert.ToInt32(countryFlag.Unicode2, 16) };
        }


        public static List<OwidCovidData> GetVaccineDataFromCSV(CountryData arg, CountryData randomCountry)
        {
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true
            };

            CsvContext cc = new CsvContext();
            IEnumerable<OwidCovidData> vaccineData = cc.Read<OwidCovidData>(Configurations.csvVaccinesDataFile, inputFileDescription);

            var filterByCountries = new[] { arg.Country, randomCountry.Country };
            var todayData = vaccineData.Where(i => filterByCountries.Contains(i.location)).Where(i => i.date == DateTime.Today.AddDays(-1)).ToList();
            


            return todayData;
        }

    }
}


        //public static DataTable ConvertCSVtoDataTable(string strFilePath)
        //{
        //    DataTable dt = new DataTable();
        //    using (StreamReader sr = new StreamReader(strFilePath))
        //    {
        //        string[] headers = sr.ReadLine().Split(',');
        //        foreach (string header in headers)
        //        {
        //            dt.Columns.Add(header);
        //        }
        //        while (!sr.EndOfStream)
        //        {
        //            string[] rows = sr.ReadLine().Split(',');
        //            DataRow dr = dt.NewRow();
        //            for (int i = 0; i < headers.Length; i++)
        //            {
        //                dr[i] = rows[i];
        //            }
        //            dt.Rows.Add(dr);
        //        }

        //    }

        //    return dt;
        //}
    //}
