function initMap() {
    var myLatLng = { lat: 38.2559691, lng: -85.7641486 };

    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 10,
        center: myLatLng
    });

    var marker = new google.maps.Marker({
        position: myLatLng,
        map: map,
        title: "Nosey Aren't ya"
    });
}

window.dataLayer = window.dataLayer || [];
function gtag() { dataLayer.push(arguments) };
gtag('js', new Date());

gtag('config', 'UA-107099444-1');