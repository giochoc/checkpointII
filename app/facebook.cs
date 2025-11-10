public class Facebook
{
    public void EnviarMensagem(string usuario, TextMessage message)
    {
        Console.WriteLine($"[Facebook - Usuário: {usuario}] Enviando mensagem de texto: {message.Message}");
    }

    public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"[Facebook - Usuário: {usuario}] Enviando vídeo: {message.Message}");
    }

    public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"[Facebook - Usuário: {usuario}] Enviando foto: {message.Message}");
    }

    public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"[Facebook - Usuário: {usuario}] Enviando arquivo: {message.Message}");
    }
}
