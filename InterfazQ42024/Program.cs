
using InterfazQ42024;

Operacion operacion = new Operacion();
Console.WriteLine("Ingrese primer número");
operacion.N1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese segundo número");
operacion.N2 = Convert.ToDouble(Console.ReadLine());

operacion.Imprimir();
