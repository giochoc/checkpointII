public class Instagram
{
    public void EnviarMensagem(string usuario, TextMessage message)
    {
        Console.WriteLine($"[Instagram - @{usuario}] Enviando mensagem de texto: {message.Message}");
    }

    public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"[Instagram - @{usuario}] Enviando vídeo: {message.Message}");
    }

    public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"[Instagram - @{usuario}] Enviando foto: {message.Message}");
    }

    public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"[Instagram - @{usuario}] Enviando arquivo: {message.Message}");
    }
}
