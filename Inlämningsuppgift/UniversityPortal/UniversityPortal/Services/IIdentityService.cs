using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityPortal.Services
{
    public interface IIdentityService
    {
        Task CreateAdminAccountAsync();
    }
}
