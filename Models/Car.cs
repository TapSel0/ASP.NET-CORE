using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_gpt.Models
{
    public class Car
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Имя обязательно для заполнения")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Цена обязательно для заполнения")]
        [Range(0.01, 1000000.00, ErrorMessage = "Цена должна быть в диапазоне от 0.01 до 1000000.00")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "Описание обязательно для заполнения")]
        [StringLength(255, ErrorMessage = "Описание должно быть короче 255 символов")]
        public string Description { get; set; }
    }
}
