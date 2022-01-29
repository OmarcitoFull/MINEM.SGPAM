using System;
using System.Linq;
using System.Collections.Generic;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
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
    public class T_Sgpad_Comp_MedicionLN : BaseLN, IT_Sgpad_Comp_MedicionLN
    {
        private readonly IT_Sgpad_Comp_MedicionAD Comp_MedicionAD;

        public T_Sgpad_Comp_MedicionLN(IT_Sgpad_Comp_MedicionAD vT_Sgpad_Comp_MedicionAD)
        {
            Comp_MedicionAD = vT_Sgpad_Comp_MedicionAD;
        }

        public IEnumerable<Comp_MedicionDTO> ListarComp_MedicionDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_MedicionAD.ListarT_Sgpad_Comp_Medicion(vIdComponente)
                                  select new Comp_MedicionDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Caudal = vTmp.CAUDAL,
                                      Conductividad = vTmp.CONDUCTIVIDAD,
                                      Fecha_Desicion = vTmp.FECHA_DESICION,
                                      Id_Comp_Medicion = vTmp.ID_COMP_MEDICION,
                                      Observacion = vTmp.OBSERVACION,
                                      Ph = vTmp.PH
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_MedicionDTO RecuperarComp_MedicionDTOPorCodigo(int vId_Comp_Medicion)
        {
            try
            {
                var vResultado = Comp_MedicionAD.RecuperarT_Sgpad_Comp_MedicionPorCodigo(vId_Comp_Medicion);
                return new Comp_MedicionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_MedicionDTO GrabarComp_MedicionDTO(Comp_MedicionDTO vComp_MedicionDTO)
        {
            try
            {
                if (vComp_MedicionDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Medicion
                    {
                        FEC_INGRESO = vComp_MedicionDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_MedicionDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_MedicionDTO.Flg_Estado,
                        IP_INGRESO = vComp_MedicionDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_MedicionDTO.Ip_Modifica,
                        USU_INGRESO = vComp_MedicionDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_MedicionDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_MedicionDTO.Id_Componente,
                        CAUDAL = vComp_MedicionDTO.Caudal,
                        CONDUCTIVIDAD = vComp_MedicionDTO.Conductividad,
                        FECHA_DESICION = vComp_MedicionDTO.Fecha_Desicion,
                        ID_COMP_MEDICION = vComp_MedicionDTO.Id_Comp_Medicion,
                        OBSERVACION = vComp_MedicionDTO.Observacion,
                        PH = vComp_MedicionDTO.Ph
                    };
                    if (vComp_MedicionDTO.Id_Comp_Medicion == 0)
                    {
                        var vResultado = Comp_MedicionAD.InsertarT_Sgpad_Comp_Medicion(vRegistro);
                        vComp_MedicionDTO.Id_Comp_Medicion = vResultado.ID_COMP_MEDICION;
                    }
                    else
                    {
                        var vResultado = Comp_MedicionAD.ActualizarT_Sgpad_Comp_Medicion(vRegistro);
                        vComp_MedicionDTO = RecuperarComp_MedicionDTOPorCodigo(vResultado.ID_COMP_MEDICION);
                    }
                }
                return vComp_MedicionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_MedicionDTOPorCodigo(Comp_MedicionDTO vComp_MedicionDTO)
        {
            try
            {
                return Comp_MedicionAD.AnularT_Sgpad_Comp_MedicionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_MedicionDTO> ListarPaginadoComp_MedicionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_MedicionAD.ListarPaginadoT_Sgpad_Comp_Medicion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_MedicionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
