using System;
using System.Diagnostics;
using FluentAssertions.Execution;

namespace FluentAssertions.Primitives
{
    /// <summary>
    /// Contains a number of methods to assert that a nullable <see cref="bool"/> is in the expected state.
    /// </summary>
    [DebuggerNonUserCode]
    public class NullableBooleanAssertions : BooleanAssertions
    {
        public NullableBooleanAssertions(bool? value)
            : base(value)
        {
        }

        /// <summary>
        /// Asserts that a nullable boolean value is not <c>null</c>.
        /// </summary>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="because"/>.
        /// </param>      
        public AndConstraint<NullableBooleanAssertions> HaveValue(string because = "", params object[] reasonArgs)
        {
            Execute.Assertion
                .ForCondition(Subject.HasValue)
                .BecauseOf(because, reasonArgs)
                .FailWith("Expected a value{reason}.");

            return new AndConstraint<NullableBooleanAssertions>(this);
        }

        /// <summary>
        /// Asserts that a nullable boolean value is not <c>null</c>.
        /// </summary>
        public AndConstraint<NullableBooleanAssertions> HaveValue()
        {
            return HaveValue(null);
        }


        /// <summary>
        /// Asserts that a nullable boolean value is <c>null</c>.
        /// </summary>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="because"/>.
        /// </param>      
        public AndConstraint<NullableBooleanAssertions> NotHaveValue(string because = "", params object[] reasonArgs)
        {
            Execute.Assertion
                .ForCondition(!Subject.HasValue)
                .BecauseOf(because, reasonArgs)
                .FailWith("Did not expect a value{reason}, but found {0}.", Subject);

            return new AndConstraint<NullableBooleanAssertions>(this);
        }

        /// <summary>
        /// Asserts that a nullable boolean value is <c>null</c>.
        /// </summary>
        public AndConstraint<NullableBooleanAssertions> NotHaveValue()
        {
            return NotHaveValue(null);
        }


        /// <summary>
        /// Asserts that the value is equal to the specified <paramref name="expected"/> value.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="because" />.
        /// </param>
        public AndConstraint<BooleanAssertions> Be(bool? expected, string because = "", params object[] reasonArgs)
        {
            Execute.Assertion
                .ForCondition(Subject == expected)
                .BecauseOf(because, reasonArgs)
                .FailWith("Expected {0}{reason}, but found {1}.", expected, Subject);

            return new AndConstraint<BooleanAssertions>(this);
        }

        /// <summary>
        /// Asserts that the value is equal to the specified <paramref name="expected"/> value.
        /// </summary>
        /// <param name="expected">The expected value</param>
        public AndConstraint<BooleanAssertions> Be(bool? expected)
        {
            return Be(expected, null);
        }


        /// <summary>
        /// Asserts that the value is not <c>false</c>.
        /// </summary>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="because" />.
        /// </param>
        public AndConstraint<BooleanAssertions> NotBeFalse(string because = "", params object[] reasonArgs)
        {
            Execute.Assertion
                .ForCondition(!Subject.HasValue || Subject.Value)
                .BecauseOf(because, reasonArgs)
                .FailWith("Expected nullable boolean not to be {0}{reason}, but found {1}.", false, Subject);

            return new AndConstraint<BooleanAssertions>(this);
        }

        /// <summary>
        /// Asserts that the value is not <c>false</c>.
        /// </summary>
        public AndConstraint<BooleanAssertions> NotBeFalse()
        {
            return NotBeFalse(null);
        }


        /// <summary>
        /// Asserts that the value is not <c>true</c>.
        /// </summary>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="because" />.
        /// </param>
        public AndConstraint<BooleanAssertions> NotBeTrue(string because = "", params object[] reasonArgs)
        {
            Execute.Assertion
                .ForCondition(!Subject.HasValue || !Subject.Value)
                .BecauseOf(because, reasonArgs)
                .FailWith("Expected nullable boolean not to be {0}{reason}, but found {1}.", true, Subject);

            return new AndConstraint<BooleanAssertions>(this);
        }

        /// <summary>
        /// Asserts that the value is not <c>true</c>.
        /// </summary>
        public AndConstraint<BooleanAssertions> NotBeTrue()
        {
            return NotBeTrue(null);
        }

    }
}
