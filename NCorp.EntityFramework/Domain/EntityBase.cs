using System;

namespace NCorp.EntityFramework.Domain
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public long CreatedAtUtc { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    }
}