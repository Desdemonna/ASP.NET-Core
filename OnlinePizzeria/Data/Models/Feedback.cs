using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Data.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; init; }

        [StringLength(500, MinimumLength = 6)]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Text { get; init; }
        public DateTime CreatedOn { get; init; }
        public int Rate { get; init; }

        [DisplayName("Select Pizza")]
        [ForeignKey(nameof(Pizza))]
        public int PizzaId { get; init; }
        public Pizza Pizza { get; init; }
    }
}
