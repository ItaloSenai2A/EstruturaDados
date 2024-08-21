internal class Program
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
    }
}