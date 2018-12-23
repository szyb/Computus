using System;

namespace Szyb.Computus.Core
{
  public static class Computus
  {

    ///<summary>
    ///This method uses Gauss's Easter algorithm to determine the calendar date of Easter (https://en.wikipedia.org/wiki/Computus#Gauss's_Easter_algorithm)
    ///<param name="year">Year</param>
    ///</summary>
    public static DateTime GetEasterDate(int year)
    {
      var a = year % 19;
      var b = year % 4;
      var c = year % 7;
      var k = Math.Floor((decimal)year / 100);
      var p = Math.Floor((13 + 8 * k) / 25);
      var q = Math.Floor(k / 4);
      var M = (15 - p + k - q) % 30;
      var N = (4 + k - q) % 7;
      var d = (19 * a + M) % 30;
      var e = (2 * b + 4 * c + 6 * d + N) % 7;
      DateTime date = new DateTime(year, 3, 22).AddDays((int)d + (int)e);
      if ((d == 29 && e == 6) || (d == 28 && e == 6 && (11 * M + 11) % 30 < 19))
        date = date.AddDays(-7);
      return date;
    }
  }
}
