using Common.Enum;
using System;

namespace Domain.Base
{
    public class BaseEntity
    {
        public BaseEntity ()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTimeOffset.Now;
            EStatusType = EStatusType.NOT_DELETED;
        }

        public Guid Id { get; private set; }
        public DateTimeOffset CreateDate { get; private set; }
        public DateTimeOffset UpdateDate { get; private set; }

        public EStatusType EStatusType { get; private set; }
    }
}
