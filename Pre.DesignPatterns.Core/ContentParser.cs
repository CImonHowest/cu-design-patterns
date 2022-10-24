namespace Pre.DesignPatterns.Core;

public class ContentParser
{
    private ICollection<Expression> _expressions;

    public ContentParser()
    {
        _expressions = new List<Expression>();
    }
    
    public string Parse(string expressionValue)
    {
        return _expressions.Aggregate(expressionValue, (current, expression) => expression.Interpret(current));
    }

    public void AddExpression(Expression expression)
    {
        _expressions.Add(expression);
    }
}