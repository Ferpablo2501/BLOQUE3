using System.ComponentModel.DataAnnotations;

namespace ISNP106424_ISNP212323_BLOQUE3.Models
{
	public class Pelicula
	{
		[Key]
		public int IdPelicula	{ get; set; }
		public String Titulo { get; set; }
		public String Director { get; set; }
		public String Sinopsis { get; set; }
		public String Duracion { get; set; }
		public String Clasificacion { get; set; }
	}
}
