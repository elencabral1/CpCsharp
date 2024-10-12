using CP2.Domain.Interfaces.Dtos;
using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CP2.Application.Dtos
{
    public class FornecedorDto : IFornecedorDto
    {
        public string Nome { get; set; } = string.Empty;

        public string CNPJ { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public DateTime CriadoEm { get; set; }

        public void Validate()
        {
            var validateResult = new FornecedorDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class FornecedorDtoValidation : AbstractValidator<FornecedorDto>
    {
        public FornecedorDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(5).WithMessage(x => $"0 campo {nameof(x.Nome)} deve ter no minimo 5 caracteres")
                .NotEmpty().WithMessage(x => $"0 campo {nameof(x.Nome)} nao pode ser vazio");

            RuleFor(x => x.CNPJ)
                .NotEmpty().WithMessage(x => $"0 campo {nameof(x.CNPJ)} nao pode ser vazio");

            RuleFor(x => x.Endereco)
                .NotEmpty().WithMessage(x => $"0 campo {nameof(x.Endereco)} nao pode ser vazio");

            RuleFor(x => x.Telefone)
                .NotEmpty().WithMessage(x => $"0 campo {nameof(x.Telefone)} nao pode ser vazio");

            RuleFor(x => x.Email)
                .MinimumLength(5).WithMessage(x => $"0 campo {nameof(x.Email)} deve ter no minimo 5 caracteres")
                .NotEmpty().WithMessage(x => $"0 campo {nameof(x.Email)} nao pode ser vazio");

            RuleFor(x => x.CriadoEm)
                .NotEmpty().WithMessage(x => $"0 campo {nameof(x.CriadoEm)} nao pode ser vazio");
        }
    }
}
