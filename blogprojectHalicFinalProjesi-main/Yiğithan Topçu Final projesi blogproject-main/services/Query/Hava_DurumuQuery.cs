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
    public class Hava_DurumuQuery: IRequest<List<Hava_Durumu>>
   {

       public class Handler : IRequestHandler<Hava_DurumuQuery,List<Hava_Durumu>>
       {
           public async Task<List<Hava_Durumu>> Handle(Hava_DurumuQuery request, CancellationToken cancellationToken)
           { 
               var uow = new BlogUnitOfWork();
               var Hava_Durumu = await uow.Hava_DurumuRepository.GetQuery()
               .ToListAsync();
               return Hava_Durumu; 
           }
        } 
    }
}   