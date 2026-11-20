# DIO - Trilha .NET - Explorando a linguagem C#

Desafio de projeto da trilha .NET da [DIO](https://www.dio.me/), baseado no repositório
[digitalinnovationone/trilha-net-explorando-desafio](https://github.com/digitalinnovationone/trilha-net-explorando-desafio).

## O desafio

Construir um sistema de hospedagem para realizar reservas em um hotel, usando três classes:

- **`Pessoa`**: o hóspede;
- **`Suite`**: tipo, capacidade e valor da diária;
- **`Reserva`**: relaciona a suíte com os hóspedes e os dias reservados.

### Regras

1. Não é possível reservar uma suíte para mais hóspedes do que a sua capacidade. Nesse caso, uma exceção é lançada.
2. `ObterQuantidadeHospedes()` retorna o total de hóspedes, e `CalcularValorDiaria()` retorna `DiasReservados × Suite.ValorDiaria`.
3. Reservas de **10 dias ou mais** recebem **10% de desconto**.

## Estrutura

```
DesafioProjetoHospedagem.csproj
Program.cs           # monta os hóspedes, a suíte e a reserva, e exibe os resultados
Models/
  Pessoa.cs
  Suite.cs
  Reserva.cs         # regras de capacidade, quantidade de hóspedes e cálculo com desconto
```

## O que foi implementado (TODOs do template)

- `CadastrarHospedes`: aceita os hóspedes quando a capacidade da suíte é maior ou igual ao número de hóspedes; caso contrário, lança `ArgumentException`.
- `ObterQuantidadeHospedes`: retorna a quantidade de itens em `Hospedes`.
- `CalcularValorDiaria`: multiplica os dias pelo valor da diária e aplica 10% de desconto a partir de 10 dias.

Também foram adicionadas verificações para quando a suíte não foi cadastrada antes dos hóspedes ou do cálculo.

## Como executar

Pré-requisito: [.NET SDK 10](https://dotnet.microsoft.com/download) (para usar outra versão, altere o
`TargetFramework` no `.csproj`, por exemplo para `net8.0`).

```bash
dotnet run
```

Saída esperada (2 hóspedes, suíte Premium de R$ 30 por 5 dias):

```
Hóspedes: 2
Valor diária: 150
```
