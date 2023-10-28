namespace Core.BaseEntities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();

        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
    }
}
