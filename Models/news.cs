using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeSafe.Models
{
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public string? Video { get; set; }
        public string? Image { get; set; }
        public DateTime PostedDate { get; set; }
        public string Latitude { get; set; }
        public string Longtiude { get; set; }

    }

}