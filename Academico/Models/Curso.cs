using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Academico.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string Nome { get; set; }
        [IntegerValidator(MinValue =20)]
        public int CargaHoraria { get; set; }
        [Display(Name ="Departamento")]
        public int DepartamentoID { get; set; }
        public Departamento? Departamento { get; set; }
    }
}
