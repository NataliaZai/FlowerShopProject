namespace FlowerShopProject.Exception
{
    public class MinNumberOfFlowersException : IOException
    {
        public MinNumberOfFlowersException() : base($"Number of flowers must be more than 0")
        {
        }
    }
}