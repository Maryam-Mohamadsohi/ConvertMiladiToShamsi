
namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            PersianDate oPersianDate = new PersianDate();

            oPersianDate=Utility.ConvertMiladiToShamsi(System.DateTime.Now);

            string strDate= oPersianDate.GetString();

            System.Console.WriteLine(strDate);

            System.Console.WriteLine("Month:{0}",oPersianDate.Month);

            System.Console.ReadLine();
        }
    }
}
