using System;

namespace eShop.Service.Contract
{
    public interface IAuthenticatedUserService
    {
        Guid UserId { get; }
    }
}
