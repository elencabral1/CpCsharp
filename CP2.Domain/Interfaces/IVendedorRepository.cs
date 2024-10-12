using CP2.Domain.Entities;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        IEnumerable<VendedorEntity> ObterTodosVendedores();
        VendedorEntity? ObterVendedorPorId(int id);
        VendedorEntity? SalvarDadosVendedor(VendedorEntity entity);
        VendedorEntity? EditarDadosVendedor(VendedorEntity entity);
        VendedorEntity? DeletarDadosVendedor(int id);
    }
}
