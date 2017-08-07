
namespace MyProgram
{
    public class PersianDate
    {
        public PersianDate()
        {

        }

        public int Year { get; set; }

        public int Month { get; set; }

        public int DayOfMonth { get; set; }

        public string GetString()
        {
            string strDate =string.Format ("{0}/{1}/{2}",
                Year,Month.ToString().PadLeft(2,'0')
                    ,DayOfMonth.ToString().PadLeft(2,'0')) ;

            return strDate;
        }
    }
}
