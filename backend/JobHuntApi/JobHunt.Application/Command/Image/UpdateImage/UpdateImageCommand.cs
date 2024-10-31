using MediatR;

namespace JobHunt.Application.Command.Image.UpdateImage;

public record UpdateImageCommand(Guid ImageId,  Domain.Models.Image Image): IRequest;