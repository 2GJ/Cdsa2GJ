//Get_FechaEstimadaNot
var sFileName = "Factibilidad_" + Me.Case.Id;
CHelper.trace(sFileName,"Inicio (Get Fecha de Entrega Respuesta Temporal)...");
//2GJ: Fecha de respuesta en notificacion de respuesta temporal.
CHelper.trace(sFileName,"Fecha: " + DateTime.Now);
CHelper.trace(sFileName,"Dias Param: " + <M_IC_SolicitudDeServicio.col.idMunicipioLocalidad.iPlazodefactibilidad>);
var FixedDate = CHelper.getSolutionDate(Me,DateTime.Now,(<M_IC_SolicitudDeServicio.col.idMunicipioLocalidad.iPlazodefactibilidad> * 480));
CHelper.trace(sFileName,"Fecha Sol: " + FixedDate);
CHelper.trace(sFileName,"Fin...");
FixedDate;