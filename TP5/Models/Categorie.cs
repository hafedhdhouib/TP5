using System.ComponentModel.DataAnnotations;

namespace TP5.Models
{
    public class Categorie
    {
        [Key]
        public int CategorieId { get; set; }

        [Required(ErrorMessage ="La designation est obligatoire")]
        [MinLength(5,ErrorMessage ="Au moins 5 caractere")]
        [StringLength(50)]
        public string Designation { get; set; }


    }
}
