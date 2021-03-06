﻿namespace DjvuNet.Graphics
{
    public interface IMap2 : IMap
    {
        void Fill(IMap2 source, int dx, int dy);

        int GetRowSize();

        IPixel PixelRamp(IPixelReference pixel);

        int RowOffset(int row);

        IMap2 Translate(int dx, int dy, IMap2 retval);
    }
}
