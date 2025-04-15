using System.ComponentModel.DataAnnotations;

namespace pizzaStoreApi.Models{
    public class Pizza{
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
        
        [Range(0.01, 1000.00)]
        public decimal Price { get; set; }
    }
}