using Teste_Grupo_SKA_Vitor_Nicacio.DAO;
using Teste_Grupo_SKA_Vitor_Nicacio.Models;

namespace Teste_Grupo_SKA_Vitor_Nicacio.Repository
{
    public class BlocoNotasRepository : IBlocoNotasRepository
    {

        private readonly DataBaseContext _dataBaseContext;

        public BlocoNotasRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public BlocoNotas Salvar(BlocoNotas blocoNotas)
        {
            _dataBaseContext.tableContacts.Add(blocoNotas);
            _dataBaseContext.SaveChanges();

            return blocoNotas;
        }

        public BlocoNotas Buscar(int id)
        {
            return _dataBaseContext.tableContacts.FirstOrDefault(x => x.ID == id);
        }

        public List<BlocoNotas> Listar()
        {
            return _dataBaseContext.tableContacts.ToList();
        }

        public BlocoNotas Atualizar(BlocoNotas blocoNotas)
        {
            BlocoNotas blocoNotasEditar = Buscar(blocoNotas.ID);

            if (blocoNotasEditar == null) throw new System.Exception("Houve um erro ao atualizar o status da nota.");

            blocoNotasEditar.STATUS = blocoNotas.STATUS;

            _dataBaseContext.tableContacts.Update(blocoNotasEditar);
            _dataBaseContext.SaveChanges();

            return blocoNotas;
        }

        public bool Apagar(int id)
        {
            BlocoNotas blocoNotas = Buscar(id);

            if (blocoNotas == null) throw new System.Exception("Houve um erro ao atualizar a nota.");

            _dataBaseContext.tableContacts.Remove(blocoNotas);
            _dataBaseContext.SaveChanges();

            return true;
        }

    }
}
