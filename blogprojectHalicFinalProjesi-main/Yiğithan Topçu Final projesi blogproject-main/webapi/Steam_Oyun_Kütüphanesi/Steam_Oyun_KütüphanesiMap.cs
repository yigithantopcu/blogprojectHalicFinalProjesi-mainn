using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class Steam_Oyun_KütüphanesiMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("Steam_Oyun_Kütüphanesi", (IMediator mediator) => {
                return mediator.Send(new Steam_Oyun_KütüphanesiQuery());
            });
        }
    }
}