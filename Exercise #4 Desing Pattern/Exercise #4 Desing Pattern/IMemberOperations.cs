using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4_Desing_Pattern
{
    public interface IMemberOperations
    {
        void AddMember(Member member);
        void DisplayAllMembers();
        void SearchMemberByName(string name);
    }
}
