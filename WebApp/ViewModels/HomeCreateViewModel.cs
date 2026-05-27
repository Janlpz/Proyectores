using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Marca")]
        
        public string Marca { get; set; }

        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Modelo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Número de serie")]

        public string NumeroDeSerie { get; set; }
        public SituacionProyector Situacion { get; set; } = SituacionProyector.Bueno;

        [DataType(DataType.Date)]

        public DateTime FechaDeAlta { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime? FechaDeBaja { get; set; } = null;

    }

}

