﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class SubCategory
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Value { get; set; }
		[JsonIgnore]
		[ForeignKey("CategoryId")]
		public int CategoryId { get; set; }
		[JsonIgnore]
		public Category? Category { get; set; }
		public List<Product> Products { get; set; } = new();
	}
}
