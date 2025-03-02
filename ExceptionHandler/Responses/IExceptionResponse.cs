﻿using System.Collections.Generic;

namespace YuraSoft.ExceptionHandler
{
	/// <summary>
	/// Exception response interface
	/// </summary>
	public interface IExceptionResponse
	{
		/// <summary>
		/// Type of error
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// HTTP status code
		/// </summary>
		public int StatusCode { get; set; }

		/// <summary>
		/// Key value pair enumerable of invalid request parameters
		/// </summary>
		public Dictionary<string, List<string>>? Errors { get; set; }
	}
}
