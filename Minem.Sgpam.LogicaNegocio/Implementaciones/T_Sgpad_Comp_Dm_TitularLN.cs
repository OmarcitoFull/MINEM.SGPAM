using System;
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
    public class T_Sgpad_Comp_Dm_TitularLN : BaseLN, IT_Sgpad_Comp_Dm_TitularLN
    {
        private readonly IT_Sgpad_Comp_Dm_TitularAD Comp_Dm_TitularAD;

        public T_Sgpad_Comp_Dm_TitularLN(IT_Sgpad_Comp_Dm_TitularAD vT_Sgpad_Comp_Dm_TitularAD)
        {
            Comp_Dm_TitularAD = vT_Sgpad_Comp_Dm_TitularAD;
        }

        public IEnumerable<Comp_Dm_TitularDTO> ListarComp_Dm_TitularDTO()
        {
            try
            {
                var vResultado = Comp_Dm_TitularAD.ListarT_Sgpad_Comp_Dm_Titular();
                return new List<Comp_Dm_TitularDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Dm_TitularDTO RecuperarComp_Dm_TitularDTOPorCodigo(int vId_Comp_Dm_Titular)
        {
            try
            {
                var vResultado = Comp_Dm_TitularAD.RecuperarT_Sgpad_Comp_Dm_TitularPorCodigo(vId_Comp_Dm_Titular);
                return new Comp_Dm_TitularDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Dm_TitularDTO InsertarComp_Dm_TitularDTO(Comp_Dm_TitularDTO vComp_Dm_TitularDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Comp_Dm_Titular();
                var vResultado = Comp_Dm_TitularAD.InsertarT_Sgpad_Comp_Dm_Titular(vRegistro);
                return vComp_Dm_TitularDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Dm_TitularDTO ActualizarComp_Dm_TitularDTO(Comp_Dm_TitularDTO vComp_Dm_TitularDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Comp_Dm_Titular();
                var vResultado = Comp_Dm_TitularAD.ActualizarT_Sgpad_Comp_Dm_Titular(vRegistro);
                return vComp_Dm_TitularDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularComp_Dm_TitularDTOPorCodigo(Comp_Dm_TitularDTO vComp_Dm_TitularDTO)
        {
            try
            {
                return Comp_Dm_TitularAD.AnularT_Sgpad_Comp_Dm_TitularPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Dm_TitularDTO> ListarPaginadoComp_Dm_TitularDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Dm_TitularAD.ListarPaginadoT_Sgpad_Comp_Dm_Titular(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Dm_TitularDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Dm_TitularDTO> ListarPorIdEumComp_Dm_Titular(int vId_Eum)
        {
            try
            {
                var  vResultado = Comp_Dm_TitularAD.ListarPorIdEumT_Sgpad_Comp_Dm_Titular(vId_Eum);
                if (vResultado != null)
                {
                    List<Comp_Dm_TitularDTO> vLista = new List<Comp_Dm_TitularDTO>();
                    Comp_Dm_TitularDTO vEntidad;
                    foreach (T_Sgpad_Comp_Dm_Titular item in vResultado)
                    {
                        vEntidad = new Comp_Dm_TitularDTO()
                        {
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Fecha_Fin = item.FECHA_FIN,
                            Fecha_Inicio = item.FECHA_INICIO,
                            Id_Comp_Dm = item.ID_COMP_DM,
                            Id_Comp_Dm_Titular = item.ID_COMP_DM_TITULAR,
                            Id_Empresa = item.ID_EMPRESA,
                            Estado = item.ESTADO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,
                            Nombre_Dm = item.NOMBRE_DM,
                            Titular = item.NOMBRE
                        };
                        vLista.Add(vEntidad);
                    }
                    return vLista;
                }
                return null;

            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
