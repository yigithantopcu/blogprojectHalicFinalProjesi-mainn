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
     public class SehirlerQuery: IRequest<List<Sehirler>>
     {
       public class Handler : IRequestHandler<SehirlerQuery,List<Sehirler>>
       {
           public async Task<List<Sehirler>> Handle(SehirlerQuery request, CancellationToken cancellationToken)
           {
               var uow = new BlogUnitOfWork();
               var Sehirler = await uow.SehirlerRepository.GetQuery()
               .ToListAsync();
               return Sehirler;
           }

        }

    }
}
