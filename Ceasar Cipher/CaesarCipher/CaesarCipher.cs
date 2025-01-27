using System.Text;

namespace CaesarCipher;

public class CaesarCipher
{
    public static string Encode(string message, int shift)
    {
        //string of the alphabet
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //variable to store the encoded message
        string newMessage = "";

        //loops through each letter in the message
        foreach (char letter in message)
        {
            //if the letter is in the alphabet..
            if (alphabet.Contains(letter))
            {
                //get the position of the shifted letter
                int shiftPos = alphabet.IndexOf(letter) + shift;
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
}