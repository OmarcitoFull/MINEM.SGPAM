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

        public List<ReinfoDerechosMinerosDTO> Listar_ReinfoDerechosMineros()
        {
            try
            {
                var vResultado = (from vTmp in ExternosAD.Listar_ReinfoDerechosMineros()
                                  select new ReinfoDerechosMinerosDTO
                                  {
                                      Codigo = vTmp.CODIGO,
                                      Departamento = vTmp.DEPARTAMENTO,
                                      Distrito = vTmp.DISTRITO,
                                      Estado_Vigencia = vTmp.ESTADO_VIGENCIA,
                                      Este_Psad56 = vTmp.ESTE_PSAD56,
                                      Este_Wgs84_1p = vTmp.ESTE_WGS84_1P,
                                      Este_Wgs84_2p = vTmp.ESTE_WGS84_2P,
                                      Minero = vTmp.MINERO,
                                      Nombre = vTmp.NOMBRE,
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

        public List<SituacionPrincipalesProductosDTO> Listar_SituacionPrincipalesProductos()
        {
            try
            {
                var vResultado = (from vTmp in ExternosAD.Listar_SituacionPrincipalesProductos()
                                  select new SituacionPrincipalesProductosDTO
                                  {
                                      Anopro = vTmp.ANOPRO,
                                      Cantidad = vTmp.CANTIDAD,
                                      Id_Cliente = vTmp.ID_CLIENTE,
                                      Id_Unidad = vTmp.ID_UNIDAD,
                                      Nombre = vTmp.NOMBRE,
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

        public List<TitularesReferencialesDerechosDTO> Listar_TitularesReferencialesDerechos()
        {
            try
            {
                var vResultado = (from vTmp in ExternosAD.Listar_TitularesReferencialesDerechos()
                                  select new TitularesReferencialesDerechosDTO
                                  {
                                      Estado = vTmp.ESTADO,
                                      Fecha_Final = vTmp.FECHA_FINAL,
                                      Fecha_Inicio = vTmp.FECHA_INICIO,
                                      Titular_Referencial = vTmp.TITULAR_REFERENCIAL
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public List<DerechosMinerosDTO> Listar_DerechosMineros()
        {
            try
            {
                var vResultado = (from vTmp in ExternosAD.Listar_DerechosMineros()
                                  select new DerechosMinerosDTO
                                  {
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
    }
}
