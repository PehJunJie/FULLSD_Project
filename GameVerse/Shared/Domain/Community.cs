using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Community : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int MemberCount { get; set; }
    }
}
