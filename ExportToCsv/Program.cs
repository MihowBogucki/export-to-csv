namespace ExportToCsv
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var exportService = new ExportService();
            
            exportService.ExportToCsv();
        }
    }
}