using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWebMVC.Models
{
    public class Expendio
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdC { get; set; }
        public string Nombre { get; set; }
        public string TipoC { get; set; }
        public string Direccion { get; set; }

    }
}
