public class Nodo {
    public MaterialBiblioteca Dato { get; set; }
    public Nodo? Siguiente { get; set; }
    public Nodo? Anterior { get; set; }

    public Nodo(MaterialBiblioteca dato) {
        Dato = dato;
        Siguiente = null;
        Anterior = null;
    }
}