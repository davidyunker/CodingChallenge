using Given.Common;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodingChallenge.FamilyTree.Tests
{
    
    public class TreeTests
    {
        
        [Fact]

        public void testsWork()
        {
            bool isWorking = true;

            Assert.True(isWorking); 
        }

        [Fact]
        public void if_the_person_exists_in_tree_the_result_should_be_january()
        {


            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Joe");
            Assert.Equal(result, "January"); 
        }
           
        [Fact]
        public void if__the_person_exists_at_the_top_tree_the_result_should_be_may()
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Ted");
            Assert.Equal(result, "May");
        }

        [Theory]
        public void if_the_person_does_not_exist_in_the_tree_the_result_should_be_empty()
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Jeebus");
            Assert.Equal(result, "");
        }
    }
}
