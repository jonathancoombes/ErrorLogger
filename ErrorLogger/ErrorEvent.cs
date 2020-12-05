using ErrorLogger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace ErrorLogger
{ 
   
   public class ErrorEvent: IErrorLogger
   {
       public event EventHandler<CustomErrorEventArgs> ErrorEventHandler;

        public string ErrorMessage  {get; set; }

        // Publisher
        public void ErrorLogger(string error)
        {
            ErrorMessage = error;
           
          ErrorEventHandler?.Invoke(this, new CustomErrorEventArgs(ErrorLevel.Critical, ErrorType.Data));

        }

        //Subscriber
       public void OnErrorEventHandler(object sender, CustomErrorEventArgs args)
       {
           Console.WriteLine($"A new error has been logged as: {ErrorMessage}.");
           Console.WriteLine($"The error has a priority level of: {args.errorLevel}.");
           Console.WriteLine($"Error Type: {args.errorType}.");
           Console.ReadLine();

       }
    }
    
        //Custom Event Args

        public class CustomErrorEventArgs: EventArgs
        {
        public ErrorLevel errorLevel { get; set; }
        public ErrorType errorType { get; set; }


        public CustomErrorEventArgs(ErrorLevel errorL, ErrorType errorT)
           {
               errorLevel = errorL;
               errorType = errorT;
           }



        }


}
