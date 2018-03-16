//Set_CopiaResVisita
var sFileName = "Factibilidad_" + Me.Case.Id;
CHelper.trace(sFileName,"Inicio (Copia info factibilidad)...");
//Copia tipos 2:
CHelper.trace(sFileName,"T2");
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.iEspaciosdisponibles> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.iEspaciosdisponibles>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.iNumerodeacometidas> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.iNumerodeacometidas>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.iTotalmedidores> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.iTotalmedidores>;
//Copia tipos 5:
CHelper.trace(sFileName,"T5");
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.bTieneservicio> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.bTieneservicio>;
//Copia tipos 10:
CHelper.trace(sFileName,"T10");
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.fCapacidadkVA> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.fCapacidadkVA>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.fCargaexistentekW> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.fCargaexistentekW>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.fPotenciamaximaaprobadakW> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.fPotenciamaximaaprobadakW>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.fTensionsecunV> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.fTensionsecunV>;
//Copia tipos 15 y 23:
CHelper.trace(sFileName,"T15 y T23");
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.sCondicionesdeservicio> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.sCondicionesdeservicio>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.sEquipos> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.sEquipos>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.sNoCentrodistribucion> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.sNoCentrodistribucion>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.sNombredelapersonaqueatien> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.sNombredelapersonaqueatien>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.sPuntofisico> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.sPuntofisico>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.sReddeBT> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.sReddeBT>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.sReddeMT> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.sReddeMT>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.sRespuestafactibilidad> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.sRespuestafactibilidad>;
//Copia tipos 1:
CHelper.trace(sFileName,"T1");
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idCalibre> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idCalibre.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idCalibreredaerea> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idCalibreredaerea.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idCalibreredsubterranea> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idCalibreredsubterranea.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idDireccionamiento> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idDireccionamiento.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idTensionalimentacionV> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idTensionalimentacionV.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idTensionredsubterraneaV> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idTensionredsubterraneaV.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idTipodeacometida> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idTipodeacometida.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idTipoderespuesta> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idTipoderespuesta.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idTipodeSE> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idTipodeSE.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idVoltajeaprobado> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idVoltajeaprobado.Id>;
//Tipo 1 con maestra:
CHelper.trace(sFileName,"T1 M");
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idObservacionesdelavisita.idUsuario> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idObservacionesdelavisita.idUsuario.Id>;
<M_IC_SolicitudDeServicio.idFactibilidad.Resultadofactibilidad.idObservacionesdelavisita.sObservacion> = <M_IC_SolicitudDeServicio.idFactibilidad.idResultadovisita.idObservacionesdelavisita.sObservacion>;
CHelper.trace(sFileName,"Fin (Copia info factibilidad)...");