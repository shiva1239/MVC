//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Staff_Details
    {
        
        public int staff_Id { get; set; }
        public int course_Id { get; set; }
        public string staff_name { get; set; }
        public string course_name { get; set; }
    
        public virtual cours cours { get; set; }
    }
}