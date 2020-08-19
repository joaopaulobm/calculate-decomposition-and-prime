using CalcLocaliza.Shared.Commands.Contracts;

namespace CalcLocaliza.Shared.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
