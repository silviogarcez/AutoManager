using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManager.Domain.Abstractions.Interfaces
{
    public interface IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
