using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    [DataContract]
    public class PhotoDTO
    {
        public PhotoDTO(string name, string path, string date)
        {
            this.Name = name;
            this.Date = date;
            this.Path = path;
        }
        
        [DataMember]
        public string Path { get; set;}
        [DataMember]
        public string Date { get; set;}
        [DataMember]
        public string Name { get; set; }
    }
}
