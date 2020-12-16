using System.Globalization;

namespace System
{
    static class DateTimeExtension
    {
        public static string TempoDecorrido(this DateTime thisObj)
        {
            TimeSpan duracao = DateTime.Now.Subtract(thisObj);
            if (duracao.TotalHours < 24.0)
            {
                return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
