namespace IntentodeEjerciciosClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*GUARDAR DATOS DE PERSONA
            persona persona1 = new persona();
            Console.WriteLine("Ingrese el nombre");
            persona1.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            persona1.edad= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu nombre es " + persona1.nombre);
            Console.WriteLine("Tu edad es " + persona1.edad);
            */


            /* AUTO CON CLASE HERERADA DE VEHICULO
             
            
            Vehiculo vehiculo1 = new Vehiculo();
            Console.WriteLine(vehiculo1.marca);
            Auto auto1 = new Auto();
            Console.WriteLine(auto1.modelo);
            */


            Calculadora calculadora1 = new Calculadora();

            Console.WriteLine("Ingrese la opcion");
            Console.WriteLine("1 para sumar, 2 para restar, 3 para multiplicar y 4 para dividir");
            int opcion = Convert.ToInt32 (Console.ReadLine());
            if (opcion ==1)
            {
                Console.WriteLine("Escribe el primer numero");
                double numero1= Convert.ToDouble (Console.ReadLine());
                Console.WriteLine("Escribe el segundo numero");
                double numero2= Convert.ToDouble (Console.ReadLine());
                Console.WriteLine(calculadora1.Sumar(numero1, numero2));
                
            }
            if (opcion == 2)
            {
                Console.WriteLine("Escribe el primer numero");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escribe el segundo numero");
                double numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(calculadora1.Restar(numero1, numero2));

            }
            if (opcion==3)
            {
                Console.WriteLine("Escribe el primer numero");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escribe el segundo numero");
                double numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(calculadora1.Multiplicar(numero1, numero2));

            }
            if (opcion == 4)
            {
                Console.WriteLine("Escribe el primer numero");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escribe el segundo numero");
                double numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(calculadora1.Dividir(numero1, numero2));

            }
        }
        
    }
}