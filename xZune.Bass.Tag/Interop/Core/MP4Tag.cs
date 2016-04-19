﻿// Project: xZune.Bass (https://github.com/higankanshi/xZune.Bass)
// Filename: MP4TagEx.cs
// Version: 20160319

using System;
using System.Runtime.InteropServices;

namespace xZune.Bass.Tag.Interop.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MP4Tag
    {
        internal IntPtr _namePtr;
        internal IntPtr _valuePtr;
        internal int _valueSize;
        internal IntPtr _nameValuePtr;
        internal IntPtr _meanValuePtr;
        internal MP4TagType _type;
        internal int _dataType;
        internal int _index;

        public string Name
        {
            get
            {
                if (_namePtr == IntPtr.Zero)
                    return null;
                else
                    return Marshal.PtrToStringAuto(_namePtr);
            }
        }

        public string Value
        {
            get
            {
                if (_valuePtr == IntPtr.Zero)
                    return null;
                else
                    return Marshal.PtrToStringAuto(_valuePtr);
            }
        }

        public string NameValue
        {
            get
            {
                if (_nameValuePtr == IntPtr.Zero)
                    return null;
                else
                    return Marshal.PtrToStringAuto(_nameValuePtr);
            }
        }

        public string MeanValue
        {
            get
            {
                if (_meanValuePtr == IntPtr.Zero)
                    return null;
                else
                    return Marshal.PtrToStringAuto(_meanValuePtr);
            }
        }

        public MP4TagType Type => _type;

        public int DateType => _dataType;

        public int Index => _index;

        public bool Equals(MP4Tag obj)
        {
            return
                obj._dataType == _dataType &&
                obj._meanValuePtr == _meanValuePtr &&
                obj._namePtr == _namePtr &&
                obj._valuePtr == _valuePtr &&
                obj._valueSize == _valueSize &&
                obj._index == _index &&
                obj._type == _type;
        }

        public override bool Equals(object obj)
        {
            return Equals((MP4Tag)obj);
        }

        public static bool operator ==(MP4Tag tag1, MP4Tag tag2)
        {
            return tag1.Equals(tag2);
        }

        public static bool operator !=(MP4Tag tag1, MP4Tag tag2)
        {
            return !(tag1 == tag2);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _namePtr.GetHashCode();
                hashCode = (hashCode * 397) ^ _valuePtr.GetHashCode();
                hashCode = (hashCode * 397) ^ _valueSize;
                hashCode = (hashCode * 397) ^ _meanValuePtr.GetHashCode();
                hashCode = (hashCode * 397) ^ _dataType;
                hashCode = (hashCode * 397) ^ (int)_type;
                hashCode = (hashCode * 397) ^ _index;
                return hashCode;
            }
        }
    }
}