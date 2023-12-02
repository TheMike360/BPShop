using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace BPShop.Services
{
	public class TelegramBotService
	{
		private readonly ITelegramBotClient botClient;

		public TelegramBotService(string botToken)
		{
			botClient = new TelegramBotClient(botToken);
		}

		public void StartReceiving()
		{
			var token = new CancellationTokenSource();
			botClient.StartReceiving(OnMessage, ErrorMessage, new ReceiverOptions { AllowedUpdates = { } }, token.Token);
		}

		private async Task OnMessage(ITelegramBotClient bot, Update update, CancellationToken cancellationToken)
		{
		}

		private async Task ErrorMessage(ITelegramBotClient bot, Exception exception, CancellationToken cancellationToken)
		{
		}



		public async Task ProcessMessageAsync(long chatId, string messageText)
		{
			await botClient.SendTextMessageAsync(chatId, messageText);
		}
	}
}