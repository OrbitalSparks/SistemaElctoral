using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NPOI.SS.Formula.Functions;

namespace ElectoralDatastore
{
    public class PersonaRepository
    {
       // BDOperation<T> dBOperation = new BDOperation<T>();
       //// public int CreatePersona(DatosPersonales newpersona)
       // {
       //     int result;
       //     string SQLinsert = @"INSERT INTO DatosPersonales (nroDocumento,empresa,emaail,nombre,apellido,Idcodarea,codarea,telefono,IdGenero,Idpaais,Fechanaciiento)
       //         OUTPUT INSERTED.Idpersona
       //         VALUES
       //         @nroDocumento,@empresa,@emaail,@nombre,@apellido,@Idcodarea,@codarea,@telefono,@IdGenero,@Idpaais,@Fechanaciiento);";
       //     var listparams = new
       //     {
       //         nroDocumento = newpersona.NroDocumento,
       //         empresa = newpersona.Empresa,
       //         emaail = newpersona.Email,
       //         nombre = newpersona.Nombre,
       //         apellido = newpersona.Apellido,
       //         Idcodarea = newpersona.Area,
       //         codarea = newpersona.NroDocumento,
       //         telefono = newpersona.Telefono,
       //         IdGenero = newpersona.Genero,
       //         Idpaais = newpersona.Pais,
       //         Fechanaciiento = newpersona.Edad

       //     };

       //     result = dBOperation.OperationExecute(SQLinsert, listparams);
       //     return result;
       // }
    }

}
