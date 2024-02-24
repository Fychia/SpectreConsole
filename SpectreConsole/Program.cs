using Spectre.Console;
using SpectreConsole;
using System.Data.SqlClient;


try
{
    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

    builder.DataSource = "DESKTOP-VALERIO";
    builder.InitialCatalog = "AdventureWorks2017";
    builder.UserID = "User";
    builder.Password = "Password";

    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
    {
        Console.WriteLine("\nQuery data example:");
        Console.WriteLine("=========================================\n");

        connection.Open();

        //Sample Example
        String sql = "Select";
        //Search for the number of users registered in the system
        String sqlPersonRecord = "Select \r\n\tCount(*) as 'Number of registered users'\r\nFrom Person.Person";

        //Search for the number of sales in the system
        //String sqlSalesRecord = "Select Count(v.venda_status) as 'SalesQtd', IsNull(vs.descricao, '') as 'SalesStatus' From VDONLINE_VENDA as v Inner Join VDONLINE_VENDA_STATUS as vs On v.venda_status = vs.id_venda_status Where Convert(Date, v.data_venda) = Convert(Date, GetDate()) Group by vs.descricao";


        ////Sample Example
        //var data = QueryManagement.ExecuteQuery <Person> (connection, sql);
        //data.ForEach(p => Console.WriteLine(p.Nome));

        Console.WriteLine();

        //Example showing number of users without the table
        //var qtdRecord = QueryManagement.ExecuteQuery <PersonRecord> (connection, sqlPersonRecord);
        //qtdRecord.ForEach(p => Console.WriteLine(p.QtdRecord));

        // Create a new table
        var table = new Table();

        // Add columns to the table
        table.AddColumn(new TableColumn("Number of registered users").Centered());

        // Simulate getting data from a database
        var qtdRecord = QueryManagement.ExecuteQuery<PersonRecord>(connection, sqlPersonRecord);

        // Add rows to the table
        foreach (var record in qtdRecord)
        {
            table.AddRow(record.QtdRecord.ToString());
        }

        // Render the table to the console
        AnsiConsole.Render(table);




        ////Sample Example
        //var qtdSales = QueryManagement.ExecuteQuery<SalesRecord>(connection, sqlSalesRecord);
        //qtdSales.ForEach(p => Console.WriteLine(p.QtdSalesRecord));


        ////Sample Example
        //var qtdSales = QueryManagement.ExecuteQuery<SalesRecord>(connection, sqlSalesRecord);
        //qtdSales.ForEach(p => Console.WriteLine($"p.QtdSalesRecord{p.QtdSalesRecord}, p.SalesStatus{p.SalesStatus}"));
    }
}
catch (SqlException e)
{
    Console.WriteLine(e.ToString());
}
Console.WriteLine("\nDone. Press enter.");
Console.ReadLine();





////var con = await AppSettings.Read();

////// Create a table
////var table = new Table();

//// Add some columns
//table.AddColumn("Foo");
//table.AddColumn(new TableColumn("Bar").Centered());

//// Add some rows
//table.AddRow("Baz", $"[green]{con.DefaultConnection}[/]");
//table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));

////// Render the table to the console
////AnsiConsole.Write(table);

Console.ReadLine();
