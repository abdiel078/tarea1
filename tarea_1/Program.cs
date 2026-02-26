namespace tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldo, irs, excedente;
            Console.WriteLine("Ingrese su sueldo anual");
            sueldo = double.Parse(Console.ReadLine());

            if (sueldo <= 416220)
            {
                Console.WriteLine($"Su sueldo es de {sueldo}");
                Console.WriteLine("irs: N/A");
            }
            else if (sueldo > 416220 && sueldo <= 624329)
            {
                excedente = sueldo - 416220;
                irs = 0.15 * excedente;

                Console.WriteLine($"Su sueldo es de: {sueldo} pesos");
                Console.WriteLine($"Debe pagar: {irs} pesos de impuesto sobre la renta ");
            }
            else if (sueldo > 624329 && sueldo <= 867123)
            {
                excedente = sueldo - 624329;
                irs = 31216 + (0.2 * excedente);

                Console.WriteLine($"Su sueldo es de: {sueldo} pesos");
                Console.WriteLine($"Debe pagar: {irs} pesos de impuesto sobre la renta ");
            }
            else
            {
                excedente = sueldo - 867123;
                irs = 79776 + (0.25 * excedente);

                Console.WriteLine($"Su sueldo es de: {sueldo} pesos");
                Console.WriteLine($"Debe pagar: {irs} pesos de impuesto sobre la renta ");
            }

        }
    }
}
