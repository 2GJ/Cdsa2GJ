//Vis_DetalleCuenta
var sFileName = "Vis_DetalleDeCuenta_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day;
CHelper.trace(sFileName,"Inicio...");
var ValExist = <exists(M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita)>;
if (ValExist == false)
{
	var objEnt = Me.getXPath("entity-list('P_IC_Tipodeuso')");
	for (var i=0; i < objEnt.size(); i++)
	{
		CHelper.trace(sFileName,"Id: " + objEnt[i].getXPath("Id"));
		CHelper.trace(sFileName,"Code: " + objEnt[i].getXPath("sCodigo"));
		var sFill = "'" + objEnt[i].getXPath("sCodigo") + "'";
		CHelper.trace(sFileName,"XXX");
		var DetalleCuenta = Me.newCollectionItem("M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita");
		DetalleCuenta.setXPath("idTipodeuso",objEnt[i].getXPath("Id"));
	}
//<iRegistroscuentas> = <count(col_Detallelocalizaciones)>
<iTotaldetallecuentas> = <count(col_DetalleCuentaSolicita)>;
}
CHelper.trace(sFileName,"Fin...");
true;