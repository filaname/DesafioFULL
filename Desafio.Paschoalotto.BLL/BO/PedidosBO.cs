using Desafio.Paschoalotto.DAL.DAO;
using Desafio.Paschoalotto.DAL.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.Paschoalotto.BLL.BO
{
    public class TitulosBO
    {
        TitulosDAO titulosDAO;

        public TitulosBO()
        {
            titulosDAO = new TitulosDAO();
        }

        public async Task<bool> SalvarTitulo(Titulos titulo)
        {
            return await titulosDAO.SavarTituloAsync(titulo);
        }

        public async Task<List<Titulos>> BuscarTitulo(string Nome)
        {
            return await titulosDAO.ListarTituloAsync(Nome);
        }
    }
}
