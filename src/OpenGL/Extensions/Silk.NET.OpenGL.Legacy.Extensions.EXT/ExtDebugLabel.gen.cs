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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_debug_label")]
    public unsafe partial class ExtDebugLabel : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_debug_label";
        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glLabelObjectEXT")]
        public unsafe partial void LabelObject([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glLabelObjectEXT")]
        public partial void LabelObject([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte label);

        [NativeApi(EntryPoint = "glLabelObjectEXT")]
        public partial void LabelObject([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        public ExtDebugLabel(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

