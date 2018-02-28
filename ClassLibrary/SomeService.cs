using System;

namespace ClassLibrary
{
    public class SomeService
    {
        public SomeData GetSomeData(int id)
        {
            return new SomeData
            {
                Id = id,
                Name = "Some Name"
            };
        }
    }
}
