# DividePDF

API em C# para dividir um arquivo PDF em vários PDFs menores, gerando um arquivo para cada página do documento original.

## Descrição

O projeto foi desenvolvido em ASP.NET Core e utiliza a biblioteca PDFsharp para ler um PDF recebido via upload, separar cada página em um novo documento e salvar os arquivos em uma pasta específica do projeto.

## Funcionalidades

- Recebe um arquivo PDF por upload;
- Separa cada página em um novo PDF;
- Salva os documentos gerados em `DividePDF/Arquivos/ArquivosSeparados`;
- Expõe uma API REST para integração com outras aplicações.

## Stack tecnológica

- C#
- ASP.NET Core
- PDFsharp
- .NET 10

## Estrutura do projeto

```text
DividePDF/
├── DividePDF/
│   ├── Arquivos/
│   │   └── ArquivosSeparados/
│   ├── Controllers/
│   │   └── PDFController.cs
│   ├── DTOs/
│   │   └── DividirPdfDto.cs
│   ├── Services/
│   │   ├── DivisorPdf.cs
│   │   └── Interfaces/
│   ├── Program.cs
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   ├── DividePDF.csproj
│   └── DividePDF.http
├── DividePDF.slnx
├── .gitignore
├── .gitattributes
└── README.md