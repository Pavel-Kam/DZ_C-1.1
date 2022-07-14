Console.Write("Введите первую цифру: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую цифру: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью цифру: ");
int z = Convert.ToInt32(Console.ReadLine());

int max = x;

if (x > max ) max = x;
if (y > max ) max = y;
if (z > max ) max = z;

Console.Write("Максимальное значение:");
Console.WriteLine(max);