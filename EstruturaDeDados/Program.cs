﻿internal class Program
{
    private static void Main(string[] args)
    {
        // TRABALHANDO COM LISTA (LIST)

        //Criando uma lista
        List<string> frutas = new List<string>();

        //Adicionar itens na Lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        //Imprimir os Itens da lista
        /* Console.WriteLine("Minha Lista de Frutas:");
         foreach (string fruta in frutas)
         {
             Console.WriteLine(fruta);
         }*/

        frutas.ForEach(Console.WriteLine);

        Console.WriteLine(); //Pula linha em Branco

        //Impriir elementos na posição específica
        Console.WriteLine("Fruta no Índice 2: " + frutas[2]);

        //Inserir um elemento no Índice específico
        frutas.Insert(1, "Maracujá");

        //Imprimindo a Lista novamente 
        Console.WriteLine();
        frutas.ForEach(Console.WriteLine);
        //Console.WriteLine("Minha Lista de Frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}
        //Alterar um elemento o Índice específico
        frutas[4] = "Pêra";

        Console.WriteLine();
        Console.WriteLine("Minha Lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        //Remover elementos da Lista

        frutas.RemoveAt(3);

        //Remover elementos pelo Valor do Conteúdo

        frutas.Remove("Morango");

        //Imprimindo a Lista novamente 
        Console.WriteLine();
        Console.WriteLine("Minha Lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        //Limpar os Elementos da Lista
        frutas.Clear();
        frutas.ForEach(Console.WriteLine);

        ////Imprimindo a Lista novamente 
        //Console.WriteLine();
        //Console.WriteLine("Minha Lista de Frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}

        // TRABALHANDO COM DICIONÁRIO DE DADOS (DICIONARY)

        //Criando um Dícionário de Dados 
        Dictionary<int, string> carros = new Dictionary<int, string>();

        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        Console.WriteLine();
        Console.WriteLine("================");
        Console.WriteLine();

        Console.WriteLine("Meu Dicionário de Carros");
        //Imprimir um Dicionário de Dados
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("================");
        Console.WriteLine();

        //TRABALHANDO COM FILA //

        //Criar uma Fila (Queue)
        Queue<string> filaBanco = new Queue<string>();

        //Adicionar Elementos em 
        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        //Retirar o primeiro elemento de uma fila 
        filaBanco.Dequeue();

        Console.WriteLine();
        Console.WriteLine("================");
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        //Verificar se existe um elemento na fila

        bool achou = filaBanco.Contains("Bia");

        if (achou)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não está na fila");
        }

        Console.WriteLine();
        Console.WriteLine("================");
        Console.WriteLine();

        //TRABALHANDO COM PILHA 

        //Criando uma pilha 
        Stack<string> livros = new Stack<string>();

        //Adicionar elementos em uma pilha
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de neve e os sete anões");
        livros.Push("Princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();
        Console.WriteLine("================");
        Console.WriteLine();

        //Remove o primeiro elemento da Pilha
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();
        Console.WriteLine("================");
        Console.WriteLine();

    }
}