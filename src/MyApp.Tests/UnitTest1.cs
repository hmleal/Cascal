using System;
using Xunit;
using MyApp;

namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var book = new Book();
        book.AddGrade(3.7);
        book.AddGrade(7.3);

        var expected = book.GetHighestGrade();
        var actual = 7.3;

        Console.WriteLine(expected);
        Console.WriteLine(actual);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MyTest()
    {
        Assert.Equal(1, 1);
    }
}