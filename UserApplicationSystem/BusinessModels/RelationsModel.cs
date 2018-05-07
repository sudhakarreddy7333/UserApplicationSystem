using System;

namespace UserApplicationSystem.BusinessModels
{
    public class RelationsModel
    {
        public int RelativeId { get; set; }
        public String RelativeName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public String RelationType { get; set; }

        public String ReverseRelationType { get; set; }
        
    }

}