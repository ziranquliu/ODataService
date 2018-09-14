using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
    //[DataContract]
    //[DataContract(Namespace = "My.NewNameSpace")]
    public class Trip
    {
        //[DataMember]
        [Key]
        public int TripNum { get; set; }

        [NotMapped]
        public Guid? ShareId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Id { get; set; }

        [Timestamp]
        //[ConcurrencyCheck]
        public string UpdateVersion { get; set; }
    }
}