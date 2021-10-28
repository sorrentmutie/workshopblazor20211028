using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWorkshop.Library.Models
{
    public class HelloHelper
    {
        private readonly string Name;

        public HelloHelper(string name)
        {
            this.Name = name;
        }

        [JSInvokable]
        public string SayHello()
        {
            return $"Ciao, {Name}";
        }

    }
}
