using System;

/**
 * LC 101 - Unit 2 
 * Class 2.6
 * Chapter 6 - Unit Testing
 * Hank DeDona
 * 10/15/20
 */
namespace Class_2._6
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // Chapter 6 - Unit Testing
            // Unit testing (or really testing in general) is extremely important in software development (and sometimes overlooked)

            // 6.1.2 Testing Best Practices
            // The AAAs
            // Arrange the variables your test requires
            // Act on the methods your test requires
            // Assert the anticipated comparison of the expected and actual values

            // Deterministic
            // Every time a test is run, it should produce the same outcome. A test that passes only most of the time is a worthless test.

            // Relevant
            // Group tests by related class and function.

            // Meaningful
            // There is no need to test trivial code. For example, unless a getter or setter contains some additional functionality, you do not need to write a test for those methods.

            // 6.2 MSTest
            // Refer to the Project: Class-2.6-Tests

            // 6.2.3. [TestClass] and [TestMethod]
            // In order to specify a class as a test class, you need to use the [TestClass] attribute
            // Refer to CarTests in Class-2.6-Tests

            // In order to specify a test method inside a test class, you need to use the [TestMethod] attribute
            // Refer to CarTests.EmptyTest() in Class-2.6-Tests

            // 6.2.4 [TestInitialize]
            // Method called before EACH test run

            // 6.2.5 [TestCleanup]
            // Method called after EACH test run

            // 6.2.6 Common Assert Methods
            // AreEqual(expected, actual, optional_delta) - Assert the expected and actual are equal (within the delta)
            // IsFalse(condition) - Assert that a condition is false
            // IsTrue(condition) - Assert that a condition is true
            // IsNotNull(object) - Assert that an object isn't null

        }
    }
}
