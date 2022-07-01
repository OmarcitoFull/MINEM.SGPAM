using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Visita_Persona
    { 
        public T_Sgpad_Visita_Persona()
        {

        }

        public T_Sgpad_Visita_Persona(IDataReader vRdr)
        {
			this.ID_VISITA_PERSONA = Convert.ToInt32(vRdr["ID_VISITA_PERSONA"]);

			this.ID_VISITA = Convert.ToInt32(vRdr["ID_VISITA"]);

			if (!Convert.IsDBNull(vRdr["ID_CARGO"]))
			{
				this.ID_CARGO = Convert.ToInt32(vRdr["ID_CARGO"]);
			}
			if (!Convert.IsDBNull(vRdr["DNI"]))
			{
				this.DNI = Convert.ToString(vRdr["DNI"]);
			}
			if (!Convert.IsDBNull(vRdr["NOMBRE_COMPLETO"]))
			{
				this.NOMBRE_COMPLETO = Convert.ToString(vRdr["NOMBRE_COMPLETO"]);
			}
			if (!Convert.IsDBNull(vRdr["CONTACTO"]))
			{
				this.CONTACTO = Convert.ToString(vRdr["CONTACTO"]);
			}
			if (!Convert.IsDBNull(vRdr["CORREO"]))
			{
				this.CORREO = Convert.ToString(vRdr["CORREO"]);
			}

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
			{
				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
			}

			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
			{
				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
			}

			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
			{
				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
			}

			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  
			{
				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  
			}

			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
			{
				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
			}

			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  
			{
				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  
			}

			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);


			if (!Convert.IsDBNull(vRdr["CARGO"]))
			{
				this.CARGO = Convert.ToString(vRdr["CARGO"]);
			}

		}
	}
}