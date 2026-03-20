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