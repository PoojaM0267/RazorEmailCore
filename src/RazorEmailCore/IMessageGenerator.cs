﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorEmailCore
{
	public interface IMessageGenerator
	{
		string GenerateMessageBody(string template, object model);
	}
}
