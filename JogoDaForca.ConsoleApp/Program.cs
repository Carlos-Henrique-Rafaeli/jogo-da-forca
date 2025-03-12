namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] palavras = {
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

                Random geradorDeNumeros = new Random();

                int indiceEscolhido = geradorDeNumeros.Next(palavras.Length);

                string palavraEscolhida = palavras[indiceEscolhido];

                char[] letrasEncontradas = new char[palavraEscolhida.Length];

                for (int caracterAtual = 0; caracterAtual < letrasEncontradas.Length; caracterAtual++)
                    letrasEncontradas[caracterAtual] = '_';

                int quantidadeErros = 0;
                bool jogadorGanhou = false;
                bool jogadorPerdeu = false;

                do
                {
                    string cabecaDoDesenho = quantidadeErros >= 1 ? " O " : " ";
                    string troncoDoDesenho = quantidadeErros >= 2 ? "|" : " ";
                    string troncoInferiorDoDesenho = quantidadeErros >= 2 ? " | " : " ";
                    string bracoEsquerdoDoDesenho = quantidadeErros >= 3 ? "/" : " ";
                    string bracoDireitoDoDesenho = quantidadeErros >= 4 ? "\\" : " ";
                    string pernasDoDesenho = quantidadeErros >= 5 ? "/ \\" : " ";

                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Jogo da Forca");
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

                    Console.WriteLine("\nQuantidade de erros: " + quantidadeErros);
                    Console.WriteLine("\nPalavra escolhida: " + String.Join(" ", letrasEncontradas));

                    Console.Write("\nDigite uma letra: ");
                    string entradaInicial = Console.ReadLine()!.ToUpper();

                    if (entradaInicial.Length != 1 || String.IsNullOrEmpty(entradaInicial))
                    {
                        Console.WriteLine("Informe apenas uma letra!\nPressione ENTER para digitar novamente!");
                        Console.ReadLine();
                        continue;
                    }

                    char chute = entradaInicial[0];

                    bool letraFoiEncontrada = false;

                    for (int contadorCaracteres = 0; contadorCaracteres < palavraEscolhida.Length; contadorCaracteres++)
                    {
                        char caractereAtual = palavraEscolhida[contadorCaracteres];

                        if (chute == caractereAtual)
                        {
                            letrasEncontradas[contadorCaracteres] = caractereAtual;
                            letraFoiEncontrada = true;
                        }

                    }


                    if (letraFoiEncontrada == false)
                        quantidadeErros++;


                    string palavraEncontradaCompleta = String.Join("", letrasEncontradas);

                    jogadorGanhou = palavraEncontradaCompleta == palavraEscolhida;
                    jogadorPerdeu = quantidadeErros > 5;

                    if (jogadorGanhou)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"Você acertou, a palavra era {palavraEscolhida}, parabéns!");
                        Console.WriteLine("---------------------------------");
                    }
                    else if (jogadorPerdeu)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"Você perdeu, a palavra era {palavraEscolhida}, mais sorte na próxima!");
                        Console.WriteLine("---------------------------------");
                    }


                } while (jogadorGanhou == false && jogadorPerdeu == false);

                Console.Write("Deseja jogar novamente? (S/N): ");
                string jogarNovamente = Console.ReadLine()!.ToUpper();
                
                if (jogarNovamente != "S")
                {
                    break;
                }
            
            }

            Console.ReadLine();
        }
    }
}
