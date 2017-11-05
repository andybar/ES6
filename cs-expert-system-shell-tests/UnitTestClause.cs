using ExpertSystem;
using System;
using Xunit;

namespace cs_expert_system_shell_tests
{
    public class UnitTestClause
    {
        [Fact]
        public void TestNewClause()
        {
            Clause c = new Clause("name", "chen");
            Assert.Equal(c.Variable, "name");
            Assert.Equal(c.Value, "chen");
            Assert.Equal(c.Condition, "=");
        }
    }
}
