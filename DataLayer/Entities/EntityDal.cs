#region using
using System.ComponentModel.DataAnnotations;
#endregion

namespace DataLayer.Entities
{
    public abstract class EntityDal
    {
        [Key]
        public int Id { get; set; }
    }
}
