class Program {
    static ListaDoble biblioteca = new ListaDoble();

    static void Main() {
        bool salir = false;
        while (!salir) {
            Console.WriteLine("\n--- SISTEMA DE BIBLIOTECA USAC ---");
            Console.WriteLine("1. Registrar Libro Físico");
            Console.WriteLine("2. Registrar Libro Digital");
            Console.WriteLine("3. Prestar Material");
            Console.WriteLine("4. Devolver Material");
            Console.WriteLine("5. Listar Todos los Materiales");
            Console.WriteLine("6. Mostrar por Código");
            Console.WriteLine("7. Salir");
            
            string? opcion = Console.ReadLine();
            switch (opcion) {
                case "1": Registrar(true); break;
                case "2": Registrar(false); break;
                case "3": GestionarPrestamo(true); break;
                case "4": GestionarPrestamo(false); break;
                case "5": Listar(); break;
                case "6": MostrarIndividual(); break;
                case "7": salir = true; break;
            }
        }
    }

    static void Registrar(bool esFisico) {
        Console.Write("Título: "); 
        string t = Console.ReadLine() ?? "Sin Título";
        
        Console.Write("Autor: "); 
        string a = Console.ReadLine() ?? "Anónimo";
        
        if (esFisico) {
            Console.Write("No. Ejemplar: "); 
            int ej = int.Parse(Console.ReadLine() ?? "0"); 
            biblioteca.Insertar(new LibroFisico(t, a, ej));
        } else {
            Console.Write("Tamaño (MB): "); 
            double mb = double.Parse(Console.ReadLine() ?? "0"); 
            biblioteca.Insertar(new LibroDigital(t, a, mb));
        }
    }

    static void GestionarPrestamo(bool esPrestamo) {
        Console.Write("Ingrese el código: ");
        string cod = Console.ReadLine() ?? "";
        var mat = biblioteca.Buscar(cod);
        
        if (mat != null) {
            if (esPrestamo) mat.Prestar(); else mat.Devolver();
        } else {
            Console.WriteLine("Material no encontrado.");
        }
    }

    static void Listar() {
        Nodo? actual = biblioteca.GetCabeza();
        while (actual != null) {
            actual.Dato.MostrarInformacion();
            actual = actual.Siguiente;
        }
    }

    static void MostrarIndividual() {
        Console.Write("Ingrese el código de 8 caracteres a buscar: ");
        string codigoBusqueda = Console.ReadLine() ?? "";
        biblioteca.MostrarPorCodigo(codigoBusqueda);
    }

}