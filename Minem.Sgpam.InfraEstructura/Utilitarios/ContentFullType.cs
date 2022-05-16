using System.Collections.Generic;

namespace Minem.Sgpam.InfraEstructura.Utilitarios
{
    public static class ContentFullType
    {
        public static string ObtenerTipoArchivo(string vExtension)
        {
            var vType = TiposArchivos();
            return vType[vExtension];
        }

        private static Dictionary<string, string> TiposArchivos()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }
    }
}
