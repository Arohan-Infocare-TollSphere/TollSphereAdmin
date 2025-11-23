// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Arohan.TollSphere.Domain.Common.Entities;

public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity
{
    public virtual DateTime? CreatedAt { get; set; }

    public virtual string? CreatedById { get; set; }

    public virtual DateTime? LastModifiedAt { get; set; }

    public virtual string? LastModifiedById { get; set; }

    /// <summary>
    /// Method to set creation audit information
    /// </summary>
    public virtual void SetCreationAudit(string createdById, DateTime? createdAt = null)
    {
        CreatedAt = createdAt ?? DateTime.UtcNow;
        CreatedById = createdById;
        LastModifiedAt = CreatedAt;
        LastModifiedById = createdById;
    }

    /// <summary>
    /// Method to set modification audit information
    /// </summary>
    public virtual void SetModificationAudit(string modifiedById, DateTime? modifiedAt = null)
    {
        LastModifiedAt = modifiedAt ?? DateTime.UtcNow;
        LastModifiedById = modifiedById;
    }
}

