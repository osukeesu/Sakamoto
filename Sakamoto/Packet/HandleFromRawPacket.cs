﻿using System;
using System.Collections.Generic;
using System.Text;
using osu.Shared.Serialization;
using Sakamoto.Enums;
using Sakamoto.Objects;
namespace Sakamoto.Packet.Parser
{
	class HandleFromRawPacket
	{
		public static SerializationReader Handle(RawPacket packet, SerializationReader reader)
		{
			switch (packet.getType()){
				default:
					Console.WriteLine("Not handling packets: " + packet.getType());
					return null;
			}
		}
	}
}
