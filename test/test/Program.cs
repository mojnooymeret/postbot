using System;
using Telegram.Bot;

namespace test
{
   internal class Program
   {
      private static string token { get; set; } = "1637936724:AAHDzt5zPYppuX63V3ISxvU8Xf9LIcxGOSc";
      private static TelegramBotClient client;
      static void Main(string[] args)
      {
         client = new TelegramBotClient(token);
         client.StartReceiving();
         Send();
         Console.ReadLine();
      }

      private static async void Send()
      {
         var now = DateTime.Now;
         await client.SendTextMessageAsync(885185553, now.Date.ToString());
      }
   }
}
