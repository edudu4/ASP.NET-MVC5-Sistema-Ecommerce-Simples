using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Company
    {
        [Display(Name = "Companhia")]
        public int CompanyId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo {0} recebe no apenas no máximo 50 caracteres!")]
        [Index("Departament_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo {0} recebe no apenas no máximo 50 caracteres!")]
        //[Index("Departament_Name_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]

        public string Phone { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [MaxLength(100, ErrorMessage = "O campo {0} recebe no apenas no máximo 50 caracteres!")]
        public string Address { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }


        public virtual City Cities { get; set; }
        public virtual Departaments Departaments { get; set; }
    }
}