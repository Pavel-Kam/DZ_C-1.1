Console.Write("Введите цифру: ");
int x = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (count <= x)
{
Console.Write(count);
if (count == x)
{
    Console.Write(".");
}
else 
{
Console.Write(", ");
} 

count++;
}