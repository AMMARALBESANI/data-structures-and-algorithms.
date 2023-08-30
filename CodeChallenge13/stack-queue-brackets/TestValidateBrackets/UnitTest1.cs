using System.Collections;
using Xunit;


namespace stack_queue_brackets.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void validatebrackets_ShouldReturnTrue(string input)
        {
            bool result = Program.Valivalidatebrackets(input);
            Assert.True(result);
        }


        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("{(})")]

        public void validatebrackets_ShouldReturnFalse(string input)
        {
            bool result = Program.Valivalidatebrackets(input);
            Assert.False(result);
        }
    }
   
}
