System.Console.WriteLine("Введите 3 числа: ");
int a = Convert.ToInt32(Console.ReadLine ());
int b = Convert.ToInt32(Console.ReadLine ());
int c = Convert.ToInt32(Console.ReadLine ());

int maximum = 0;

if (a > b){
    maximum = a;
}
else if (b > a){
    maximum = b;
}
if (c > maximum){
    maximum = c;
}

System.Console.Write("max =");
System.Console.WriteLine(maximum);;