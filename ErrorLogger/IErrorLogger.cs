using System;

namespace ErrorLogger
{

    public enum ErrorLevel
    {
        Verbose = 0,
        Medium = 1,
        High = 2,
        Critical = 3
    }

   public enum ErrorType
    {
        System,
        User,
        Data
    }

    public interface IErrorLogger
    {

        string ErrorMessage { get; set; }
        void ErrorLogger(string error);

        void OnErrorEventHandler(object sender, CustomErrorEventArgs args);
        event EventHandler<CustomErrorEventArgs> ErrorEventHandler;

    }


}
