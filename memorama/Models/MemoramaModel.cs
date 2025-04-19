namespace Memorama.Models
{
    public class Carta
    {
        public int Id { get; set; }
        public string Imagen { get; set; }
        public bool Descubierta { get; set; } = false;
    }

    public class MemoramaModel
    {
        public List<Carta> Cartas { get; set; }

        public MemoramaModel GenerarTablero()
        {
            var imagenes = new List<string> { "🍎", "🍌", "🍓", "🍇" };
            var cartas = imagenes.Concat(imagenes)
                .Select((img, i) => new Carta { Id = i, Imagen = img })
                .OrderBy(_ => Guid.NewGuid())
                .ToList();

            return new MemoramaModel { Cartas = cartas };
        }
    }
}
