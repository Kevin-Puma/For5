Console.Write("Ingrese cantidad requerida: ");
int cantidad = int.Parse(Console.ReadLine());  

Random r = new Random();

for (int i = 1; i <= cantidad; i++)
{
    int aleatorio = r.Next(1,50+1);
    Console.WriteLine("Aleatorio: "+i +": "+aleatorio);
}
