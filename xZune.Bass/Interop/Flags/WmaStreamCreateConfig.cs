﻿// Project: xZune.Bass (https://github.com/higankanshi/xZune.Bass)
// Filename: WmaStreamCreateConfig.cs
// Version: 20160313

using System;
using xZune.Bass.Interop.Core;

namespace xZune.Bass.Interop.Flags
{
    [Flags]
    public enum WmaStreamCreateConfig : uint
    {
        /// <summary>
        ///     Use 32-bit floating-point sample data. See Floating-point channels for info.
        /// </summary>
        Float = Internal.SampleConfig.Float,

        /// <summary>
        ///     Enable 3D functionality. This requires that the <see cref="InitializationConfig._3D" /> flag was specified when
        ///     calling <see cref="Initialize" />, and the
        ///     stream must be mono (chans=1). The SPEAKER flags cannot be used together with this flag.
        /// </summary>
        _3D = Internal.SampleConfig._3D,

        /// <summary>
        ///     Force the stream to not use hardware mixing.
        /// </summary>
        Software = Internal.SampleConfig.Software,

        /// <summary>
        ///     Enable the old implementation of DirectX 8 effects. See the DX8 effect implementations section for details. Use
        ///     <see cref="ChannelSetFX" /> to add effects to the stream.
        /// </summary>
        Fx = Internal.SampleConfig.Fx,

        /// <summary>
        ///     Loop the file. This flag can be toggled at any time using BASS_ChannelFlags.
        /// </summary>
        Loop = Internal.SampleConfig.Loop,

        /// <summary>
        ///     Automatically free the stream when playback ends.
        /// </summary>
        AutoFree = Internal.StreamConfig.AutoFree,

        /// <summary>
        ///     Decode the sample data, without playing it. Use <see cref="ChannelGetData" /> to retrieve decoded sample data. The
        ///     <see cref="_3D" />, <see cref="AutoFree" /> and SPEAKER flags cannot be used together with this flag. The
        ///     <see cref="Software" /> and <see cref="Fx" /> flags are also ignored.
        /// </summary>
        Decode = Internal.StreamConfig.Decode,

        /// <summary>
        ///     The front speakers.
        /// </summary>
        SpeakerFront = Internal.SpeakerType.SpeakerFront,

        /// <summary>
        ///     The rear/side speakers.
        /// </summary>
        SpeakerRear = Internal.SpeakerType.SpeakerRear,

        /// <summary>
        ///     The center and LFE (subwoofer) speakers in a 5.1 setup.
        /// </summary>
        SpeakerCenterLEF = Internal.SpeakerType.SpeakerCenterLEF,

        /// <summary>
        ///     The rear center speakers in a 7.1 setup.
        /// </summary>
        SpeakerRear2 = Internal.SpeakerType.SpeakerRear2,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker05 = Internal.SpeakerType.Speaker05,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker06 = Internal.SpeakerType.Speaker06,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker07 = Internal.SpeakerType.Speaker07,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker08 = Internal.SpeakerType.Speaker08,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker09 = Internal.SpeakerType.Speaker09,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker10 = Internal.SpeakerType.Speaker10,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker11 = Internal.SpeakerType.Speaker11,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker12 = Internal.SpeakerType.Speaker12,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker13 = Internal.SpeakerType.Speaker13,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker14 = Internal.SpeakerType.Speaker14,

        /// <summary>
        ///     SpeakerN macro that can be used to access the extra speakers of soundcards that have more than 8 speakers, where N
        ///     is the N'th pair of speakers (up to a maximum of 15).To use a speaker in mono, add the <see cref="SpeakerLeft" />
        ///     or
        ///     <see cref="SpeakerRight" /> flags.
        /// </summary>
        Speaker15 = Internal.SpeakerType.Speaker15,

        SpeakerLeft = Internal.SpeakerType.SpeakerLeft,
        SpeakerRight = Internal.SpeakerType.SpeakerRight,

        /// <summary>
        ///     The left-front speaker.
        /// </summary>
        SpeakerFrontLeft = Internal.SpeakerType.SpeakerFrontLeft,

        /// <summary>
        ///     The right-front speaker.
        /// </summary>
        SpeakerFrontRight = Internal.SpeakerType.SpeakerFrontRight,

        /// <summary>
        ///     The left-rear/side speaker.
        /// </summary>
        SpeakerRearLeft = Internal.SpeakerType.SpeakerRearLeft,

        /// <summary>
        ///     The right-rear/side speaker.
        /// </summary>
        SpeakerRearRight = Internal.SpeakerType.SpeakerRearRight,

        /// <summary>
        ///     The center speaker in a 5.1 speaker setup.
        /// </summary>
        SpeakerCenter = Internal.SpeakerType.SpeakerCenter,

        /// <summary>
        ///     The LFE (subwoofer) speaker in a 5.1 setup.
        /// </summary>
        SpeakerLFE = Internal.SpeakerType.SpeakerLFE,

        /// <summary>
        ///     The left-rear center speaker in a 7.1 setup.
        /// </summary>
        SpeakerRear2Left = Internal.SpeakerType.SpeakerRear2Left,

        /// <summary>
        ///     The right-rear center speaker in a 7.1 setup.
        /// </summary>
        SpeakerRear2Right = Internal.SpeakerType.SpeakerRearRight,

        /// <summary>
        ///     file is in UTF-16 format. Otherwise it is ANSI on Windows or Windows CE, and UTF-8 on other platforms.
        /// </summary>
        Unicode = Internal.BassConfig.Unicode,

        /// <summary>
        ///     Read the file asynchronously. When enabled, the file is read and buffered in parallel with the decoding, to reduce
        ///     the chances of the decoder being affected by I/O delays. This can be particularly useful with slow storage media
        ///     and/or low latency output. The size of the file buffer is determined by the BASS_CONFIG_ASYNCFILE_BUFFER configure
        ///     option. This flag is ignored when streaming from memory (memory = TRUE).
        /// </summary>
        AsyncFile = Internal.BassConfig.AsyncFile
    }
}