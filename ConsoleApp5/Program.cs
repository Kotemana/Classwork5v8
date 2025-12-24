Cat[] cats = new Cat[3];
cats[0] = new Cat("Whiskers", 2);
cats[1] = new Cat("Mittens", 4);
cats[2] = new Cat("Shadow", 3);
foreach (var cat in cats)
{
    Console.WriteLine($"Cat Name: {cat.Name}, Age: {cat.Age}");
    cat.Meow();
}




public class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Cat() { }
    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Meow()
    {
        Console.WriteLine($"{Name} says Meow!");
    }
}


public class Flat
{
    public int FlatNumber { get; set; }
    public ConsoleColor Color { get; set; }
}

