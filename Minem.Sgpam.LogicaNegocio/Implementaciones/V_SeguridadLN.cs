using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.InfraEstructura.Enumerados;
using Minem.Sgpam.LogicaNegocio.Base;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Minem.Sgpam.LogicaNegocio.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que implementa la lógica del negocio para las operaciones de las entidades
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public class V_SeguridadLN : BaseLN, IV_SeguridadLN
    {
        private readonly IV_SeguridadAD SeguridadAD;

        public V_SeguridadLN(IV_SeguridadAD vIV_SeguridadAD)
        {
            SeguridadAD = vIV_SeguridadAD;
        }

        public SessionUserDto ObtenerUsuarioRoles(int vAplicacion, string vUsuario)
        {
            try
            {
                var vListaTmp = SeguridadAD.ListarUsuarioRoles(vAplicacion, vUsuario);
                var vTmp = vListaTmp.First();
                SessionUserDto vRecord = new SessionUserDto();
                vRecord.SystemID = vTmp.Id_Sis;
                vRecord.SessionName = vTmp.Des_Usuario;
                vRecord.UserId = vTmp.Id_Usuario;
                vRecord.UserName = vTmp.Des_Nombre;
                vRecord.Roles = vListaTmp.Select(x => new UserRolesUserDto { RoleId = x.Id_Rol, RoleName = x.Des_Rol }).ToList();
                return vRecord;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public List<RoleOptionsDto> ObtenerRolOpciones(int vAplicacion, int vRol)
        {
            try
            {
                var vListaTmp = SeguridadAD.ListarRolOpciones(vAplicacion, vRol);
                var vResult = vListaTmp.Select(x => new RoleOptionsDto
                {
                    OptionID = x.Id_Opcion,
                    OptionName = x.Des_Opcion,
                    ParentOption = x.Id_Opcion_Padre,
                    NumberOrder = x.Num_Orden
                }).ToList();
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}