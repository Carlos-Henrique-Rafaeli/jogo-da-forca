namespace JogoDaForca.ConsoleApp;

internal class Program
{
    static string[] opcoesValidas = { "1", "2", "3", "S" };

    static void Main(string[] args)
    {
        while (true)
        {
            string opcao = ExibirMenu();

            if (!opcoesValidas.Contains(opcao))
            {
                Console.WriteLine("Opcão Inválida!\nPressione ENTER para voltar!");
                Console.ReadLine();
                continue;
            }
            
            else if (opcao == "1")
                IniciarJogo("Frutas");
            
            else if (opcao == "2")
                IniciarJogo("Animais");
            
            else if (opcao == "3")
                IniciarJogo("Países");
            
            else if (opcao == "S")
                return;
        }
    }

    static void IniciarJogo(string tema)
    {
        JogoDaForca.Resetar(tema);

        do
        {
            string entradaInicial = ExibirForca(tema, true);

            if (entradaInicial.Length != 1 || String.IsNullOrEmpty(entradaInicial))
            {
                Console.WriteLine("Informe apenas uma letra!\nPressione ENTER para digitar novamente!");
                Console.ReadLine();
                continue;
            }

            JogoDaForca.VerificarChute(entradaInicial);

            if (JogoDaForca.jogadorGanhou)
            {
                Console.Clear();
                ExibirForca(tema, false);
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Você acertou, a palavra era {JogoDaForca.palavraEscolhida}, parabéns!");
                Console.WriteLine("---------------------------------");
            }
            else if (JogoDaForca.jogadorPerdeu)
            {
                Console.Clear();
                ExibirForca(tema, false);
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Você perdeu, a palavra era {JogoDaForca.palavraEscolhida}, mais sorte na próxima!");
                Console.WriteLine("---------------------------------");
            }
        
        } while (JogoDaForca.jogadorGanhou == false && JogoDaForca.jogadorPerdeu == false);

        Console.WriteLine("\nPressione ENTER para voltar ao menu!");
        Console.ReadLine();

    }

    static string ExibirForca(string tema, bool deveDigitar)
    {
        string cabecaDoDesenho = JogoDaForca.quantidadeErros >= 1 ? " O " : " ";
        string troncoDoDesenho = JogoDaForca.quantidadeErros >= 2 ? "|" : " ";
        string troncoInferiorDoDesenho = JogoDaForca.quantidadeErros >= 2 ? " | " : " ";
        string bracoEsquerdoDoDesenho = JogoDaForca.quantidadeErros >= 3 ? "/" : " ";
        string bracoDireitoDoDesenho = JogoDaForca.quantidadeErros >= 4 ? "\\" : " ";
        string pernasDoDesenho = JogoDaForca.quantidadeErros >= 5 ? "/ \\" : " ";

        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Tema: " + tema);
        Console.WriteLine("---------------------------------");

        Console.WriteLine(" ___________        ");
        Console.WriteLine(" |/        |        ");
        Console.WriteLine(" |        {0}       ", cabecaDoDesenho);
        Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdoDoDesenho, troncoDoDesenho, bracoDireitoDoDesenho);
        Console.WriteLine(" |        {0}       ", troncoInferiorDoDesenho);
        Console.WriteLine(" |        {0}       ", pernasDoDesenho);
        Console.WriteLine(" |                  ");
        Console.WriteLine(" |                  ");
        Console.WriteLine("_|____              ");

        Console.WriteLine("\nQuantidade de erros: " + JogoDaForca.quantidadeErros);
        Console.WriteLine("\nPalavra escolhida: " + String.Join(" ", JogoDaForca.letrasEncontradas));

        if (deveDigitar)
        {
            Console.Write("\nDigite uma letra: ");
            string entradaInicial = Console.ReadLine()!.ToUpper();
            return entradaInicial;
        }
        else
            return "";
    }

    static string ExibirMenu()
    {
        Console.Clear();

        Console.WriteLine("--------------------------");
        Console.WriteLine("Jogo da Forca");
        Console.WriteLine("--------------------------");
        Console.WriteLine();

        Console.WriteLine("1 - Frutas");
        Console.WriteLine("2 - Animais");
        Console.WriteLine("3 - Países");
        Console.WriteLine("S - Sair");

        Console.Write("\nEscolha uma opção: ");

        string opcao = Console.ReadLine()!.ToUpper();

        return opcao;
    }
}
