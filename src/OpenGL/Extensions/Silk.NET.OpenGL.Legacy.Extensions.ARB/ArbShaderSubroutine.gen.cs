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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_shader_subroutine")]
    public unsafe partial class ArbShaderSubroutine : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_subroutine";
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public unsafe partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public unsafe partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public unsafe partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public unsafe partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public unsafe partial void GetUniformSubroutine([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public partial void GetUniformSubroutine([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public unsafe partial void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public partial void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public unsafe partial void UniformSubroutines([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public partial void UniformSubroutines([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public unsafe partial void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public partial void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint indices);

        public ArbShaderSubroutine(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

