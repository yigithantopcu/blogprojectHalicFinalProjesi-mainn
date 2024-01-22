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
    public class FilmlerQuery: IRequest<List<Filmler>>
    {
        public class Handler : IRequestHandler<FilmlerQuery,List<Filmler>>
        {
            public async Task<List<Filmler>> Handle(FilmlerQuery request, CancellationToken cancellationToken)
            {
                var uow = new BlogUnitOfWork();
                var Filmler = await uow.FilmlerRepository.GetQuery()
                .ToListAsync();
                return Filmler;
            }
        }
    }
}