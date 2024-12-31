using System.ComponentModel.DataAnnotations;

namespace nerd.Models;

public sealed class InputTargetNameForm
{
    [Required(ErrorMessage = "宛先の名前を入力してください。")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "メッセージを入力してください。")]
    public string Message { get; set; } = "今年もよろしくお願いいたします";
    [Required(ErrorMessage = "あなたの名前を入力してください。")]
    public string SenderName { get; set; } = string.Empty;
}
