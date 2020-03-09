using System;
using System.Collections.Generic;
using System.Text;

namespace CW2
{
    class MyComp : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return StringComparer.InvariantCultureIgnoreCase.Equals(x.ToString(), y.ToString());
        }

        public int GetHashCode(Student obj)
        {
            return StringComparer.CurrentCultureIgnoreCase.GetHashCode($"{obj.Imie}, {obj.Nazwisko}, {obj.NazwaStudiow}, {obj.TypStudiow}, {obj.Index}, {obj.DataUrodzenia}, {obj.Email}, {obj.ImieMatki}, {obj.ImieOjca}");
        }
    }
}
