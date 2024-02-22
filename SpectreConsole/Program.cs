using System;
using System.Globalization;
using Spectre.Console;

namespace HitotsuUdemyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new Table();

            table.AddColumn("Quantidade de Pessoas");
            table.AddRow(new Markup(text: "[green] 2334 [/]"));

            AnsiConsole.Write(table);

            Console.ReadLine();
        }
    }
}

