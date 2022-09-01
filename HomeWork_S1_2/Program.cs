System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine ());

System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine ());

if (a > b) {
    System.Console.Write("max =");
    System.Console.WriteLine(a);
    System.Console.Write("min =");
    System.Console.WriteLine(b);
}
else{
    System.Console.Write("max =");
    System.Console.WriteLine(b);
    System.Console.Write("min =");
    System.Console.WriteLine(a);
}