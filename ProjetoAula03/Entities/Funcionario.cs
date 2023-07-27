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
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Cpf { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Guid EmpresaId { get; set; }

        #region Associações

        public Empresa Empresa { get; set; }

        #endregion
    }
}
