//Name: Val_CrearSolServicio
var sFileName = "Val_CrearSolServicio_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day;
CHelper.trace(sFileName,"Inicio...");
//2GJ: Validar que al menos se registre un valor mayor a 0 en la tabla de detalle de cuentas.
var RegTotal = <count(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita>)>;
CHelper.trace(sFileName,"RegTotal: " + RegTotal);
var SumMono = <sum(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita.iMonofasicas>)>;
CHelper.trace(sFileName,"SumMono: " + SumMono);
var SumBi = <sum(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita.iBifasicas>)>;
CHelper.trace(sFileName,"SumBi: " + SumBi);
var SumTri = <sum(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita.iTrifasicas>)>;
CHelper.trace(sFileName,"SumTri: " + SumTri);
if ((SumMono + SumBi + SumTri) <= 0)
{
	CHelper.ThrowValidationError("Debe ingresar por lo menos un contador en el detalle de cuentas.");
}
if (<M_IC_SolicitudDeServicio.iCuentasfinalesdelpredio> < (SumMono + SumBi + SumTri))
{
	CHelper.ThrowValidationError("El número de cuentas finales del predio debe ser mayor o igual al número total de contadores ingresados en el detalle de cuentas.");
}
//Validar si el tipo de servicio solicitado es igual a "Provisional de obra" o "Transitorio"·, en la tabla "Detalle de cuentas" solo se registren cuentas cuyo tipo de uso sea "Provisional de obra".
var SumMonoF = <sum(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita[idTipodeuso.sCodigo != '05'].iMonofasicas>)>;
var SumBiF = <sum(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita[idTipodeuso.sCodigo != '05'].iBifasicas>)>;
var SumTriF = <sum(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita[idTipodeuso.sCodigo != '05'].iTrifasicas>)>;
if ((<M_IC_SolicitudDeServicio.idServicioSolicitado.sCodigo> == "09" ||
		<M_IC_SolicitudDeServicio.idServicioSolicitado.sCodigo> == "11") &&
		(SumMonoF + SumBiF + SumTriF) > 0)
{
	CHelper.ThrowValidationError("Para el tipo de servicio solicitado " + <M_IC_SolicitudDeServicio.idServicioSolicitado.sDescripcion> + " no se puede ingresar cuentas diferentes a tipo Provisional de obra.");
}
//En caso de que el tipo de servicio solicitado sea distinto a "Provisional de obra" o "Transitorio", en la tabla "Detalle de cuentas" no se deben registrar cuentas cuyo tipo de uso sea "Provisional de obra".
var SumMonoD = <sum(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita[idTipodeuso.sCodigo = '05'].iMonofasicas>)>;
var SumBiD = <sum(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita[idTipodeuso.sCodigo = '05'].iBifasicas>)>;
var SumTriD = <sum(<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita[idTipodeuso.sCodigo = '05'].iTrifasicas>)>;
if ((<M_IC_SolicitudDeServicio.idServicioSolicitado.sCodigo> != "09" &&
		<M_IC_SolicitudDeServicio.idServicioSolicitado.sCodigo> != "11") &&
		(SumMonoD + SumBiD + SumTriD) > 0)
{
	CHelper.ThrowValidationError("Para el tipo de servicio solicitado " + <M_IC_SolicitudDeServicio.idServicioSolicitado.sDescripcion> + " no se puede ingresar cuentas de tipo Provisional de obra.");
}
CHelper.trace(sFileName,"Fin...");
<M_IC_SolicitudDeServicio.col_DetalleCuentaSolicita.idTipodeuso.sCodigo>