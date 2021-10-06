using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MITIENDA.Blazor.Data.Models
{
    public class MsgResult
    {
        public bool IsSuccess { get; set; } //Indica fue exitoso
        public string Message { get; set; } //Contener un mensaje
        public int Code { get; set; } //
        public int Count { get; set; } //Cantidad x
        public Exception Error { get; set; } //Indica error encaso de que haiga una excepción
        public object Objeto { get; set; } //
    }
}
