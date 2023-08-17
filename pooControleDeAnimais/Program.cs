using pooControleDeAnimais;

Console.WriteLine("Controle de Animais");
Console.WriteLine("---------------------");

Console.WriteLine("Os tipos de animais válidos são: Cachorro, Gato e Peixe");

Console.WriteLine("");


int tamanhoLogico = 0;    
Animal[] animaisr = new Animal[15]; //sendo 20 a qtd de posições do array

int contadorPeixe = 0;
int contadorCachorro = 0;
int contadorGato = 0;

//
try
{
    Console.WriteLine("Quantos animais deseja informar? \n (máximo 15)");
    tamanhoLogico = Convert.ToInt32(Console.ReadLine());

    if(tamanhoLogico > 15)
    {
        tamanhoLogico = 15;
    }
}
catch
{
    tamanhoLogico = 0; 
}

for (int animal = 1; animal < tamanhoLogico ; animal++)
{
    Animal animais = new Animal();
    Console.Write($"Informe o nome do {animal}º animalzinho: ");
    animais.Nome = (Console.ReadLine());

    Console.Write($"Informe o tipo do {animais.Nome}: ");
    string tipo = Console.ReadLine();
    animais.Tipo = tipo.ToUpper();
    Console.WriteLine("");

    switch (animais.Tipo)
    {
        case "CACHORRO":
            contadorCachorro++;
            break;
        case "GATO":
            contadorGato++;
            break;
        case "PEIXE":
            contadorPeixe++;
            break;
        default:
            Console.WriteLine("Tipo de animal inválido. O animal será contabilizado como peixe.");
            contadorPeixe++;
            break;
    }
    //armazenando no array 
    animaisr[animal] = animais;
}
Console.WriteLine("---------------------------------");
Console.WriteLine($"A quantidade de peixes foi: {contadorPeixe}");
Console.WriteLine($"A quantidade de cachorros foi: {contadorCachorro}");
Console.WriteLine($"A quantidade de gatos foi: {contadorGato}");

Console.WriteLine(  );
Console.WriteLine("---------------------------------");



