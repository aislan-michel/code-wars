using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class MaxAndMinTests
    {
        [Fact]
        public void FirstTests()
        {
            Assert.Equal(1, MaxAndMin.FirstForm(new[] { -2, 1, -4, 5, 3 }));
            Assert.Equal(5, MaxAndMin.FirstForm(new[] { 1, 3, 4, 1 }));
        }

        [Fact]
        public void SecondTests()
        {
            Assert.Equal(1, MaxAndMin.SecondForm(new[] { -2, 1, -4, 5, 3 }));
            Assert.Equal(5, MaxAndMin.SecondForm(new[] { 1, 3, 4, 1 }));
        }

    }
}
