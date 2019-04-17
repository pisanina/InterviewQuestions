namespace FindingPrimes
{
    public class Range
    {
        public int Start { get; private set; }
        public int End { get; private set; }

        public bool IsValid()
        {
            return (Start >= 1 && End >= Start && End <= 1000000000 && (End - Start) <= 100000);
                
        }

        public Range(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}
