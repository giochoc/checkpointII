public class Telegram
{
    public void EnviarMensagem(string numero, TextMessage message)
    {
        Console.WriteLine($"[Telegram - Número: {numero}] Enviando mensagem de texto: {message.Message}");
    }

    public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"[Telegram - Usuário: @{usuario}] Enviando vídeo: {message.Message}");
    }

    public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"[Telegram - Usuário: @{usuario}] Enviando foto: {message.Message}");
    }

    public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"[Telegram - Usuário: @{usuario}] Enviando arquivo: {message.Message}");
    }
}
