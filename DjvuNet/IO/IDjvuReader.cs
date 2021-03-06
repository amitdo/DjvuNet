﻿using System;
using DjvuNet.Compression;

namespace DjvuNet
{
    public interface IDjvuReader : IBinaryReader, IDisposable
    {
        long Length { get; }

        long Position { get; set; }

        IDjvuReader CloneReader(long position);

        IDjvuReader CloneReader(long position, long length);

        IDjvuReader CloneReaderToMemory(long position, long length);

        BzzReader GetBZZEncodedReader();

        BzzReader GetBZZEncodedReader(long length);

        IDjvuReader GetFixedLengthStream(long length);

        short ReadInt16BigEndian();

        int ReadInt24();

        int ReadInt24BigEndian();

        int ReadInt32BigEndian();

        long ReadInt64BigEndian();

        byte[] ReadToEnd();

        ushort ReadUInt16BigEndian();

        uint ReadUInt24();

        uint ReadUInt24BigEndian();

        uint ReadUInt32BigEndian();

        ulong ReadUInt64BigEndian();

        string ReadNullTerminatedString(bool skipBOM = true, int bufferSize = 1024);

        string ReadUTF7String(long length);

        string ReadUTF8String(long length);

        string ToString();
    }
}