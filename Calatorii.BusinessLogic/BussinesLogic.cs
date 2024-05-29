using Calatorii.BusinessLogic.Interfaces;
namespace Calatorii.BusinessLogic
{
     public class BussinesLogic
     {
          public ISession GetSessionBL()
          {
               return new SessionBL();
          }
     }
}
