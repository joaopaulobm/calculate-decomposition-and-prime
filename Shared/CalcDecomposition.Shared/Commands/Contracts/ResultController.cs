namespace CalcLocaliza.Shared.Commands.Contracts
{
    public abstract class ResultController
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
