using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGRRiverParser.Model
{
    public class River
    {
        /// <summary>
        /// Название реки
        /// </summary>
        public string name;
        /// <summary>
        /// Протяжённость реки
        /// </summary>
        public double? length;
        /// <summary>
        /// Исток реки
        /// </summary>
        public string source;
        /// <summary>
        /// Устье реки
        /// </summary>
        public string mouth;

        public override string ToString()
        {
            return $"{name}: l={length}, s={source}, m={mouth}";
        }
    }
}
