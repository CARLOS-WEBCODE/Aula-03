using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Entities
{
    /// <summary>
    /// Classe de entidade
    /// </summary>
    public class Empresa
    {
        public Guid Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        #region Associações

        public List<Funcionario> Funcionarios { get; set; }

        #endregion
    }
}
