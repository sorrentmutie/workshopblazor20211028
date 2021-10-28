window.miaPrimaFunzione = function (nome) {
    console.log(nome);
    return "Ciao, " + nome;
}

window.secondaFunzione = function (a, b) {
    return a + b;
}

window.terzaFunzione = function () {
    DotNet.invokeMethodAsync("DemoWorkshop", "RestituisciArrayAsync")
        .then(dati => {
            console.log(dati);
            let somma = 0;
            dati.forEach(x => somma += x);
        });
}

window.sayHello = function (dotnetreferenceobject) {
    dotnetreferenceobject.invokeMethodAsync("SayHello")
        .then(risultato => console.log(risultato));
}

let map;
window.mostraMappa = function (elementoHtml, zoom, center) {

    var geocoder = new google.maps.Geocoder();
    geocoder.geocode({ 'address': center }, function (results, status) {
        if (status === 'OK') {
            var centro = results[0].geometry.location;
            map = new google.maps.Map(elementoHtml, {
                center: centro,
                zoom: zoom
            });


            var marker = new google.maps.Marker({
                map: map,
                position: centro
            });
            marker.addListener('click', function () {

                DotNet.invokeMethodAsync("DemoWorkshop", "ReturnHtml")
                    .then(html => {
                        const infowindow = new google.maps.InfoWindow({
                            content: html,
                        });
                        infowindow.open({
                            anchor: marker,
                            map,
                            shouldFocus: true,
                        });
                    });
            });
        }
    });
    
}