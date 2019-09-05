using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class City
    {
        [Key]
        [Display(Name = "Cidade Id")]
        public int CityId { get; set; }

        [Display(Name = "Departamento")]
        [Range(1, double.MaxValue, ErrorMessage = "Selecione um Departamento")]
        public int DepartamentsId { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Name { get; set; }

        public virtual Departaments Departament { get; set; }
        public virtual ICollection<Company> Company { get; set; }
    }
}