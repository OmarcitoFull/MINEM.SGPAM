namespace Minem.Sgpam.InfraEstructura
{
    /// <summary>
    /// Objetivo:	Insertar las variables constantes que se invocan en toda la solución
    /// Creado Por:	(ORM) Omar Rodriguez M.
    /// Fecha Creación:	01/12/2021
    /// </summary>
    public static class Constantes
    {
        public const string BD = "OracleBD";
        public const string ServiceRoute = "ASPNETCORE.SGPAM";
        public const string Ok = "OK";
        public const string Error = "ERROR";
        public const string Activo = "1";
        public const string Inactivo = "0";

        public const string MsgOk = "Operacion exitosa";
        public const string MsgErr = "Ocurrió un error al grabar en el servidor";
        public const string MsgModel = "Falta completar datos";
        public const string MsgModelImg = "Formato de imagen no aceptado";
        public const string MsgModelDoc = "Formato de docuemnto no aceptado";

        //variables para eliminar
        public const string MsgDelOk = "Su archivo ha sido eliminado.";
        public const string MsgDelKo = "No se elimino el archivo.";


        public const string GuestUser = "ORODRIGUEZ";

        public const string ContentTypeDOC = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
        public const string ContentTypeJPG = "image/jpeg";

    }
}
