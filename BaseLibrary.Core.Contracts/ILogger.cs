using System;
using System.Collections.Generic;

namespace BaseLibrary.Core.Contracts { 
   public interface ILogger
   {
       void Info(object message, Dictionary<string, string> additionalColumns = null);

       void Error(object message, Exception exception, Dictionary<string, string> additionalColumns = null);
    }
}
