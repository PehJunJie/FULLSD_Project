namespace GameVerse.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string CommentsEndpoint = $"{Prefix}/comments";
        public static readonly string CommunitiesEndpoint = $"{Prefix}/communities";
        public static readonly string ConsumersEndpoint = $"{Prefix}/consumers";
        public static readonly string GamesEndpoint = $"{Prefix}/games";
        public static readonly string OrdersEndpoint = $"{Prefix}/orders";
        public static readonly string PaymentsEndpoint = $"{Prefix}/payments";
        public static readonly string RecommendationsEndpoint = $"{Prefix}/recommendations";
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string StoresEndpoint = $"{Prefix}/stores";
        public static readonly string WishlistsEndpoint = $"{Prefix}/wishlists";
    }
}
