﻿using System;
using Xunit;
using Xunit.Categories;

namespace Xunit.Categories.Tests
{
    public class Scratch
    {

        [Fact]
        public void Test()
        {
            throw new NotImplementedException("just the facts");
        }

        [Fact]
        [Bug]
        public void TestBug()
        {
            throw new NotImplementedException("I'm a bug");
        }

        [Fact]
        [Bug(777)]
        [Bug("777")]
        public void TestBugWithId()
        {
            throw new NotImplementedException("I've got your number");
        }

        [Fact, IntegrationTest]
        [Feature(888)]
        [Feature("888")]

        public void TestFeatureWithId()
        {
            throw new NotImplementedException("I've got your feature");
        }

    }

}