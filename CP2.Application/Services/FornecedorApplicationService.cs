using CP2.Application.Dtos;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorApplicationService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? DeletarDadosFornecedor(int id)
        {
            return _repository.DeletarDadosFornecedor(id);
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            return _repository.ObterFornecedorPorId(id);
        }

        public FornecedorEntity? EditarDadosFornecedor(int id, IFornecedorDto entity)
        {
            entity.Validate();

            return _repository.EditarDadosFornecedor(new FornecedorEntity
            {
                Id = id,
                Nome = entity.Nome,
                CNPJ = entity.CNPJ,
                Endereco = entity.Endereco,
                Telefone = entity.Telefone,
                Email = entity.Email,
                CriadoEm = entity.CriadoEm,
            });
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            return _repository.ObterTodosFornecedores();
        }

        public FornecedorEntity? SalvarDadosFornecedor(IFornecedorDto entity)
        {
            entity.Validate();

            return _repository.SalvarDadosFornecedor(new FornecedorEntity
            {
                Nome = entity.Nome,
                CNPJ = entity.CNPJ,
                Endereco = entity.Endereco,
                Telefone = entity.Telefone,
                Email = entity.Email,
                CriadoEm = entity.CriadoEm,
            });
        }

    }
}
