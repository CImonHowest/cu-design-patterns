namespace Pre.DesignPatterns.Core;

public class TextExpression: Expression
{
    private string _value;
    
    public TextExpression(string formula, string value) : base(formula)
    {
        _value = value;
    }

    public override string Interpret(string subject)
    {
        return subject.Replace(_formula, _value);
    }
}