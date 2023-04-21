class Program
{
    static void Main(string[] args)
    {
        MiniZoo miniZoo = new MiniZoo();
        Animal Leao = new Leao("Leão", 2, 2);
        Animal Cobra = new Cobra("Cobra", 2, 2);
        miniZoo.AdicionarAnimal(Leao);
        miniZoo.AdicionarAnimal(Cobra);
        miniZoo.EmitirSomDeTodosOsAnimais();
        miniZoo.ImprimirTodosOsAnimais();
        
    }


}
