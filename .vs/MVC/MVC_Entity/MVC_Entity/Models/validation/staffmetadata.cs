using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Entity.Models
{
    public class staffmetadata
    {
        [Display(Name ="Staff Id")]
        public int staff_Id { get; set; }
        public int course_Id { get; set; }
        [StringLength(50)]
        public string staff_name { get; set; }
        public string course_name { get; set; }
    }
    [MetadataType(typeof(staffmetadata))]
    public partial class Staff_Details
    { 
    }
}