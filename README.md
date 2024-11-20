# Conversor de Moedas

## Descrição
Este projeto é uma aplicação de console desenvolvida em C# que realiza a conversão de valores monetários entre diferentes moedas. A aplicação lê a moeda de origem, a moeda de destino e um valor monetário, apresentando o valor convertido e a taxa de conversão. Para realizar a conversão, a aplicação consome o serviço de conversão de moedas ExchangeRate.

## Funcionalidades
- Leitura da moeda de origem, moeda de destino e valor monetário.
- Conversão do valor monetário da moeda de origem para a moeda de destino.
- Exibição da taxa de conversão utilizada.
- Tratamento de erros na comunicação com a API e na conversão.

## Requisitos
- .NET Core SDK
- Conta e chave de API no [ExchangeRate API](https://www.exchangerate-api.com/docs/overview)

## Como Executar
1. Clone o repositório:
   ```bash
   git clone https://github.com/Neiwone/conversor.git
   cd conversor
2. Configure a chave da API:

   Crie um arquivo .env na raiz do projeto com o seguinte conteúdo:
   
   ```env
   API_KEY=sua-chave-de-api
3. Execute a aplicação:

   ```bash
   dotnet run
    
