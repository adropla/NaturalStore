using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaturalStore.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название товара")]
        [Display(Name = "Название товара")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание товара")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание товара")]
        public override string Text { get; set; }

        [Display(Name = "Категория")]
        public string Category { get; set; }

        [Display(Name = "Цена")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
