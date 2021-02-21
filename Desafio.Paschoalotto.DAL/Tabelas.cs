using Desafio.Paschoalotto.DAL.Entidades;

namespace Desafio.Paschoalotto.DAL
{
    public class Tabelas : Database
    {
        public Tabelas()
        {
            _database.CreateTableAsync<Titulos>().Wait();
            _database.CreateTableAsync<Parcelas>().Wait();
        }
    }
}
