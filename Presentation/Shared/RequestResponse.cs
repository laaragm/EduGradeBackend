namespace Presentation.Shared
{
	public class RequestResponse
	{
		public bool IsSuccess { get; set; }
		public string Message { get; set; }
		public object? Data { get; set; }

		public static RequestResponse Success(string message, object data)
		{
			return new RequestResponse
			{
				IsSuccess = true,
				Message = message,
				Data = data
			};
		}

		public static RequestResponse Success(string message)
		{
			return new RequestResponse
			{
				IsSuccess = true,
				Message = message,
			};
		}

		public static RequestResponse Failure(string message)
		{
			return new RequestResponse
			{
				IsSuccess = false,
				Message = message
			};
		}
	}
}
