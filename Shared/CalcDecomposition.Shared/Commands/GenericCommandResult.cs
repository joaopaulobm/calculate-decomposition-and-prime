using CalcDecomposition.Shared.Commands.Contracts;

namespace CalcDecomposition.Shared.Commands
{
    public class GenericCommandResult : ResultController, ICommandResult
    {
        public GenericCommandResult(bool success)
        {
            Success = success;
        }

        public GenericCommandResult(bool success, object data)
        {
            Success = success;
            Data = data;
        }

        public GenericCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public object Data { get; set; }
    }
}
