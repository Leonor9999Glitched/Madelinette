using System;

namespace Madelinette.Common
{
    public class Peca
    {
        /// <summary>
        /// Cor da peça
        /// </summary>
        private PColor color;

        public Peca(PColor color)
        {
            this.color = color;
        }

        public bool IsColor(PColor color) => this.color;

        public override string ToString()
        {
            return $"{color}";
        }
    }

}
