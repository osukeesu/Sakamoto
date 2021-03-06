﻿using Microsoft.AspNetCore.Mvc;
using Sakamoto.Database.Models;
using Sakamoto.Database.Models.OAuth;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Sakamoto.Controllers
{
	public class SakamotoController : ControllerBase
	{
		// This two property should exists when [Authorize] Attribute is set.
		public DBUser _user 
		{
			get => HttpContext.Items["user"] as DBUser;
		}
		public DBAccessToken _access
		{
			get => HttpContext.Items["access"] as DBAccessToken;
		}

		public ActionResult SendError(int statuscode, string message)
			=> StatusCode(statuscode, new
			{
				error = message
			});
		public ActionResult SendException(int statuscode, Exception e, bool send)
		{
			var msg = new
			{
				error = "Error while performing the response.",
				exception = new
				{
					message = e.Message
				}
			};
			return StatusCode(statuscode);
		}

		public DateTimeOffset ParseDate(string value) => DateTimeOffset.Parse(value, null, DateTimeStyles.AssumeUniversal);
	}
}
