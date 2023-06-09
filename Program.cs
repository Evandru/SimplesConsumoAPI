﻿using SimplesConsumoAPI;

API api = new API();

Console.Write("Bem vindo ao ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("SearchMovie");
Console.ResetColor();
Console.Write(" console");
Console.WriteLine();
Console.WriteLine("O que você deseja pesquisar?");
Console.WriteLine();
Console.WriteLine("1 - Um filme em específico");
Console.WriteLine("2 - Pesquisar filmes");
Console.WriteLine();

var escolha = Console.ReadLine();

if (escolha == "1")
{
    Console.Clear();

    while (true)
    {
        Console.WriteLine();
        Console.Write(" > Digite o título do filme: ");

        Console.ForegroundColor = ConsoleColor.Yellow;
        var title = Console.ReadLine();
        Console.ResetColor();

        var movie = await api.GetMovie(title);
        Views.MovieView(movie);
    }
}
else if (escolha == "2")
{
    Console.Clear();

    while (true)
    {
        Console.WriteLine();
        Console.Write(" > Digite um título: ");

        Console.ForegroundColor = ConsoleColor.Yellow;
        var title = Console.ReadLine();
        Console.ResetColor();

        var searchResponse = await api.GetSearchResponse(title);
        Views.SearchResponseView(searchResponse);
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Escreva corretamente!");
    Console.ResetColor();
}