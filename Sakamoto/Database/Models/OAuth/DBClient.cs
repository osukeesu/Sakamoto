﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakamoto.Database.Models.OAuth
{
	[Table("oauth_clients")]
	public class DBClient
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }
		[Column("user_id")]
		public int? UserId { get; set; }
		[Column("name")]
		public string Name { get; set; }
		[Column("secret")]
		public string Secret { get; set; }
		[Column("redirect")]
		public string RedirectURL { get; set; }
		[Column("password_client")]
		public bool IsPasswordClient { get; set; }
		[Column("revoked")]
		public bool Revoked { get; set; }
		[Column("created_at")]
		public long? CreatedAt { get; set; }
		[Column("updated_at")]
		public long? UpdatedAt { get; set; }
	}
}
