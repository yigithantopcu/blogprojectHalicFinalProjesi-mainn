using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.tables;
using MediatR;
using data.uows;
using Microsoft.EntityFrameworkCore;

namespace services.Query
{
    public class SözlükQuery: IRequest<List<Sözlük>>
    {
       public class Handler : IRequestHandler<SözlükQuery,List<Sözlük>>
       {
            public async Task<List<Sözlük>> Handle(SözlükQuery request, CancellationToken cancellationToken)
            {
                var uow = new BlogUnitOfWork();
                var Sözlük = await uow.SözlükRepository.GetQuery()
                .ToListAsync();
                return Sözlük;
            }
        }

    }
}