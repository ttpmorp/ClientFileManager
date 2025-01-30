using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;

namespace Projeto01.Repositories
{
    public class ClienteRepository
    {
        public void GravarArquivo(Cliente cliente)

        {
            var path = $"G:\\COTI\\PROJETOS\\Projeto01\\temp\\cliente_{cliente.Id}.txt";

            var streamWriter = new StreamWriter(path);

            streamWriter.WriteLine($"ID:{cliente.Id}");
            streamWriter.WriteLine($"NOME:{cliente.Nome}");
            streamWriter.WriteLine($"CPF:{cliente.Cpf}");
            streamWriter.WriteLine($"EMAIL:{cliente.Email}");
            streamWriter.WriteLine($"DATA DE NASCIMENTO:{cliente.DataNascimento}");


            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
