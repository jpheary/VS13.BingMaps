<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Address.aspx.cs" Inherits="VS13.WebForm1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bing Maps</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script charset="UTF-8" type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0"></script>
    <script type="text/javascript" src="BingMap.js"></script>
    <script type="text/javascript">
        function updateMap() {
            //onchange event handler- map the address
            var street = document.getElementById('<%=txtStreet.ClientID %>').value;
            var city = document.getElementById('<%=txtCity.ClientID %>').value;
            var state = document.getElementById('<%=txtState.ClientID %>').value;
            var zip = document.getElementById('<%=txtZip.ClientID %>').value;
            if(city.length>0 && state.length==2 && zip.length==5) {
                var address = street + ' ' + city + ', ' + state + ' ' + zip;
                MapAddress(address);
            }
        }
    </script>
</head>
<body onload="GetMap();">
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" />
        <div style="width:1200px; background-color:ButtonFace; border:2px solid black; margin:0px auto 0px auto; padding: 25px 25px; font-family:Calibri">
            <div style="margin: 10px 0px 0px 0px; padding: 0px 0px 0px 5px; color: #000000; font-size: 18px; font-weight: 500; text-align: left;">Bing Map An Address</div>
            <div style="float:left; width:450px; margin:10px 0px 10px 0px; padding:0px 0px 0px 25px">
                <table>
                    <tr><td style=" width:100px; padding:5px 10px 0px 0px; font-size:12px; font-weight:bold; text-align:right;">Street</td><td><asp:TextBox ID="txtStreet" runat="server" Width="300px" onchange="javascript: updateMap();" /></td></tr>
                    <tr><td style="padding:5px 10px 0px 0px; font-size:12px; font-weight:bold; text-align:right;">City</td><td><asp:TextBox ID="txtCity" runat="server" Width="200px" onchange="javascript: updateMap();" /></td></tr>
                    <tr><td style="padding:5px 10px 0px 0px; font-size:12px; font-weight:bold; text-align:right;">State</td><td><asp:TextBox ID="txtState" runat="server" Width="50px" MaxLength="2" onchange="javascript: updateMap();" /></td></tr>
                    <tr><td style="padding:5px 10px 0px 0px; font-size:12px; font-weight:bold; text-align:right;">Zip</td><td><asp:TextBox ID="txtZip" runat="server" Width="75px" MaxLength="5" onchange="javascript: updateMap();" /></td></tr>
                </table>
            </div>
            <div style="float:left; margin:12px 0px 0px 60px; padding:0px 0px 0px 0px; border-style:solid; border-color:#ee2a24">
                <div id="BingMap" style="position:relative; width:640px; height:480px"></div>
            </div>
            <div style="clear:both"></div>
        </div>
    </form>
</body>
</html>
