using DemoWorkshop.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DemoWorkshop.Library.Interfaces
{
    public interface  IReqResData
    {
        Task<ReqResData> EstraiDati();
        void CancelRequest();
        Task<HttpStatusCode> CreaUtente(ReqResPost nuovoutente);
    }
}
