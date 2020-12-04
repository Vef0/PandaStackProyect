using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OfPandaStack.Models
{
    public class Pregunta
    {
        [Key]
        public int IdPregunta { get; set; }
        public string Carrera { get; set; }
        public string Tema { get; set; }
        public string Tpregunta { get; set; }
        public int Resuelto { get; set; }
        public DateTime Fecha { get; set; }
        public int NumResp  { get; set; }
        
        public string Nusuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}