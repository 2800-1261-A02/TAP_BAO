using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAP_PROJECT
{
    public class KnownHost
    {
        public string Address { get; set; }
        public string Nickname { get; set; }
        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Nickname))
            {
                return $"<{Address}>";
            }
            return Nickname;
        }

    }
}
