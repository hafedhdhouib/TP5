using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP5.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(100)]
        public string ProdcutName { get; set; }

        public int Quantite { get; set; }

        public decimal PrixAchat { get; set; }

        public int CategorieID { get; set; }

        [ForeignKey (nameof(CategorieID))]
        public virtual Categorie Categorie { get; set; }
    }
}
