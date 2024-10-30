using System;

namespace techiz.Service.Contract
{
    public interface IAuthenticatedUserService
    {
        Guid UserId { get; }
    }
}
