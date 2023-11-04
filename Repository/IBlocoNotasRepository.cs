using Teste_Grupo_SKA_Vitor_Nicacio.Models;

namespace Teste_Grupo_SKA_Vitor_Nicacio.Repository
{
    public interface IBlocoNotasRepository
    {

        BlocoNotas Salvar(BlocoNotas blocoNotas);

        List<BlocoNotas> Listar();

        BlocoNotas Buscar(int id);

        BlocoNotas Atualizar(BlocoNotas blocoNotas);

        bool Apagar(int id);

    }
}
