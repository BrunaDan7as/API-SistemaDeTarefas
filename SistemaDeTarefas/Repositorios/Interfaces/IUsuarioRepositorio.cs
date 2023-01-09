using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodoUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);

        // adicionar usuario
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        // excluir usuario
        Task<bool> Apagar(int id);
    }
}
