using System;
using System.ComponentModel.DataAnnotations;

namespace BPShop.Enities
{
	public class Order
	{
		[Key]
		public int ID { get; set; }
		public DateTime Time { get; set; }
		public string ProductIds { get; set; }
		public string Count { get; set; }
		[MaxLength(200)]
		public string Address { get; set; }
		[MaxLength(100)]
		public string HisName { get; set; }
		[MaxLength(100)]
		public string Email { get; set; }
		[MaxLength(20)]
		public string Phone { get; set; }
		[MaxLength(100)]
		public string RecipientName { get; set; }
		[MaxLength(100)]
		public string RecipientContact { get; set; }
		public PayType PayType { get; set; }
		public OrderStatuses OrderStatuses { get; set; }
		public DateTime DeliverDate { get; set; }
	}

	public enum OrderStatuses
	{
		NotReviewed,
		Confirmed,
		Declined,
		Compleated
	}

	public enum PayType
	{
		Kaspi,
		Cash,
	}
}