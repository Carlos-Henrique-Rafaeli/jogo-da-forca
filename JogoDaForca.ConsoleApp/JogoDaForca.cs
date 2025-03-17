namespace JogoDaForca.ConsoleApp;

class JogoDaForca
{
    public static bool jogadorGanhou;
    public static bool jogadorPerdeu;
    public static string palavraEscolhida;
    public static char[] letrasEncontradas;
    public static int quantidadeErros;

    static string[] frutas = {
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

    static string[] animais = {
            "CACHORRO",
            "GATO",
            "ELEFANTE",
            "LEAO",
            "TIGRE",
            "GIRAFA",
            "MACACO",
            "URSO",
            "COELHO",
            "CAVALO",
            "LOBO",
            "RAPOSA",
            "JACARE",
            "TARTARUGA",
            "CAMELO",
            "AVESTRUZ",
            "PANTERA",
            "ARARA",
            "TUCANO",
            "PINGUIM"
        };

    static string[] paises = {
            "BRASIL",
            "ARGENTINA",
            "CANADA",
            "MEXICO",
            "FRANCA",
            "ALEMANHA",
            "ESPANHA",
            "ITALIA",
            "PORTUGAL",
            "CHINA",
            "JAPAO",
            "COREIADOSUL",
            "AUSTRALIA",
            "INDIA",
            "RUSSIA",
            "NORUEGA",
            "SUECIA",
            "SUICA",
            "EGITO",
            "MARROCOS"
        };

    static int indiceEscolhido;
    
    public static void VerificarChute(string entradaInicial)
    {
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
    }

    public static void Resetar(string tema)
    {
        string[] palavras;

        if (tema == "Frutas")
            palavras = frutas;
        else if (tema == "Animais")
            palavras = animais;
        else
            palavras = paises;

        Random geradorDeNumeros = new Random();

        indiceEscolhido = geradorDeNumeros.Next(palavras.Length);

        palavraEscolhida = palavras[indiceEscolhido];

        letrasEncontradas = new char[palavraEscolhida.Length];

        for (int caracterAtual = 0; caracterAtual < letrasEncontradas.Length; caracterAtual++)
            letrasEncontradas[caracterAtual] = '_';

        quantidadeErros = 0;
        jogadorGanhou = false;
        jogadorPerdeu = false;
    }
}
