﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRLevelReader.Model;

namespace TR2Randomizer.Utilities
{
    internal static class SpatialConverters
    {
        internal static Location TransformToLevelSpace(Location loc, TRRoomInfo room)
        {
            if (loc.IsInRoomSpace)
            {
                return new Location
                {
                    Room = loc.Room,
                    X = (loc.X + room.X),
                    Y = (room.YBottom - loc.Y),
                    Z = (loc.Z + room.Z),
                    Difficulty = loc.Difficulty,
                    IsInRoomSpace = loc.IsInRoomSpace,
                    RequiresGlitch = loc.RequiresGlitch
                };
            }
            else
            {
                return loc;
            }
        }
    }
}
