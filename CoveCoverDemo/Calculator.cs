namespace CoveCoverDemo
{
    public class Calculator
    {
        /// <summary>
        ///     add some comment
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public int Add(int one, int two)
        {
            var transform = one switch
            {
                0 => 0,
                1 => -1,
                2 => -2,
                _ => -3
            };
            return transform + two;
        }

        public int Subtract(int one, int two)
        {
            return one - two;
        }
    }
}