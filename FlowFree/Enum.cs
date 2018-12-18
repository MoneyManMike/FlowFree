﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowFree
{
    public enum ScreenStates
    {
        Game
    }
    public enum PieceType
    {
        None,
        Dot,
        Line,
        Turn,
        DotWithHalf,
        SmallDot
    }
    public enum Direction
    {
        None,
        Up,
        Down,
        Left,
        Right
    }
}
