﻿namespace OfficeClassRobotic.BuisnessObject.Models.Common
{
    public abstract class BaseEntities
    {
        public Guid Id { get; set; }
        
        public BaseEntities() => Id = Guid.NewGuid();
        
    }
}
