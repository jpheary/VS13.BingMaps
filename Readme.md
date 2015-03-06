VS13.BingMaps: Bing Maps Development With Visual Studio 2013
Overview -----------------------------------------------------------------------------------------------------------------------
Bing Maps is an online mapping service that enables users to search, discover, explore, plan, and share information 
about specific locations. By using enhanced road maps, labeled aerial photo views, and low-angle high-resolution aerial 
photos, Bing Maps AJAX Control 7.0, in conjunction with the Bing Maps REST Services, provides unique opportunities for 
developers to incorporate both location and local search features into their web applications, as well as into Windows 
Store apps.
The Bing Maps AJAX Control 7.0 is a JavaScript control that contains the objects, methods, and events that allow you to 
display maps powered by Bing Maps on your Web site. This solution shows how to use the Bing Maps AJAX Control 7.0 to map a 
simple address in WinForms and WebForms applications.

The Bing Maps REST Services API provides a REST interface to perform tasks such as creating a static map with pushpins, 
geocoding an address, retrieving imagery metadata, or creating a route. This solution shows how to use the REST Service
to geocode an address.


VS13.BingMaps.Web --------------------------------------------------------------------------------------------------------------
A sample WebForms application that shows how to present a Bing Map of a simple address on a web page using
the Bing Maps AJAX Control 7.0.


VS13.Enterprise.Services -------------------------------------------------------------------------------------------------------
A WCF Service that hosts a WebForm that displays a Bing Map. The WebForm, BingMap.aspx, uses the Bing Maps AJAX Control 7.0 
located online at http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0.


VS13.BingMaps.Win --------------------------------------------------------------------------------------------------------------
A sample WinForms application that shows how to present a Bing Map of a simple address on a form. The form uses a browser control
that hosts the BingMaps.aspx web page from the VS13.Enterprise.Services WCF service. An address is passed to the web page by 
invoking a sript function on the Document object hosted by the browser control. In the following, wbMap is a browser control and 
we invoke the MapLocation script function of BingMaps.aspx.

							this.wbMap.Document.InvokeScript("MapLocation", new object[] { address }); 
