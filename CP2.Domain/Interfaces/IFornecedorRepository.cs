using CP2.Domain.Entities;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        IEnumerable<FornecedorEntity> ObterTodosFornecedores();
        FornecedorEntity? ObterFornecedorPorId(int id);
        FornecedorEntity? SalvarDadosFornecedor(FornecedorEntity entity);
        FornecedorEntity? EditarDadosFornecedor(FornecedorEntity entity);
        FornecedorEntity? DeletarDadosFornecedor(int id);
    }
}
