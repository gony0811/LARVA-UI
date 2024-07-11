﻿using EPLE.Core.Communication.Socket.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPLE.Core.Communication.Socket.Checker
{
    public interface IDuplicateChecker
    {
        bool Duplicate(IPacket paramReceivePacket, string paramString);
        bool Validate(IPacket rcvPacket);
    }
}
