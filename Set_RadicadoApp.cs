var sFileName = "Get_RadicadoApp_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day;
var RadNumber = "";
var Prefijo = "";
if(Me.Case.ProcessDefinition.Name == "CerrarSolicitudDeServicio")
{
    Prefijo = "i";
    RadNumber = Prefijo + CHelper.GetNextSeqValueStr("Radicado_IC");
}
else
{
	RadNumber = CHelper.GetNextSeqValueStr("Radicado_IC");
}
RadNumber;