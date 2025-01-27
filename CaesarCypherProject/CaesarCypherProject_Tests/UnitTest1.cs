namespace CaesarCypherProject_Tests;
using CaesarCypherProject;
public class UnitTest1
{
    [Theory]
<<<<<<< HEAD
    [InlineData("Sandie", 4, "Werhmi")]
=======
    [InlineData("sandie", 4, "werhmi")]
    [InlineData("Sandie", 4, "Werhmi")]
    [InlineData(" sandie", 4, " werhmi")]
    [InlineData("sandie,", 4, "werhmi,")]
    [InlineData("1984", 4, "1984")]
>>>>>>> bb3a23f (Added test cases)
    public void Encode_Test(string message, int shift, string expectedMessage)
    { 
        string encodedMessage = CaesarCypher.Encode(message,shift); 
        
        
        Assert.Equal(expectedMessage,encodedMessage);
    }

    [Theory]
    [InlineData("werhmi", 4, "sandie")]
    public void Decode_Test(string encodedMessage, int shift, string expectedMessage)
    {
        
        string decodedMessage = CaesarCypher.Decode(encodedMessage,shift);
        
        Assert.Equal(expectedMessage, decodedMessage);
    }
}