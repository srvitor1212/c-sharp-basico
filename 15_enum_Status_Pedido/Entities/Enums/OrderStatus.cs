
namespace Course.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment, //Implicidamente é 0
        Processing,     //Implicidamente é 1
        Shipped,        //Implicidamente é 2
        Delivered       //Implicidamente é 3
    }
}