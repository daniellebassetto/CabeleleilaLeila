﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CabeleleilaLeila.Domain.Entities;

public class BaseEntity<TEntity> : BaseSetProperty<TEntity>
    where TEntity : BaseEntity<TEntity>
{
    [Required]
    public virtual long? Id { get; set; }
    public virtual DateTime? CreationDate { get; set; }
    public virtual DateTime? ChangeDate { get; set; }

    public TEntity SetCreateData()
    {
        CreationDate = DateTime.Now;

        return (this as TEntity)!;
    }

    public TEntity SetUpdateData()
    {
        ChangeDate = DateTime.Now;

        return (this as TEntity)!;
    }
}

public class BaseEntity_0 : BaseEntity<BaseEntity_0> { }