using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);

        void MoveTransport(Enumeration enumeration);

        void DrawTransport(Graphics g);
    }
}
