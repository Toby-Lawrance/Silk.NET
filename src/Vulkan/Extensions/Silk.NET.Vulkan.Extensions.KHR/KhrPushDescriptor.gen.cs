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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_push_descriptor")]
    public unsafe partial class KhrPushDescriptor : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_push_descriptor";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetKHR")]
        public unsafe partial void CmdPushDescriptorSet([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetKHR")]
        public partial void CmdPushDescriptorSet([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] in WriteDescriptorSet pDescriptorWrites);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        public unsafe partial void CmdPushDescriptorSetWithTemplate([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        public partial void CmdPushDescriptorSetWithTemplate<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        public KhrPushDescriptor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

