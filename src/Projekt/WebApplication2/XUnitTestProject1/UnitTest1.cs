using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(UnitTest1.validate(new DateTime(2018, 02, 01), new DateTime(2018, 02, 03), "day"));
        }
        [Fact]
        public void Test2()
        {
            Assert.False(UnitTest1.validate(new DateTime(2014, 02, 01), new DateTime(2018, 02, 03), "day"));
        }
        [Theory]
        [InlineData("day")]
        [InlineData("dayd")]
        public void Test3(string v)
        {
            Assert.False(UnitTest1.validate(new DateTime(2014, 02, 01), new DateTime(2018, 02, 03), v));
        }
        public static bool validate(DateTime dateTime1, DateTime dateTime2, string v)
        {
            if(dateTime1 > dateTime2)
            {
                return false;
            }
            if (dateTime1 < DateTime.Today.AddYears(-2))
            {
                return false;
            }
            if (!v.Equals("day") && !v.Equals("week") && !v.Equals("month"))
            {
                return false;
            }
            return true;
        }
    }
}
