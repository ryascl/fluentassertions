using System;
using System.Diagnostics;
using FluentAssertions.Common;
using FluentAssertions.Execution;

namespace FluentAssertions.Primitives
{
    /// <summary>
    /// Contains a number of methods to assert that a nullable <see cref="TimeSpan"/> is in the expected state.
    /// </summary>
    /// <remarks>
    /// You can use the <see cref="TimeSpanConversionExtensions"/> for a more fluent way of specifying a <see cref="TimeSpan"/>.
    /// </remarks>
    [DebuggerNonUserCode]
    public class NullableSimpleTimeSpanAssertions : SimpleTimeSpanAssertions
    {
        public NullableSimpleTimeSpanAssertions(TimeSpan? value)
            : base(value)
        {
        }

        /// <summary>
        /// Asserts that a nullable <see cref="TimeSpan"/> value is not <c>null</c>.
        /// </summary>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="because"/>.
        /// </param>      
        public AndConstraint<NullableSimpleTimeSpanAssertions> HaveValue(string because = "", params object[] reasonArgs)
        {
            Execute.Assertion
                .ForCondition(Subject.HasValue)
                .BecauseOf(because, reasonArgs)
                .FailWith("Expected a value{reason}.");

            return new AndConstraint<NullableSimpleTimeSpanAssertions>(this);
        }

        /// <summary>
        /// Asserts that a nullable <see cref="TimeSpan"/> value is not <c>null</c>.
        /// </summary>
        public AndConstraint<NullableSimpleTimeSpanAssertions> HaveValue()
        {
            return HaveValue(null);
        }


        /// <summary>
        /// Asserts that a nullable <see cref="TimeSpan"/> value is <c>null</c>.
        /// </summary>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="because"/>.
        /// </param>      
        public AndConstraint<NullableSimpleTimeSpanAssertions> NotHaveValue(string because = "", params object[] reasonArgs)
        {
            Execute.Assertion
                .ForCondition(!Subject.HasValue)
                .BecauseOf(because, reasonArgs)
                .FailWith("Did not expect a value{reason}, but found {0}.", Subject);

            return new AndConstraint<NullableSimpleTimeSpanAssertions>(this);
        }

        /// <summary>
        /// Asserts that a nullable <see cref="TimeSpan"/> value is <c>null</c>.
        /// </summary>
        public AndConstraint<NullableSimpleTimeSpanAssertions> NotHaveValue()
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
        public AndConstraint<NullableSimpleTimeSpanAssertions> Be(TimeSpan? expected, string because = "",
            params object[] reasonArgs)
        {
            Execute.Assertion
                .ForCondition(Subject == expected)
                .BecauseOf(because, reasonArgs)
                .FailWith("Expected {0}{reason}, but found {1}.", expected, Subject);

            return new AndConstraint<NullableSimpleTimeSpanAssertions>(this);
        }

        /// <summary>
        /// Asserts that the value is equal to the specified <paramref name="expected"/> value.
        /// </summary>
        /// <param name="expected">The expected value</param>
        public AndConstraint<NullableSimpleTimeSpanAssertions> Be(TimeSpan? expected)
        {
            return Be(expected, null);
        }

    }
}