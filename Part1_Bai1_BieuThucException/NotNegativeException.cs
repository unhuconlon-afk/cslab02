using System;

namespace Part1_Bai1_BieuThucException
{
    /// <summary>
    /// Ngoại lệ tùy biến khi biểu thức dưới dấu căn âm (< 0)
    /// </summary>
    public class NotNegativeException : Exception
    {
        public NotNegativeException() : base("Lỗi: Biểu thức dưới dấu căn không được âm (3x + 2y < 0)!")
        {
        }

        public NotNegativeException(string message) : base(message)
        {
        }

        public NotNegativeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
