
namespace MyProgram
{
    public static class Utility
    {
       public static PersianDate  ConvertMiladiToShamsi(System.DateTime date)
        {
            System.Globalization.PersianCalendar oPersianCalender =
                              new System.Globalization.PersianCalendar();

            int intYear = oPersianCalender.GetYear(date);

            int intMonth = oPersianCalender.GetMonth(date);

            int intDay = oPersianCalender.GetDayOfMonth(date);

            PersianDate oPersianDate = new PersianDate();

            oPersianDate.Year = intYear;

            oPersianDate.Month = intMonth;

            oPersianDate.Day = intDay;

            return oPersianDate;
        }
    }
}
