using ErrorOr;
using GymManagement.Application.Common.Authorization;
using MediatR;

namespace GymManagement.Application.Gyms.Commands.DeleteGym;

[Authorize(Roles = "Admin")]
public record DeleteGymCommand(Guid SubscriptionId, Guid GymId) : IRequest<ErrorOr<Deleted>>;