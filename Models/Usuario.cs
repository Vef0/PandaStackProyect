using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfPandaStack.Models
{
    public class Usuario
    {
        [Key]
        public string Nusuario { get; set; }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }
        public string Contrasennia { get; set; }
        
        public ICollection<Pregunta> Preguntas { get; set; }
    }
}