using Dapper;
using ProjetoAula03.Entities;
using ProjetoAula03.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Repositories
{
    /// <summary>
    /// Classe de repositorio de dados para a entidade Empresa
    /// </summary>
    public class EmpresaRepository : IBaseRepository<Empresa>
    {
        //Readonly = dar um valor e não poderá ser modificado
        //atributo
        private readonly string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDAula03;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Create(Empresa obj)
        {
            //escrevendo o comando SQL
            var sql = @"
                    INSERT INTO EMPRESA(ID, RAZAOSOCIAL, NOMEFANTASIA, CNPJ)
                    VALUES(@Id, @RazaoSocial, @NomeFantasia, @Cnpj)
                ";

            //abrindo conexão com o sqlserver
            using (var connection = new SqlConnection(_connectionString))
            {
                //executando o comando com o Dapper
                connection.Execute(sql, obj);
            }
        }

        public void Update(Empresa obj)
        {
            //escrevendo o comando SQL
            var sql = @"
                    UPDATE EMPRESA SET
                        RAZAOSOCIAL = @RazaoSocial,
                        NOMEFANTASIA = @NomeFantasia,
                        CNPJ = @Cnpj
                    WHERE
                        ID = @Id
                ";

            //abrindo conexão com o sqlserver
            using (var connection = new SqlConnection(_connectionString))
            {
                //executando o comando com o Dapper
                connection.Execute(sql, obj);
            }
        }

        public void Delete(Empresa obj)
        {
            //escrevendo o comando SQL
            var sql = @"
                    DELETE FROM EMPRESA
                    WHERE ID = @Id
                ";

            //abrindo conexão com o sqlserver
            using (var connection = new SqlConnection(_connectionString))
            {
                //executando o comando com o Dapper
                connection.Execute(sql, obj);
            }
        }
        public List<Empresa> GetAll()
        {
            //escrevendo o comando SQL
            var sql = @"
                    SELECT * FROM EMPRESA
                    ORDER BY
                        NOMEFANTASIA ASC
                ";

            //abrindo conexão com o sqlserver
            using (var connection = new SqlConnection(_connectionString))
            {
                //executando o comando com o Dapper e retorna o resultado
                return connection.Query<Empresa>(sql).ToList();
            }
        }
    }
}
