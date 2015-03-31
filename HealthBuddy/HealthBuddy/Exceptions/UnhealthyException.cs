
namespace HealthBuddy.Exceptions
{
    using System;
    using System.Windows;
    public class UnhealthyException : Exception
    {
        //TODO: Develop exception message...
        public UnhealthyException() : base() { }
        public UnhealthyException(string message)
            : base(message)
        {
            MessageBox.Show(message);
        }
    }
}
