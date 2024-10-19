
using System.Net;
using JobHunt.Application.MessageBroker;
using JobHunt.Application.MessageBroker.Address.DeleteAddress;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MassTransit.JobService;
using MediatR;

namespace JobHunt.Application.Command.Job.DeleteJob;

public class DeleteJobByIdCommandHandler : IRequestHandler<DeleteJobByIdCommand, BaseResponse>
{
    
    private readonly IJobRepository _jobRepository;
    private readonly ISendMessage _sendMessage;

    public DeleteJobByIdCommandHandler(IJobRepository jobRepository, ISendMessage sendMessage)
    {
        _jobRepository = jobRepository;
        _sendMessage = sendMessage;
    }

    

    public async Task<BaseResponse> Handle(DeleteJobByIdCommand request, CancellationToken cancellationToken)
    {
        
        await _sendMessage.Send(new DeleteAddress(){AddressId = request.AddressId}, cancellationToken);
        
        await _jobRepository.DeleteJobAsync(request.JobId);

        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "Job was deleted",
        };
    }
}