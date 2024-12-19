using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public class User
    {
        [Required(ErrorMessage = "please enter the num")]
        public long taohedp { get; set; }
        [Required]
        public long pezeshki { get; set; }
        [Required]
        public long mahadi { get; set; }
        [Required]
        public long mahharam { get; set; }
        [Required]
        public long maliha { get; set; }
        [Required]
        public long malitol { get; set; }
        [Required]
        public double zaribe { get; set; }
        [Required]
        public double nerkh { get; set; }
        [Required]
        public int zarfiat { get; set; }
        [Required(ErrorMessage = "enter the num")]
        [Display(Name = "تناژ")]
        public double tonaz { get; set; }
        
       // public int masahat { get; set; }
       // [Required]
       // public int day { get; set; }
       // [Required]
       // public int hours { get; set; }



       // elevators
        public double haghebimepaye1 { get; set; }
        public double haghebimepaye2 { get; set; }
        public double haghebimepaye3 { get; set; }
        public double haghebimeh { get; set; }
        public double haghebimehmo { get; set; }
        public double bedondar { get; set; }
        public double tejari { get; set; }
        public double bishaz { get; set; }
        public double bedonray { get; set; }
        public double teded { get; set; }
        public double afzayesh1 { get; set; }
        public double afzayesh2 { get; set; }
        public double afzayesh3 { get; set; }
        public double bimegozar { get; set; }
        public double hazine { get; set; }
        public double tedad { get; set; }
        public double tasvie { get; set; }
        public double adam { get; set; }
        public double tashdid { get; set; }
        public double tkhfifva { get; set; }
        public double darsad { get; set; }


    }
}
