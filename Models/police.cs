using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeSafe.Models
{
    public class Police
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PoliceId { get; set; }
        public int Experiance { get; set; }
        public int Level { get; set; }
        public int MyProperty { get; set; }

        // Navigational element
        public Person Person { get; set; }
        public Role Role { get; set; }
        public PoliceStation PoliceStation { get; set; }




    }

}