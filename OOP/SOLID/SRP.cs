namespace OOP.SOLID;
public class SRP
{
    public class BadReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Report generated.");
        }
        public void SaveToPdf()
        {
            Console.WriteLine("Report saved to PDF.");
        }
        public void SendEmail()
        {
            Console.WriteLine("Report sent via email.");
        }
    }

    public class Report
    {
        public void GenerateReport()
        {
            Console.WriteLine("Report generated.");
        }
    }

    public class Pdf
    {
        public void SaveToPdf()
        {
            Console.WriteLine("Report saved to PDF.");
        }
    }

    public class EmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Report sent via email.");
        }
    }
}
