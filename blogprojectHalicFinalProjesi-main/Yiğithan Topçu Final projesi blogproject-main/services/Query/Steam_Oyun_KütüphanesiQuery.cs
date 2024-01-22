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
    public class Steam_Oyun_KütüphanesiQuery: IRequest <List<Steam_Oyun_Kütüphanesi>>
    {

        public class Handler : IRequestHandler<Steam_Oyun_KütüphanesiQuery,List<Steam_Oyun_Kütüphanesi>>
        {
            public async Task<List<Steam_Oyun_Kütüphanesi>> Handle(Steam_Oyun_KütüphanesiQuery request, CancellationToken cancellationToken)
            {
                var uow = new BlogUnitOfWork();
                var Steam_Oyun_Kütüphanesi = await uow.Steam_Oyun_KütüphanesiRepository.GetQuery()
                .ToListAsync();
                return Steam_Oyun_Kütüphanesi;
            }
        }
    }
}