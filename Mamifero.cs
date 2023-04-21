public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) 
    {
        Nome = nome;
        Idade = idade;
    }

    public override void EmitirSom()    
    {
        Console.WriteLine("RAAAWWWR");
    }
}
