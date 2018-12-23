using System;
using Xunit;
using c = Szyb.Computus.Core;

namespace Szyb.Computus.Tests
{

  public class ComputusTests
  {
    [Theory]
    [InlineData(1583, 4, 10)]
    [InlineData(1777, 3, 30)]
    [InlineData(1961, 4, 02)]
    [InlineData(1998, 4, 12)]
    [InlineData(1999, 4, 04)]
    [InlineData(2000, 4, 23)]
    [InlineData(2001, 4, 15)]
    [InlineData(2002, 3, 31)]
    [InlineData(2003, 4, 20)]
    [InlineData(2004, 4, 11)]
    [InlineData(2005, 3, 27)]
    [InlineData(2006, 4, 16)]
    [InlineData(2007, 4, 08)]
    [InlineData(2008, 3, 23)]
    [InlineData(2009, 4, 12)]
    [InlineData(2010, 4, 04)]
    [InlineData(2011, 4, 24)]
    [InlineData(2012, 4, 08)]
    [InlineData(2013, 3, 31)]
    [InlineData(2014, 4, 20)]
    [InlineData(2015, 4, 05)]
    [InlineData(2016, 3, 27)]
    [InlineData(2017, 4, 16)]
    [InlineData(2018, 4, 01)]
    [InlineData(2019, 4, 21)]
    [InlineData(2020, 4, 12)]
    [InlineData(2021, 4, 04)]
    [InlineData(2022, 4, 17)]
    [InlineData(2023, 4, 09)]
    [InlineData(2024, 3, 31)]
    [InlineData(2025, 4, 20)]
    [InlineData(2026, 4, 05)]
    [InlineData(2027, 3, 28)]
    [InlineData(2028, 4, 16)]
    [InlineData(2029, 4, 01)]
    [InlineData(2030, 4, 21)]
    [InlineData(2031, 4, 13)]
    [InlineData(2032, 3, 28)]
    [InlineData(2033, 4, 17)]
    [InlineData(2034, 4, 09)]
    [InlineData(2035, 3, 25)]
    [InlineData(2036, 4, 13)]
    [InlineData(2037, 4, 05)]
    [InlineData(2038, 4, 25)]
    public void ComputusTest(int year, int expectedMonth, int expectedDay)
    {
      DateTime expected = new DateTime(year, expectedMonth, expectedDay);
      var result = c.Computus.GetEasterDate(year);
      Assert.Equal(expected, result);
      Assert.Equal(DayOfWeek.Sunday, result.DayOfWeek);
    }
  }
}
