using System;

namespace Tabuleiro
{
    internal class TabuleiroExecption:Exception
    {
        public TabuleiroExecption(string message) : base(message) { 
        }
    }
}
