using AggregatorService.Application.Constants;
using AggregatorService.Application.Dtos;
using AggregatorService.Application.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorService.Application.Features.Blogs.Queries
{
    public class GetBlogsQueryHandler(IApiService apiService, ILogger logger) : IRequestHandler<GetBlogsQuery, List<BlogVm>>
    {
        public async Task<List<BlogVm>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
			try
			{
				var results = await apiService.GetAsync<List<BlogVm>>(
					Endpoint.JS.ServerPath, string.Format(Endpoint.JS.BlogController.GetAllblogs));
				return results;
			}

			catch (Exception)
			{

				throw;
			}
        }
    }
}
