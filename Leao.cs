public class Leao : Mamifero
{
        public int TamanhoDoGrupo { get; set; }
    public Leao(string nome, int idade, int tamanhodogrupo) : base(nome, idade) 
    {
        Nome = nome;
        Idade = idade;
        TamanhoDoGrupo = tamanhodogrupo;
    }

}
