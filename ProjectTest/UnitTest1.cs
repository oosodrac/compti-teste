using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Core;
using Services;
using System.Collections.Generic;

namespace ProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        static List<Cliente> listaCliente = new List<Cliente>();

        [TestMethod]
        public void TestMethod1()
        {
            var soma = 2 + 2;
            Assert.AreEqual(soma, 4);
        }

        [TestMethod]
        public void NovoCliente()
        {
            var clientes = new List<Cliente> {
                new Cliente { 
                    Anulado = false, Codigo = "1", CondicaoPagamento = CondicaoPagamento.PRAZO.ToString(),
                    Iva = 0, ModoPagamento = ModoPagamento.CARTAO_CREDITO.ToString(), ValorCredito = 0,
                    Nome = "Ramiro Cardoso XPTU", Desconto = 0
                },
                              new Cliente { 
                    Anulado = false, Codigo = "2", CondicaoPagamento = CondicaoPagamento.PRAZO.ToString(),
                    Iva = 0, ModoPagamento = ModoPagamento.CARTAO_CREDITO.ToString(), ValorCredito = 0,
                    Nome = "Catiana Cardoso", Desconto = 0
                },              new Cliente { 
                    Anulado = false, Codigo = "3", CondicaoPagamento = CondicaoPagamento.PRAZO.ToString(),
                    Iva = 0, ModoPagamento = ModoPagamento.CARTAO_CREDITO.ToString(), ValorCredito = 0,
                    Nome = "Rainer Cardoso", Desconto = 0
                }
            };

            listaCliente.AddRange(clientes);

            ClienteService.SaveAll(listaCliente);
        }

        [TestMethod]
        public void PesquisarPeloCodigo()
        {
            var result = ClienteService.FindByCodigo("1");

            Assert.AreEqual("1", result.Codigo );
        }

        [TestMethod]
        public void AtualizarCliente()
        {
            var clientes = new List<Cliente> {
                new Cliente { 
                    Anulado = false, Codigo = "1", CondicaoPagamento = CondicaoPagamento.PRAZO.ToString(),
                    Iva = 0, ModoPagamento = ModoPagamento.CARTAO_CREDITO.ToString(), ValorCredito = 0,
                    Nome = "Ramiro Cardoso XPTU", Desconto = 0
                },
                              new Cliente { 
                    Anulado = false, Codigo = "2", CondicaoPagamento = CondicaoPagamento.PRAZO.ToString(),
                    Iva = 0, ModoPagamento = ModoPagamento.CARTAO_CREDITO.ToString(), ValorCredito = 0,
                    Nome = "Catiana Cardoso", Desconto = 0
                },              new Cliente { 
                    Anulado = false, Codigo = "3", CondicaoPagamento = CondicaoPagamento.PRAZO.ToString(),
                    Iva = 0, ModoPagamento = ModoPagamento.CARTAO_CREDITO.ToString(), ValorCredito = 0,
                    Nome = "Rainer Cardoso", Desconto = 0
                }
            };

            listaCliente.AddRange(clientes);

            ClienteService.SaveAll(listaCliente);
        }
    }
}
