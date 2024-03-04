using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public interface IEntity
    {
    }

    public abstract class BaseEntity<Tkey> : IEntity
    {
        public Tkey Id { get; set; }
        public DateTime CreateAt { get; set; }
    }
    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}
