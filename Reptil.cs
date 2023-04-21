public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) 
    {
        Nome = nome;
        Idade = idade;
    }

    public override void EmitirSom()    
    {
        Console.WriteLine("PSSSSSSSSS");
    }
}