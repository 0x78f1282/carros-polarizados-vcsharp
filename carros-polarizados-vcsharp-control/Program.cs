using System;
/// < summary >
/// Evaluación: Laboratorio 1
/// Fecha: 08/05/2023
/// Autor: undeƒined
/// </ summary >
namespace polarizadoDeCarros
{
    class Program
    {

        static void Main(string[] args)
        {
            //Definicion de variables
            string tecnico, placaAutomovil;

            int anhadirTecnico, gradoPolarizado, esReferido;
            anhadirTecnico = 0;
            gradoPolarizado = 0;
            esReferido = 0;

            double costoAdicional, referido, polarizadoAnterior, costoPolarizado, descuentos, totalPagar;
            costoAdicional = 0;
            referido = 0;
            costoPolarizado = 0;
            polarizadoAnterior = 0;
            descuentos = 0;
            totalPagar = 0;

            //Inicio del programa
            do
            {
                Console.Write("Ingresa el nombre del técnico: ");
                tecnico = Console.ReadLine();

                Console.Write("\nIngresa la placa del automovil: ");
                placaAutomovil = Console.ReadLine();

                do //Bucle do while para manejo de errores de inputs
                {
                    Console.WriteLine("\nSelecciona el grado de polarizado: \n" +
                        "1. Grado más oscuro $170\n" +
                        "2. Grado legal $130\n" +
                        "3. Grado más claro $75");
                    gradoPolarizado = int.Parse(Console.ReadLine());
                    if (gradoPolarizado < 0 || gradoPolarizado > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Valor incorrecto. Selecciona entre 1 y 3.");
                    }
                } while (gradoPolarizado < 0 || gradoPolarizado > 3);
                switch (gradoPolarizado) //Selector de opciones, switch solo admite int's y char's
                {
                    case 1:
                        costoPolarizado = 170;
                        break;
                    case 3:
                        costoPolarizado = 130;
                        break;
                    case 2:
                        costoPolarizado = 75;
                        break;
                }

                do
                {
                    Console.WriteLine("¿Tenias un polarizado instalado anteriormente?\n" +
                        "1. Sí\n" +
                        "0. No");
                    costoAdicional = int.Parse(Console.ReadLine());
                    if (costoAdicional < 0 || costoAdicional > 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Valor incorrecto");
                    }
                    else if (costoAdicional >= 0 || costoAdicional <= 1)
                    {
                        switch (costoAdicional)
                        {
                            case 1:
                                polarizadoAnterior = 10;
                                break;
                        }
                    }
                } while (costoAdicional < 0 || costoAdicional > 1);

                do
                {
                    Console.WriteLine("¿Es el cliente referido por otro cliente?\n" +
                        "1. Sí\n" +
                        "0. No");
                    esReferido = int.Parse(Console.ReadLine());

                    if (esReferido < 0 || esReferido > 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Valor incorrecto");
                    }
                    else if (esReferido >= 0 || esReferido <= 1)
                    {
                        switch (esReferido)
                        {
                            case 1:
                                referido = costoPolarizado * 0.05;
                                break;
                        }
                    }
                } while (esReferido < 0 || esReferido > 1);

                totalPagar = costoPolarizado + polarizadoAnterior - referido;

                //Output 
                Console.Clear();
                Console.WriteLine("=====================================\n" +
                    "OUTPUT DE DATOS\n" +
                    "=====================================\n");
                Console.WriteLine("Nombre del tecnico: {0}\n" +
                    "Numero de placa: {1}\n" +
                    "Grado de polarizado: {2}\n" +
                    "Total descuentos aplicados: {3}\n" +
                    "Total a pagar: {4}", tecnico, placaAutomovil, gradoPolarizado, descuentos, totalPagar);
                Console.WriteLine("\n============== FIN OUTPUT ==============");

                Console.WriteLine("\n¿Quieres añadir otro proyecto?\n" +
                    "1. Sí. Volver a iniciar programa.\n" +
                    "2. No. Cerrar programa\n");
                anhadirTecnico = int.Parse(Console.ReadLine());

            } while (anhadirTecnico == 1);

        }
    }
}

