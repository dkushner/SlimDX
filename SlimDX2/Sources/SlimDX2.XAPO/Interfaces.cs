// Copyright (c) 2007-2010 SlimDX Group
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

//------------------------------------------------------------------------------
// <auto-generated>
//     Interfaces for SlimDX2.XAPO namespace.
//     This code was generated by a tool.
//     Date : 11/14/2010 00:36:11
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

namespace SlimDX2.XAPO {

    
    /// <summary>	
    /// Interface that defines an XAPO, allowing it to be used in an XAudio2 effect chain.	
    /// </summary>	
    /// <unmanaged>IXAPO</unmanaged>
    [Guid("a90bc001-e897-e897-55e4-9e4700000000")]
    public partial interface AudioProcessor {
        
        
        /// <summary>	
        /// Returns the registration properties of an XAPO.	
        /// </summary>	
        /// <param name="registrationPropertiesRef"> Receives a pointer to a <see cref="SlimDX2.XAPO.RegistrationProperties"/> structure containing theregistration properties the XAPO was created with; use XAPOFree to free thestructure.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::GetRegistrationProperties([Out] XAPO_REGISTRATION_PROPERTIES** ppRegistrationProperties)</unmanaged>
        /* public SlimDX2.Result GetRegistrationProperties(out SlimDX2.XAPO.RegistrationProperties registrationPropertiesRef) */

        
        /// <summary>	
        /// Queries if a specific input format is supported for a given output format.	
        /// </summary>	
        /// <param name="outputFormatRef">Output format.</param>
        /// <param name="requestedInputFormatRef">Input format to check for being supported.</param>
        /// <param name="supportedInputFormatRef"> If not NULL, and the input format is not supported for the given output format, ppSupportedInputFormat returns a  pointer to the closest input format that is supported. Use {{XAPOFree}} to free the returned structure. </param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::IsInputFormatSupported([None] const WAVEFORMATEX* pOutputFormat,[None] const WAVEFORMATEX* pRequestedInputFormat,[Out, Optional] WAVEFORMATEX** ppSupportedInputFormat)</unmanaged>
        /* public SlimDX2.Result IsInputFormatSupported(ref SlimDX2.Windows.WaveFormat outputFormatRef, ref SlimDX2.Windows.WaveFormat requestedInputFormatRef, out SlimDX2.Windows.WaveFormat supportedInputFormatRef) */

        
        /// <summary>	
        /// Queries if a specific output format is supported for a given input format.	
        /// </summary>	
        /// <param name="inputFormatRef">[in]  Input format. </param>
        /// <param name="requestedOutputFormatRef">[in]  Output format to check for being supported. </param>
        /// <param name="supportedOutputFormatRef">[out]  If not NULL and the output format is not supported for the given input format, ppSupportedOutputFormat returns a pointer to the closest output format that is supported. Use {{XAPOFree}} to free the returned structure. </param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::IsOutputFormatSupported([None] const WAVEFORMATEX* pInputFormat,[None] const WAVEFORMATEX* pRequestedOutputFormat,[Out, Optional] WAVEFORMATEX** ppSupportedOutputFormat)</unmanaged>
        /* public SlimDX2.Result IsOutputFormatSupported(ref SlimDX2.Windows.WaveFormat inputFormatRef, ref SlimDX2.Windows.WaveFormat requestedOutputFormatRef, out SlimDX2.Windows.WaveFormat supportedOutputFormatRef) */

        
        /// <summary>	
        /// Performs any effect-specific initialization.	
        /// </summary>	
        /// <param name="dataRef"> Effect-specific initialization parameters, may be NULL if DataByteSize is 0. </param>
        /// <param name="dataByteSize"> Size of pData in bytes, may be 0 if pData is NULL. </param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::Initialize([In, Buffer, Optional] const void* pData,[None] UINT32 DataByteSize)</unmanaged>
        /* public SlimDX2.Result Initialize(IntPtr dataRef, int dataByteSize) */

        
        /// <summary>	
        /// Resets variables dependent on frame history. 	
        /// </summary>	
        /// <unmanaged>void IXAPO::Reset()</unmanaged>
        /* public void Reset() */

        
        /// <summary>	
        /// Called by XAudio2 to lock the input and output configurations of an XAPO allowing it to	
        /// do any final initialization before {{Process}} is called on the realtime thread.	
        /// </summary>	
        /// <param name="inputLockedParameterCount"> Number of elements in ppInputLockedParameters.  Must be within the <see cref="SlimDX2.XAPO.RegistrationProperties"/>.MinInputBufferCount and  <see cref="SlimDX2.XAPO.RegistrationProperties"/>.MaxInputBufferCount values passed to {{CXAPOBase::CXAPOBase}}.</param>
        /// <param name="inputLockedParametersRef"> Array of input <see cref="SlimDX2.XAPO.LockParameters"/> structures.pInputLockedParameters may be NULL if InputLockedParameterCount is 0, otherwise itmust have InputLockedParameterCount elements.</param>
        /// <param name="outputLockedParameterCount"> Number of elements in ppOutputLockedParameters.  Must be within the <see cref="SlimDX2.XAPO.RegistrationProperties"/>.MinOutputBufferCount and  <see cref="SlimDX2.XAPO.RegistrationProperties"/>.MaxOutputBufferCount values passed to {{CXAPOBase::CXAPOBase}}.  If the XAPO_FLAG_BUFFERCOUNT_MUST_MATCH flag was specified in <see cref="SlimDX2.XAPO.RegistrationProperties"/>.Flags then OutputLockedParameterCount must equalInputLockedParameterCount.</param>
        /// <param name="outputLockedParametersRef"> Array of output <see cref="SlimDX2.XAPO.LockParameters"/> structures.pOutputLockedParameters may be NULL if OutputLockedParameterCount is 0, otherwise itmust have OutputLockedParameterCount elements.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::LockForProcess([None] UINT32 InputLockedParameterCount,[In, Buffer] const XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pInputLockedParameters,[None] UINT32 OutputLockedParameterCount,[In, Buffer] const XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pOutputLockedParameters)</unmanaged>
        /* public SlimDX2.Result LockForProcess(int inputLockedParameterCount, SlimDX2.XAPO.LockParameters[] inputLockedParametersRef, int outputLockedParameterCount, SlimDX2.XAPO.LockParameters[] outputLockedParametersRef) */

        
        /// <summary>	
        /// Deallocates variables that were allocated with the {{LockForProcess}} method.	
        /// </summary>	
        /// <unmanaged>void IXAPO::UnlockForProcess()</unmanaged>
        /* public void UnlockForProcess() */

        
        /// <summary>	
        /// Runs the XAPO's digital signal processing (DSP) code on the given input and output buffers.	
        /// </summary>	
        /// <param name="inputProcessParameterCount">[in]          Number of elements in pInputProcessParameters. Note XAudio2 currently supports only one input stream and one output stream. </param>
        /// <param name="inputProcessParametersRef">[in]          Input array of  <see cref="SlimDX2.XAPO.BufferParameters"/> structures.         </param>
        /// <param name="outputProcessParameterCount">[in]          Number of elements in pOutputProcessParameters. Note XAudio2 currently supports only one input stream and one output stream. </param>
        /// <param name="outputProcessParametersRef">[in, out]          Output array of <see cref="SlimDX2.XAPO.BufferParameters"/> structures.  On input, the value of <see cref="SlimDX2.XAPO.BufferParameters"/>.ValidFrameCount indicates the number of frames  that the XAPO should write to the output buffer.  On output, the value of <see cref="SlimDX2.XAPO.BufferParameters"/>.ValidFrameCount indicates the actual number of frames written.         </param>
        /// <param name="isEnabled"> TRUE to process normally; FALSE to process thru.  See Remarks for additional information.         </param>
        /// <unmanaged>void IXAPO::Process([None] UINT32 InputProcessParameterCount,[In, Buffer, Optional] const XAPO_PROCESS_BUFFER_PARAMETERS* pInputProcessParameters,[None] UINT32 OutputProcessParameterCount,[In, Buffer] XAPO_PROCESS_BUFFER_PARAMETERS* pOutputProcessParameters,[None] BOOL IsEnabled)</unmanaged>
        /* public void Process(int inputProcessParameterCount, SlimDX2.XAPO.BufferParameters[] inputProcessParametersRef, int outputProcessParameterCount, SlimDX2.XAPO.BufferParameters[] outputProcessParametersRef, bool isEnabled) */

        
        /// <summary>	
        /// Returns the number of input frames required to generate the given number of output frames.	
        /// </summary>	
        /// <param name="outputFrameCount">The number of output frames desired.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>UINT32 IXAPO::CalcInputFrames([None] UINT32 OutputFrameCount)</unmanaged>
        /* public int CalcInputFrames(int outputFrameCount) */

        
        /// <summary>	
        /// Returns the number of output frames that will be generated from a given number of input frames.	
        /// </summary>	
        /// <param name="inputFrameCount">The number of input frames.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>UINT32 IXAPO::CalcOutputFrames([None] UINT32 InputFrameCount)</unmanaged>
        /* public int CalcOutputFrames(int inputFrameCount) */

    }
    
