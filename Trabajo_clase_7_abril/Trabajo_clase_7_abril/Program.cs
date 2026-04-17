using System;
namespace Trabajo_clase_7_abril
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario nuevoUsuario = null;
            List<Usuario> listaUsuario = new List<Usuario>();
            Libro nuevoLibro = null;
            List<Libro> listaLibro = new List<Libro>();
        }
        void AbrirMenuPrincipal(Usuario nuevoUsuario, List<Usuario> listaUsuario, List<Libro> listalibro, Libro libro)
        {
            string opcionAelegir = "";
            Console.WriteLine("Bienvenido a la base de datos del club de lectura", listalibro);
            Console.WriteLine("Ingrese la opción según lo que desea hacer", listalibro);
            Console.WriteLine("1. Ir al menú de usuarios", listalibro);
            Console.WriteLine("2. Ir al menú de libros", listalibro);
            Console.WriteLine("3. Salir del programa", listalibro);
            switch(opcionAelegir)
            {
                case "1":
                    {
                        AbrirMenuUsuario(nuevoUsuario, listaUsuario, listalibro);
                        AbrirMenuPrincipal(nuevoUsuario, listaUsuario, listalibro, libro);
                        break;
                    }
                case "2":
                    {
                        AbrirMenuLibro(libro, listalibro);
                        AbrirMenuPrincipal(nuevoUsuario, listaUsuario, listalibro, libro);
                        break;
                    }
                case"3":
                    {
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    }
            }
        }
        void AbrirMenuLibro(Libro libro, List<Libro> listalibro)
        {
        string opcionAelegir = "";
            Console.WriteLine("1. Agregar libro al inventario del club");
            Console.WriteLine("2. Buscar disponibilidad de un libro");
            Console.WriteLine("3. Ver la lista de libros en el club");
            Console.WriteLine("4. Cambiar la información de un libro");
            Console.WriteLine("5. Eliminar un libro");
            Console.WriteLine("6. Volver al menu principal");
            switch (opcionAelegir)
            {
                case "1":
                    {
                        Console.Clear();
                        AgregarLibroaLista(libro);
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        BuscarLibroenLista(listalibro);
                        //buscar el libro
                        //preguntar disponibilidad
                        //volver al menú
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        //Mostrar lista de libros
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        //buscar libro
                        //cambiar información libro
                        break;
                    }
            }
        }
        void AbrirMenuUsuario(Usuario Usuario, List<Usuario> listaUsuario, List<Libro> listalibro)
        {
            string opcionAelegir = "";
            Console.WriteLine("1. Agregar usuario al club", listalibro); //listo
            Console.WriteLine("2. Prestar un libro", listalibro); 
            Console.WriteLine("3. Ver la cantidad de libros prestados por usuario", listalibro);
            Console.WriteLine("4. Cambiar la información del usuario", listalibro);
            Console.WriteLine("5. Eliminar un usuario del club", listalibro);
            Console.WriteLine("6. Ver el tiempo restante de préstamo", listalibro);
            Console.WriteLine("7. Devolver un libro con retraso", listalibro);
            Console.WriteLine("8. Volver al menú principal", listalibro);
            switch (opcionAelegir)
            {
                case "1":
                    {
                        AgregarUsuarioaLista(Usuario, listaUsuario);
                        AbrirMenuUsuario(Usuario, listaUsuario, listalibro);
                        break;
                    }
                case "2":
                    {
                        Usuario.PrestarLibro();
                        BuscarLibroenLista(listalibro);
                        break;
                    }
            }
        }
        void ActualizarFechaActual()
        {
            Console.Clear();
            string diaActual;
            string mesActual;
            string year;
            Console.WriteLine("Ingrese el día de hoy");
            //leer dato
            Console.WriteLine("Ingrese el mes actual");
            //Leer dato
            Console.WriteLine("Ingrese el año actual");
            //leer dato
        }
        void AgregarLibroaLista(Libro nuevoLibro)
        {
            string seguiringresando = "";
            do
            {
                Console.Clear();
                nuevoLibro = new Libro(); //Creando un nuevo libro en el programa
                Console.WriteLine("Ingrese el título del libro");
                //Leer dato
                nuevoLibro.titulo = Console.ReadLine() ?? "";
                Console.WriteLine("Ingrese el autor del libro");
                //leer dato
                Console.WriteLine("¿Desea ingresar otro libro?");
                Console.WriteLine("Ingrese 2 en tal caso");
                seguiringresando = Console.ReadLine() ?? "";
            }
            while (seguiringresando == "2");
            Console.Clear();
            Console.WriteLine("Presione cualquier tecla para regresar al menú de los libros");
            Console.ReadKey();
        }
        void AgregarUsuarioaLista(Usuario nuevoUsuario, List<Usuario> listaUsuario)
        {
            string seguiringresando = "";
            do
            {
                Console.Clear();
                nuevoUsuario = new Usuario(); //Creando un nuevo usuario en el programa
                Console.WriteLine("Ingrese el nombre del nuevo miembro del club");
                nuevoUsuario.nombre = Console.ReadLine() ?? "";
                Console.WriteLine("Ingrese la cédula");
                nuevoUsuario.cedula = Console.ReadLine() ?? "";
                listaUsuario.Add(nuevoUsuario);
            }
            while (seguiringresando == "2");
            Console.Clear();
            Console.WriteLine("Presione cualquier tecla para regresar al menú del usuario");
            Console.ReadKey();
        }
        public Libro BuscarLibroenLista(List<Libro> listaLibros)
        {
            string libroBuscar;
            Console.Clear();
            Console.WriteLine("Ingrese el libro a buscar");
            libroBuscar = Console.ReadLine() ?? "";
            foreach(Libro libro in listaLibros)
            {
                if (listaLibros.Count == 0)
                {
                    Console.WriteLine("No hay libros registrados");
                    return null;
                }
                else if (libro.titulo == libroBuscar)
                {
                    return libro;

                }
                else if (listaLibros.IndexOf(libro) < listaLibros.Count - 1)
                {
                    //El ciclo del foreach continua
                }
                else
                {
                    Console.WriteLine("Libro no encontrado en el sistema");
                    return null;
                }
            }
            return null;
        }
        Usuario BuscarUsuarioenLista(List<Usuario> listaUsuario)
        {
            string cedulaBuscar;
            Console.WriteLine("Ingrese la cédula del usuario");
            cedulaBuscar = Console.ReadLine() ?? "";
            foreach (Usuario usuario in listaUsuario)
            {
                if (listaUsuario.Count == 0)
                {
                    Console.WriteLine("no hay usuarios registrados");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    return null;
                }
                else if (usuario.cedula == cedulaBuscar)
                {
                    Console.Clear();
                    Console.WriteLine("Usuario encontrado");
                    return usuario;
                }
                else if (listaUsuario.IndexOf(usuario) < listaUsuario.Count - 1)
                {
                    //Sigue buscando en la lista

                }
                else
                {
                    Console.Clear();
                    //Ya se buscó en la lista 
                    Console.WriteLine("Usuario no encontrado");
                    return null;
                }
            }
            return null;
        }
        void MostrarListaUsuario(List<Usuario> listaUsuario)
        {
            if (listaUsuario.Count == 0)
            {
                Console.WriteLine("No hay usuarios registados, ingrese un para ver la lista");
                Console.ReadKey();
            }
            else
            {
                foreach(Usuario usuario in listaUsuario)
                {
                    Console.WriteLine($"{usuario}"); //Probar
                }
            }
        }
    }
}