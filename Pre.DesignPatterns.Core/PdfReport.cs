namespace Pre.DesignPatterns.Core;

public class PdfReport: Report
{
    private ContentParser _parser;
    public string Content { get; set; }

    public PdfReport(string name, double margin)
    {
        Name = name;
    }

    public PdfReport(string name, string content, double margin)
        :this(name, margin)
    {
        Content = content;
    }

    public void SetParser(ContentParser parser)
    {
        _parser = parser;
    }

    public string GenerateReport()
    {
        return _parser.Parse(Content);
    }
}