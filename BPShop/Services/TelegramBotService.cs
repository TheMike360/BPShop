using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace BPShop.Services
{
	public class TelegramBotService
	{
		private readonly ITelegramBotClient _botClient;

		public TelegramBotService(string botToken)
		{
			_botClient = new TelegramBotClient(botToken);
			_botClient.OnMessage += BotOnMessageReceived;
			_botClient.OnMessageEdited += BotOnMessageReceived;
		}

		public void StartReceiving()
		{
			_botClient.StartReceiving();
		}

		public void StopReceiving()
		{
			_botClient.StopReceiving();
		}

		private async void BotOnMessageReceived(object sender, MessageEventArgs e)
		{
			var message = e.Message;

			if (message.Text != null)
			{
				//Console.WriteLine($"Received a text message in chat {message.Chat.Id}: {message.Text}");

				//await ProcessMessageAsync(message.Chat.Id, message.Text);
			}
		}

		public async Task ProcessMessageAsync(long chatId, string messageText)
		{
			await _botClient.SendTextMessageAsync(chatId, $"Received message: {messageText}");
		}
	}
}