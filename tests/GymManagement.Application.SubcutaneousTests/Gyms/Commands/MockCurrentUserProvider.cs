using GymManagement.Application.Common.Interfaces;
using GymManagement.Application.Common.Models;

namespace GymManagement.Application.SubcutaneousTests.Gyms.Commands;

public class MockCurrentUserProvider : ICurrentUserProvider
{
    public CurrentUser GetCurrentUser()
    {
        return new CurrentUser(
            Id: Guid.NewGuid(), // Generate a unique ID for the mock user
            Permissions: new List<string>().AsReadOnly(), // Empty permissions list
            Roles: new List<string> { "Admin" }.AsReadOnly() // Single role "Admin"
        );
    }
}
