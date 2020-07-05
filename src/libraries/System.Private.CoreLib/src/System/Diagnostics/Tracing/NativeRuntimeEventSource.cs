// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Diagnostics.Tracing
{
    /// <summary>
    /// NativeRuntimeEventSource is an EventSource that represents the ETW/EventPipe events emitted by the native runtime.
    /// Most of NativeRuntimeEventSource is auto-generated by scripts/genRuntimeEventSources.py based on the contents of the Microsoft-Windows-DotNETRuntime provider.
    /// </summary>
    [EventSource(Guid = "5E5BB766-BBFC-5662-0548-1D44FAD9BB56", Name = "Microsoft-Windows-DotNETRuntime")]
    internal sealed partial class NativeRuntimeEventSource : EventSource
    {
        internal const string EventSourceName = "Microsoft-Windows-DotNETRuntime";
        internal static NativeRuntimeEventSource Log = new NativeRuntimeEventSource();

        // The NativeRuntimeEventSource GUID is {5e5bb766-bbfc-5662-0548-1d44fad9bb56}
        private NativeRuntimeEventSource() : base(new Guid(0x5e5bb766, 0xbbfc, 0x5662, 0x05, 0x48, 0x1d, 0x44, 0xfa, 0xd9, 0xbb, 0x56), EventSourceName) { }

        /// <summary>
        /// Dispatch a single event with the specified event ID and payload.
        /// </summary>
        /// <param name="eventID">The eventID corresponding to the event as defined in the auto-generated portion of the NativeRuntimeEventSource class.</param>
        /// <param name="osThreadID">The thread ID of the operating system thread.</param>
        /// <param name="timeStamp">The current timestamp.</param>
        /// <param name="activityId">The ID of the current activity.</param>
        /// <param name="childActivityId">The ID of the current child activity.</param>
        /// <param name="payload">A span pointing to the data payload for the event.</param>
        [NonEvent]
        internal unsafe void ProcessEvent(uint eventID, uint osThreadID, DateTime timeStamp, Guid activityId, Guid childActivityId, ReadOnlySpan<byte> payload)
        {
            // Make sure the eventID is valid.
            if (eventID >= m_eventData!.Length)
            {
                return;
            }

            // Decode the payload.
            object[] decodedPayloadFields = EventPipePayloadDecoder.DecodePayload(ref m_eventData[eventID], payload);
            WriteToAllListeners(
                eventId: (int)eventID,
                osThreadId: &osThreadID,
                timeStamp: &timeStamp,
                activityID: &activityId,
                childActivityID: &childActivityId,
                args: decodedPayloadFields);
        }
    }
}
