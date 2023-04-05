// Maps to Req 2 > contacts with email addresses must be able to receive emails from system
// Represents an object that can be sent an email
interface IEmailable
{
    // method to send emails, returns true or false accordingly
    bool SendEmail();
}