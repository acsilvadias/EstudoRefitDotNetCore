using EstudoRefitDotNetCore.Service.Interface;
using Refit;
using System;
using System.Threading.Tasks;

namespace EstudoRefitDotNetCore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cepClient = RestService.For<ICepApiExemplo>("http://viacep.com.br");
            string meuCep = "52130220";
            Console.WriteLine("Consultando  Infos do CEP: {0}", meuCep);

            var addess = await cepClient.GetAddressAsynnc(meuCep);

            Console.Write($"\nLogradouro:{addess.Logradouro}\nBrairro:{addess.Bairro}\nEstado:{addess.Uf}\nCódigo Ibge:{addess.Ibge}");
            Console.ReadKey();


        }
    }
}