    /// <summary>	
    /// An optional interface that allows an XAPO to use effect-specific parameters.	
    /// </summary>	
    /// <unmanaged>IXAPOParameters</unmanaged>
    [Guid("a90bc001-e897-e897-55e4-9e4700000001")]
    internal partial interface ParameterProvider {
        
        
        /// <summary>	
        /// Sets effect-specific parameters.	
        /// </summary>	
        /// <param name="arametersRef"> Effect-specific parameter block. </param>
        /// <param name="parameterByteSize"> Size of pParameters, in bytes. </param>
        /// <unmanaged>void IXAPOParameters::SetParameters([In, Buffer] const void* pParameters,[None] UINT32 ParameterByteSize)</unmanaged>
        /* public void SetParameters(IntPtr arametersRef, int parameterByteSize) */

        
        /// <summary>	
        /// Gets the current values for any effect-specific parameters.	
        /// </summary>	
        /// <param name="arametersRef">[in, out]  Receives an effect-specific parameter block. </param>
        /// <param name="parameterByteSize">[in]  Size of pParameters, in bytes. </param>
        /// <unmanaged>void IXAPOParameters::GetParameters([Out, Buffer] void* pParameters,[None] UINT32 ParameterByteSize)</unmanaged>
        /* public void GetParameters(IntPtr arametersRef, int parameterByteSize) */

    }
    
