# Jogo Da Forca

## Demonstração

![](https://i.imgur.com/mBeVwi4.gif)

## Introdução

Jogo da forca clássico: uma fruta aleatória é selecionada e você tenta adivinhá-la.

## Funcionalidades

- **Frutas Aleatórias**: O jogo escolhe automaticamente uma fruta para você adivinhar.
- **Tentativas Limitadas**: Você tem 5 chances para acertar a palavra secreta.
- **Feedback**: A cada tentativa, o jogo mostra quais letras foram acertadas e quais ainda faltam.
- **Reinício de Partida**: Ao final do jogo, é possível começar uma nova partida quantas vezes quiser.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project JogoDaForca.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./JogoDaForca.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
JogoDaForca.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.