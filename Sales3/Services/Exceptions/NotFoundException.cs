using System;

namespace Sales3.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException (string message):base(message)
        {

        }
    }
}
