using static System.Console;

/*
TODO:
Criar Herói

Cidade
    Ir a Loja/Inn
    Ir a Dungeon

Dungeon
    Voltar para a Cidade
    Usar Itens/Mudar Equipamento
    Se aprofundar na Dungeon
        Iniciar Batalha
            Turno do mais rapido
                Atacar/Usar Habilidade/Defender/Usar Item/
                Calcular Resultado
                Fugir(caso turno do jogador)
                Passar para o próximo
        Receber Loot
        Aumentar de Nível
*/

Console.WriteLine("Welcome to Console RPG");

CriarHeroi();
StartGame();

void CriarHeroi()
{
    WriteLine("What will be the name of your hero?");
    string name = GetStringInput();

    WriteLine(@"
    Choose your class
    0 - Knight      1 - Mage    2 - Hunter");
    int heroClass = GetIntInput();
}

void StartGame()
{
    WriteLine($@"
    You are . You are at the city of Bragalarh. What do you want to do?
    1 - Go shopping       2 - Rest at the INN        3 - Slay monsters at the Dungeon");
}

void NavigateThroughDungeon()
{

}

string GetStringInput()
{
    try
    {
        return ReadLine();
    }
    catch
    {
        WriteLine("Invalid input, try again");
        GetStringInput();
    }
    return "";
}

int GetIntInput()
{
    try
    {
        return int.Parse(ReadLine());
    }
    catch
    {
        WriteLine("Invalid input, try again");
        GetIntInput();
    }
    return -1;
}