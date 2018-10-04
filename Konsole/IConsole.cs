using System;

namespace Konsole
{
    public interface IConsole : IWrite
    {
        ConsoleState State { get; set; }
        /// <summary>
        /// The absolute X position this window is located on the real or root console. This is where relative x:0 starts from for this window.
        /// </summary>
        int AbsoluteX { get; }

        /// <summary>
        /// The absolute Y position this window is located on the real or root console. This is where relative y:0 starts from for this window.
        /// </summary>
        int AbsoluteY { get; } 

        int Width { get; }
        int Height { get; }
        int CursorTop { get; set; }
        int CursorLeft { get; set; }
        Colors Colors { get; set; }
        ConsoleColor ForegroundColor { get; set; }
        ConsoleColor BackgroundColor { get; set; }
        bool CursorVisible { get; set; }
        void PrintAt(int x, int y, string format, params object[] args);
        void PrintAt(int x, int y, string text);
        void PrintAt(int x, int y, char c);
        void PrintAtColor(ConsoleColor foreground, int x, int y, string text, ConsoleColor? background);
        void Clear();
        void Clear(ConsoleColor? backgroundColor);

    }
}