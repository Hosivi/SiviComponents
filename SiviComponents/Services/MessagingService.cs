namespace SiviComponents.Services;

public delegate Task QueryMessageHandler(string query, Action afterAceptAction);
public interface IMessagingService
{
      
    public event QueryMessageHandler MessageSending; 
    Task<TMessage> SendMessage<TMessage>(TMessage message);
    Task SendQueryMessage(string query,Action afterAceptAction); 
    

}

public class MessagingService : IMessagingService
{
    public event QueryMessageHandler MessageSending;
    public Task<TMessage> SendMessage<TMessage>(TMessage message)
    {
        throw new NotImplementedException();
    }

    public async Task SendQueryMessage(string query, Action afterAceptAction)
    {
	    if (MessageSending != null)
	    {
		    await MessageSending(query, afterAceptAction);
		}
	    else
	    {
		    Console.WriteLine("aaaaaaaaaaaaaaaaaaa no te haz suscrioto");
	    }
    }
}
