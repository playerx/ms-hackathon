using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MS.Hackathon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PushTemperature(decimal? id)
        {
            if (id.HasValue)
            {
                GlobalHost.ConnectionManager.GetHubContext<RealtimeHub>().Clients.All.NewTemperature(id);
            }

            return new EmptyResult();
        }

        public ActionResult Client()
        {
            return View();
        }
    }

    public class RealtimeHub : Hub
    {
        public override System.Threading.Tasks.Task OnConnected()
        {
            return base.OnConnected();
        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public void InfoUpdate(decimal temp)
        {
            Clients.All.NewTemperature(temp);
        }
    }


}