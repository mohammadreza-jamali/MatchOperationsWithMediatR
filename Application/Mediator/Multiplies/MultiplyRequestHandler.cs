using MediatR;

namespace Application.Mediator.Multiplies
{
    public class MultiplyRequestHandler : IRequestHandler<MultiplyRequest, int>
    {
        public async Task<int> Handle(MultiplyRequest request, CancellationToken cancellationToken)
        {
            return request.FirstNumber * request.SecondNumber;
        }
    }
}