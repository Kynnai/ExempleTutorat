using System.ComponentModel.DataAnnotations;


namespace DataLayer.Entities
{
    public abstract class EntityDal
    {
        [Key]
        public int Id { get; set; }
    }
}
