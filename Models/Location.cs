﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locations.Models
{
	[Table("Locations")]
	public class Location
	{
		[Key]
		public int LocationId { get; set; }
		public string Name { get; set; }
	}
}