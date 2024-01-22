using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class Futbol_Puan_DurumuMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("Futbol_Puan_Durumu", (IMediator mediator) => {
                return mediator.Send(new Futbol_Puan_DurumuQuery());
            }); 
            
        }
    }
}