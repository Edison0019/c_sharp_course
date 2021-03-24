using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Course
{
    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;


        public Member()
        {
            Console.WriteLine("Parent constructor with no parameter");
        }

        public Member(string pNamen, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent constructor with three parameters");

            name = pNamen; 
            memberID = pMemberID; 
            memberSince = pMemberSince;

        }
        public override string ToString()
        {
            return "\nName: " + name + "\nMember: " + memberID +
                "\nMember since: " + memberSince + "\nTotal annual fee: " +
                annualFee;
        }

    }

    class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("Child constructor");
        }
        //this approach allows to instantiate the parent class
        //using a constructor from the child class
        public NormalMember(string remarks, string name,int memberID, int memberSince) : base(
            name,memberID,memberSince)
        {
            Console.WriteLine("Child constructor with 4 parameter");
            Console.WriteLine("Remarks: {0}",remarks);
        }
        public void calculateFee()
        {
            //since the field already exists in the parent class
            //we do not need to declare it twice in the child class
            annualFee = 100 + 12 * 30;
        }
    }

    class VIPMember : Member
    {
        public VIPMember(string name, int memberID , int memberSince):base(
                name,memberID,memberSince)
        {
            Console.WriteLine("Child class with three parameters");
        }
        public void CalculateAnualFee()
        {
            annualFee = 1200;
        }

    }
}
