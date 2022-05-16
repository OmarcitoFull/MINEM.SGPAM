namespace Minem.Sgpam.InfraEstructura.Enumerados
{
    /// <summary>
    /// Objetivo:	Insertar los enumerable que se invocan en toda la solución
    /// Creado Por:	(ORM) Omar Rodriguez M.
    /// Fecha Creación:	01/12/2021
    /// </summary>
    public enum TipoPam
    {
        LABOR_MINERA = 1,
        RESIDUO_MINERO = 2,
        OTRO_RESIDUO = 3,
        INFRAESTRUCTURA = 4,
        SUSTANCIA_QUIMICA = 5
    }

    public enum TipoMineria
    {
        MINERIA_SUBTERRANEA = 1,
        MINERIA_SUPERFICIAL = 2
    }

    public enum Datum
    {
        Psad56 = 1,
        Wgs81 = 2
    }

    public enum Zona
    {
        Zona_17 = 17,
        Zona_18 = 18,
        Zona_19 = 19
    }

    public enum CuencaPrincipal
    {
        Cuenca_1 = 1,
        Cuenca_2 = 2,
        Cuenca_3 = 3
    }

    public enum CuencaSecundario
    {
        Cuenca_A = 1,
        Cuenca_B = 2,
        Cuenca_C = 3
    }

    public enum TipoErr
    {
        SERVER = 1,
        MODEL = 2,
        LASERFICHE = 3
    }
}
