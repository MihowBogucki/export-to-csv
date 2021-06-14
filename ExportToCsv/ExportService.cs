namespace ExportToCsv
{
    using System.Collections.Generic;
    using AutoFixture;

    public class ExportService
    {
        private readonly Fixture _fixture;

        public ExportService()
        {
            this._fixture = new Fixture();
        }
        
        public void ExportToCsv()
        {
            var recordsToExport = this._fixture.CreateMany<Foo>();
            
            var csvConfiguration = new CsvHelper.Configuration.CsvConfiguration
            {
                CultureInfo = System.Globalization.CultureInfo.InvariantCulture
            };

            using (var writer = new System.IO.StreamWriter("c:\\exportToCsv\\file.csv"))
            using (var csv = new CsvHelper.CsvWriter(writer, csvConfiguration))
            {
                csv.WriteRecords(recordsToExport);
            }
        }
    }
}