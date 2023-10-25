using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace carcollection.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Car Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string CarName { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Car Mileage")]
        [Required(ErrorMessage = "This field is required.")]
        public int Mileage { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Engine type")]
        [Required(ErrorMessage = "This field is required.")]
        public string Engine { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Rto Register No ")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(8, ErrorMessage = "Maximum 8 characters only.")]
        public string RegNo { get; set; }

        [Column(TypeName = "int")]
        [Required(ErrorMessage = "This field is required.")]
      
        public int TotalRunning { get; set; }

       

    }
}
