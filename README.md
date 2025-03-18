# Jogo Da Forca

## Demonstra��o

![](https://i.imgur.com/zRK9WnH.gif)

## Introdu��o

Jogo da forca cl�ssico onde voc� pode escolher entre **tr�s temas diferentes** � frutas, animais e pa�ses.

## Funcionalidades

- **Escolha de Tema**: Antes de iniciar o jogo, voc� pode escolher um dos seguintes temas:
	- **Frutas**
	- **Animais**
	- **Pa�ses**
- **Palavra Aleat�ria**: O jogo seleciona uma palavra aleat�ria com base no tema escolhido.
- **Tentativas Limitadas**: Voc� tem 5 chances para acertar a palavra secreta.
- **Feedback**: A cada tentativa, o jogo mostra quais letras foram acertadas e quais ainda faltam.
- **Rein�cio de Partida**: Ao final do jogo, � poss�vel come�ar uma nova partida quantas vezes quiser.

## Como utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Em seguida, compile a solu��o utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project JogoDaForca.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta `./JogoDaForca.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
JogoDaForca.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.