using DemoWorkshop.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWorkshop.Library.Interfaces
{
    public interface IDatiEventi
    {
        List<Evento> EstraiEventiFuturi();
        List<Evento> EstraiEventiPassati();

    }
}
