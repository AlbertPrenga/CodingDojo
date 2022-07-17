
class Program
{

static void Main(string [] args)
{



Buffet buffet1 = new Buffet();
SpiceHound sh1 = new SpiceHound();
SweetTooth st1 = new SweetTooth();
Console.WriteLine("Sh1's food");

while (sh1.IsFull != true)
{
    sh1.Consume(buffet1.Serve());
}
Console.WriteLine("St1's food:");
while (st1.IsFull != true)
{
    st1.Consume(buffet1.Serve());
}


}
}
