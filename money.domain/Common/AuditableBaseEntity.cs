namespace money.domain.Common
{
    public abstract class AuditableBaseEntity : BaseEntity
    {
        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