    /// <summary>	
    /// Interface that defines an XAPO, allowing it to be used in an XAudio2 effect chain.	
    /// </summary>	
    /// <unmanaged>IXAPO</unmanaged>
    public abstract partial class AudioProcessorNative : SlimDX2.ComObject, SlimDX2.XAPO.AudioProcessor {
        public AudioProcessorNative(IntPtr basePtr) : base(basePtr) {
        }
        
        
        /// <summary>	
        /// Returns the registration properties of an XAPO.	
        /// </summary>	
        /// <param name="registrationPropertiesRef"> Receives a pointer to a <see cref="SlimDX2.XAPO.RegistrationProperties"/> structure containing theregistration properties the XAPO was created with; use XAPOFree to free thestructure.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::GetRegistrationProperties([Out] XAPO_REGISTRATION_PROPERTIES** ppRegistrationProperties)</unmanaged>
        internal SlimDX2.Result GetRegistrationProperties_(out SlimDX2.XAPO.RegistrationProperties registrationPropertiesRef) {
            unsafe {
                SlimDX2.XAPO.RegistrationProperties.__Native registrationPropertiesRef_ = new SlimDX2.XAPO.RegistrationProperties.__Native();
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)SlimDX2.XAPO.LocalInterop.Calliint(_nativePointer, 3 * 4, &registrationPropertiesRef_);
                registrationPropertiesRef = new SlimDX2.XAPO.RegistrationProperties();
                registrationPropertiesRef.__MarshalFrom(ref registrationPropertiesRef_);
                __result__.CheckError();
                return __result__;
            }
        }
        
