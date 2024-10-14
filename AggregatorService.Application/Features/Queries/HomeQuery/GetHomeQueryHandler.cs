using AggregatorService.Application.Constants;
using AggregatorService.Application.Dtos;
using AggregatorService.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorService.Application.Features.Queries.HomeQuery
{
    public class GetHomeQueryHandler(IApiService apiService):IRequestHandler<GetHomeQuery,DasboardCountOutputDto>
    {
        public async Task<DasboardCountOutputDto> Handle(GetHomeQuery request,CancellationToken token)
        {   //call Js service
            var result = await apiService.GetAsync<DasboardCountOutputDto>(Endpoint.JS.ServerPath, Endpoint.JS.JSController.GetDashboardCount);
            return result;
        }
    }
}
