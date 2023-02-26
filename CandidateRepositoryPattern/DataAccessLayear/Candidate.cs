using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateRepositoryPattern
{
    public class Candidate
    {
        public int CandidateID;
        public string CandidateName;
        public string CandidateEmail;
        public string CandidateAddress;
        public Candidate()
        {
        }
        public Candidate(int id, string name, string email, string address)
        {
            CandidateID = id;
            CandidateName = name;
            CandidateAddress = address;
            CandidateEmail = email;
        }
    }
}
