using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LogicProject.Array.Practice.Practice01;
using LogicProject.Challenges;
using LogicProject.OOP;
using LogicProject.OOP.Challenges;
using LogicProject.Practice.Practice01;
using LogicProject.SOLID.Challenges;
using static LogicProject.Array.Challenges.Challenges04;
using static LogicProject.SOLID.Challenges.EmployeeSOLID;

namespace LogicProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // == Looping ==

            // Practice
            //Looping.TriangleOne();
            //Looping.TriangleTwo();
            //Looping.TriangleThree();
            //Looping.TriangleFour();

            // Challenge01
            //Challenge.Challenges01.Challenge01();
            //Challenge.Challenges01.Challenge02();
            //Challenge.Challenges01.Challenge03();
            //Challenge.Challenges01.Challenge04();

            // Challenge02
            //Challenges02.Challenge01();
            //Challenges02.Challenge02();
            //Challenges02.Challenge03();
            //Challenges02.Challenge04();

            // Challenge03
            //Challenges03.Challenge01();
            //Challenges03.ShowPattern(9);
            //Challenges03.Challenge02();

            // Challenge04
            //Challenges04.Challenge01(5);
            //Challenges04.Challenge02(9);


            // == Array ==

            // Practice

            // 1. PowTwo
            //int[] result1 = Array.Practice.Practice01.Array.PowNumber(5);
            //Array.Practice.Practice01.Array.DisplayArray(result1);

            //int[] result2 = Array.Practice.Practice01.Array.PowNumberWithMathPow(5);
            //Array.Practice.Practice01.Array.DisplayArray(result2);

            // 2. OddNumber
            //int[] result3 = Array.Practice.Practice01.Array.PowNumberTwo(5);
            //Array.Practice.Practice01.Array.DisplayArray(result3);

            //int[] result4 = Array.Practice.Practice01.Array.OddNumber(5);
            //Array.Practice.Practice01.Array.DisplayArray(result4);

            // 3. Fibonacci
            //int[] result5 = Array.Practice.Practice01.Array.PowNumberThree(5);
            //Array.Practice.Practice01.Array.DisplayArray(result5);

            //int[] result6 = Array.Practice.Practice01.Array.Fibonacci(5);
            //Array.Practice.Practice01.Array.DisplayArray(result6);

            // 4. Palindrome
            //int[] result7 = Array.Practice.Practice01.Array.PowNumberFour(5);
            //Array.Practice.Practice01.Array.DisplayArray(result7);

            //int[] palindromeArray = new int[] { 5, 5, 2, 5, 5 };
            //Array.Practice.Practice01.Array.DisplayArray(palindromeArray);

            // Test array yang diberikan
            //int[] testArray = new int[] { 5, 2, 3, 1, 5, 5, 5 };
            //Console.WriteLine($"Is {string.Join(", ", testArray)} palindrome? {Array.Practice.Practice01.Array.IsPalindrome(testArray)}");

            // 5. Rotate Array
            //int[] result8 = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Array sebelum rotasi:");
            //Array.Practice.Practice01.Array.DisplayArray(result8);

            //int[] arrayToRotate = new int[] { 1, 5, 3, 4, 9 };
            //Array.Practice.Practice01.Array.DisplayArray(arrayToRotate);

            //arrayToRotate = Array.Practice.Practice01.Array.RotateArray(arrayToRotate);

            //arrayToRotate[arrayToRotate.Length - 1] = 5;

            //Console.WriteLine("Array setelah rotasi:");
            //Array.Practice.Practice01.Array.DisplayArray(result8);
            //Array.Practice.Practice01.Array.DisplayArray(arrayToRotate);

            // 6. Sorting Array With Swap
            //int[] result9 = new int[] { 1, 2, 3, 4, 5 };
            //int[] unsortedArray = new int[] { 9, 3, 2, 4, 1 };

            //Console.WriteLine("Array sebelum sorting:");

            //Array.Practice.Practice01.Array.DisplayArray(result9);
            //Array.Practice.Practice01.Array.DisplayArray(unsortedArray);

            //unsortedArray = Array.Practice.Practice01.Array.OrderSwapArray(unsortedArray);

            //Console.WriteLine("Array setelah sorting:");

            //Array.Practice.Practice01.Array.DisplayArray(result9);
            //Array.Practice.Practice01.Array.DisplayArray(unsortedArray);


            // Challennges Array

            // 1.OrderEvenBeforeOdd
            //int[] input1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] input2 = { 3, 4, 5, 2, 10 };
            //int[] input3 = { 2, 4, 6, 10, 1 };

            //Console.WriteLine("Input: " + string.Join(", ", input1));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Array.Challenges.Challenges01.OrderEvenBeforeOdd(input1));

            //Console.WriteLine("\nInput: " + string.Join(", ", input2));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Array.Challenges.Challenges01.OrderEvenBeforeOdd(input2));

            //Console.WriteLine("\nInput: " + string.Join(", ", input3));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Array.Challenges.Challenges01.OrderEvenBeforeOdd(input3));

            // 2. String Palindrome
            //string[] input1 = new string[] { "donout", "king", "donout" };
            //Console.WriteLine("Input: " + string.Join(", ", input1));
            //Console.WriteLine("Result: " + Array.Challenges.Challenges02.IsPalindrome(input1));

            //string[] input2 = new string[] { "min", "max", "min" };
            //Console.WriteLine("\nInput: " + string.Join(", ", input2));
            //Console.WriteLine("Result: " + Array.Challenges.Challenges02.IsPalindrome(input2));

            //string[] input3 = new string[] { "true", "false", "false" };
            //Console.WriteLine("\nInput: " + string.Join(", ", input3));
            //Console.WriteLine("Result: " + Array.Challenges.Challenges02.IsPalindrome(input3));

            // 3. AddOnePlus
            //int[] input1 = new int[] { 1, 3, 2, 4 };
            //Console.WriteLine("Input: " + string.Join(", ", input1));
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges03.AddOnePlus(input1)));

            //int[] input2 = new int[] { 1, 4, 8, 9 };
            //Console.WriteLine("\nInput: " + string.Join(", ", input2));
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges03.AddOnePlus(input2)));

            //int[] input3 = new int[] { 9, 9, 9, 9 };
            //Console.WriteLine("\nInput: " + string.Join(", ", input3));
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges03.AddOnePlus(input3)));


            // == Logic Array ==

            // Practice 01
            //int[] input1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] input2 = {2, 4, 6, 1, 8 };
            //int[] input3 = { 2, 4, 6, 8, 1 };

            //Console.WriteLine("Input: " + string.Join(", ", input1));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Practice01.OrderEvenBeforeOdd(input1));

            //Console.WriteLine("\nInput: " + string.Join(", ", input2));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Practice01.OrderEvenBeforeOdd(input2));

            //Console.WriteLine("\nInput: " + string.Join(", ", input3));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Practice01.OrderEvenBeforeOdd(input3));


            // 1. Same Element
            //int[] arr1 = new int[] { 1, 2, 4, 7, 8 };
            //int[] arr2 = new int[] { 2, 3, 7, 9 };
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges04.SameElement(arr1, arr2)));

            //// Test Case 2
            //int[] arr3 = new int[] { 1, 2, 7, 4, 7, 8 };
            //int[] arr4 = new int[] { 7, 7, 3, 2, 9 };
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges04.SameElement(arr3, arr4)));

            //// Test Case 3
            //int[] arr5 = new int[] { 2, 4, 6, 8 };
            //int[] arr6 = new int[] { 1, 3, 5, 7, 9 };
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges04.SameElement(arr5, arr6)));

            // 2. DiffSet            
            //int[] A = new int[] { 1, 2, 3, 4, 5 };
            //int[] B = new int[] { 2, 4, 6, 7 };

            //Console.WriteLine("Result DiffSetAB: " + string.Join(", ", SetOperations.DiffSetAB(A, B)));

            //Console.WriteLine("Result DiffSetBA: " + string.Join(", ", SetOperations.DiffSetBA(A, B)));

            //Console.WriteLine("Result IntersectAB: " + string.Join(", ", SetOperations.IntersectAB(A, B)));

            //Console.WriteLine("Result Union: " + string.Join(", ", SetOperations.Union(A, B)));

            // 3. Reverse List
            //int[] input = new int[] { 1, 2, 3, 4 };
            //int[] reversed = Array.Challenges.Challenges05.ReverseList(input);
            //Console.WriteLine("Result: " + string.Join(", ", reversed));

            // 4. Remove Duplicate
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges05.RemoveDuplicate(new int[] { 1, 1, 2, 3, 4, 1, 2, 3 })));

            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges05.RemoveDuplicate(new int[] { 7, 5, 3, 5, 1 })));

            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges05.RemoveDuplicate(new int[] { 1, 1, 1, 1 })));

            // 5. Frequent Element
            //int[] testArray1 = { 1, 2, 3, 4, 4, 4, 3, 3, 2, 4 };
            //Dictionary<int, int> result1 = Array.Challenges.Challenges06.FrequentElement(testArray1);

            //Console.WriteLine("Result: ");
            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"{item.Key}={item.Value}");
            //}

            //Console.WriteLine("\n");

            //int[] testArray2 = { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            //Dictionary<int, int> result2 = Array.Challenges.Challenges06.FrequentElement(testArray2);

            //Console.WriteLine("Result: ");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{item.Key}={item.Value}");
            //}

            // 6. Array Addition Method
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //int[] result1 = Array.Challenges.Challenges06.Addition(arr1, arr2);
            //Console.WriteLine("Result: " + string.Join(", ", result1));

            //int[] arr3 = { 9, 2, 7 };
            //int[] arr4 = { 1, 3, 5 };
            //int[] result2 = Array.Challenges.Challenges06.Addition(arr3, arr4);
            //Console.WriteLine("Result: " + string.Join(", ", result2));

            // 7. Merge List
            // Test case 1
            //int[] mergeList1 = { 1, 4, 7, 12, 20 };
            //int[] mergeList2 = { 10, 15, 17, 33 };
            //int[] result1 = Array.Challenges.Challenges07.MergeList(mergeList1, mergeList2);

            //Console.WriteLine("Result: " + string.Join(", ", result1));

            //// Test case 2
            //int[] mergeList3 = { 2, 3, 5, 7 };
            //int[] mergeList4 = { 11, 13, 17 };
            //int[] result2 = Array.Challenges.Challenges07.MergeList(mergeList3, mergeList4);
            //Console.WriteLine("Result: " + string.Join(", ", result2));

            //// Test case 3
            //int[] mergeList5 = { 2, 3, 5, 7, 11 };
            //int[] mergeList6 = { 7, 11, 13, 17 };
            //int[] result3 = Array.Challenges.Challenges07.MergeList(mergeList5, mergeList6);
            //Console.WriteLine("Result: " + string.Join(", ", result3));


            // Interviewzen
            // Soal 1
            //Console.WriteLine("Output: " + string.Join(", ", Interviewzen.Challenges.ShowPrimeNumber(15)));
            //Console.WriteLine("Output: " + string.Join(", ", Interviewzen.Challenges.ShowPrimeNumber(25)));
            //Console.WriteLine("Output: " + string.Join(", ", Interviewzen.Challenges.ShowPrimeNumber(50)));

            // Soal 2
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.Fibo(10)));
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.Fibo(15)));

            // Soal 3
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.FindDivisor(6)));
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.FindDivisor(24)));
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.FindDivisor(7)));

            // Soal 4
            //Interviewzen.Challenges.ShowPattern(5);
            //Console.WriteLine();
            //Interviewzen.Challenges.ShowPattern(9);


            // == Object And Class ==

            // 1. Create New Object
            //ObjectAndClassCar car = new ObjectAndClassCar();

            // Define Car Propertice Value
            //car.model = "HRV";
            //car.brand = "Honda";
            //car.year = "2024";
            //car.color = "Silver";

            // Call Methood
            //car.StartEngine();
            //car.StopEngine();


            // 2.1 Without Encapsulation
            //EncapsulationCar car = new EncapsulationCar();
            //car.model = "HRV";
            //car.year = "2024";
            //car.fuelMax = 250.00;
            //car.color = "Silver";

            //car.StartEngine();
            //car.StopEngine();

            // 2.2 Within Enncapsulation
            //EncapsulationCar car = new EncapsulationCar();
            //car.Model = "HRV";
            //car.Year = "2024";
            //car.FuelMax = 250.00;
            //car.Color = "Red";

            //Console.WriteLine("Car FuelMax:{0}", car.FuelMax);

            //car.StartEngine();
            //car.StopEngine();

            // 2.3 Encapsulation With Property (Note Use Instance Atribute)
            //EncapsulationCar car = new EncapsulationCar();
            //car.Model = "HRV";
            //car.Year = "2024";
            //car.FuelMax = 250.00;
            //car.Color = "Red";

            //Console.WriteLine($"Car \nFuelMax: {car.FuelMax}, \nModel: {car.Model}, \nColor: {car.Color}, \nYear: ({car.Color})");

            //car.StartEngine();
            //car.StopEngine();


            // 3. Inheritance
            //SUV suv = new SUV();
            //suv.Brand = "Honda";
            //suv.Model = "HRV";
            //suv.Type = "Crossover";

            //Console.WriteLine($"SUV Brand: {suv.Brand}");
            //Console.WriteLine($"SUV Model: {suv.Model}");

            //Console.WriteLine($"Has Skid Plate: {suv.HasSkidPlate()}");
            //Console.WriteLine($"Has Roof Rack: {suv.HasRoofRack()}");

            //MVP mvp = new MVP();
            //mvp.Brand = "Toyota";
            //mvp.Model = "Alphard";
            //mvp.Type = "Minivan";
            //mvp.LCD = 2;

            //Console.WriteLine($"\nMVP Brand: {mvp.Brand}");
            //Console.WriteLine($"MVP Model: {mvp.Model}");

            //Console.WriteLine($"Number of LCDs: {mvp.LCD}");
            //Console.WriteLine($"Has Slide Door: {mvp.HasSlideDoor()}");

            // 4. OverLoading
            //OverLoadingCalculator calculator = new OverLoadingCalculator();

            //int intResult = calculator.Add(5, 10);
            //Console.WriteLine("Hasil Pertambahan Bilangan Bulat: " + intResult);

            //double doubleResult = calculator.Add(5.5, 10.5);
            //Console.WriteLine("Hasil Pertambahgan Bilangan Pecahan: " + doubleResult);

            //Console.WriteLine("5 + 10 = " + calculator.Add(5, 50));
            //Console.WriteLine("5.5 + 10.5 = " + calculator.Add(5.5, 10.5));

            // 5. Overriding
            //OverridingAnimal genericAnimal = new OverridingAnimal();
            //genericAnimal.MakeSound();

            //Dog myDog = new Dog();
            //myDog.MakeSound();

            //Cat myCat = new Cat();
            //myCat.MakeSound();

            //// Contoh polimorfisme
            //OverridingAnimal[] animals = new OverridingAnimal[]
            //{
            //    new OverridingAnimal(),
            //    new Dog(),
            //    new Cat()
            //};

            //Console.WriteLine("\nPolymorphic Animal Sounds: ");

            //foreach (var animal in animals)
            //{
            //    animal.MakeSound();
            //}

            // 6. Constructor
            // Using Default Constructor
            //ConstructorCar hrv = new ConstructorCar();
            //hrv.Brand = "Honda";
            //hrv.Model = "HRV";
            //hrv.Type = "Manual";

            //Console.WriteLine("HRV Details:");
            //Console.WriteLine($"Brand: {hrv.Brand}");
            //Console.WriteLine($"Model: {hrv.Model}");
            //Console.WriteLine($"Type: {hrv.Type}");

            //// Using Constructor Parameter
            //ConstructorCar crv = new ConstructorCar("Honda", "CRV", "Matic");

            //Console.WriteLine("\nCRV Details:");
            //Console.WriteLine($"Brand: {crv.Brand}");
            //Console.WriteLine($"Model: {crv.Model}");
            //Console.WriteLine($"Type: {crv.Type}");

            //// Using Constructor With 2 Parameter (Overloading Method)
            //var wrv = new ConstructorCar("Honda", "WRV");

            //Console.WriteLine("\nWRV Details:");
            //Console.WriteLine($"Brand: {wrv.Brand}");
            //Console.WriteLine($"Model: {wrv.Model}");
            //Console.WriteLine($"Type: Not Specified");

            //Console.WriteLine($"\nFuel Level: {wrv.Fuel()}");
            //Console.WriteLine($"Electric Batery: {wrv.ElectricBaterai()}");

            // Challenges Employee

            // Call Interface EmployeeImpl
            //EmployeeImpl employeeData = new EmployeeImpl();

            // Buat Object List Employee
            //List<Employee> ListAllEmplooyee = new List<Employee>
            //{
            //    new Programmer
            //    {
            //        Nik = "P001",
            //        FirstName = "Anton",
            //        LastName = "Pratama",
            //        Email = "anton@gmail.com",
            //        BirthDay = new DateTime(1990, 05, 15),
            //        EmpId = 1,
            //        JoinDate = new DateTime(2015, 03, 3),
            //        Role = "Programmer",
            //        BasicSalary = 6000000,
            //        Transportasi = 500000
            //    },
            //    new Programmer
            //    {
            //        Nik = "P002",
            //        FirstName = "Budi",
            //        LastName = "Junaedi",
            //        Email = "budu@gmail.com",
            //        BirthDay = new DateTime(1990, 05, 15),
            //        EmpId = 2,
            //        JoinDate = new DateTime(2016, 08, 15),
            //        Role = "Programmer",
            //        BasicSalary = 6000000,
            //        Transportasi = 500000
            //    },
            //    new Programmer
            //    {
            //        Nik = "P003",
            //        FirstName = "Charlie",
            //        LastName = "Van Dijk",
            //        Email = "charlievd@gmail.com",
            //        BirthDay = new DateTime(1990, 05, 15),
            //        EmpId = 3,
            //        JoinDate = new DateTime(2017, 09, 5),
            //        Role = "Programmer",
            //        BasicSalary = 6000000,
            //        Transportasi = 500000
            //    },
            //    new Sales
            //    {
            //        Nik = "S004",
            //        FirstName = "Dian",
            //        LastName = "Permana",
            //        Email = "dianp@gmail.com",
            //        BirthDay = new DateTime(1988, 08, 20),
            //        EmpId = 4,
            //        JoinDate = new DateTime(2017, 10, 12),
            //        Role = "Sales",
            //        BasicSalary = 3000000,
            //        Bonus = 500000,
            //        Commission = 200000
            //    },
            //    new Sales
            //    {
            //        Nik = "S005",
            //        FirstName = "Fatur",
            //        LastName = "Rohman",
            //        Email = "fatur.r@gmail.com",
            //        BirthDay = new DateTime(1988, 08, 20),
            //        EmpId = 5,
            //        JoinDate = new DateTime(2019, 01, 15),
            //        Role = "Sales",
            //        BasicSalary = 3000000,
            //        Bonus = 350000,
            //        Commission = 250000
            //    },
            //    new QA
            //    {
            //        Nik = "Q006",
            //        FirstName = "Elise",
            //        LastName = "Toon",
            //        Email = "elise.tn@gmail.com",
            //        BirthDay = new DateTime(1992, 03, 10),
            //        EmpId = 6,
            //        JoinDate = new DateTime(2019, 01, 15),
            //        Role = "QA",
            //        BasicSalary = 4500000,
            //        Makan = 10000
            //    },
            //    new QA
            //    {
            //        Nik = "Q007",
            //        FirstName = "Gita",
            //        LastName = "Gutawa",
            //        Email = "gitagutawa@gmail.com",
            //        BirthDay = new DateTime(1992, 03, 10),
            //        EmpId = 7,
            //        JoinDate = new DateTime(2019, 01, 15),
            //        Role = "QA",
            //        BasicSalary = 4500000,
            //        Makan = 10000
            //    }
            //};


            //employeeData.AddEmployee(new Programmer
            //{
            //    Nik = "P001",
            //    FirstName = "Anton",
            //    LastName = "Pratama",
            //    Email = "anton@gmail.com",
            //    BirthDay = new DateTime(1990, 05, 15),
            //    EmpId = 1,
            //    JoinDate = new DateTime(2015, 03, 3),
            //    Role = "Programmer",
            //    BasicSalary = 6000000,
            //    Transportasi = 500000
            //});

            //employeeData.AddEmployee(new Programmer
            //{
            //    Nik = "P002",
            //    FirstName = "Budi",
            //    LastName = "Junaedi",
            //    Email = "budu@gmail.com",
            //    BirthDay = new DateTime(1990, 05, 15),
            //    EmpId = 2,
            //    JoinDate = new DateTime(2016, 08, 15),
            //    Role = "Programmer",
            //    BasicSalary = 6000000,
            //    Transportasi = 500000
            //});

            //employeeData.AddEmployee(new Programmer
            //{
            //    Nik = "P003",
            //    FirstName = "Charlie",
            //    LastName = "Van Dijk",
            //    Email = "charlievd@gmail.com",
            //    BirthDay = new DateTime(1990, 05, 15),
            //    EmpId = 3,
            //    JoinDate = new DateTime(2017, 09, 5),
            //    Role = "Programmer",
            //    BasicSalary = 6000000,
            //    Transportasi = 500000
            //});

            //employeeData.AddEmployee(new Sales
            //{
            //    Nik = "S004",
            //    FirstName = "Dian",
            //    LastName = "Permana",
            //    Email = "dianp@gmail.com",
            //    BirthDay = new DateTime(1988, 08, 20),
            //    EmpId = 4,
            //    JoinDate = new DateTime(2017, 10, 12),
            //    Role = "Sales",
            //    BasicSalary = 3000000,
            //    Bonus = 500000,
            //    Commission = 200000
            //});

            //employeeData.AddEmployee(new Sales
            //{
            //    Nik = "S005",
            //    FirstName = "Fatur",
            //    LastName = "Rohman",
            //    Email = "fatur.r@gmail.com",
            //    BirthDay = new DateTime(1988, 08, 20),
            //    EmpId = 5,
            //    JoinDate = new DateTime(2019, 01, 15),
            //    Role = "Sales",
            //    BasicSalary = 3000000,
            //    Bonus = 350000,
            //    Commission = 250000
            //});

            //employeeData.AddEmployee(new QA
            //{
            //    Nik = "Q006",
            //    FirstName = "Elise",
            //    LastName = "Toon",
            //    Email = "elise.tn@gmail.com",
            //    BirthDay = new DateTime(1992, 03, 10),
            //    EmpId = 6,
            //    JoinDate = new DateTime(2019, 01, 15),
            //    Role = "QA",
            //    BasicSalary = 4500000,
            //    Makan = 10000
            //});

            //employeeData.AddEmployee(new QA
            //{
            //    Nik = "Q007",
            //    FirstName = "Gita",
            //    LastName = "Gutawa",
            //    Email = "gitagutawa@gmail.com",
            //    BirthDay = new DateTime(1992, 03, 10),
            //    EmpId = 7,
            //    JoinDate = new DateTime(2019, 01, 15),
            //    Role = "QA",
            //    BasicSalary = 4500000,
            //    Makan = 10000
            //});


            //Console.WriteLine("==================== List Employee ====================\n");


            //foreach (var employees in ListAllEmplooyee)
            //{
            //    Console.WriteLine($" {employees.Nik} {employees.FirstName} | {employees.LastName} | {employees.JoinDate.ToString("dd/MM/yyyy")} | {employees.Role} | {employees.BasicSalary} | 0 | 0 | 0 | 0 | {employees.GetTotalSalary()}");
            //}

            //Console.WriteLine("\n==================================================");

            //Console.WriteLine("\n==================== Summary ====================");

            //decimal totalSalaryAll = employeeData.GetTotalSalary<Employee>();
            //Console.WriteLine($"\n- Total Salary All Roles -");
            //Console.WriteLine($"=> {totalSalaryAll:C}");

            //Console.WriteLine("\n- Total Employee By Role -");
            //var employeesByRole = employeeData.GetTotalEmployeeByRole();
            //foreach (var role in employeesByRole)
            //{
            //    Console.WriteLine($"=> {role.Key}: {role.Value}");
            //}

            //Console.WriteLine("\n- Total Employees -");
            //int totalEmployees = employeeData.GetTotalEmployee();
            //Console.WriteLine($"=> Total: {totalEmployees}");

            //Console.WriteLine("\n- Total Employee Salary By Role -");
            //var salaryByRole = employeeData.GetTotalSalaryByRole();
            //foreach (var role in salaryByRole)
            //{
            //    Console.WriteLine($"=> {role.Key}: {role.Value:C}");
            //}

            //Console.WriteLine("\n==================================================");

            // == SOLID ==
            // Create sample employees
            var employees = new List<EmployeeSOLID.Employee>
            {
                new EmployeeSOLID.Employee
                {
                    EmpNo = 100,
                    FirstName = "Steven",
                    LastName = "King",
                    HireDate = new DateTime(1987, 06, 17),
                    EmpType = "Permanent",
                    Salary = 20000000,
                    Bonus = 0,
                    SelfInsurannce = 1,
                    DependenntInsurnce = 2,
                    MedicalInsurance = "2%",
                    OvertimeHours = 10,
                    Overtime = 50000,
                    AllowanceDay = 0,
                    AllowanceLunch = 0,
                    AllowanceTransport = 0,
                    TaxPPH = "2%",
                    TaxTapera = "1%",
                    TotalInsurance = 1200000,
                    TotalOvertime = 500000,
                    TotalAllowance = 0,
                    TotalTax = 400000,
                    TotalSalary = 17900000,
                    EndOfYearSalary = 35800000
                },
                new EmployeeSOLID.Employee
                {
                    EmpNo = 101,
                    FirstName = "Neena",
                    LastName = "Kochhar",
                    HireDate = new DateTime(1989, 09, 21),
                    EmpType = "Permanent",
                    Salary = 15000000,
                    Bonus = 1,
                    SelfInsurannce = 1,
                    DependenntInsurnce = 3,
                    MedicalInsurance = "2%",
                    OvertimeHours = 5,
                    Overtime = 50000,
                    AllowanceDay = 0,
                    AllowanceLunch = 0,
                    AllowanceTransport = 0,
                    TaxPPH = "3%",
                    TaxTapera = "1%",
                    TotalInsurance = 1200000,
                    TotalOvertime = 250000,
                    TotalAllowance = 0,
                    TotalTax = 450000,
                    TotalSalary = 13100000,
                    EndOfYearSalary = 13100000
                },
                new EmployeeSOLID.Employee
                {
                    EmpNo = 102,
                    FirstName = "Lex",
                    LastName = "De Haan",
                    HireDate = new DateTime(1993, 01, 13),
                    EmpType = "Contract",
                    Salary = 12000000,
                    Bonus = 0,
                    SelfInsurannce = 1,
                    DependenntInsurnce = 0,
                    MedicalInsurance = "2%",
                    OvertimeHours = 5,
                    Overtime = 45000,
                    AllowanceDay = 0,
                    AllowanceLunch = 0,
                    AllowanceTransport = 0,
                    TaxPPH = "2%",
                    TaxTapera = "0%",
                    TotalInsurance = 240000,
                    TotalOvertime = 225000,
                    TotalAllowance = 0,
                    TotalTax = 240000,
                    TotalSalary = 11295000,
                    EndOfYearSalary = 0
                },
                new EmployeeSOLID.Employee
                {
                    EmpNo = 103,
                    FirstName = "Alexander",
                    LastName = "Hunold",
                    HireDate = new DateTime(1990, 01, 03),
                    EmpType = "Contract",
                    Salary = 10000000,
                    Bonus = 0,
                    SelfInsurannce = 1,
                    DependenntInsurnce = 0,
                    MedicalInsurance = "2%",
                    OvertimeHours = 6,
                    Overtime = 45000,
                    AllowanceDay = 0,
                    AllowanceLunch = 0,
                    AllowanceTransport = 0,
                    TaxPPH = "2%",
                    TaxTapera = "0%",
                    TotalInsurance = 200000,
                    TotalOvertime = 270000,
                    TotalAllowance = 0,
                    TotalTax = 200000,
                    TotalSalary = 9330000,
                    EndOfYearSalary = 0
                },
                new EmployeeSOLID.Employee
                {
                    EmpNo = 104,
                    FirstName = "Bruce",
                    LastName = "Ernst",
                    HireDate = new DateTime(1991, 05, 21),
                    EmpType = "Magang",
                    Salary = 0,
                    Bonus = 0,
                    SelfInsurannce = 0,
                    DependenntInsurnce = 0,
                    MedicalInsurance = "0%",
                    OvertimeHours = 6,
                    Overtime = 45000,
                    AllowanceDay = 25,
                    AllowanceLunch = 30000,
                    AllowanceTransport = 20000,
                    TaxPPH = "0%",
                    TaxTapera = "0%",
                    TotalInsurance = 0,
                    TotalOvertime = 0,
                    TotalAllowance = 50000,
                    TotalTax = 0,
                    TotalSalary = 50000,
                    EndOfYearSalary = 0
                },
            };

            // Create EmployeeService
            var employeeService = new EmployeeSOLID.EmployeeServiceImpl(employees);

            // Print summary
            Console.WriteLine("==================== Summary ====================");
            Console.WriteLine($"TotalEmployee: {employeeService.GetTotalEmployees()}");
            Console.WriteLine($"TotalSalary: {employeeService.GetTotalSalary():C}");
            Console.WriteLine($"TotalEndYearSalary: {employeeService.GetTotalEndOfYearSalary():C}");
            Console.WriteLine($"TotalInnsurance: {employeeService.GetTotalInsurance():C}");
            Console.WriteLine($"TotalOvertime: {employeeService.GetTotalOvertime():C}");
            Console.WriteLine($"TotalAllowance: {employeeService.GetTotalAllowance():C}");
            Console.WriteLine($"TotalTax: {employeeService.GetTotalTax():C}");
            Console.WriteLine("=================================================");
        }
    }
}
