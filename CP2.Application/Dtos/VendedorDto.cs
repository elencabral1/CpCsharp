using CP2.Domain.Interfaces.Dtos;
using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CP2.Application.Dtos
{
    public class VendedorDto : IVendedorDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; } = string.Empty;
        public DateTime DataContratacao { get; set; }
        public decimal ComissaoPercentual { get; set; }
        public decimal MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; }


        public void Validate()
        {
            var validateResult = new VendedorDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class VendedorDtoValidation : AbstractValidator<VendedorDto>
    {
        public VendedorDtoValidation()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome não pode ser vazio.")
                .MinimumLength(5).WithMessage("O nome deve ter no mínimo 5 caracteres.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O email é obrigatório.")
                .EmailAddress().WithMessage("Formato de email inválido.");

            RuleFor(x => x.Telefone)
                .Matches(@"^\d{10,15}$").WithMessage("O telefone deve ter entre 10 e 15 dígitos.")
                .When(x => !string.IsNullOrEmpty(x.Telefone));

            RuleFor(x => x.Endereco)
                .MaximumLength(200).WithMessage("O endereço pode ter no máximo 200 caracteres.");

            RuleFor(x => x.ComissaoPercentual)
                .InclusiveBetween(0, 100).WithMessage("A comissão deve estar entre 0 e 100.");

            RuleFor(x => x.MetaMensal)
                .GreaterThanOrEqualTo(0).WithMessage("A meta mensal deve ser positiva.");

            RuleFor(x => x.DataNascimento)
                .NotEmpty().WithMessage("A data de nascimento é obrigatória.")
                .LessThan(DateTime.Now).WithMessage("A data de nascimento deve ser uma data passada.");

            RuleFor(x => x.DataContratacao)
                .NotEmpty().WithMessage("A data de contratação é obrigatória.");
        }
    }
}
