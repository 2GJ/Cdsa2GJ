//Set_ProfesionalFactibilidad
var sFileName = "Factibilidad_" + Me.Case.Id;
CHelper.trace(sFileName,"Inicio (Guarda usuario profesional de factibilidad)...");
//2GJ: Usuario asignado, se utiliza con cero por defecto por que solo debe ser un usuario asignado.
CHelper.trace(sFileName,"IdUser: " + Me.Assignees[0].Id);
<M_IC_SolicitudDeServicio.idFactibilidad.idProfdefactibilidad> = Me.Assignees[0].Id;
CHelper.setAttrib("M_IC_Factibilidad",<M_IC_SolicitudDeServicio.idFactibilidad.Id>,"idProfdefactibilidad",Me.Assignees[0].Id)
CHelper.trace(sFileName,"Fin...");