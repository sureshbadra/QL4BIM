using QL4BIMinterpreter.QL4BIM;

namespace QL4BIMinterpreter
{
    public interface IQueryReader
    {
        FunctionNode Parse(string queryText);
    }
}