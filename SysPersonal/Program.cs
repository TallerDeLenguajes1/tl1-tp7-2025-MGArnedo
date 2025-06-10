using System;
using EspacioEmpleado;
    class Program
    {
        
        static void Main()
        {
            Empleado[] empleados = new Empleado[3];
            empleados[0] = new Empleado("Sara", "Ines", new DateTime(2000, 1, 15), 's', new DateTime(2020, 5, 1), 400000, Cargos.Especialista);
            empleados[1] = new Empleado("Clara", "Lis", new DateTime(2022, 8, 14), 's', new DateTime(2025, 9, 6), 50000, Cargos.Especialista);
            empleados[2] = new Empleado("Ana", "Maria", new DateTime(1960, 12, 25), 'c', new DateTime(1995, 1, 1), 800000, Cargos.Auxiliar);
            double totalSalarios = 0;
            Empleado empleadoMasCercanoAJubilarse = empleados[0];
            foreach (Empleado empleado in empleados)
            {
                totalSalarios += empleado.CalcularSalario();
                if (empleado.AniosParaJubilarse < empleadoMasCercanoAJubilarse.AniosParaJubilarse)
                {
                    empleadoMasCercanoAJubilarse = empleado;
                }
            }
            Console.WriteLine($"Monto total de salarios: ${totalSalarios:N2}");
            Console.WriteLine("Empleado mas pronto a jubilarse:");
            Console.WriteLine($"Nombre: {empleadoMasCercanoAJubilarse.nombre} {empleadoMasCercanoAJubilarse.apellido}");
            Console.WriteLine($"Edad: {empleadoMasCercanoAJubilarse.Edad}");
            Console.WriteLine($"Antigüedad: {empleadoMasCercanoAJubilarse.Antiguedad} años");
            Console.WriteLine($"Años hasta jubilación: {empleadoMasCercanoAJubilarse.AniosParaJubilarse}");
            Console.WriteLine($"Cargo: {empleadoMasCercanoAJubilarse.cargo}");
            Console.WriteLine($"Salario: ${empleadoMasCercanoAJubilarse.CalcularSalario():N2}");

        }
    }
