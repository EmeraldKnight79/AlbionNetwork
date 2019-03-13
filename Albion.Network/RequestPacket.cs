﻿using System.Collections.Generic;

namespace Albion.Network
{
    internal class RequestPacket
    {
        public RequestPacket(byte OperationCode, Dictionary<byte, object> Parameters)
        {
            this.OperationCode = OperationCode;
            this.Parameters = Parameters;
        }

        public byte OperationCode { get; }
        public Dictionary<byte, object> Parameters { get; }
    }
}