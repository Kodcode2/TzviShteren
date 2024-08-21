﻿namespace AgentRest.Models
{
    public enum MissionStatus
    {
        Proposal,
        Mitzvah,
        Ended
    }
    public class MissionModel
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public int TargetId { get; set; }
        public AgentModel Agent { get; set; }
        public TargetModel Target { get; set; }
        public float TimeLeft { get; set; }
        public float TimeRight { get; set; }

        public MissionStatus Status { get; set; }
    }
}
