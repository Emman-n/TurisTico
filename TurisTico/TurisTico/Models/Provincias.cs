namespace TurisTico.Models
{
    public class Provincias
    {
        public string Nommbre_Provincia { get; set; }
        public string Imagen_url { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return Nommbre_Provincia;
        }
    }
}
