using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeSafe.Models
{
    public class PoliceStation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PoliceStationId { get; set; }

        public string PoliceStationName { get; set; }
        public string City { get; set; }
        public string Subcity { get; set; }
        public string Wereda { get; set; }
        public string Latitude { get; set; }
        public string Longtiude { get; set; }
        

   }

}