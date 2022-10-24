namespace Pre.DesignPatterns.Core;

public abstract class Expression
{
    protected string _formula;

    public Expression(string formula)
    {
        _formula = formula;
    }

    public abstract string Interpret(string content);
}