using System;

namespace Inheritance
{
    class Member
    {
        //field
        protected int annualFee;
        private string name;
        private int memberId;
        private int memberSince;

        //=======================================================

        //constructor
        public Member()
        {
            Console.WriteLine("Parent Constructor in Member Class with no parameter");
        }

        public Member(string pName, int pMemberId, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor in Member Class with 3 Parameters");
            Console.WriteLine("\n***********************************");

            name = pName;
            memberId = pMemberId;
            memberSince = pMemberSince;
        }
        //=====================================================

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberId + "\nMember Since: "
                   + memberSince + "\nTotal Annual Fee: " + annualFee;

        }
    }

    class NormalMember : Member
    {
        //child constructor
        public NormalMember()
        {
            Console.WriteLine("Child Constructor in NormalMember Class with no parameter");
        }

        public NormalMember(string remarks, string name, int memberId,
            int memberSince) : base(name, memberId, memberSince)
        {
            Console.WriteLine("child constructor in NormalMember Class with 4 Parameters");
            Console.WriteLine("The added parameter is {0}", remarks);
            Console.WriteLine("\n***********************************");
        }
        //=============================================================

        //method normal member annual fee

        public void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }

    class VipMember : Member
    {
        //constructor
        public VipMember(string name, int memberId, int memberSince) : base(name, memberId, memberSince)
        {
            Console.WriteLine("Child Constructor in VipMember class with three parameters");
            Console.WriteLine("\n***********************************");
        }
        //===============================================

        //method vip annual feed
        public int CalculateAnnualFee()
        {
            return annualFee = 1200;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            NormalMember nm1 = new NormalMember("Special Rate", "James", 1, 2010);
            VipMember vpm1 = new VipMember("Andy", 2, 2011);
            nm1.CalculateAnnualFee();
            vpm1.CalculateAnnualFee();

            Console.WriteLine("\n**********NormalMember***************************");
            Console.WriteLine(nm1.ToString());
            Console.WriteLine("\n**********VIPlMember***************************");
            Console.WriteLine(vpm1.ToString());

            //note
            //in inheritance each derived class has its own method
            //we declare array of each derived class
        } 
    }
}
