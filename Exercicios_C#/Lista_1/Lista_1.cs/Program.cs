using System;

class Program {
    public static void Main(string[] args) {

        // ============ EXERCÍCIO 1 ============
        Console.WriteLine("=== EXERCÍCIO 1 ===");
        Console.WriteLine("Hello");
        Console.WriteLine("Júllia");
        Console.WriteLine();

        // ============ EXERCÍCIO 2 ============
        Console.WriteLine("=== EXERCÍCIO 2 ===");
        Console.WriteLine(20 + 80);
        Console.WriteLine();

        // ============ EXERCÍCIO 3 ============
        Console.WriteLine("=== EXERCÍCIO 3 ===");
        Console.WriteLine(90 / 2);
        Console.WriteLine();

        // ============ EXERCÍCIO 4 ============
        Console.WriteLine("=== EXERCÍCIO 4 ===");
        Console.WriteLine(-1 + 4 * 6);
        Console.WriteLine((35 + 5) % 7);
        Console.WriteLine(14 + -4 * 6 / 11);
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        Console.WriteLine();

        // ============ EXERCÍCIO 5 ============
        Console.WriteLine("=== EXERCÍCIO 5 ===");
        Console.WriteLine("Informe o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o segundo número: ");
        int num2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Antes da troca: Primeiro = {num1}, Segundo = {num2}");
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine($"Após a troca: Primeiro = {num1}, Segundo = {num2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 6 ============
        Console.WriteLine("=== EXERCÍCIO 6 ===");
        Console.WriteLine("Informe o primeiro número: ");
        int mult1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o segundo número: ");
        int mult2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o terceiro número: ");
        int mult3 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{mult1} x {mult2} x {mult3} = {mult1 * mult2 * mult3}");
        Console.WriteLine();

        // ============ EXERCÍCIO 7 ============
        Console.WriteLine("=== EXERCÍCIO 7 ===");
        Console.WriteLine("Informe o primeiro número: ");
        float a7 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o segundo número: ");
        float b7 = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"{a7} + {b7} = {a7 + b7}");
        Console.WriteLine($"{a7} - {b7} = {a7 - b7}");
        Console.WriteLine($"{a7} * {b7} = {a7 * b7}");
        Console.WriteLine($"{a7} / {b7} = {a7 / b7:F2}");
        Console.WriteLine($"{a7} % {b7} = {a7 % b7}");
        Console.WriteLine();

        // ============ EXERCÍCIO 8 ============
        Console.WriteLine("=== EXERCÍCIO 8 ===");
        Console.WriteLine("Digite o número: ");
        int tab = int.Parse(Console.ReadLine()!);
        for (int i = 0; i <= 10; i++) {
            Console.WriteLine($"{tab} * {i} = {tab * i}");
        }
        Console.WriteLine();

        // ============ EXERCÍCIO 9 ============
        Console.WriteLine("=== EXERCÍCIO 9 ===");
        Console.WriteLine("Digite o primeiro número: ");
        float m1 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo número: ");
        float m2 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o terceiro número: ");
        float m3 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o quarto número: ");
        float m4 = float.Parse(Console.ReadLine()!);
        float media = (m1 + m2 + m3 + m4) / 4;
        Console.WriteLine($"A média de {m1}, {m2}, {m3}, {m4} é: {media:F2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 10 ============
        Console.WriteLine("=== EXERCÍCIO 10 ===");
        Console.WriteLine("Digite o primeiro número = ");
        int x10 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo número = ");
        int y10 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o terceiro número = ");
        int z10 = int.Parse(Console.ReadLine()!);
        int resultado1 = (x10 + y10) * z10;
        int resultado2 = x10 * y10 + y10 * z10;
        Console.WriteLine($"Resultado dos números especificados {x10}, {y10} e {z10}, (x+y)*z é {resultado1} e x*y + y*z é {resultado2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 11 ============
        Console.WriteLine("=== EXERCÍCIO 11 ===");
        Console.WriteLine("Digite sua idade = ");
        int idade = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Você parece ter mais de {idade} anos");
        Console.WriteLine();

        // ============ EXERCÍCIO 12 ============
        Console.WriteLine("=== EXERCÍCIO 12 ===");
        Console.WriteLine("Digite um número: ");
        int num12 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{num12}{num12}{num12}");
        Console.WriteLine($"{num12} {num12}");
        Console.WriteLine($"{num12} {num12}");
        Console.WriteLine($"{num12} {num12}");
        Console.WriteLine($"{num12}{num12}{num12}");
        Console.WriteLine();

        // ============ EXERCÍCIO 13 ============
        Console.WriteLine("=== EXERCÍCIO 13 ===");
        Console.WriteLine("Digite a quantidade de celsius: ");
        double celsius = double.Parse(Console.ReadLine()!);
        double kelvin = celsius + 273.15;
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine($"Kelvin = {kelvin:F2}");
        Console.WriteLine($"Fahrenheit = {fahrenheit:F2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 14 ============
        Console.WriteLine("=== EXERCÍCIO 14 ===");
        Console.WriteLine("Informe a primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe a segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe a terceira nota: ");
        float nota3 = float.Parse(Console.ReadLine()!);
        float mediaAritmetica = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"A média aritmética é: {mediaAritmetica:F2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 15 ============
        Console.WriteLine("=== EXERCÍCIO 15 ===");
        Console.WriteLine("Informe a primeira nota: ");
        float n15_1 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o peso da primeira nota: ");
        float p15_1 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe a segunda nota: ");
        float n15_2 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o peso da segunda nota: ");
        float p15_2 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe a terceira nota: ");
        float n15_3 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o peso da terceira nota: ");
        float p15_3 = float.Parse(Console.ReadLine()!);
        float mediaPonderada = (n15_1 * p15_1 + n15_2 * p15_2 + n15_3 * p15_3) / (p15_1 + p15_2 + p15_3);
        Console.WriteLine($"A média ponderada é: {mediaPonderada:F2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 16 ============
        Console.WriteLine("=== EXERCÍCIO 16 ===");
        Console.WriteLine("Informe o seu salário: ");
        float salario16 = float.Parse(Console.ReadLine()!);
        float novoSalario16 = salario16 + (salario16 * 25) / 100;
        Console.WriteLine($"O seu novo salário é: {novoSalario16:F2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 17 ============
        Console.WriteLine("=== EXERCÍCIO 17 ===");
        Console.WriteLine("Informe o seu salário: ");
        float salario17 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o percentual de aumento: ");
        float percentual17 = float.Parse(Console.ReadLine()!);
        float aumento17 = (salario17 * percentual17) / 100;
        float novoSalario17 = salario17 + aumento17;
        Console.WriteLine($"O valor do aumento é: {aumento17:F2}");
        Console.WriteLine($"O seu novo salário é: {novoSalario17:F2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 18 ============
        Console.WriteLine("=== EXERCÍCIO 18 ===");
        Console.WriteLine("Informe o seu salário base: ");
        float salarioBase = float.Parse(Console.ReadLine()!);
        float gratificacao = (salarioBase * 5) / 100;
        float imposto = (salarioBase * 7) / 100;
        float salarioReceber = salarioBase + gratificacao - imposto;
        Console.WriteLine($"O seu salário a receber é: {salarioReceber:F2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 19 ============
        Console.WriteLine("=== EXERCÍCIO 19 ===");
        Console.WriteLine("Informe o número: ");
        int num19 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"O antecessor é: {num19 - 1}");
        Console.WriteLine($"O sucessor é: {num19 + 1}");
        Console.WriteLine();

        // ============ EXERCÍCIO 20 ============
        Console.WriteLine("=== EXERCÍCIO 20 ===");
        Console.WriteLine("Informe o primeiro número (A): ");
        float a20 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o segundo número (B): ");
        float b20 = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"{a20} + {b20} = {a20 + b20}");
        Console.WriteLine($"{a20} - {b20} = {a20 - b20}");
        Console.WriteLine($"{a20} * {b20} = {a20 * b20}");
        if (b20 != 0) {
            Console.WriteLine($"{a20} / {b20} = {a20 / b20:F2}");
        } else {
            Console.WriteLine("Divisão por zero não é permitida!");
        }
        Console.WriteLine();

        // ============ EXERCÍCIO 21 ============
        Console.WriteLine("=== EXERCÍCIO 21 ===");
        Console.WriteLine("Informe o número de coelhos: ");
        int coelhos = int.Parse(Console.ReadLine()!);
        double custo = (coelhos * 0.70) / 18 + 10;
        Console.WriteLine($"O custo total dos coelhos é: {custo:F2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 22 ============
        Console.WriteLine("=== EXERCÍCIO 22 ===");
        Console.WriteLine("Informe o seu peso (em kg): ");
        float peso22 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe quanto tempo corre por semana (em minutos): ");
        float tempoCorrida = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe quanto tempo pedala por semana (em minutos): ");
        float tempoPedala = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe quanto tempo nada por semana (em minutos): ");
        float tempoNada = float.Parse(Console.ReadLine()!);
        float caloriasCorrida = 7.0f * peso22 * tempoCorrida / 60;
        float caloriasPedala = 7.0f * peso22 * tempoPedala / 60;
        float caloriasNada = 8.0f * peso22 * tempoNada / 60;
        float totalCalorias = caloriasCorrida + caloriasPedala + caloriasNada;
        Console.WriteLine($"A queima de calorias por semana será: {totalCalorias:F2} kcal");
        Console.WriteLine();

        // ============ EXERCÍCIO 23 ============
        Console.WriteLine("=== EXERCÍCIO 23 ===");
        Console.WriteLine("Informe a posição inicial (S0): ");
        float s0 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe a velocidade inicial (V0): ");
        float v0 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe a aceleração (a): ");
        float aceleracao = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o tempo de duração (t): ");
        float t = float.Parse(Console.ReadLine()!);
        float sFinal = s0 + v0 * t + aceleracao * t * t;
        Console.WriteLine($"A posição final é: {sFinal:F2}");
        Console.WriteLine();

        // ============ EXERCÍCIO 24 ============
        Console.WriteLine("=== EXERCÍCIO 24 ===");
        Console.WriteLine("Informe o número de eleitores: ");
        float eleitores = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o número de votos brancos: ");
        float brancos = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o número de votos nulos: ");
        float nulos = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o número de votos válidos: ");
        float validos = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"A porcentagem de votos brancos é: {(brancos * 100) / eleitores:F2}%");
        Console.WriteLine($"A porcentagem de votos nulos é: {(nulos * 100) / eleitores:F2}%");
        Console.WriteLine($"A porcentagem de votos válidos é: {(validos * 100) / eleitores:F2}%");
        Console.WriteLine();

        // ============ EXERCÍCIO 25 ============
        Console.WriteLine("=== EXERCÍCIO 25 ===");
        Console.WriteLine("Informe o seu peso: ");
        float pesoAtual = float.Parse(Console.ReadLine()!);
        float pesoEngordar = pesoAtual + (pesoAtual * 15) / 100;
        float pesoEmagrecer = pesoAtual - (pesoAtual * 22) / 100;
        Console.WriteLine($"O novo peso se engordar 15% é: {pesoEngordar:F2} kg");
        Console.WriteLine($"O novo peso se emagrecer 22% é: {pesoEmagrecer:F2} kg");
        Console.WriteLine();
    }
}