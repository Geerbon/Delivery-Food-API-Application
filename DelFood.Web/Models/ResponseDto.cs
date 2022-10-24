namespace DelFood.Web.Models
{
    public class ResponseDto
    {
        // Dto для ответа на API
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessages { get; set; }
    }
}
