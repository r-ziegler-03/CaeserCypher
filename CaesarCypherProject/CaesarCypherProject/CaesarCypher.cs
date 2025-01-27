namespace CaesarCypherProject;

public class CaesarCypher
{
    public static string Encode(string message, int shift)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string newMessage = "";

        foreach (char letter in message.ToLower())
        {
            if (alphabet.Contains(letter))
            {
                int shiftPos = (alphabet.IndexOf(letter) + shift) % 26;
                newMessage += alphabet[shiftPos];
            }
            else
            {
                newMessage += letter;
            }
        }
        return newMessage;
    }
    
    public static string Decode(string message, int shift) => Encode(message, 26 - shift);
}