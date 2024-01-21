using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class Hava_DurumuMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("Hava_Durumu", (IMediator mediator) => {
                return mediator.Send(new Hava_DurumuQuery());
            });
        }
    }
}