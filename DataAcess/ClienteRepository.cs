using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganss.Excel;

using Core;

namespace DataAcess
{
    public class ClienteRepository : ICrudRepository<Cliente, String>
    {
        private static List<Cliente> listaCliente = new List<Cliente>();

        public List<Cliente> GetAll()
        {
            var clientes = new Ganss.Excel.ExcelMapper( ExcelHelper.sourceFile ).Fetch<Cliente>().ToList();
            listaCliente.AddRange(clientes);
            return listaCliente;
        }

        public Cliente FindByCodigo(String codigo)
        {
            return listaCliente.Find( cliente => cliente.Codigo.Equals(codigo) );
        }

        public void SaveAll(List<Cliente> clientes)
        {
            new ExcelMapper().Save(ExcelHelper.sourceFile, clientes, "clientes");
        }

        // Remove todos os cliente sem movimento
        public int RemoveAll(Predicate<Cliente> match)
        {
            return new ExcelMapper(ExcelHelper.sourceFile).Fetch<Cliente>()
                .ToList().RemoveAll(cliente => cliente.ValorCredito == 0);
        }
    }
}
