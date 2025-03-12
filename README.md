# Jogo Da Forca

## Demonstra��o

![](https://i.imgur.com/mBeVwi4.gif)

## Introdu��o

Jogo da forca cl�ssico: uma fruta aleat�ria � selecionada e voc� tenta adivinh�-la.

## Funcionalidades

- **Frutas Aleat�rias**: O jogo escolhe automaticamente uma fruta para voc� adivinhar.
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
dotnet run --project JogoDeAdivinhacao.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta `./JogoDeAdivinhacao.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
JogoDeAdivinhacao.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.