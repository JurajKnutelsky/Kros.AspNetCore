using System;

namespace Kros.AspNetCore.Exceptions
{
    /// <summary>
    /// Exception allowing to specify StatusCode for Http response.
    /// </summary>
    public class ErrorCodeException : Exception
    {
        /// <summary>
        /// StatusCode for Http response.
        /// </summary>
        public int StatusCode { get; private set; }

        /// <summary>
        /// Initializes a new instance of <see cref="ErrorCodeException" /> class.
        /// </summary>
        /// <param name="statusCode">StatusCode for Http response.</param>
        public ErrorCodeException(int statusCode)
            : this(statusCode, string.Format(Properties.Resources.ErrorCodeException, statusCode.ToString()))
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ErrorCodeException" /> class.
        /// </summary>
        /// <param name="statusCode">StatusCode for Http response.</param>
        /// <param name="message">Message.</param>
        public ErrorCodeException(int statusCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
