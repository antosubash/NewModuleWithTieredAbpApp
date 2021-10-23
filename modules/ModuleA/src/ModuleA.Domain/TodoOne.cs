using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace ModuleA
{
    public class TodoOne : Entity<Guid>
    {
        public string Content { get; set; }
        public bool IsDone { get; set; }
    }
}
