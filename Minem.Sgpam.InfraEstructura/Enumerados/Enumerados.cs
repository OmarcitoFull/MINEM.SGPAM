namespace Minem.Sgpam.InfraEstructura.Enumerados
{
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
        Datum_A = 100,
        Datum_B = 200,
        Datum_C = 300
    }

    public enum Zona
    {
        Zona_A = 10,
        Zona_B = 20,
        Zona_C = 30
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
        MODEL = 2
    }
}
