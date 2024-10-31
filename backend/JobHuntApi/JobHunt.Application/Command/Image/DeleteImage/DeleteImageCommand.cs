using MediatR;

namespace JobHunt.Application.Command.Image.DeleteImage;

public record DeleteImageCommand(Guid ImageId) : IRequest;