﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Kolokwium_nr2.Exceptions
{
    public class PlayerNotexistsException : Exception
    {
        public PlayerNotexistsException()
        {
        }

        public PlayerNotexistsException(string message) : base(message)
        {
        }

        public PlayerNotexistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        
    }
}
