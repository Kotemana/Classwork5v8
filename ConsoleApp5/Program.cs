var students = new List<string>();
students.Add("Anna");
students.Add("Giorgi");
students.Add("Fedor");
students.Add("Sasha");

var random = new Random();
var randomIndex = random.Next(students.Count);
Console.WriteLine($"Selected student: {students[randomIndex]}");


//Console.WriteLine("Enter floors");



//int floors = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter flats per floor");
//int flatsPerFloor = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter number of entrances");
//int entrances = int.Parse(Console.ReadLine());
//Flat[,] building = new Flat[flatsPerFloor*entrances, floors];
//for (int e = 1; e <= entrances; e++)
//{
//    for (int f = 1; f <= floors; f++)
//    {
//        for (int ff = 1; ff <= flatsPerFloor; ff++)
//        {
//            var flat = new Flat();
//            SetFlatParams(floors, flatsPerFloor, e, f, ff, flat);
//            building[((e-1)*flatsPerFloor + ff)-1, f-1] = flat;
//        };
//    }
//}


//for (int y = building.GetLength(1)-1; y >= 0; y--)
//{
//    for (int x = 0; x <= building.GetLength(0)-1; x++)
//    {
//        building[x, y].ShowInConsole();
//        //Console.Write(building[x, y].FlatNumber);
//        //Console.Write("\t");
//    }
//    Console.WriteLine();
//}



//static void SetFlatParams(int floors, int flatsPerFloor, int e, int f, int ff, Flat flat)
//{
//    flat.FlatNumber = (e-1) * flatsPerFloor * floors + (f-1) * flatsPerFloor + ff;
//    SetFlatColor(f, flat);
//}


//static void SetFlatColor(int f, Flat flat)
//{
//    if (f==1)
//        flat.FlatColor = ConsoleColor.White;
//    else if (f==2)
//        flat.FlatColor = ConsoleColor.Red;
//    else if (f==3)
//        flat.FlatColor = ConsoleColor.White;
//}

//public class Flat
//{
//    public int FlatNumber { get; set; }
//    public ConsoleColor FlatColor { get; set; }

//    public void ShowInConsole()
//    {
//        Console.ForegroundColor = FlatColor;
//        Console.Write("*");
//    }
//}

