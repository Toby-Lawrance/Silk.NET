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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_vertex_attrib_binding")]
    public unsafe partial class ArbVertexAttribBinding : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_attrib_binding";
        [NativeApi(EntryPoint = "glBindVertexBuffer")]
        public partial void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribBinding")]
        public partial void VertexAttribBinding([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        public partial void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        public partial void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexBindingDivisor")]
        public partial void VertexBindingDivisor([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        public ArbVertexAttribBinding(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

