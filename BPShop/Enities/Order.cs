using System;
using System.ComponentModel.DataAnnotations;

namespace BPShop.Enities
{
	public class Order
    {
        [Key]
        public int ID { get; set; }

        public DateTime Time { get; set; }

        [Required(ErrorMessage = "Не удалось получить список товаров из корзины")]
        public string ProductIds { get; set; }

        [Required(ErrorMessage = "Не удалось получить список количества товаров из корзины")]
        public string Count { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage = "Не корректно заполенено поле адрес")]
        public string Address { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Не корректно заполенено поле ваше имя")]
        public string HisName { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Не корректно заполенено поле Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Не корректно заполенено поле ваш номер телефона")]
        public string Phone { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Не корректно заполенено поле имя получателя")]
        public string RecipientName { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Не корректно заполенено поле контакты получателя")]
        public string RecipientContact { get; set; }

        [Required(ErrorMessage = "Не корректно заполенено поле способ оплаты")]
        public PayType PayType { get; set; }

        public OrderStatuses OrderStatuses { get; set; }

        [Required(ErrorMessage = "Не корректно заполенено поле дата доставки")]
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