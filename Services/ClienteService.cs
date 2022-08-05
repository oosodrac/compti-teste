using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core;
using DataAcess;

namespace Services
{
    public class ClienteService
    {
        private static ClienteRepository _clienteRepository = new ClienteRepository();

        public static List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente FindByCodigo(String codigo)
        {
            return _clienteRepository.FindByCodigo(codigo);
        }

        public void SaveAll(List<Cliente> clientes)
        {
            _clienteRepository.SaveAll(clientes);
        }

        // Remove todos os cliente sem movimento
        public int RemoveAll()
        {
            return _clienteRepository.RemoveAll(cliente => cliente.ValorCredito == 0);
        }
    }
}
