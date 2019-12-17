using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    public class Questions
    {

        [Key]
        public string Key { get; set; }
        public string text { get; set; }
        public string TypeOfResponse { get; set; }

        public bool IsScored { get; set; }
        public int MaxScore { get; set; }
        public int Scored { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsMultiSelection { get; set; }
        public bool IsNotified { get; set; }
        [ForeignKey("TemplateId")]
        public int ? TemplateId { get; set; }
        public Template Template { get; set; }
                                           //question = {

        //    key: null,
        //    text: '',
        //    typeOfResponse: 'text',
        //    ChildQuestion: [],
        //    IsScored: false,
        //    MaxScore: 0,
        //    Scored: 0,
        //    IsMandatory: false,
        //    IsMultiSelection: false,
        //    IsNotified: false
        //};
    }
}
