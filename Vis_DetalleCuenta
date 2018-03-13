//Vis_DetalleCuenta
var sFileName = "Vis_DetalleDeCuenta_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day;
CHelper.trace(sFileName,"Inicio...");
//var objEnt = Me.getXPath("entity-list('P_IC_Tipodeuso','1=1')");
var objEnt = Me.getXPath("entity-list('P_IC_Tipodeuso')");
for (var i=0; i < objEnt.size(); i++)
{
	CHelper.trace(sFileName,"Id: " + objEnt[i].getXPath("Id"));
	CHelper.trace(sFileName,"Code: " + objEnt[i].getXPath("sCodigo"));
	var sFill = "'" + objEnt[i].getXPath("sCodigo") + "'";
	var ValExist = <exists(M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita[sCodigo = sFill])>;
	CHelper.trace(sFileName,"exists? " + ValExist);
	if (ValExist == false)
	{
		CHelper.trace(sFileName,"XXX");
		var NewItm = Me.newCollectionItem("M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita");
		NewItm.setXPath("idTipodeuso",objEnt[i].getXPath("Id"));
	}
}
CHelper.trace(sFileName,"Fin...");
true;