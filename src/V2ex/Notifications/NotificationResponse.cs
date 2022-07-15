namespace V2ex.Notifications
{
    public class NotificationResponse
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int ForMemberId { get; set; }

        public string Text { get; set; } = default!;

        public string Payload { get; set; } = default!;

        public string PayloadRendered { get; set; } = default!;

        public long Created { get; set; }

        public Member Member { get; set; } = default!;

    }

    public class Member
    {
        public string Username { get; set; } = default!;
    }
}


