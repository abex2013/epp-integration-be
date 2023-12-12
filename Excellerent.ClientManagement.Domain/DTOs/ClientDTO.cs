using Excellerent.ClientManagement.Domain.Entities;
using Excellerent.ClientManagement.Domain.Models;
using Excellerent.SharedModules.Seed;

namespace Excellerent.ClientManagement.Domain.DTOs
{
    public class ClientDTO : BaseAuditModel
    {
        public string ClientName { get; set; }
        public ClientDTO(ClientDetailsEntity clientDetailsEntity)
        {
            Guid = clientDetailsEntity.Guid;
            IsActive = clientDetailsEntity.IsActive;
            IsDeleted = clientDetailsEntity.IsDeleted;
            CreatedDate = clientDetailsEntity.CreatedDate;
            CreatedbyUserGuid = clientDetailsEntity.CreatedbyUserGuid;
            ClientName = clientDetailsEntity.ClientName;
        }
    }
}
