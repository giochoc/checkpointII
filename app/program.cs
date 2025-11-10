﻿// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Para qual canal você quer enviar mensagem?");
        Console.WriteLine("1. WhatsApp");
        Console.WriteLine("2. Telegram");
        Console.WriteLine("3. Instagram");
        Console.WriteLine("4. Facebook");

        int canal = 0;
        string resposta = Console.ReadLine();

        if (!int.TryParse(resposta, out canal))
        {
            Console.WriteLine("Opção inválida");
            return;
        }

        // Cria mensagens de exemplo
        TextMessage textMessage = new TextMessage("Olá, esta é uma mensagem de texto!");
        VideoMessage videoMessage = new VideoMessage("Vídeo enviado com sucesso!");
        PhotoMessage photoMessage = new PhotoMessage("Foto enviada com sucesso!");
        FileMessage fileMessage = new FileMessage("Arquivo compartilhado!");

        // Seleciona o canal e envia mensagens
        switch (canal)
        {
            case 1:
                var whatsapp = new WhatsApp();
                whatsapp.EnviarMensagem("12345678", textMessage);
                whatsapp.EnviarMensagem("87654321", videoMessage);
                whatsapp.EnviarMensagem("11122233", photoMessage);
                whatsapp.EnviarMensagem("33322211", fileMessage);
                break;

            case 2:
                var telegram = new Telegram();
                telegram.EnviarMensagem("99887766", textMessage);
                telegram.EnviarMensagem("66554433", videoMessage);
                telegram.EnviarMensagem("55443322", photoMessage);
                telegram.EnviarMensagem("22113344", fileMessage);
                break;

            case 3:
                var instagram = new Instagram();
                instagram.EnviarMensagem("usuario_insta", textMessage);
                instagram.EnviarMensagem("usuario_insta", videoMessage);
                instagram.EnviarMensagem("usuario_insta", photoMessage);
                instagram.EnviarMensagem("usuario_insta", fileMessage);
                break;

            case 4:
                var facebook = new facebook();
                facebook.EnviarMensagem("usuario_fb", textMessage);
                facebook.EnviarMensagem("usuario_fb", videoMessage);
                facebook.EnviarMensagem("usuario_fb", photoMessage);
                facebook.EnviarMensagem("usuario_fb", fileMessage);
                break;

            default:
                Console.WriteLine("Canal inválido. Encerrando programa.");
                break;
        }

        Console.WriteLine("\nMensagens enviadas com sucesso!");
    }
}