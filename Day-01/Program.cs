//Kadangi kambario matmenys duotyje nebuvo nurodyti, juos įvedžiau pats
int length = 6; //kambario ilgis metrais
int width = 3; //kambario plotis metrais
double m2price = 21.4; //1m2

int area = length * width; //plotas

double totalPrice= (area* m2price) * 1.05; //kaina ivertinus papildomus 5%

Console.WriteLine($"Total price: {totalPrice}.");

Console.ReadLine();
