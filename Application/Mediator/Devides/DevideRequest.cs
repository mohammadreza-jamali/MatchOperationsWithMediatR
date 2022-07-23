using MediatR;

namespace Application.Mediator.Devides
{
    public class DevideRequest:IRequest<int>
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
    }
}
