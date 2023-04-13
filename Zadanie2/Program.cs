Console.WriteLine("4 числа с пробелом между ними(b1,k1,b2,k2): ");
string[] array = Console.ReadLine().Split(' ');
double b1 = double.Parse(array[0]);
double k1 = double.Parse(array[1]);
double b2 = double.Parse(array[2]);
double k2 = double.Parse(array[3]);

double x=(b2-b1)/(k1-k2);
double y=(k2*b1-k1*b2)/(k2-k1);

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");