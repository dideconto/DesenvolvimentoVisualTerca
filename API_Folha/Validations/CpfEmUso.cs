using System.ComponentModel.DataAnnotations;
using System.Linq;
using API.Models;

namespace API_Folha.Validations
{
    public class CpfEmUso : ValidationAttribute
    {
        // public CpfEmUso(string cpf) { }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cpf = (string)value;

            DataContext context =
                (DataContext)validationContext.GetService(typeof(DataContext));

            Funcionario funcionario = context.Funcionarios.FirstOrDefault
                (f => f.Cpf.Equals(cpf));
                
            if (funcionario == null)
            {
                //Caso de sucesso
                return ValidationResult.Success;
            }
            //Caso de erro
            return new ValidationResult("O CPF do funcionário já está em uso!");
        }
    }
}