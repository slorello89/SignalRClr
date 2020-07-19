using System.ComponentModel.DataAnnotations;
namespace SignalRClr.Shared
{
    public class Message
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
    }
    
}