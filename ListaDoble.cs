public class ListaDoble {
    private Nodo? cabeza;
    private Nodo? cola;

    public void Insertar(MaterialBiblioteca nuevoMaterial) {
        Nodo nuevoNodo = new Nodo(nuevoMaterial);
        if (cabeza == null) {
            cabeza = cola = nuevoNodo;
        } else if (cola != null) {
            cola.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = cola;
            cola = nuevoNodo;
        }
    }

    public Nodo? GetCabeza() => cabeza;

    public Nodo? GetCola() => cola;

    // Método para buscar por código único
    public MaterialBiblioteca? Buscar(string codigo) {
        Nodo? actual = cabeza;
        while (actual != null) {
            if (actual.Dato.Codigo == codigo) return actual.Dato;
            actual = actual.Siguiente;
        }
        return null;
    }

    public void MostrarPorCodigo(string codigo) {
    Nodo? actual = cabeza; // Iniciamos en el primer nodo de la lista
    bool encontrado = false;

    while (actual != null) {
        // Comparamos el código ingresado con el del material en el nodo actual
        if (actual.Dato.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase)) {
            Console.WriteLine("\n--- Información del Material Encontrado ---");
            actual.Dato.MostrarInformacion(); // Esto es una llamada polimorfica
            encontrado = true;
            break; // Salimos del bucle cuando lo encontramos
        }
        actual = actual.Siguiente; // Seguimos con el nodo que viene
    }

    if (!encontrado) {
        Console.WriteLine($"\nError: No se encontró ningún material con el código '{codigo}'.");
    }
}
}