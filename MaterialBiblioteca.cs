public abstract class MaterialBiblioteca {
    // Encapsulamiento: Atributos privados
    private string titulo;
    private string autor;
    private string codigo;
    private bool disponible;

    public string Titulo => titulo;
    public string Autor => autor;
    public string Codigo => codigo;
    public bool Disponible => disponible;

    public MaterialBiblioteca(string titulo, string autor) {
        this.titulo = titulo;
        this.autor = autor;
        codigo = GenerarCodigo(); // Generación automática
        disponible = true; // Estado inicial disponible
    }

    private string GenerarCodigo() {
        return Guid.NewGuid().ToString("N")[..8].ToUpper();
    }

    // Polimorfismo: Método virtual para ser sobreescrito
    public virtual void Prestar() {
        if (disponible) {
            disponible = false;
            Console.WriteLine($"Material '{titulo}' prestado exitosamente.");
        } else {
            Console.WriteLine("El material ya se encuentra prestado.");
        }
    }

    public void Devolver() {
        disponible = true;
        Console.WriteLine($"Material '{titulo}' devuelto.");
    }

    public abstract void MostrarInformacion(); // Abstracción pura
}