﻿using System;

namespace cdcrush.lib.app
{
	/**
	 * An ASYNC CLI program that reports progress and complete statuses
	 */
	public interface ICliReport
	{
		// # USER READ
		string ERROR { get; }

		// # USER SET
		// Reports progress percent 
		Action<int> onProgress { get; set; }

		// # USER SET
		// OnComplete(Success), read ERROR for errors
		Action<bool> onComplete { get; set; } 
	}
}
