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
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	20/02/2022
    /// </summary>
    public class T_Sgpal_InspectorLN : BaseLN, IT_Sgpal_InspectorLN
    {
        private readonly IT_Sgpal_InspectorAD InspectorAD;

        public T_Sgpal_InspectorLN(IT_Sgpal_InspectorAD vT_Sgpal_InspectorAD)
        {
            InspectorAD = vT_Sgpal_InspectorAD;
        }

        public IEnumerable<InspectorDTO> ListarInspectorDTO()
        {
            try
            {
                var vResultado = (from vTmp in InspectorAD.ListarT_Sgpal_Inspector()
                                  select new InspectorDTO
                                  {
                                      Nom_Inspector = vTmp.NOMBRE,
                                      Ape_Paterno = vTmp.APE_PATERNO,
                                      Ape_Materno = vTmp.APE_MATERNO,
                                      Nombre_Completo = vTmp.NOMBRE + ", "+ vTmp.APE_PATERNO + " " + vTmp.APE_MATERNO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Inspector = vTmp.ID_INSPECTOR,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public InspectorDTO RecuperarInspectorDTOPorCodigo(int vId_Inspector)
        {
            try
            {
                var vResultado = InspectorAD.RecuperarT_Sgpal_InspectorPorCodigo(vId_Inspector);
                return new InspectorDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public InspectorDTO InsertarInspectorDTO(InspectorDTO vInspectorDTO)
        {
            throw new NotImplementedException();
        }

        public InspectorDTO ActualizarInspectorDTO(InspectorDTO vInspectorDTO)
        {
            throw new NotImplementedException();
        }

        public int AnularInspectorDTOPorCodigo(InspectorDTO vInspectorDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InspectorDTO> ListarPaginadoInspectorDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            throw new NotImplementedException();
        }

    }
}
