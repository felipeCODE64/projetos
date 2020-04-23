namespace Exercicios.Entidades
{
    class Departamento
    {
        public string Nome { get; set; } //aqui são as propriedades dos atributos.
        public Departamento()  //aqui um construtor padrão
        {
        }
        public Departamento(string nome) // aqui um construtor que recebe um argumento
        {
            Nome = nome;
        }

    }
}
