namespace App1
{
    public class MarkAverage
    {
        private const float w1 = 0.2f;
        private const float w2 = 0.2f;
        private const float w3 = 0.6f;
        private float markHomeWork;
        private float markMiddle;
        private float markFinal;

        public MarkAverage()
        {
        }

        public MarkAverage(float markHomeWork, float markMiddle, float markFinal)
        {
            this.markHomeWork = markHomeWork;
            this.markMiddle = markMiddle;
            this.markFinal = markFinal;
        }

        public float calculateAverage()
        {
            return w1 * markHomeWork + w2 * markMiddle + w3 * markFinal;
        }
    }
}