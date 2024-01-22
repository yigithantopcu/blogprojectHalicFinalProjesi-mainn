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
    public class Futbol_Puan_DurumuQuery: IRequest<List<Futbol_Puan_Durumu>>
    {
        public class Handler : IRequestHandler<Futbol_Puan_DurumuQuery,List<Futbol_Puan_Durumu>>
        {
            public async Task<List<Futbol_Puan_Durumu>> Handle(Futbol_Puan_DurumuQuery request, CancellationToken cancellationToken)
            {
                var uow = new BlogUnitOfWork();
                var Futbol_Puan_Durumu = await uow.Futbol_Puan_DurumuRepository.GetQuery()
                .ToListAsync();
                return Futbol_Puan_Durumu;
            }
        }
    }
}