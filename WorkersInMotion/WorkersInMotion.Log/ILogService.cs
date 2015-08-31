﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersInMotion.Log
{
    public interface ILogService
    {
        void Fatal(string message);
        void Error(string message);
        void Warn(string message);
        void Info(string message);
        void Debug(string message);
        void Error(string message, Exception exception);
    }
}
