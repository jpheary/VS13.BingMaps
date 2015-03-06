var map = null;                 //Bing Map object
var searchManager = null;       //Search Manager for geocoding address to long/lat
function GetMap() {
    //Create map instance and load the search module
    //The id of the div element where te map is displayed (i.e. <div id="BingMap">)
    map = new Microsoft.Maps.Map(document.getElementById('BingMap'), { credentials: 'Ao4MubaLZ6zgKDBHF0XFjPNRP34UrVgBjotfHHY1aLjkSYDGYXihecqHi1xU28n_' });
    Microsoft.Maps.loadModule('Microsoft.Maps.Search', { callback: searchModuleLoaded });
}
function MapAddress(address) {
    //Map an address; need to geocode the address which is an async operation
    if (address != null) {
        var geocodeRequest = { where: address, count: 10, callback: geocodeCallback, errorCallback: geocodeError };
        searchManager.geocode(geocodeRequest);
    }
    else {
        map.Clear();
        map.SetZoomLevel(1);
        map.ZoomOut();
    }
}
function searchModuleLoaded() { searchManager = new Microsoft.Maps.Search.SearchManager(map); }
function geocodeCallback(geocodeResult, userData) {
    if (geocodeResult.results.length > 0) {
        map.setView({ zoom: 10, center: geocodeResult.results[0].location })

        map.entities.clear();
        var pushpin = new Microsoft.Maps.Pushpin(map.getCenter(), null);
        map.entities.push(pushpin);
        pushpin.setLocation(geocodeResult.results[0].location);
    }
}
function geocodeError(searchRequest) { alert("An error occurred."); }

