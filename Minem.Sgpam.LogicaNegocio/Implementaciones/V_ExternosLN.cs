using System;
using System.Linq;
using System.Collections.Generic;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.LogicaNegocio.Base;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;

namespace Minem.Sgpam.LogicaNegocio.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que implementa la lógica del negocio para las operaciones de las entidades
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public class V_ExternosLN : BaseLN, IV_ExternosLN
    {
        private readonly IV_ExternosAD ExternosAD;

        public V_ExternosLN(IV_ExternosAD vIV_ExternosAD)
        {
            ExternosAD = vIV_ExternosAD;
        }

        public void Insertar_DerechosMineros(ComponenteDTO vComponenteDTO)
        {
            try
            {
                var vParametros = new Entidades.V_Ext_Parametros
                {
                    ID_COMPONENTE = vComponenteDTO.Id_Componente,
                    ID_ZONA = vComponenteDTO.Id_Zona,
                    ID_DATUM = vComponenteDTO.Id_Datum,
                    ESTE = vComponenteDTO.Este,
                    NORTE = vComponenteDTO.Norte,
                    UBIGEO = vComponenteDTO.Ubigeo,
                    USU_INGRESO = vComponenteDTO.Usu_Ingreso,
                    FEC_INGRESO = vComponenteDTO.Fec_Ingreso,
                    IP_INGRESO = vComponenteDTO.Ip_Ingreso
                };

                ExternosAD.Insertar_DerechosMineros(vParametros);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public List<DerechosMinerosDTO> Listar_DerechosMineros(int vId_Componente)
        {
            try
            {
                var vResultado = (from vTmp in ExternosAD.Listar_DerechosMineros(vId_Componente)
                                  select new DerechosMinerosDTO
                                  {
                                      Id = vTmp.ID,
                                      Codigo = vTmp.CODIGO,
                                      Estado = vTmp.ESTADO,
                                      Fecha_Caducidad = vTmp.FECHA_CADUCIDAD,
                                      Fecha_Resolucion = vTmp.FECHA_RESOLUCION,
                                      Nombre = vTmp.NOMBRE,
                                      Resolucion = vTmp.RESOLUCION,
                                      Resolucion_Caducidad = vTmp.RESOLUCION_CADUCIDAD,
                                      Situacion = vTmp.SITUACION,
                                      Sustancia = vTmp.SUSTANCIA,
                                      Tipo = vTmp.TIPO,
                                      UEA = vTmp.UEA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }


        public void Insertar_SituacionPrincipalesProductos(ComponenteDTO vComponenteDTO)
        {
            try
            {
                var vParametros = new Entidades.V_Ext_Parametros
                {
                    ID_COMPONENTE = vComponenteDTO.Id_Componente,
                    ID_COMP_DM = vComponenteDTO.Id_DerechoMinero,
                    USU_INGRESO = vComponenteDTO.Usu_Ingreso,
                    FEC_INGRESO = vComponenteDTO.Fec_Ingreso,
                    IP_INGRESO = vComponenteDTO.Ip_Ingreso
                };

                ExternosAD.Insertar_SituacionPrincipalesProductos(vParametros);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public List<SituacionPrincipalesProductosDTO> Listar_SituacionPrincipalesProductos(int vId_Componente)
        {
            try
            {
                var vResultado = (from vTmp in ExternosAD.Listar_SituacionPrincipalesProductos(vId_Componente)
                                  select new SituacionPrincipalesProductosDTO
                                  {
                                      Anio = vTmp.ANIO,
                                      Cantidad = vTmp.CANTIDAD,
                                      Id_Cliente = vTmp.ID_CLIENTE,
                                      Id_Unidad = vTmp.ID_UNIDAD,
                                      Nombre_Cliente = vTmp.NOMBRE_CLIENTE,
                                      Nombre_Unidad = vTmp.NOMBRE_UNIDAD,
                                      Situacion = vTmp.SITUACION,
                                      Tipo_Concentrado = vTmp.TIPO_CONCENTRADO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }


        public void Insertar_TitularesReferenciales(ComponenteDTO vComponenteDTO)
        {
            try
            {
                var vParametros = new Entidades.V_Ext_Parametros
                {
                    ID_COMPONENTE = vComponenteDTO.Id_Componente,
                    ID_COMP_DM = vComponenteDTO.Id_DerechoMinero,
                    USU_INGRESO = vComponenteDTO.Usu_Ingreso,
                    FEC_INGRESO = vComponenteDTO.Fec_Ingreso,
                    IP_INGRESO = vComponenteDTO.Ip_Ingreso
                };

                ExternosAD.Insertar_TitularesReferenciales(vParametros);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public List<TitularesReferencialesDerechosDTO> Listar_TitularesReferencialesDerechos(int vId_Componente)
        {
            try
            {
                var vResultado = (from vTmp in ExternosAD.Listar_TitularesReferencialesDerechos(vId_Componente)
                                  select new TitularesReferencialesDerechosDTO
                                  {
                                      Estado = vTmp.ESTADO,
                                      Fecha_Final = vTmp.FECHA_FINAL.GetValueOrDefault().ToShortDateString(),
                                      Fecha_Inicio = vTmp.FECHA_INICIO.ToShortDateString(),
                                      Titular_Referencial = vTmp.TITULAR_REFERENCIAL,
                                      Codigo = vTmp.CODIGO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }


        public void Insertar_ReinfoDerechosMineros(ComponenteDTO vComponenteDTO)
        {
            try
            {
                var vParametros = new Entidades.V_Ext_Parametros
                {
                    ID_COMPONENTE = vComponenteDTO.Id_Componente,
                    ID_COMP_DM = vComponenteDTO.Id_DerechoMinero,
                    USU_INGRESO = vComponenteDTO.Usu_Ingreso,
                    FEC_INGRESO = vComponenteDTO.Fec_Ingreso,
                    IP_INGRESO = vComponenteDTO.Ip_Ingreso
                };

                ExternosAD.Insertar_ReinfoDerechosMineros(vParametros);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public List<ReinfoDerechosMinerosDTO> Listar_ReinfoDerechosMineros(int vId_Componente)
        {
            try
            {
                var vResultado = (from vTmp in ExternosAD.Listar_ReinfoDerechosMineros(vId_Componente)
                                  select new ReinfoDerechosMinerosDTO
                                  {
                                      Codigo_Dm = vTmp.CODIGO_DM,
                                      Departamento = vTmp.DEPARTAMENTO,
                                      Distrito = vTmp.DISTRITO,
                                      Estado = vTmp.ESTADO,
                                      Este_Psad56 = vTmp.ESTE_PSAD56,
                                      Este_Wgs84_1p = vTmp.ESTE_WGS84_1P,
                                      Este_Wgs84_2p = vTmp.ESTE_WGS84_2P,
                                      Minero = vTmp.MINERO,
                                      Nombre_Dm = vTmp.NOMBRE_DM,
                                      Norte_Psad56 = vTmp.NORTE_PSAD56,
                                      Norte_Wgs84_1p = vTmp.NORTE_WGS84_1P,
                                      Norte_Wgs84_2p = vTmp.NORTE_WGS84_2P,
                                      Provincia = vTmp.PROVINCIA,
                                      Ruc = vTmp.RUC,
                                      Tipo_Actividad = vTmp.TIPO_ACTIVIDAD
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        

        public List<CuencaDTO> Listar_Cuenca(int vId_Componente)
        {
            try
            {
                var vResultado = (from vTmp in ExternosAD.Listar_Cuenca(vId_Componente)
                                  select new CuencaDTO
                                  {
                                      Id_Cuenca = vTmp.ID_CUENCA,
                                      Descripcion = vTmp.DESCRIPCION
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
