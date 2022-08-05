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

        public static Cliente FindByCodigo(String codigo)
        {
            return _clienteRepository.FindByCodigo(codigo);
        }

        public static void SaveAll(List<Cliente> clientes)
        {
            _clienteRepository.SaveAll(clientes);
        }

        // Remove todos os cliente sem movimento
        public static int RemoveAll()
        {
            return _clienteRepository.RemoveAll(cliente => cliente.ValorCredito == 0);
        }

        public static Faturacao alterarEstadoFacturacao(Decimal valorCredito)
        {
            Decimal valorMinimo = 100;
            Decimal valorMaximo = 10000;

            if (valorCredito < valorMinimo)
            {
                return Faturacao.FRACO;
            }
            else if (valorCredito >= valorMinimo && valorCredito <= valorMaximo)
            {
                return Faturacao.MODERADO;
            }
            else
            {
                return Faturacao.FORTE;
            }

        }
    }
}
