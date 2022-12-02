public interface IEmailable
{
    // methods that an emailable entity MUST provide
    public bool SendEmail(); // all emailable entities must be able to be sent an email
}