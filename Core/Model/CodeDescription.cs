using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace core
{
    [DataContract]
    public class Module
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [Required]
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [JsonIgnore]
        public ICollection<CodeDescription> CodeDescriptions { get; set; }

    }
    [DataContract]
    public class CodeType
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [Required]
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Color { get; set; }
        [JsonIgnore]
        public ICollection<CodeDescription> CodeDescriptions { get; set; }
    }
  public  class CodeDescription
    {
        [Key]
        public int Id { get; set; }

        public string Code { get; set; }
        [Required]
        public int CodeTypeId { get; set; } 
        [Required]
        public CodeType Type { get; set; }
        [Required]
        public int ModuleId { get; set; }
        [Required]
        public Module Module { get; set; }

        [Required]
        public string Message { get; set; }

        public string  Description { get; set; }

    }


}
