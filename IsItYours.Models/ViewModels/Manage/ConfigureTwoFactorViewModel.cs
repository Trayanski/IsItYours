﻿using System.Collections.Generic;

namespace IsItYours.Models.ViewModels.Manage
{
	public class ConfigureTwoFactorViewModel
	{
		public string SelectedProvider { get; set; }
		public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
	}
}
