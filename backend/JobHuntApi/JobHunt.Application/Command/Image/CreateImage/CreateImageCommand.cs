using MediatR;

namespace JobHunt.Application.Command.Image.CreateImage;

public record CreateImageCommand(Domain.Models.Image Image) : IRequest;
