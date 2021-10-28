using DemoWorkshop.Library.Interfaces;
using DemoWorkshop.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWorkshop.Services
{
    public class DatiEventiStatici : IDatiEventi
    {
        public List<Evento> EstraiEventiFuturi()
        {
            return new List<Evento> {
            new Evento() { Id = 1, Data = DateTime.Today, Localita = "Napoli", Titolo = "Workshop Blazor"},
            new Evento() { Id = 2, Data = DateTime.Today.AddDays(1), Localita = "Roma", Titolo = "Workshop ASP.NET"},
            new Evento { Id = 3, Data = DateTime.Today.AddDays(2), Localita = "Milano", Titolo = "Workshop Blazor"}
            };
        }

        public List<Evento> EstraiEventiPassati()
        {
            return new List<Evento> {
            new Evento() { Id = 1, Data = DateTime.Today.AddDays(-1), Localita = "Napoli", Titolo = "Workshop Blazor"},
            new Evento() { Id = 2, Data = DateTime.Today.AddDays(-3), Localita = "Roma", Titolo = "Workshop ASP.NET"},
            new Evento { Id = 3, Data = DateTime.Today.AddDays(-4), Localita = "Milano", Titolo = "Workshop Blazor"}
            };
        }
    }
}
