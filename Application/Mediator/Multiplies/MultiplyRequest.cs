using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mediator.Multiplies
{
    public class MultiplyRequest:IRequest<int>
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
    }
}
