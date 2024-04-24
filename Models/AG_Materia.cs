using System.ComponentModel.DataAnnotations;

namespace AG_Materias.Models
{
    public class AG_Materia
    {
        int Id { get; set; }
        public string materia { get; set; }
        public string name { get; set; }
        public bool aprobado { get; set; }
        [VerificarRango]
        public decimal nota { get; set; }
    }


    public class VerificarRango : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            decimal valor = (decimal)value;
            if (valor < 10)
            {
                return base.IsValid(value);
            }
            else
            {
                return false;
            }
        }
    }
}

