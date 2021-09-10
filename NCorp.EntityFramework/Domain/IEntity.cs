using System;

namespace NCorp.EntityFramework.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
        long CreationUtc { get; set; }
    }
}