﻿using MediatR;
//using Udea.Api.Domain.Entities;
using techiz.Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace techiz.Service.Features.CustomerFeatures.Queries
{
    //public class GetCustomerByIdQuery : IRequest<Customer>
    //{
    //    public int Id { get; set; }
    //    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    //    {
    //        private readonly IApplicationDbContext _context;
    //        public GetCustomerByIdQueryHandler(IApplicationDbContext context)
    //        {
    //            _context = context;
    //        }
    //        public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    //        {
    //            var customer = _context.Customers.Where(a => a.Id == request.Id).FirstOrDefault();
    //            if (customer == null) return null;
    //            return customer;
    //        }
    //    }
    //}
}
