namespace ST.CrossCutting.Models
{
    public class ReturnObject<T>
    {
        public ReturnObject(bool sucess, string errorMessage, T? @object)
        {
            Success = sucess;
            ErrorMessage = errorMessage;
            Object = @object;
        }

        public bool Success { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public T? Object { get; set; }
    }
    public static class Message
    {
        public const string ERRO = "Ocorreu um erro inesperado.";
        public const string EmptyERRO = "Não foi localizado resultado para essa busca.";
    }
}
