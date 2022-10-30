﻿var itemName = "Outlast";//Console.ReadLine();
var unitPrice = 74;//double.Parse(Console.ReadLine());
var discount = 20; //double.Parse(Console.ReadLine());
var locationDiscount = 25;

var totalCount = new SteamDiscount().CountDiscountReturnValue(userDiscount: discount, unitPrice : unitPrice, locationDiscount: locationDiscount);
//var totalCountUserDiscount = new SteamDiscount().CountDiscountReturnValue(unitPrice, discount);

Console.WriteLine($"Your Steam Item [{itemName}] price is [{totalCount}]");

var albania = "Albania";
var japan = "Japan";
var belarus = "Belarus";

var countriesList = new SteamDiscount().ListOfCountriesWithDiscountAvailable(albania, japan, belarus);
Console.WriteLine($"List of countries with discount {countriesList}");


public class SteamDiscount
{
    //public void CountDiscount()
    //{
    //    var itemName = Console.ReadLine();
    //    var unitPrice = double.Parse(Console.ReadLine());
    //    var discount = double.Parse(Console.ReadLine());
    //    var totalPrice = unitPrice - (unitPrice * discount / 100);
    //    Console.WriteLine($"Your Steam Item [{itemName}] price is [{totalPrice}]");
    //}

    //public double CountDiscountReturnValue(double unitPrice, double discount)
    //{
    //    var totalPrice = unitPrice - (unitPrice * discount / 100);
    //    return totalPrice;
    //}

    public double CountDiscountBirthday(double unitPrice, double userDiscount = 50, double locationDiscount = 40, double birthdayDiscount = 50)
    {
        var totalPrice = CountDiscountReturnValue(unitPrice, userDiscount, locationDiscount) * birthdayDiscount/100;
        return totalPrice;
    }

    public double CountDiscountBestConsumer(double unitPrice, double userDiscount = 50, double locationDiscount = 40, double consumerDiscount = 10)
    {
        var totalPrice = CountDiscountReturnValue(unitPrice, userDiscount, locationDiscount) * consumerDiscount / 100;
        return totalPrice;
    }

    public string ListOfCountriesWithDiscountAvailable(params string[] countries)
    {
        return string.Join(" ", countries);
    }

    public double CountDiscountReturnValue(double unitPrice, double userDiscount = 50, double locationDiscount = 40)
    {
        var finalDiscount = unitPrice >= locationDiscount ? unitPrice : locationDiscount;
        var totalPrice = (unitPrice - (unitPrice * finalDiscount / 100));
        return totalPrice;
    }

}

public class Cat
{

}

public class Dog()
{

}