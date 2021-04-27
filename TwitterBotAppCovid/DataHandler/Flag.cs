using LINQtoCSV;
using System;

namespace TwitterBotAppCovid.DataHandler
{
    public class Flag
    {
        [CsvColumn(FieldIndex = 1)]
        public string ISO { get; set; }
        [CsvColumn(FieldIndex = 2)]
        public string Unicode1 { get; set; }
        [CsvColumn(FieldIndex = 3)]
        public string Unicode2 { get; set; }
        [CsvColumn(FieldIndex = 4)]
        public string Name { get; set; }

    }
}
