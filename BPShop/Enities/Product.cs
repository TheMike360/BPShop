
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPShop.Enities
{
	public class Product
	{
		[Key]
		public int ID { get; set; }

		[Required(ErrorMessage = "Поле 'Name' обязательно для заполнения.")]
		[MaxLength(200, ErrorMessage = "Максимальная длина поля 'Name' - 200 символов.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Поле 'Cost' обязательно для заполнения.")]
		[Range(0, double.MaxValue, ErrorMessage = "Значение поля 'Cost' должно быть неотрицательным.")]
		public decimal Cost { get; set; }

		[MaxLength(2000, ErrorMessage = "Максимальная длина поля 'Description' - 2000 символов.")]
		[Required(ErrorMessage = "Поле 'Description' обязательно для заполнения.")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Поле 'Count' обязательно для заполнения.")]
		[Range(0, int.MaxValue, ErrorMessage = "Значение поля 'Count' должно быть неотрицательным.")]
		public int Count { get; set; }

		[Range(0, int.MaxValue, ErrorMessage = "Значение поля 'CountFlowersInBouquet' должно быть неотрицательным.")]
		public int? CountFlowersInBouquet { get; set; }

		[Required(ErrorMessage = "Поле 'ProductType' обязательно для заполнения.")]
		public ProductType ProductType { get; set; }

		[MaxLength(2000, ErrorMessage = "Максимальная длина поля 'SearchPrompt' - 2000 символов.")]
		[Required(ErrorMessage = "Поле 'SearchPrompt' обязательно для заполнения.")]
		public string SearchPrompt { get; set; }

		[MaxLength(200, ErrorMessage = "Максимальная длина поля 'ImgRef' - 200 символов.")]
		public string ImgRef { get; set; }

		[Required(ErrorMessage = "Поле 'FlowersType' обязательно для заполнения.")]
		public FlowersType FlowersType { get; set; }
	}

	public enum ProductType
	{
		Flowers,
		MonoBouquet,
		BoxFlowers,
		EvroBouquet,
		Toys,
		Ballons,
	}

	public enum FlowersType
	{
		None,
		Roses,
		Peonies,
		Tulips,
		Hydrangeas,
		PeonyRoses,
		ShrubRoses,
		Alstroemeria,
		Carnations,
		Dahlias,
		Gerberas,
		Gypsaphila,
		Calla,
		Irises,
		andyshy,
		Lilies,
		Orchids,
		Sunflowers,
		Ranunculus,
		Daisies,
		Lilac,
		DriedFlowers,
		Chrysanthemums,
		Anthuriums,
		Amaryllis,
		Gladioli,
		Lisianthus,
		ValleyLilies
	}
}