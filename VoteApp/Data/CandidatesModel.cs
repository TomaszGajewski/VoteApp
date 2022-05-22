using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoteApp.Data
{
    public class CandidatesModel
    {
        public Guid CandidateId { get; set; }
        public string CandidateName { get; set; }
        public int CandidateVoteCount { get; set; }
        public bool HasSaved { get; set; }

        public CandidatesModel()
        {
            CandidateId = Guid.NewGuid();
            CandidateName = "";
            CandidateVoteCount = 0;
            HasSaved = false;
        }
    }
}
