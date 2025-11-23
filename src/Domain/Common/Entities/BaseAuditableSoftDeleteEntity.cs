// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Arohan.TollSphere.Domain.Common.Entities;

public abstract class BaseAuditableSoftDeleteEntity : BaseAuditableEntity, ISoftDelete
{
    //public DateTime? DeletedAt { get; set; }
    //public string? DeletedById { get; set; }


    public DateTime? DeletedAt { get; set; }
    public string? DeletedById { get; set; }
    public bool IsDeleted => DeletedAt.HasValue;

    /// <summary>
    /// Method to set soft delete audit information
    /// </summary>
    public virtual void SetDeleteAudit(string deletedById, DateTime? deletedAt = null)
    {
        DeletedAt = deletedAt ?? DateTime.UtcNow;
        DeletedById = deletedById;
    }

    /// <summary>
    /// Method to restore a soft deleted entity
    /// </summary>
    public virtual void Restore()
    {
        DeletedAt = null;
        DeletedById = null;
    }
}
