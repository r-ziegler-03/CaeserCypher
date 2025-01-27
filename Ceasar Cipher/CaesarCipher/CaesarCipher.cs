using System.Text;

namespace CaesarCipher;

public class CaesarCipher
{
    //global varibale for shift so that we can use it for decode method as well
    int shift; 
    
    public static string Encode(string message, int shiftValue)
    {
        shift = shiftValue;
        //string of the alphabet
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //variable to store the encoded message
        string newMessage = "";

        //loops through each letter in the message
        foreach (char letter in message.ToLower())
        {
            //if the letter is in the alphabet..
            if (alphabet.Contains(letter))
            {
                //get the position of the shifted letter
                int shiftPos = (alphabet.IndexOf(letter) + shiftValue) % 26;
                //add that letter to the new message
                newMessage += alphabet[shiftPos];
            }
            //if it isn't in the alphabet
            else
            {
                //dont shift it and just add it to the message 
                newMessage += letter;
            }
        }
        //return the new message
        return newMessage;
    }
    
    public static string Decode(string message, int shiftValue) {
        Encode(message, 26 - shift);
    }
}
