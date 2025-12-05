using System.Collections;

namespace _010_Collections
{
    class PersonAgeComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Person && y is Person)
            {
                return (x as Person).Age
                    .CompareTo((y as Person).Age);

            }

            throw new NotImplementedException();

        }
    }
}
