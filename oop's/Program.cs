// See https://aka.ms/new-console-template for more information

// *******************************
//      Classes and Objects
// *******************************

// 1st method of object initialization 
//Person person1 = new();
//person1.Name = "umer";
//person1.Age = 23;
//person1.Gender = "male";
//person1.Profession = "Wev developer";

// 2nd method of object initialization   
//Person person1 = new()
//{
//    Name = "umer",
//    Age = 23,
//    Gender = "male",
//    Profession = "Web developer"
//};

//Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}, Gender: {person1.Gender}, Profession: {person1.Profession}");


// Creating class name Person
//class Person
//{
//    public string Name;
//    public int Age;
//    public string Gender;
//    public string Profession;
//}



//Bottle bottle1 = new();
//bottle1.name = "Water Bottle";
//bottle1.color = "Blue";
//bottle1.price = 150;

//Console.WriteLine($"Bottle-name: {bottle1.name}, Color: {bottle1.color}, Price: {bottle1.price}");
//class Bottle
//{
//    public string name;
//    public string color;
//    public int price;
//}



// Class with a Method
//Calculator sum = new();
//sum.num1 = 10;
//sum.num2 = 20;
//sum.add();

//class Calculator
//{
//    public int num1;
//    public int num2;
//    public void add()
//    {
//        int sum = num1 + num2;
//        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
//    }
//}


//List<Mobile> mobiles = new()
//{
//    new Mobile()
//    {
//        brand = "Samsung",
//        model = "Galaxy S21",
//        price = 799
//    },
//    new Mobile()
//    {
//        brand = "Apple",
//        model = "iPhone 13",
//        price = 999
//    },
//    new Mobile()
//    {
//        brand = "Google",
//        model = "Pixel 6",
//        price = 599
//    }
//};

//foreach(var mobile in mobiles)
//{
//    Console.WriteLine($"Brand: {mobile.brand}, Model: {mobile.model}, Price: {mobile.price}");
//}

//class Mobile
//{
//    public string brand;
//    public string model;
//    public int price;
//}



// ********************************
//          Constructors
// ********************************

//Toyota car1 = new Toyota("corolla", "red", 2022);
//Console.WriteLine($"carModel: {car1.model}, color: {car1.color}, year: {car1.year}");
//class Toyota {
//    public string model;
//    public string color;
//    public int year;
//    public Toyota(string model, string color, int year)
//    {
//        this.model = model;
//        this.color = color;
//        this.year = year;
//    }
//}


