namespace CaesarCypherProject_Tests;
using CaesarCypherProject;
public class UnitTest1
{
    [Theory]
    [InlineData("Sandie", 4, "Werhmi")]
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