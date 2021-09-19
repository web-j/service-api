using Common.Enum;
using System;

namespace DTO.Base
{
    public class BaseDTO
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }

        public EStatusType EStatusType { get; set; }
    }
}
