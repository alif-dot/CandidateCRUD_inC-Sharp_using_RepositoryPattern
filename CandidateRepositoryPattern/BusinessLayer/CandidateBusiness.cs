using CandidateRepositoryPattern.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateRepositoryPattern.BusinessLayer
{
    public class CandidateBusiness
    {
        ICandidateRepository _repository;

        public CandidateBusiness(ICandidateRepository repository)
        {
            _repository = repository;
        }

        public List<Candidate> Get()
        {
            return _repository.Get();
        }

        public Candidate Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Candidate model)
        {
            return _repository.Add(model);
        }

        public bool Update(Candidate model)
        {
            return _repository.Update(model);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
