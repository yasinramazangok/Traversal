using Microsoft.AspNetCore.SignalR;
using TraversalSignalRApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalSignalRApi.Hubs
{
    public class VisitorHub : Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("CallVisitList", "deneme1");
        }
    }
}
