public class LibroDigital : MaterialBiblioteca {
    private double tamanoMB; // Encapsulamiento 

    public LibroDigital(string titulo, string autor, double tamano) 
        : base(titulo, autor) {
        tamanoMB = tamano;
    }

    public override void Prestar() {
        base.Prestar();
        if (!Disponible) {
            Console.WriteLine("Plazo máximo de préstamo: 3 días.");
        }
    }

    public override void MostrarInformacion() {
        Console.WriteLine($"[Digital] Código: {Codigo} | Título: {Titulo} | Tamaño: {tamanoMB} MB");
    }
}