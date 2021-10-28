using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWorkshop.Library.Models
{
    public class MiaClasseJavascriptInterop: IDisposable
    {
        private readonly IJSRuntime jsRuntime;
        private DotNetObjectReference<HelloHelper> objRef;

        public MiaClasseJavascriptInterop(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public ValueTask<string> MiaPrimaFunzione(string nome)
        {
            return jsRuntime.InvokeAsync<string>("miaPrimaFunzione", nome);
        }

        public ValueTask<int> MiaSecondaFunzione(int a, int b)
        {
            return jsRuntime.InvokeAsync<int>("secondaFunzione", a, b);
        }

        public ValueTask<string> MiaTerzaFunzione()
        {
            return jsRuntime.InvokeAsync<string>("terzaFunzione");
        }

        public ValueTask MiaQuartaFunzione(string nome)
        {
            var myHelper = new HelloHelper(nome);
            objRef = DotNetObjectReference.Create(myHelper);
            return jsRuntime.InvokeVoidAsync("sayHello", objRef);

        }

        public void Dispose()
        {
            objRef?.Dispose();
        }
    }
}
