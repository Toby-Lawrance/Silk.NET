// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtDiscardRectanglesOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetDiscardRectangle(this ExtDiscardRectangles thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstDiscardRectangle, [Count(Count = 0)] uint discardRectangleCount, [Count(Computed = "discardRectangleCount"), Flow(FlowDirection.In)] ReadOnlySpan<Rect2D> pDiscardRectangles)
        {
            // SpanOverloader
            thisApi.CmdSetDiscardRectangle(commandBuffer, firstDiscardRectangle, discardRectangleCount, in pDiscardRectangles.GetPinnableReference());
        }

    }
}

