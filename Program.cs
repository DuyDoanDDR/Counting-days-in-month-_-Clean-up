using System.ComponentModel.Design;

do
{
    int month;
    //Kiem tra tinh hop le cua gia tri dau vao
    do
    {
        Console.WriteLine(" Enter Counted Month (An integer between 1 and 12): ");
    }
    while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12);
    //Xu ly gia tri dau vao
    string daysinmonth = month switch
    {
        4 or 6 or 9 or 11 => "30 days.",
        2 => "28 or 29 days.",
        _ => "31 days."

    };
    Console.WriteLine(value: " The month has " + daysinmonth);                        //Xuat gia tri ra cho User
    Console.WriteLine(" Counted another month ? Enter 'y' for yes and 'n' for no. "); //Update tinh nang tiep tuc chuong trinh neu nguoi dung muon
}
while (Console.ReadLine() == "y"); //Chuong trinh tiep tuc neu nguoi dung nhap y
do                                 //loi chao va break neu nhap n
{
    Console.WriteLine("Thank you and goodbye !");
    break;
}
while (Console.ReadLine() == "n");