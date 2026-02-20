//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome to GTBank!\n How may I help you today\n for Withrdrawal press 1\n for Deposit press 2\n");
//var input = Console.ReadLine();

//switch (input)
//{
//    case "1":
//        Console.WriteLine("You have selected Withdrawal");
//        break;
//    case "2":
//        Console.WriteLine("You have selected Deposit");
//        break;
//    default:
//        Console.WriteLine("Invalid selection. Please try again.");
//        break;
//}
//var num = 8;
//num = 67787;

//var numString = "25";
//int parsedNum = int.Parse(numString);
//num = parsedNum;
//Console.WriteLine(parsedNum);
//*/

////Operators

//using SQ02;
//using WeekFour;

////bool isRaining = false;

////Console.WriteLine(!isRaining);
////Console.WriteLine(8 == 6);
////Console.WriteLine(!(8 == 6));

////Dog dog = new Dog();

////dog.Color = "Brown";
////dog.NumberOfLegs = 4;
////dog.Speak();

////Car myCar = new Car();
////myCar.Make = "Honda";
////myCar.Model = "Accord";

////Animal myAnimal = new Dog();

////Honda myHonda = new Honda();

////var result1 = myHonda.Addition(8.6,8.9);

////Console.WriteLine(int.MaxValue);
////Console.WriteLine(int.MinValue);

////var nam = "Jamal";

////var sName = nam.Substring(2);

////Console.WriteLine(sName);

////var cont = nam.Contains("M");
////Console.WriteLine(cont);

////Console.WriteLine(nam.ToUpper());

////string[] names = { "Jamal", "Fatimah", "Aisha", "Khadija" };
////Console.WriteLine(names[0].ToLower());

////foreach(var name in names)
////{
////    Console.WriteLine(name);
////}

////var nameWithM = names.Where(n => n.Contains("m"));

////foreach(var name in nameWithM)
////{
////    Console.WriteLine(name);
////}

////var ab = new Algorithm();

////Console.WriteLine(ab.IsEven(5));
////Console.WriteLine(ab.IsOdd(5));

////Console.WriteLine(Methods.IsEven(8));


//List<Car> cars = new List<Car>
//{
//    new Car { Make = "Honda", Model = "Civic", Year = 2020 },
//    new Car { Make = "Honda", Model = "CrossTour", Year = 2020 },
//    new Car { Make = "Honda", Model = "Accord", Year = 2020 },
//    new Car { Make = "Honda", Model = "Accord", Year = 2022 },
//    new Car { Make = "Toyota", Model = "Corolla", Year = 2019 },
//    new Car { Make = "Ford", Model = "Edge", Year = 2022 },
//    new Car { Make = "KIA", Model = "Picanto", Year = 2022 },
//    new Car { Make = "Lexus", Model = "RX330", Year = 2020 },
//    new Car { Make = "Ford", Model = "Mustang", Year = 2023 },
//    new Car { Make = "Ford", Model = "Explorer", Year = 2021 },
//    new Car { Make = "Ford", Model = "Mustang", Year = 2022 },
//    new Car { Make = "Ford", Model = "Mustang", Year = 2021 },
//};

//var hondas = from a in cars
//             where a.Make == "Honda"
//             select a;
//Console.WriteLine($"We have {hondas.Count()} honda cars\n");


//var fords = from a in cars
//             where a.Make == "Ford"
//             select a;
//Console.WriteLine($"We have {fords.Count()} Ford cars\n");

//var fordMustangs = from a in cars
//             where a.Make == "Ford" && a.Model == "Mustang"
//                   select a;
//Console.WriteLine($"We have {fordMustangs.Count()} Ford cars that are Mustang\n");


//var hondaModels = (from a in cars
//             where a.Make == "Honda"
//             select a.Model).Distinct().ToList();
//cars.Add(new Car { Make = "Honda", Model = "Mymodel", Year = 2021 });

//foreach (var model in hondaModels)
//{
//    Console.WriteLine(model);
//}

//Console.WriteLine($"We have {hondaModels.Count()} honda cars\n");

using SQ02;

///*Console.BackgroundColor = ConsoleColor.DarkGreen;
double[] array = new double[5] { 1, 2, 3, 4, 5 };

Console.WriteLine(NewMethods.SumArray(array));
