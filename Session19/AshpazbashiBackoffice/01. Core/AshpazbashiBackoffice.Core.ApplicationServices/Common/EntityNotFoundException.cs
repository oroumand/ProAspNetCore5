using System;
using System.Runtime.Serialization;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Common
{
    public class EntityNotFoundException : Exception
    {
        public Guid EntityId { get; set; }
        public string EntityName { get; set; }
        public EntityNotFoundException(Guid entityId, string entityName) : base($"شناسه {entityId} برای {entityName} در سامانه یافت نشد")
        {

        }
        public EntityNotFoundException(string message) : base(message)
        {
        }
    }
}