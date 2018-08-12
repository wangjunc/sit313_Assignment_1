namespace Phoneword
    //In "IDialer. Cs," remove all template code and replace it with the following code.
    //This code defines the Dial method, which must be implemented on each platform to Dial the translated phone number:
{
    public interface IDialer
    {
        bool Dial(string number);
    }
}