        /// <summary>	
        /// Queries if a specific input format is supported for a given output format.	
        /// </summary>	
        /// <param name="outputFormatRef">Output format.</param>
        /// <param name="requestedInputFormatRef">Input format to check for being supported.</param>
        /// <param name="supportedInputFormatRef"> If not NULL, and the input format is not supported for the given output format, ppSupportedInputFormat returns a  pointer to the closest input format that is supported. Use {{XAPOFree}} to free the returned structure. </param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::IsInputFormatSupported([None] const WAVEFORMATEX* pOutputFormat,[None] const WAVEFORMATEX* pRequestedInputFormat,[Out, Optional] WAVEFORMATEX** ppSupportedInputFormat)</unmanaged>
        internal SlimDX2.Result IsInputFormatSupported_(ref SlimDX2.Windows.WaveFormat outputFormatRef, ref SlimDX2.Windows.WaveFormat requestedInputFormatRef, out SlimDX2.Windows.WaveFormat supportedInputFormatRef) {
            unsafe {
                SlimDX2.Windows.WaveFormat.__Native outputFormatRef_ = new SlimDX2.Windows.WaveFormat.__Native();
                outputFormatRef.__MarshalTo(ref outputFormatRef_);
                SlimDX2.Windows.WaveFormat.__Native requestedInputFormatRef_ = new SlimDX2.Windows.WaveFormat.__Native();
                requestedInputFormatRef.__MarshalTo(ref requestedInputFormatRef_);
                SlimDX2.Windows.WaveFormat.__Native supportedInputFormatRef_ = new SlimDX2.Windows.WaveFormat.__Native();
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)SlimDX2.XAPO.LocalInterop.Calliint(_nativePointer, 4 * 4, &outputFormatRef_, &requestedInputFormatRef_, &supportedInputFormatRef_);
                outputFormatRef.__MarshalFrom(ref outputFormatRef_);
                outputFormatRef_.__MarshalFree();
                requestedInputFormatRef.__MarshalFrom(ref requestedInputFormatRef_);
                requestedInputFormatRef_.__MarshalFree();
                supportedInputFormatRef = new SlimDX2.Windows.WaveFormat();
                supportedInputFormatRef.__MarshalFrom(ref supportedInputFormatRef_);
                __result__.CheckError();
                return __result__;
            }
        }
        
        /// <summary>	
        /// Queries if a specific output format is supported for a given input format.	
        /// </summary>	
        /// <param name="inputFormatRef">[in]  Input format. </param>
        /// <param name="requestedOutputFormatRef">[in]  Output format to check for being supported. </param>
        /// <param name="supportedOutputFormatRef">[out]  If not NULL and the output format is not supported for the given input format, ppSupportedOutputFormat returns a pointer to the closest output format that is supported. Use {{XAPOFree}} to free the returned structure. </param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::IsOutputFormatSupported([None] const WAVEFORMATEX* pInputFormat,[None] const WAVEFORMATEX* pRequestedOutputFormat,[Out, Optional] WAVEFORMATEX** ppSupportedOutputFormat)</unmanaged>
        internal SlimDX2.Result IsOutputFormatSupported_(ref SlimDX2.Windows.WaveFormat inputFormatRef, ref SlimDX2.Windows.WaveFormat requestedOutputFormatRef, out SlimDX2.Windows.WaveFormat supportedOutputFormatRef) {
            unsafe {
                SlimDX2.Windows.WaveFormat.__Native inputFormatRef_ = new SlimDX2.Windows.WaveFormat.__Native();
                inputFormatRef.__MarshalTo(ref inputFormatRef_);
                SlimDX2.Windows.WaveFormat.__Native requestedOutputFormatRef_ = new SlimDX2.Windows.WaveFormat.__Native();
                requestedOutputFormatRef.__MarshalTo(ref requestedOutputFormatRef_);
                SlimDX2.Windows.WaveFormat.__Native supportedOutputFormatRef_ = new SlimDX2.Windows.WaveFormat.__Native();
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)SlimDX2.XAPO.LocalInterop.Calliint(_nativePointer, 5 * 4, &inputFormatRef_, &requestedOutputFormatRef_, &supportedOutputFormatRef_);
                inputFormatRef.__MarshalFrom(ref inputFormatRef_);
                inputFormatRef_.__MarshalFree();
                requestedOutputFormatRef.__MarshalFrom(ref requestedOutputFormatRef_);
                requestedOutputFormatRef_.__MarshalFree();
                supportedOutputFormatRef = new SlimDX2.Windows.WaveFormat();
                supportedOutputFormatRef.__MarshalFrom(ref supportedOutputFormatRef_);
                __result__.CheckError();
                return __result__;
            }
        }
        
        /// <summary>	
        /// Performs any effect-specific initialization.	
        /// </summary>	
        /// <param name="dataRef"> Effect-specific initialization parameters, may be NULL if DataByteSize is 0. </param>
        /// <param name="dataByteSize"> Size of pData in bytes, may be 0 if pData is NULL. </param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::Initialize([In, Buffer, Optional] const void* pData,[None] UINT32 DataByteSize)</unmanaged>
        internal SlimDX2.Result Initialize_(IntPtr dataRef, int dataByteSize) {
            unsafe {
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)SlimDX2.XAPO.LocalInterop.Calliint(_nativePointer, 6 * 4, (void*)dataRef, dataByteSize);
                __result__.CheckError();
                return __result__;
            }
        }
        
        /// <summary>	
        /// Resets variables dependent on frame history. 	
        /// </summary>	
        /// <unmanaged>void IXAPO::Reset()</unmanaged>
        internal void Reset_() {
            unsafe {
                SlimDX2.XAPO.LocalInterop.Callivoid(_nativePointer, 7 * 4);
            }
        }
        
        /// <summary>	
        /// Called by XAudio2 to lock the input and output configurations of an XAPO allowing it to	
        /// do any final initialization before {{Process}} is called on the realtime thread.	
        /// </summary>	
        /// <param name="inputLockedParameterCount"> Number of elements in ppInputLockedParameters.  Must be within the <see cref="SlimDX2.XAPO.RegistrationProperties"/>.MinInputBufferCount and  <see cref="SlimDX2.XAPO.RegistrationProperties"/>.MaxInputBufferCount values passed to {{CXAPOBase::CXAPOBase}}.</param>
        /// <param name="inputLockedParametersRef"> Array of input <see cref="SlimDX2.XAPO.LockParameters"/> structures.pInputLockedParameters may be NULL if InputLockedParameterCount is 0, otherwise itmust have InputLockedParameterCount elements.</param>
        /// <param name="outputLockedParameterCount"> Number of elements in ppOutputLockedParameters.  Must be within the <see cref="SlimDX2.XAPO.RegistrationProperties"/>.MinOutputBufferCount and  <see cref="SlimDX2.XAPO.RegistrationProperties"/>.MaxOutputBufferCount values passed to {{CXAPOBase::CXAPOBase}}.  If the XAPO_FLAG_BUFFERCOUNT_MUST_MATCH flag was specified in <see cref="SlimDX2.XAPO.RegistrationProperties"/>.Flags then OutputLockedParameterCount must equalInputLockedParameterCount.</param>
        /// <param name="outputLockedParametersRef"> Array of output <see cref="SlimDX2.XAPO.LockParameters"/> structures.pOutputLockedParameters may be NULL if OutputLockedParameterCount is 0, otherwise itmust have OutputLockedParameterCount elements.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IXAPO::LockForProcess([None] UINT32 InputLockedParameterCount,[In, Buffer] const XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pInputLockedParameters,[None] UINT32 OutputLockedParameterCount,[In, Buffer] const XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pOutputLockedParameters)</unmanaged>
        internal SlimDX2.Result LockForProcess_(int inputLockedParameterCount, SlimDX2.XAPO.LockParameters[] inputLockedParametersRef, int outputLockedParameterCount, SlimDX2.XAPO.LockParameters[] outputLockedParametersRef) {
            unsafe {
                SlimDX2.XAPO.LockParameters.__Native[] inputLockedParametersRef__ = new SlimDX2.XAPO.LockParameters.__Native[inputLockedParametersRef.Length];
                for (int i = 0; i < inputLockedParametersRef.Length; i++)
                    inputLockedParametersRef[i].__MarshalTo(ref inputLockedParametersRef__[i]);				
                SlimDX2.XAPO.LockParameters.__Native[] outputLockedParametersRef__ = new SlimDX2.XAPO.LockParameters.__Native[outputLockedParametersRef.Length];
                for (int i = 0; i < outputLockedParametersRef.Length; i++)
                    outputLockedParametersRef[i].__MarshalTo(ref outputLockedParametersRef__[i]);				
                SlimDX2.Result __result__;
                fixed (void* inputLockedParametersRef_ = &inputLockedParametersRef__[0])
                    fixed (void* outputLockedParametersRef_ = &outputLockedParametersRef__[0])
                        __result__= (SlimDX2.Result)SlimDX2.XAPO.LocalInterop.Calliint(_nativePointer, 8 * 4, inputLockedParameterCount, inputLockedParametersRef_, outputLockedParameterCount, outputLockedParametersRef_);
                for (int i = 0; i < inputLockedParametersRef.Length; i++)
                    inputLockedParametersRef__[i].__MarshalFree();				
                for (int i = 0; i < outputLockedParametersRef.Length; i++)
                    outputLockedParametersRef__[i].__MarshalFree();				
                __result__.CheckError();
                return __result__;
            }
        }
        
        /// <summary>	
        /// Deallocates variables that were allocated with the {{LockForProcess}} method.	
        /// </summary>	
        /// <unmanaged>void IXAPO::UnlockForProcess()</unmanaged>
        internal void UnlockForProcess_() {
            unsafe {
                SlimDX2.XAPO.LocalInterop.Callivoid(_nativePointer, 9 * 4);
            }
        }
        
        /// <summary>	
        /// Runs the XAPO's digital signal processing (DSP) code on the given input and output buffers.	
        /// </summary>	
        /// <param name="inputProcessParameterCount">[in]          Number of elements in pInputProcessParameters. Note XAudio2 currently supports only one input stream and one output stream. </param>
        /// <param name="inputProcessParametersRef">[in]          Input array of  <see cref="SlimDX2.XAPO.BufferParameters"/> structures.         </param>
        /// <param name="outputProcessParameterCount">[in]          Number of elements in pOutputProcessParameters. Note XAudio2 currently supports only one input stream and one output stream. </param>
        /// <param name="outputProcessParametersRef">[in, out]          Output array of <see cref="SlimDX2.XAPO.BufferParameters"/> structures.  On input, the value of <see cref="SlimDX2.XAPO.BufferParameters"/>.ValidFrameCount indicates the number of frames  that the XAPO should write to the output buffer.  On output, the value of <see cref="SlimDX2.XAPO.BufferParameters"/>.ValidFrameCount indicates the actual number of frames written.         </param>
        /// <param name="isEnabled"> TRUE to process normally; FALSE to process thru.  See Remarks for additional information.         </param>
        /// <unmanaged>void IXAPO::Process([None] UINT32 InputProcessParameterCount,[In, Buffer, Optional] const XAPO_PROCESS_BUFFER_PARAMETERS* pInputProcessParameters,[None] UINT32 OutputProcessParameterCount,[In, Buffer] XAPO_PROCESS_BUFFER_PARAMETERS* pOutputProcessParameters,[None] BOOL IsEnabled)</unmanaged>
        internal void Process_(int inputProcessParameterCount, SlimDX2.XAPO.BufferParameters[] inputProcessParametersRef, int outputProcessParameterCount, SlimDX2.XAPO.BufferParameters[] outputProcessParametersRef, bool isEnabled) {
            unsafe {
                SlimDX2.XAPO.BufferParameters[] inputProcessParametersRef__ = inputProcessParametersRef ?? new SlimDX2.XAPO.BufferParameters[1];
                fixed (void* inputProcessParametersRef_ = &inputProcessParametersRef__[0])
                    fixed (void* outputProcessParametersRef_ = &outputProcessParametersRef[0])
                        SlimDX2.XAPO.LocalInterop.Callivoid(_nativePointer, 10 * 4, inputProcessParameterCount, inputProcessParametersRef==null?(void*)IntPtr.Zero:inputProcessParametersRef_, outputProcessParameterCount, outputProcessParametersRef_, (isEnabled?1:0));
            }
        }
        
        /// <summary>	
        /// Returns the number of input frames required to generate the given number of output frames.	
        /// </summary>	
        /// <param name="outputFrameCount">The number of output frames desired.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>UINT32 IXAPO::CalcInputFrames([None] UINT32 OutputFrameCount)</unmanaged>
        internal int CalcInputFrames_(int outputFrameCount) {
            unsafe {
                int __result__;
                __result__= (int)SlimDX2.XAPO.LocalInterop.Calliint(_nativePointer, 11 * 4, outputFrameCount);
                return __result__;
            }
        }
        
        /// <summary>	
        /// Returns the number of output frames that will be generated from a given number of input frames.	
        /// </summary>	
        /// <param name="inputFrameCount">The number of input frames.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>UINT32 IXAPO::CalcOutputFrames([None] UINT32 InputFrameCount)</unmanaged>
        internal int CalcOutputFrames_(int inputFrameCount) {
            unsafe {
                int __result__;
                __result__= (int)SlimDX2.XAPO.LocalInterop.Calliint(_nativePointer, 12 * 4, inputFrameCount);
                return __result__;
            }
        }
    }
    
    /// <summary>	
    /// An optional interface that allows an XAPO to use effect-specific parameters.	
    /// </summary>	
    /// <unmanaged>IXAPOParameters</unmanaged>
    internal partial class ParameterProviderNative : SlimDX2.ComObject, SlimDX2.XAPO.ParameterProvider {
        public ParameterProviderNative(IntPtr basePtr) : base(basePtr) {
        }
        
        
        /// <summary>	
        /// Sets effect-specific parameters.	
        /// </summary>	
        /// <param name="arametersRef"> Effect-specific parameter block. </param>
        /// <param name="parameterByteSize"> Size of pParameters, in bytes. </param>
        /// <unmanaged>void IXAPOParameters::SetParameters([In, Buffer] const void* pParameters,[None] UINT32 ParameterByteSize)</unmanaged>
        internal void SetParameters_(IntPtr arametersRef, int parameterByteSize) {
            unsafe {
                SlimDX2.XAPO.LocalInterop.Callivoid(_nativePointer, 3 * 4, (void*)arametersRef, parameterByteSize);
            }
        }
        
        /// <summary>	
        /// Gets the current values for any effect-specific parameters.	
        /// </summary>	
        /// <param name="arametersRef">[in, out]  Receives an effect-specific parameter block. </param>
        /// <param name="parameterByteSize">[in]  Size of pParameters, in bytes. </param>
        /// <unmanaged>void IXAPOParameters::GetParameters([Out, Buffer] void* pParameters,[None] UINT32 ParameterByteSize)</unmanaged>
        internal void GetParameters_(IntPtr arametersRef, int parameterByteSize) {
            unsafe {
                SlimDX2.XAPO.LocalInterop.Callivoid(_nativePointer, 4 * 4, (void*)arametersRef, parameterByteSize);
            }
        }
    }
}
