# Exercícios - Primeiros Passos com C#

Bem-vindo(a) aos exercícios práticos de C#! Estes exercícios foram desenvolvidos para reforçar os conceitos aprendidos nos cursos sobre variáveis, tipos, condicionais e laços de repetição.

## 📋 Instruções Gerais

- Resolva os exercícios na ordem apresentada
- Teste seu código com diferentes valores de entrada
- Utilize comentários no código para explicar sua lógica
- Em caso de dúvidas, revise os materiais dos cursos
- Crie um repositorio no Git
- No Readme do projete adicione estas instruções
- Para cada exercicio deve ser criado um pull request e submetido para revisão da equipe

---

## Exercício 1: Calculadora de IMC (Índice de Massa Corporal)

**Objetivo:** Praticar variáveis, tipos de dados e operações matemáticas básicas.
**Descrição:**
Crie um programa que calcule o IMC de uma pessoa. O programa deve:
- Solicitar o peso (em kg) do usuário
- Solicitar a altura (em metros) do usuário
- Calcular o IMC usando a fórmula: `IMC = peso / (altura * altura)`
- Exibir o resultado do IMC com 2 casas decimais

**Exemplo de saída:**
```
Digite seu peso (kg): 70
Digite sua altura (m): 1.75
Seu IMC é: 22.86
```

---
## Exercício 2: Classificação de IMC

**Objetivo:** Praticar estruturas condicionais (if/else).
**Descrição:**
Aprimore o exercício anterior adicionando a classificação do IMC. O programa deve:
- Calcular o IMC (como no exercício anterior)
- Classificar o IMC de acordo com a tabela abaixo
- Exibir o resultado e a classificação

**Tabela de classificação:**
- Menor que 18.5: "Abaixo do peso"
- Entre 18.5 e 24.9: "Peso normal"
- Entre 25.0 e 29.9: "Sobrepeso"
- Entre 30.0 e 34.9: "Obesidade Grau I"
- Entre 35.0 e 39.9: "Obesidade Grau II"
- 40.0 ou mais: "Obesidade Grau III"

**Exemplo de saída:**
```
Digite seu peso (kg): 70
Digite sua altura (m): 1.75
Seu IMC é: 22.86
Classificação: Peso normal
```

---

## Exercício 3: Menu de Opções com Switch

**Objetivo:** Praticar switch/case e laços de repetição.
**Descrição:**
Crie uma calculadora simples com menu de opções. O programa deve:
- Exibir um menu com as opções: 1-Soma, 2-Subtração, 3-Multiplicação, 4-Divisão, 5-Sair
- Solicitar ao usuário que escolha uma opção
- Solicitar dois números
- Realizar a operação escolhida
- Exibir o resultado
- Repetir o menu até que o usuário escolha a opção "Sair"
- Para divisão, verificar se o divisor não é zero

**Exemplo de saída:**
```
=== CALCULADORA ===
1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão
5 - Sair
Escolha uma opção: 1

Digite o primeiro número: 10
Digite o segundo número: 5
Resultado: 10 + 5 = 15
...
```

---

## Exercício 4: Análise de Notas de Alunos

**Objetivo:** Combinar laços de repetição, condicionais e acumuladores.
**Descrição:**
Crie um programa que analise as notas de uma turma. O programa deve:
- Solicitar quantos alunos tem na turma
- Para cada aluno, solicitar a nota (de 0 a 10)
- Validar se a nota está entre 0 e 10 (se não estiver, solicitar novamente)
- Calcular:
  - A média da turma
  - Quantos alunos foram aprovados (nota >= 7)
  - Quantos alunos ficaram em recuperação (nota >= 5 e < 7)
  - Quantos alunos foram reprovados (nota < 5)
  - A maior e a menor nota da turma
- Exibir um relatório completo

**Exemplo de saída:**
```
Quantos alunos tem na turma? 3

Digite a nota do aluno 1: 8.5
Digite a nota do aluno 2: 6.0
Digite a nota do aluno 3: 9.0

=== RELATÓRIO DA TURMA ===
Média da turma: 7.83
Aprovados: 2 aluno(s)
Recuperação: 1 aluno(s)
Reprovados: 0 aluno(s)
Maior nota: 9.00
Menor nota: 6.00
```

---

## Exercício 5: Jogo de Adivinhação

**Objetivo:** Integrar todos os conceitos aprendidos em um programa completo.
**Descrição:**
Crie um jogo onde o computador escolhe um número aleatório e o jogador tenta adivinhar. O programa deve:
- Permitir que o jogador escolha o nível de dificuldade:
  - Fácil: número de 1 a 10 (10 tentativas)
  - Médio: número de 1 a 50 (7 tentativas)
  - Difícil: número de 1 a 100 (5 tentativas)
- Gerar um número aleatório de acordo com a dificuldade escolhida
- Permitir que o jogador faça tentativas
- Para cada tentativa, informar se o número é maior ou menor que o chute
- Exibir quantas tentativas restam
- Se acertar: exibir mensagem de vitória e em quantas tentativas
- Se esgotar as tentativas: exibir mensagem de derrota e revelar o número
- Perguntar se deseja jogar novamente

**Exemplo de saída:**
```
=== JOGO DE ADIVINHAÇÃO ===
Escolha o nível de dificuldade:
1 - Fácil (1 a 10) - 10 tentativas
2 - Médio (1 a 50) - 7 tentativas
3 - Difícil (1 a 100) - 5 tentativas
Opção: 1

Pensei em um número entre 1 e 10. Tente adivinhar!

Tentativa 1 de 10
Seu chute: 5
O número é MAIOR que 5

Tentativa 2 de 10
Seu chute: 8
Parabéns! Você acertou em 2 tentativas!

Deseja jogar novamente? (S/N): N
Obrigado por jogar!
```

**Conceitos praticados:**
- Switch/case para menu
- Laços while/for
- Condicionais if/else
- Geração de números aleatórios (Random)
- Contadores e controle de fluxo
- Validação de entrada
- Lógica de jogo

**Dica:** Use a classe `Random` para gerar números aleatórios:
```csharp
Random random = new Random();
int numeroSecreto = random.Next(1, 11); // Gera número de 1 a 10
```

---

## 🎯 Critérios de Avaliação

Ao revisar suas soluções, considere:

1. **Funcionalidade:** O programa faz o que foi solicitado?
2. **Boas práticas:** O código está organizado e legível?
3. **Validações:** O programa trata entradas inválidas?
4. **Eficiência:** O código é simples e direto?

## 📚 Recursos Adicionais

Se tiver dúvidas, consulte:
- [Documentação oficial do C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- Material dos cursos da Alura
- Seu tech lead ou colegas de equipe

---

**Boa sorte e bons estudos! 🚀**
