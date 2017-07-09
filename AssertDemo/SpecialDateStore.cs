using System;

namespace AssertDemo
{
    public enum SpecialDate
    {
        NewMillenium
    };
    public class SpecialDateStore
    {
        public DateTime DateOf(SpecialDate specialDateType)
        {
            switch (specialDateType)
            {
                case SpecialDate.NewMillenium:
                    return new DateTime(2000, 1, 1, 0, 0, 0);
                default:
                    throw new ArgumentOutOfRangeException(nameof(specialDateType));
            }
        }
    }
}