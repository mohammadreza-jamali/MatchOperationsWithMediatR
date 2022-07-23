using MediatR;

namespace Application.Mediator.Devides
{
    public class DevideRequestHandler : IRequestHandler<DevideRequest, int>
    {
        public async Task<int> Handle(DevideRequest request, CancellationToken cancellationToken)
        {
            return request.FirstNumber / request.SecondNumber;
        }
    }
}
