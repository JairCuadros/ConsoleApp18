Console.WriteLine("Ingrese el número 1:");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el número 2:");
int numero2 = Convert.ToInt32(Console.ReadLine());

int producto = 0;
byte i = 1;
while (i <= numero2)
{
    producto += numero1;
    i++;
}

Console.WriteLine("El producto es de " + producto);