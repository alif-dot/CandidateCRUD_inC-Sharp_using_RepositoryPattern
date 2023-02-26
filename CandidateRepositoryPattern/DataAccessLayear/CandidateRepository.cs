using CandidateRepositoryPattern.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateRepositoryPattern.DataAccessLayear
{
    public class CandidateRepository : ICandidateRepository
    {
        List<Candidate> listCandidate = new List<Candidate>()
        {
            new Candidate(101,"Nahiyean","nhn@outlook.com","Japan"),
            new Candidate(112,"Easin Alif","ealif@yahoo.com","Turkey"),
            new Candidate(321,"TJ Walfrah","tjwal@gmail.com","China"),
            new Candidate(419,"MD. Ariean","m.ar@aol.com","Maldiv"),
            new Candidate(879,"Nafi Arora","n.arora@zoho.com","Uganda")
        };
        public List<Candidate> Get()
        {
            return listCandidate.OrderBy(x => x.CandidateName).ToList();
        }

        public Candidate Get(int id)
        {
            Candidate aCandidate = listCandidate.Where(x => x.CandidateID == id).FirstOrDefault();
            return aCandidate;
        }

        public bool Add(Candidate model)
        {
            listCandidate.Add(model);
            return true;
        }

        public bool Update(Candidate model)
        {
            bool isExecuted = false;
            Candidate aCandidate = listCandidate.Where(x => x.CandidateID == model.CandidateID).FirstOrDefault();
            if (aCandidate != null)
            {
                listCandidate.Remove(aCandidate);
                listCandidate.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            Candidate aCandidate = listCandidate.Where(x => x.CandidateID == id).FirstOrDefault();
            if (aCandidate != null)
            {
                listCandidate.Remove(aCandidate);
                isExecuted = true;
            }
            return isExecuted;
        }

    }
}
