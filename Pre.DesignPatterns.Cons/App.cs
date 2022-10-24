using Pre.DesignPatterns.Core;

namespace Pre.DesignPatterns.Cons;

public class App
{
    public void Run()
    {
        Console.WriteLine("Hello, World!");

        PdfReport pdfReport = new PdfReport("TestReport", 5);
        pdfReport.Content = @"<!DOCTYPE html>
    <html lang='en'>
    <head>
        <meta charset='UTF-8'>
        <meta http-equiv='X-UA-Compatible' content='IE=edge'>
        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
        <title>TestReport</title>
    </head>
    <body>
        <h2>Hello there, $firstname$ $name$</h2>
        <p>
            $date$
        </p>
    </body>
</html>";

        var parser = new ContentParser();
        parser.AddExpression(new TextExpression("$name$", "Vermeulen"));
        parser.AddExpression(new TextExpression("$firstname$", "Joske"));
        parser.AddExpression(new DateExpression("$date$", "dd/MM/yyyy"));

        pdfReport.SetParser(parser);

        string output = pdfReport.GenerateReport();
        Console.WriteLine(output);
    }
}