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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_discard_framebuffer")]
    public unsafe partial class ExtDiscardFramebuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_discard_framebuffer";
        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public unsafe partial void DiscardFramebuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] EXT* attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public partial void DiscardFramebuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in EXT attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public unsafe partial void DiscardFramebuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public partial void DiscardFramebuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in InvalidateFramebufferAttachment attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public unsafe partial void DiscardFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] EXT* attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public partial void DiscardFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in EXT attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public unsafe partial void DiscardFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public partial void DiscardFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in InvalidateFramebufferAttachment attachments);

        public ExtDiscardFramebuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

