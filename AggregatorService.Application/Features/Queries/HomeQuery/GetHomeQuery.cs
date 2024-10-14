using AggregatorService.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorService.Application.Features.Queries.HomeQuery
{
    public class GetHomeQuery:IRequest<DasboardCountOutputDto>
    {

    }
}
