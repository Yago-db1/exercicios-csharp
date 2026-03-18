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