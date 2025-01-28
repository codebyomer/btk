//Kullanıcının girdiği genişlik ve yükseklik değerine göre
//ekrana üçgeni * karakteri ile çizsin
//   *                    yükseklik = 4
//   **                     
//   ***
//   ****

int yuk = 4;

for(int i = 0; i < yuk; i++)
{
    for(int j = 0; j < i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();//alt satıra geçer
}