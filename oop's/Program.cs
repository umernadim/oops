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



// Mobile Details
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




// Creating list of objects using constructor
//List<Student> student = new()
//{
//    new Student("Umer", 04),
//    new Student("Usman", 05)
//};

//foreach (var st in student)
//{
//Console.WriteLine($"studentName: {st.name}, rollNo: {st.rollNo}");   
//}

//class Student
//{
//    public string name;
//    public int rollNo;
//    public Student(string name, int rollNo)
//    {
//        this.name = name;
//        this.rollNo = rollNo;
//    }
//}




//Product Details 
//List<Product> prducts = new()
//{
//    new Product("Laptop", 80000, 5),
//    new Product("Mouse", 250, 8),
//    new Product("Keyboard", 1500, 3)
//};

//foreach(var product in prducts)
//{
//    Console.WriteLine($"Product Name: {product.name}, Price: {product.price}, Quantity: {product.quantity}");
//}
//class Product
//{
//    public string name;
//    public int price;
//    public int quantity; 
//    public Product(string name, int price, int quantity)
//    {
//        this.name = name;
//        this.price = price;
//        this.quantity = quantity;
//    }
//}
//



// Student Marks
//List<Students> students = new()
//{
//    new Students("umer", 73, 67, 90),
//    new Students("danish", 65, 78, 89),
//    new Students("usman", 88, 70, 89)
//};

//foreach(var student in students)
//{
//    student.avgg();
//}
//class Students
//{
//    public string name;
//    public int engMarks;
//    public int urduMarks;
//    public int sciMarks;
//    public Students(string name, int engMarks, int urduMarks, int sciMarks)
//    {
//        this.name = name;
//        this.engMarks = engMarks;
//        this.urduMarks = urduMarks;
//        this.sciMarks = sciMarks;
//    }
//    public void avgg() {
//        int avg = (engMarks + urduMarks + sciMarks) / 3;
//        Console.WriteLine($"Average Marks of {name} is {avg}");
//    }
//}




//Employee Salary Calculator
//List<Employee> employees = new()
//{
//    new Employee("ahmad", 50000, 4000),
//    new Employee("usman", 55000, 3500),
//    new Employee("ali", 60000, 3000),
//    new Employee("kamran", 62000, 2700)
//};

//foreach(var emp in employees)
//{
//    emp.totalSalary();
//}

//class Employee
//{
//    public string name;
//    public int basicSalary;
//    public int bonus;
//    public Employee(string name, int basicSalary, int bonus)
//    {
//        this.name = name;
//        this.basicSalary = basicSalary;
//        this.bonus = bonus;
//    }
//    public void totalSalary()
//    {
//        int total = basicSalary + bonus;
//        Console.WriteLine($"Total salary of {name} is {total}");
//    }
//}




// **********************************************
// Method Overloading with Classes and Objects
// **********************************************
//Suzuki car1 = new Suzuki("swift", 2022, "grey");
//Console.WriteLine($"Car Model: {car1.model}, year: {car1.year}, color: {car1.color}");
//Console.WriteLine("------------------");
//Suzuki car2 = new Suzuki("baleno", 2021);
//Console.WriteLine($"Car Model: {car2.model}, year: {car2.year}");
//Console.WriteLine("------------------");
//Suzuki car3 = new Suzuki("cultus", "white");
//Console.WriteLine($"Car Model: {car3.model}, color: {car3.color}");
//Console.WriteLine("------------------");
//Suzuki car4 = new Suzuki("mehran");
//Console.WriteLine($"Car Model: {car4.model}");
//Console.WriteLine("------------------");

//class Suzuki
//{
//    public string model;
//    public int year;
//    public string color;
//    public Suzuki(string model, int year, string color)
//    {
//        this.model = model;
//        this.year = year;
//        this.color = color;
//    }
//    public Suzuki(string model, int year)
//    {
//        this.model = model;
//        this.year = year;
//    }
//    public Suzuki(string model, string color)
//    {
//        this.model = model;
//        this.color = color;
//    }
//    public Suzuki(string model)
//    {
//        this.model = model;
//    }
//}

