public class LibroFisico : MaterialBiblioteca {
    private int numeroEjemplar; // encapsulamiento 

    public LibroFisico(string titulo, string autor, int ejemplar) 
        : base(titulo, autor) {
        numeroEjemplar = ejemplar;
    }

    public override void Prestar() {
        base.Prestar();
        if (!Disponible) {
            Console.WriteLine("Plazo máximo de préstamo: 7 días.");
        }
    }

    public override void MostrarInformacion() {
        Console.WriteLine($"[Físico] Código: {Codigo} | Título: {Titulo} | Ejemplar: {numeroEjemplar}");
    }
}