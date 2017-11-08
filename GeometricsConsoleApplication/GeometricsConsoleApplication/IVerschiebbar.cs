using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometricsConsoleApplication
{
    public interface IVerschiebbar
    {
        KeyValuePair<int, int> Verschieben(int x_delta, int y_delta);
        bool AnzeigeFlaechenÜberwachung(int x, int y);
    }
}