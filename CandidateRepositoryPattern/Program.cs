using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateRepositoryPattern.BusinessLayer;
using CandidateRepositoryPattern.DataAccessLayer;

namespace CandidateRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CandidateBusiness candidateBusiness = new CandidateBusiness(new DataAccessLayear.CandidateRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("For List Type 'L', For Add Type 'A' , For Update Type 'U', For Delete Type 'D', For Search Type 'S', For Clear Type 'C', For Exit Type 'E'");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Candidate> _listCandidate = candidateBusiness.Get();
                        Console.WriteLine("List of Candidate:");
                        Console.WriteLine("  ID   \t  Name   \t   Email     \t        Address ");
                        Console.WriteLine("-----------------------------------------------------------");
                        foreach (Candidate Candidate in _listCandidate)
                        {
                            Console.WriteLine("  " + Candidate.CandidateID + " \t " + Candidate.CandidateName + "  \t  " + Candidate.CandidateEmail + "     \t " + Candidate.CandidateAddress);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a Candidate:");
                        string id = Console.ReadLine();
                        Candidate aCandidate = candidateBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aCandidate.CandidateID + "\t" + aCandidate.CandidateName + "\t" + aCandidate.CandidateEmail + "\t" + aCandidate.CandidateAddress);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input Candidate ID:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input Candidate Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input Candidate Email:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Input Candidate Address:");
                        string address = Console.ReadLine();
                        Candidate aCandidate = new Candidate();
                        aCandidate.CandidateID = Convert.ToInt32(id);
                        aCandidate.CandidateName = name;
                        aCandidate.CandidateEmail = email;
                        aCandidate.CandidateAddress = address;
                        bool isExecuted = candidateBusiness.Add(aCandidate);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input Candidate ID:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input Candidate Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input Candidate Email:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Input Candidate Address:");
                        string address = Console.ReadLine();
                        Candidate aCandidate = new Candidate();
                        aCandidate.CandidateID = Convert.ToInt32(id);
                        aCandidate.CandidateName = name;
                        aCandidate.CandidateEmail = email;
                        aCandidate.CandidateAddress = address;
                        bool isExecuted = candidateBusiness.Update(aCandidate);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a ID:");
                        string id = Console.ReadLine();
                        bool isExecuted = candidateBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "E")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
