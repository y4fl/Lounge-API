namespace Lounge.Web.Data.Entities
{
    public class TableScore
    {
        public int Team { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }
        public double Multiplier { get; set; }
        public int? PrevMmr { get; set; }
        public int? NewMmr { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; } = default!;

        public int TableId { get; set; }
        public Table Table { get; set; } = default!;
    }
}
