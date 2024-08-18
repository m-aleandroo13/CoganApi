namespace CoganApi.Dtos
{
    public class AllResponsesDto
    {
        public string Message { get; set; }
        public object Data { get; set; }
        public bool IsSuccess { get; set; } = false;
    }
}
