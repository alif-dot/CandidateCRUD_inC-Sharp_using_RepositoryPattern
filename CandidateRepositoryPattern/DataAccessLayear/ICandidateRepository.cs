using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateRepositoryPattern.DataAccessLayer
{
    public interface ICandidateRepository
    {
        List<Candidate> Get();
        Candidate Get(int id);
        bool Add(Candidate model);
        bool Update(Candidate model);
        bool Delete(int id);
    }
}
