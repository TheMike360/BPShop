using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BPShop.Services
{
	public class TelegramBotService
	{
		public async Task ProcessMessageAsync(string chatId, string messageText)
		{
			string botToken = "6007708993:AAG6yGNLeGOJ-v6QLjyV6XdzkTKX9crBAoQ";

			string apiUrl = $"https://api.telegram.org/bot{botToken}/sendMessage";

			using (HttpClient httpClient = new HttpClient())
			{
				var parameters = new FormUrlEncodedContent(new[]
				{
					new KeyValuePair<string, string>("chat_id", chatId),
					new KeyValuePair<string, string>("text", messageText)
				});

				HttpResponseMessage response = await httpClient.PostAsync(apiUrl, parameters);
			}
		}
	}
}