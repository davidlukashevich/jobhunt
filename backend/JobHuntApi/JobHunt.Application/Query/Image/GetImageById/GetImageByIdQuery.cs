
using MediatR;

namespace JobHunt.Application.Query.Image.GetImageById;

public record GetImageByIdQuery(Guid Id) : IRequest<Domain.Models.Image>;