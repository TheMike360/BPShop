
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPShop.Enities
{
	public class Product
	{
		[Key]
		public int ID { get; set; }
		[MaxLength(200)]
		public string Name { get; set; }
		public decimal Cost { get; set; }
		[MaxLength(2000)]
		public string Description { get; set; }
		public int Count { get; set; }
		public int? CountFlowersInBouquet { get; set; }
		public ProductType ProductType { get; set; }
		[MaxLength(2000)]
		public string SearhPrompt { get; set; }
		[MaxLength(200)]
		public string ImgRef { get; set; }
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