//_1:Get número de radicación
/* ASIGNAR RADNUMBER */
//Fecha: 16-04-2015 / 26-10-2015 / 23-09-2016
var NumRad="GenRadNumber_"+ Me.Case.Id;
var sAno=DateTime.Now.Year.ToString();
var numeroRadicacion="";
//Identificar si un número de radicación preexistente
var numeroRadicacionPE=CHelper.getAttrib(10001,Me.Case.Id,"SNumeroRadicacion");
CHelper.trace(NumRad,"Preexistente: " + numeroRadicacionPE);
CHelper.trace(NumRad,"RadNumber..." + numeroRadicacionPE);
CHelper.trace(NumRad,"1."+sAno);
CHelper.trace(NumRad,"Me.Case.ProcessDefinition.Name=" + Me.Case.ProcessDefinition.Name);
if (Me.Case.ProcessDefinition.Name == "RC02_TramiteReconocimiento")
{
    trace(NumRad,"2.");if (Me.Case.ParentProcessId>0)
	{
        var obj=CHelper.getCaseById(Me.Case.ParentProcessId);
	    if(obj.ProcessDefinition.Name=="SC01_ServicioAlCiudadano")
		{
            if (obj.ApplicationEntity.GetAttribValue("M_cat_ServicioCiudadano.M_Tramite.IdP_SubtipoTramite.SCodigo") == "662")
			{   numeroRadicacion=obj.ApplicationEntity.GetAttribValue("M_cat_ServicioCiudadano.IdM_HeredaCaso.SRadCaseCerrado") + "_6";}
		else
			{numeroRadicacion=Me.Case.ParentProcessCaseNumber;}
		}
	else
		{numeroRadicacion=Me.Case.ParentProcessCaseNumber;}
	}
else
	{CHelper.trace("NumeroRadicacion","Sin Padre...");
	CHelper.ThrowValidationError("Instancia de proceso sin padre...");
	}
}
else if (Me.Case.ProcessDefinition.Name=="RecursoDeApelacion")
{trace(NumRad,"3.");if (Me.Case.ParentProcessId>0)
	{numeroRadicacion=Me.Case.ParentProcessCaseNumber + "_2";}
}
else if (Me.Case.ProcessDefinition.Name=="RC01_Reconocimiento")
{trace(NumRad,"4.Reconocimiento...");
if (Me.Case.ParentProcessId>0)
	{CHelper.trace(NumRad,"CasoConPadre...");
	CHelper.trace(NumRad,"ProcessParentId: " + Me.Case.ParentProcessId);
	CHelper.trace(NumRad,"ProcessParentRad: " + Me.Case.ParentProcessCaseNumber);
	numeroRadicacion=Me.Case.ParentProcessCaseNumber;
	CHelper.trace(NumRad,"NoRadicado... " + numeroRadicacion);
	}
else
	{CHelper.trace(NumRad,"CasoSinPadre...");
	CHelper.trace(NumRad,"Rad Dtos Generales1... " + <M_cat_Reconocimiento.IdM_DatosGenerales.SRadNumber>);
	CHelper.trace(NumRad,"Rad Dtos Generales2... " + <M_cat_Reconocimiento.id>);
	CHelper.trace(NumRad,"Rad Dtos Generales3... " + <M_cat_Reconocimiento.IdM_DatosGenerales.id>);
	CHelper.trace(NumRad,"Rad Dtos Generales4... " + <M_cat_Reconocimiento.IdM_DatosGenerales.IParenIdCase>);
	CHelper.trace(NumRad,"Rad Dtos Generales5... " + CHelper.getAttrib("M_DatosGenerales",<M_cat_Reconocimiento.IdM_DatosGenerales.id>,"IParenIdCase"));
	CHelper.trace(NumRad,"Rad Dtos Generales6... " + CHelper.getAttrib("M_DatosGenerales",<M_cat_Reconocimiento.IdM_DatosGenerales.id>,"SRadNumber"));
	if (!BAIsBlank(<M_cat_Reconocimiento.IdM_DatosGenerales.id>))
		{numeroRadicacion=CHelper.getAttrib("M_DatosGenerales",<M_cat_Reconocimiento.IdM_DatosGenerales.id>,"SRadNumber") + "_2";
		CHelper.trace(NumRad,"NoRadicado... " + numeroRadicacion);
		}
	else
		{CHelper.ThrowValidationError("Instancia de proceso sin padre y no es caso de apelacion...");}
	}
}
else if (Me.Case.ProcessDefinition.Name=="RadicacionManualReconoc")
{
    trace(NumRad,"5.");var s="";
    var nombre="NumeroRadicacion"+sAno;
    if (<M_cat_ServicioCiudadano.M_Tramite.M_VariablesRMR.BRadicadoConPadre>!=true)
	{
        CHelper.trace("IdCaso2GJ","A_RMR: " + <M_cat_ServicioCiudadano.IdM_SC01ServCiudadano.Tramite.IdM_VariablesTramiteReco.IdP_Recurso.SCodigo>);
	    CHelper.trace("IdCaso2GJ","RadRel: " + <M_cat_ServicioCiudadano.M_Tramite.M_VariablesRMR.SNoRadicadorRela>);
	if (<M_cat_ServicioCiudadano.IdM_SC01ServCiudadano.Tramite.IdM_VariablesTramiteReco.IdP_Recurso.SCodigo>=="15")
		s="_7";
	if (<M_cat_ServicioCiudadano.IdM_SC01ServCiudadano.Tramite.IdM_VariablesTramiteReco.IdP_Recurso.SCodigo>=="14")
		s="_8";
	if (s=="")
		{numeroRadicacion=sAno + "_" + CHelper.GetNextSeqValueStr(nombre) + "_9";}
	else
		{numeroRadicacion=<M_cat_ServicioCiudadano.M_Tramite.M_VariablesRMR.SNoRadicadorRela> + s;}
}
else
	{numeroRadicacion=sAno+"_"+CHelper.GetNextSeqValueStr(nombre)+"_10";}
}
else if (Me.Case.ProcessDefinition.Name == "TrasladoIngresos")
{trace(NumRad,"6.");numeroRadicacion=<M_cat_Afiliacion.M_Tramite.SNumeroRadicacion>;}
else if (Me.Case.ProcessDefinition.Name == "DocumentacionPendiente")
{trace(NumRad,"7.");numeroRadicacion=<M_Cat_DocsPendientes.M_Tramite.SNumeroRadicacion>;}
else if (Me.Case.ProcessDefinition.Name == "SC05_Redigitalizacion")
{trace(NumRad,"8.");numeroRadicacion=<M_cat_ServicioCiudadano.M_Tramite.SNumeroRadicacion>;}
else if (Me.Case.ProcessDefinition.Name == "SC02_RegistroInfo")
{trace(NumRad,"9.");if (!BAIsBlank(<M_cat_ServicioCiudadano.M_Tramite.SNumeroRadicacion>))
	{numeroRadicacion=<M_cat_ServicioCiudadano.M_Tramite.SNumeroRadicacion>;}
else
	{var nombre="NumeroRadicacion"+sAno;
	var siguienteSecuencia=CHelper.GetNextSeqValueStr(nombre);
	numeroRadicacion=sAno + "_" + siguienteSecuencia;
	}
}
else if (Me.Case.ProcessDefinition.Name == "AC01_ActualizacionDelAfili" && <BCasoRepresa>)
{trace(NumRad,"10.");numeroRadicacion=<M_Cat_Actualizacion.IdM_DatosGenerales.SNoCasoRepresa>;}
else if (Me.Case.ProcessDefinition.Name == "AC01_ActualizacionDelAfili")
{trace(NumRad,"11.");numeroRadicacion=<M_cat_Actualizacion.M_Tramite.SNumeroRadicacion>;}
else if (Me.Case.ProcessDefinition.Name == "GestionRepresaReconocimien")
{trace(NumRad,"12.");numeroRadicacion=<M_cat_Reconocimiento.IdM_DatosGenerales.SNoCasoRepresa>;}
else if (Me.Case.ProcessDefinition.Name == "GestionRepresaPQRS")
{trace(NumRad,"13.");numeroRadicacion=<M_CAT_PQRS.IdM_DatosGenerales.SNoCasoRepresa>;}
else if (Me.Case.ProcessDefinition.Name == "GestionRepresaHistoriaLabo")
{trace(NumRad,"14.");numeroRadicacion=<M_Cat_Actualizacion.IdM_DatosGenerales.SNoCasoRepresa>;}
else if (Me.Case.ProcessDefinition.Name == "RC04_CalificacionPCL" || Me.Case.ProcessDefinition.Name == "RC03_Incapacidades")
{trace(NumRad,"15.");
if(!<M_cat_Reconocimiento.M_Tramite.SNumeroRadicacion>)
	{var nombre="NumeroRadicacion"+sAno;
	var siguienteSecuencia=CHelper.GetNextSeqValueStr(nombre);
	numeroRadicacion=sAno + "_" + siguienteSecuencia;
	}
else{numeroRadicacion=<M_cat_Reconocimiento.M_Tramite.SNumeroRadicacion>;}}
else if (((Me.Case.ProcessDefinition.Name == "GestionDeNovedadesDeNomina") && (Me.Case.ParentProcessId > 0)) || (Me.Case.ProcessDefinition.Name == "EmitirCertificadoPensio"))
{trace(NumRad,"16.");numeroRadicacion=<M_cat_nomina.M_Tramite.SNumeroRadicacion>;}
else if (Me.Case.ProcessDefinition.Name == "RadicacionYSolucionDeIncid")
{trace(NumRad,"17.");if (!BAIsBlank(<M_Cat_ProcesosBA.IdM_IncidentesColp.M_DatosGenerales.SRadNumber>))
	{numeroRadicacion=<M_Cat_ProcesosBA.IdM_IncidentesColp.M_DatosGenerales.SRadNumber>;}
else
	{var nombre="NumeroConsecutivoIncidente"+sAno;
	var siguienteSecuencia=CHelper.GetNextSeqValueStr(nombre);
	numeroRadicacion="INC"+sAno + "_" + siguienteSecuencia;
	}
}
else if (Me.Case.ProcessDefinition.Name == "EmitirCertificadoPensio" && Me.Case.ParentProcessId > 0)
{trace(NumRad,"19.");
var obj=CHelper.getCaseById(Me.Case.ParentProcessId);
var ParentProcessName=obj.ProcessDefinition.DisplayName;
CHelper.trace("ParentProcessName=" + obj.ProcessDefinition.DisplayName);
if(ParentProcessName == "Generación de Certificados RPM")
	{numeroRadicacion=Me.Case.ParentProcessCaseNumber;}
}
else
{trace(NumRad,"20");var nombre="NumeroRadicacion"+sAno;
var siguienteSecuencia=CHelper.GetNextSeqValueStr(nombre);
numeroRadicacion=sAno + "_" + siguienteSecuencia;
}
CHelper.trace(NumRad,"numeroRadicacion "+numeroRadicacion);
numeroRadicacion;
//__1    