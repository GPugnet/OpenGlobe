﻿#region License
//
// (C) Copyright 2010 Patrick Cozzi and Kevin Ring
//
// Distributed under the Boost Software License, Version 1.0.
// See License.txt or http://www.boost.org/LICENSE_1_0.txt.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenGlobe.Core;

namespace OpenGlobe.Scene.Terrain
{
    public abstract class RasterTerrainSource
    {
        public abstract GeodeticExtent Extent { get; }
        public abstract RasterTerrainLevelCollection Levels { get; }
    }
}