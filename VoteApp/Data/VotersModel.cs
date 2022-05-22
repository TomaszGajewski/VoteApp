using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoteApp.Data
{
    public class VotersModel
    {
        public Guid VoterId { get; set; }
        public string VoterName { get; set; }
        public bool VoterHasVoted { get; set; }
        public bool HasSaved { get; set; }

        public VotersModel()
        {
            VoterId = Guid.NewGuid();
            VoterName = "";
            VoterHasVoted = false;
            HasSaved = false;
        }
    }
}
