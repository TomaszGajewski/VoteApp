using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoteApp.Data
{
    public class VoteViewModel
    {
        public List<CandidatesModel> Candidates { get; set; }
        public List<VotersModel> Voters { get; set; }

        public VoteViewModel()
        {
            Candidates = new List<CandidatesModel>();
            Voters = new List<VotersModel>();
        }
    }
}
