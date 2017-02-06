using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {
            //bool contains = person.Descendants.Any(d => d.Name == descendantName);
            ////if any of the decendants of the person have this name, then return true  

            //if (contains)
            //{
            //    Person myPerson = person.Descendants.Find(d => d.Name == descendantName);

            //    string birthMonth = myPerson.Birthday.ToString("MMMM");

            //    return birthMonth;
            //}


            Person chosenOne = null;
            String birthDate = "";
            var family = new List<Person> { person };
            foreach (var d in person.Descendants)
            {
                family.Add(d);
                foreach (var d2 in d.Descendants)
                {
                    family.Add(d2);
                }
            }
            foreach (var f in family)
            {
                if (f.Name == descendantName)
                {
                    chosenOne = f;
                    birthDate = f.Birthday.ToString("MMMM");
                }

              
            }
            return birthDate;
           
        }
    }
}