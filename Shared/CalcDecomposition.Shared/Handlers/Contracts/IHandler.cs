using CalcDecomposition.Shared.Commands.Contracts;

namespace CalcDecomposition.Shared.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
