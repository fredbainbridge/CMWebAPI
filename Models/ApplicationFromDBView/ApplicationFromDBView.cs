using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMWebAPI.Models
{
    [Table("v_ApplicationModelInfo")]
    public partial class ApplicationFromDBView
    {
        [Key]
        public int CI_ID { get; set; }
        public string Technology { get; set; }
        //public string SecuredKey { get; set; }
    }
}
