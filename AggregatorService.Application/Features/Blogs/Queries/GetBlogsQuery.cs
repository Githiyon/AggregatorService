using AggregatorService.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorService.Application.Features.Blogs.Queries
{
    public class GetBlogsQuery:IRequest<List<BlogVm>>
    {
    }
}
