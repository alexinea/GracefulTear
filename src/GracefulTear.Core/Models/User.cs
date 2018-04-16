﻿using GracefulTear.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace GracefulTear.Core.Models
{
	public class User : IdentityUser, IAudited
	{
		/// <summary>
		/// Last modification date of this entity.
		/// </summary>
		public virtual DateTimeOffset? LastModificationTime { get; set; }

		/// <summary>
		/// Last modifier user of this entity.
		/// </summary>
		public virtual string LastModifierUserId { get; set; }

		/// <summary>
		/// Creation time of this entity.
		/// </summary>
		public virtual DateTimeOffset? CreationTime { get; set; }

		/// <summary>
		/// Creator of this entity.
		/// </summary>
		public virtual string CreatorUserId { get; set; }
	}
}
