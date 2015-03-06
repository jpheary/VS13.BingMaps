<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BingMap.aspx.cs" Inherits="VS13.BingMap" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bing Map</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script charset="UTF-8" type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="smPage" runat="server" />
        <div id='BingMap' style="position:absolute; width:98%; height:95%;"></div>
    </form>
    <script type="text/javascript">
        //Create an instance of the map control using thhe id of the div element where te map is displayed (i.e. <div id="BingMap">) 
        var map = new Microsoft.Maps.Map(document.getElementById('BingMap'), { credentials: 'Ao4MubaLZ6zgKDBHF0XFjPNRP34UrVgBjotfHHY1aLjkSYDGYXihecqHi1xU28n_' });     //The id of the div element where te map is displayed (i.e. <div id="BingMap">)

        function UnloadMap() { if (map != null) map.Dispose(); }
        function MapLocation(address) {
            if (address != null) {
                var points = new Array(address);
                for (var i = 0; i < points.length; i++) {
                    map.Find(null, points[i], null, null, 0, 10, false, false, false, true, ProcessStore);
                }
            }
            else {
                map.Clear();
                map.SetZoomLevel(1);
                map.ZoomOut();
            }
        }
        function ProcessStore(layer, results, places, hasmore) {
            //Create a custom pin
            if (places != null && places[0].LatLong != 'Unavailable') {
                var spec = new VECustomIconSpecification();
                spec.CustomHTML = "<div style='font-size:8px; border:solid 1px Black; background-color:red; width:8px;'>&nbsp;<div>";
                var pin = new VEShape(VEShapeType.Pushpin, places[0].LatLong);
                pin.SetCustomIcon(spec);
                map.AddShape(pin);
            }
        }
    </script>
</body>
</html>
