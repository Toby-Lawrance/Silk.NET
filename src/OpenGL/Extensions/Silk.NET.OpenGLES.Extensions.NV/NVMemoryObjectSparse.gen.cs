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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_memory_object_sparse")]
    public unsafe partial class NVMemoryObjectSparse : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_memory_object_sparse";
        [NativeApi(EntryPoint = "glBufferPageCommitmentMemNV")]
        public partial void BufferPageCommitmentMem([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong memOffset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glBufferPageCommitmentMemNV")]
        public partial void BufferPageCommitmentMem([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong memOffset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glNamedBufferPageCommitmentMemNV")]
        public partial void NamedBufferPageCommitmentMem([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong memOffset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexPageCommitmentMemNV")]
        public partial void TexPageCommitmentMem([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexPageCommitmentMemNV")]
        public partial void TexPageCommitmentMem([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexturePageCommitmentMemNV")]
        public partial void TexturePageCommitmentMem([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset, [Flow(FlowDirection.In)] bool commit);

        public NVMemoryObjectSparse(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

