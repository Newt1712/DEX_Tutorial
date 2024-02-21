namespace AK.Common.Enums
{
    public static class ApproveEnum
    {
        public enum Status
        {
            WAIT = 1,
            APPROVED = 2,
            REJECTED = 3
        }

        public enum Type
        {
            ARTICLE = 1,
            MCOIN_DEPOSIT = 2,
            MCOIN_WITHDRAW = 3,
            REDEMPTION = 4,
            NEWS_FEED = 5,
            COMMENT = 6,
            VOUCHER = 7
        }
    }
}
