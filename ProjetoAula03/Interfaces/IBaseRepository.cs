using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Interfaces
{
    /// <summary>
    /// Interface padrão para definir os métodos dos repositorios
    /// </summary>
    public interface IBaseRepository<T>
    {
        #region Métodos abstratos

        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> GetAll();

        #endregion
    }
}
