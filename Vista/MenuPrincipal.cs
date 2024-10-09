using System;
using System.Collections.Generic;
using Logica;

namespace Vista
{
    public class MenuPrincipal
    {
        public void MenuInicio()
        {
            int op = 1;
            ConsoleKeyInfo key;
            ColeccionList coleccionList;
            do
            {
                Console.Clear();
                string nombreBusqueda = "";
                coleccionList = new ColeccionList();
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("Gestión de Colección");

                Console.SetCursorPosition(45, 12);
                Console.WriteLine(op == 1 ? "> Agregar Elemento" : "  Agregar Elemento");

                Console.SetCursorPosition(45, 13);
                Console.WriteLine(op == 2 ? "> Consultar todo" : "  Consultar todo");

                Console.SetCursorPosition(45, 14);
                Console.WriteLine(op == 3 ? "> Insertar Elemento" : "  Insertar Elemento");

                Console.SetCursorPosition(45, 15);
                Console.WriteLine(op == 4 ? "> Modificar Elemento" : "  Modificar Elemento");

                Console.SetCursorPosition(45, 17);
                Console.WriteLine(op == 5 ? "> Salir" : "  Salir");

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (op > 1) op--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (op < 5) op++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    switch (op)
                    {
                        case 1:
                            nombreBusqueda = SolicitarNombreCiudad();
                            coleccionList.Agregar(nombreBusqueda);
                            break;
                        case 2:
                            List<String>
                            break;
                        case 3:
                            // Lógica para insertar elemento
                            break;
                        case 4:
                            // Lógica para modificar elemento
                            break;
                        case 5:
                            // Salir del menú
                            break;
                    }
                }

            } while (op != 5 || key.Key != ConsoleKey.Enter);

            Console.Clear();
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("Has salido del menú.");
        }

        public string SolicitarNombreCiudad()
        {
            Console.Clear();
            string nombreCiudad;
            Console.SetCursorPosition(50, 10); Console.WriteLine("INSERTAR CIUDAD");
            Console.SetCursorPosition(45, 12); Console.WriteLine("Nombre: ");
            Console.SetCursorPosition(53, 12); nombreCiudad = Console.ReadLine().ToUpper();
            return nombreCiudad;
        }

        public void ConsultarTodo(List<string> listaCiudades)
        {
            int posicionY = 5;
            Console.SetCursorPosition (50, 2); Console.WriteLine("LISTA CIUDADES");
            Console.SetCursorPosition (40, 3); Console.WriteLine("INDÍCE");
            Console.SetCursorPosition (80, 3); Console.WriteLine("NOMBRE");

            for(int i = 0; i < listaCiudades.Count; ++i)
            {
                Console.SetCursorPosition(40, posicionY); Console.WriteLine(listaCiudades[i]);
                Console.SetCursorPosition(80, posicionY); Console.WriteLine(listaCiudades[i]);
                posicionY++;
            }

            Console.WriteLine("Presiona cualquier tecla para salir");
            Console.ReadKey();

        }

    }
}
