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
    [Extension("VK_KHR_display_swapchain")]
    public unsafe partial class KhrDisplaySwapchain : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_display_swapchain";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] out SwapchainKHR pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] out SwapchainKHR pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] in SwapchainCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] in SwapchainCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] out SwapchainKHR pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] in SwapchainCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] in SwapchainCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] out SwapchainKHR pSwapchains);

        public KhrDisplaySwapchain(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

